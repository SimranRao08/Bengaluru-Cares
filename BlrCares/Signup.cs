using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Required for database connection
using BlrCares;

namespace BengaluruCares
{
    public partial class Signup : Form
    {
        // Uses the centralized connection string from AppSecrets.cs
        string connString = AppSecrets.ConnString;

        public Signup()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;

                string username = txtUser.Text.Trim();
                string email = txtEmail.Text.Trim();
                string mobile = txtMobile.Text.Trim();
                string pin = txtPin.Text.Trim();
                string password = txtPass.Text;

                // 1. Validation Logic
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(mobile) || string.IsNullOrEmpty(pin) ||
                    string.IsNullOrEmpty(password))
                {
                    throw new ArgumentNullException("All fields are required.");
                }

                if (!Regex.IsMatch(username, @"^[a-zA-Z0-9]+$"))
                    throw new FormatException("Username must contain only alphabets and numbers.");

                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new FormatException("Invalid Email format.");

                if (!Regex.IsMatch(mobile, @"^\d{10}$"))
                    throw new FormatException("Mobile number must be 10 digits.");

                if (!Regex.IsMatch(pin, @"^\d{6}$"))
                    throw new FormatException("PIN code must be 6 digits.");

                if (!Regex.IsMatch(password, @"^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8,}$"))
                    throw new FormatException("Password must be 8+ chars with 1 digit and 1 special char.");

                // 2. Encrypt Password using SecurityHelper.cs
                string hashedPassword = SecurityHelper.Encrypt(password);

                // 3. Database Insertion into the Users table
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();

                    // Check if username or email already exists
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@user OR Email=@email";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@user", username);
                        checkCmd.Parameters.AddWithValue("@email", email);
                        int exists = (int)checkCmd.ExecuteScalar();
                        if (exists > 0) throw new Exception("Username or Email already registered.");
                    }

                    // Insert new user
                    string query = "INSERT INTO Users (Username, Email, Mobile, PinCode, PasswordHash) " +
                                   "VALUES (@user, @email, @mobile, @pin, @pass)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@mobile", mobile);
                        cmd.Parameters.AddWithValue("@pin", pin);
                        cmd.Parameters.AddWithValue("@pass", hashedPassword);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dashboard dash = new Dashboard();
                dash.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
                lblError.Visible = true;
            }
        }

        private void lblGotoLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}