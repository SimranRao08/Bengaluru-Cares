using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Required for SQL
using BengaluruCares;

namespace BlrCares
{
    public partial class Login : Form
    {
        private string connString = AppSecrets.ConnString; //
        private string currentOTP;
        private EmailService emailService = new EmailService(); //

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

                    // Check if we are in "Reset Mode"
                    if (btnLogin.Text == "Update & Login")
                    {
                        string encryptedPass = SecurityHelper.Encrypt(password);
                        string updateQuery = "UPDATE Users SET PasswordHash = @pass WHERE Email = @email";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@pass", encryptedPass);
                            updateCmd.Parameters.AddWithValue("@email", email);
                            await updateCmd.ExecuteScalarAsync();
                        }
                        MessageBox.Show("Password updated successfully!", "Success");
                    }

                    // Standard Login Verification
                    string query = "SELECT PasswordHash FROM Users WHERE Email = @email";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        object result = await cmd.ExecuteScalarAsync();

                        if (result != null)
                        {
                            string decryptedPassword = SecurityHelper.Decrypt(result.ToString());

                            if (password == decryptedPassword)
                            {
                                new Dashboard().Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid password.");
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
                // 1. Generate a real OTP using EmailService
                currentOTP = emailService.GenerateOTP();

                // 2. Send the actual email asynchronously
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
            // Verify if the entered OTP matches the one sent
            if (txtOTP.Text == currentOTP)
            {
                MessageBox.Show("OTP Verified! You may now enter a new password and login.", "Security Cleared");

                pnlOTP.Visible = false;
                txtPass.Text = ""; // Clear password field for new entry
                txtPass.Focus();

                // Change Login button text to indicate the next click updates the account
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