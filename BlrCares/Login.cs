using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using BengaluruCares;

namespace BlrCares
{
    public partial class Login : Form
    {
        // Uses the centralized connection string from AppSecrets
        private string connString = AppSecrets.ConnString;
        private string currentOTP;
        private EmailService emailService = new EmailService();

        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPass.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both Email and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    await con.OpenAsync();

                    // --- RESET PASSWORD MODE ---
                    if (btnLogin.Text == "Update & Login")
                    {
                        string encryptedPass = SecurityHelper.Encrypt(password);
                        string updateQuery = "UPDATE Users SET PasswordHash = @pass WHERE Email = @email";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@pass", encryptedPass);
                            updateCmd.Parameters.AddWithValue("@email", email);
                            await updateCmd.ExecuteNonQueryAsync();
                        }
                        MessageBox.Show("Password updated successfully!", "Success");
                    }

                    // --- STANDARD LOGIN VERIFICATION ---
                    // Retrieve Name and PasswordHash for Session initialization
                    string query = "SELECT Username, PasswordHash FROM Users WHERE Email = @email";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader["PasswordHash"].ToString();
                                string decryptedPassword = SecurityHelper.Decrypt(storedHash);

                                if (password == decryptedPassword)
                                {
                                    // Initialize Global Session
                                    Session.UserEmail = email;
                                    Session.UserName = reader["Username"].ToString();
                                    Session.UserRole = "Volunteer";

                                    MessageBox.Show($"Welcome back, {Session.UserName}!", "Login Successful");

                                    new Dashboard().Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No account found with this email.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void lblForgotPass_Click(object sender, EventArgs e)
        {
            string receiverEmail = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(receiverEmail))
            {
                MessageBox.Show("Please enter your email first.", "Email Required");
                return;
            }

            try
            {
                currentOTP = emailService.GenerateOTP();
                await emailService.SendOtpAsync(receiverEmail, currentOTP);

                MessageBox.Show($"A verification OTP has been sent to {receiverEmail}.", "OTP Sent");

                pnlOTP.Visible = true;
                txtOTP.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message, "SMTP Error");
            }
        }

        private void btnVerifyOTP_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == currentOTP)
            {
                MessageBox.Show("OTP Verified! You may now enter a new password and click 'Update & Login'.", "Security Cleared");

                pnlOTP.Visible = false;
                txtPass.Clear();
                txtPass.Focus();
                btnLogin.Text = "Update & Login";
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.", "Verification Failed");
                txtOTP.Clear();
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}