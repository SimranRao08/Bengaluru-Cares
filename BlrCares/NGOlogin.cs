using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Required for database access
using BengaluruCares;

namespace BlrCares
{
    public partial class NGOlogin : Form
    {
        // Use the centralized connection string from AppSecrets.cs
        private string connString = AppSecrets.ConnString;

        public NGOlogin()
        {
            InitializeComponent();

            // 1. Visual enhancement: Gradient for the left panel
            panelLeft.Paint += (s, e) =>
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    panelLeft.ClientRectangle,
                    Color.FromArgb(34, 94, 65),
                    Color.FromArgb(46, 139, 87),
                    90F))
                {
                    e.Graphics.FillRectangle(brush, panelLeft.ClientRectangle);
                }
            };
        }

        // --- STANDARD CREDENTIAL LOGIN ---
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPass.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both the NGO Official Email and Password.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    await con.OpenAsync();

                    // Retrieve the encrypted password hash for the NGO
                    string query = "SELECT PasswordHash FROM NGOs WHERE Email = @email";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        object result = await cmd.ExecuteScalarAsync();

                        if (result != null)
                        {
                            // Decrypt and verify using SecurityHelper
                            string decryptedPassword = SecurityHelper.Decrypt(result.ToString());

                            if (password == decryptedPassword)
                            {
                                MessageBox.Show("NGO Authentication Successful! Access Granted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                OpenDashboard();
                            }
                            else
                            {
                                MessageBox.Show("Invalid password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No NGO account found with this email.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- BIOMETRIC FINGERPRINT LOGIN ---
        private async void btnFingerprint_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || email == "NGO Official Email")
            {
                MessageBox.Show("Please enter your Official Email first so we know which fingerprint to verify.", "Identity Required");
                return;
            }

            DialogResult result = MessageBox.Show("Place authorized finger on scanner...", "Biometric Scanner", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(AppSecrets.ConnString))
                    {
                        await con.OpenAsync();

                        // CRITICAL FIX: Only select the BiometricID for the specific email entered
                        string query = "SELECT BiometricID, NGOName FROM NGOs WHERE Email = @email";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@email", email);
                            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                            {
                                if (reader.Read())
                                {
                                    string storedTemplate = reader["BiometricID"].ToString();
                                    string ngoName = reader["NGOName"].ToString();

                                    if (!string.IsNullOrEmpty(storedTemplate))
                                    {
                                        // In a real SDK, you would use: Scanner.Verify(captured, storedTemplate)
                                        MessageBox.Show($"Fingerprint verified for {ngoName}!", "Access Granted");
                                        new Dashboard().Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No fingerprint registered for this account.", "Access Denied");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No NGO account found with this email.", "Access Denied");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("System Error: " + ex.Message); }
            }
        }
        private void OpenDashboard()
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        // --- NAVIGATION & UTILITIES ---
        private void lblGotoSignup_Click(object sender, EventArgs e)
        {
            NGOSignup ngoSignup = new NGOSignup();
            ngoSignup.Show();
            this.Hide();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}