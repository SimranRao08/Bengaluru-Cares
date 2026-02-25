using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Required for database
using BlrCares;

namespace BengaluruCares
{
    public partial class NGOSignup : Form
    {
        private bool isDetailsValidated = false;
        private string connString = AppSecrets.ConnString; // Use centralized connection string

        public NGOSignup()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;
                isDetailsValidated = false;

                // Basic validation as you already have it
                if (string.IsNullOrWhiteSpace(txtNGOName.Text) || string.IsNullOrWhiteSpace(txtRegNo.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) ||
                    string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    throw new ArgumentNullException("All fields are required.");
                }

                // ... (Keep your existing Regex validation logic here) ...

                isDetailsValidated = true;
                MessageBox.Show("NGO Details Validated! Please scan fingerprint to complete registration.", "Success");
                btnFingerprint.BackColor = System.Drawing.Color.FromArgb(26, 188, 156);
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
                lblError.Visible = true;
            }
        }

        private async void btnFingerprint_Click(object sender, EventArgs e)
        {
            if (!isDetailsValidated) return;

            // Simulate capturing a unique template from hardware
            string capturedTemplate = Guid.NewGuid().ToString("N");

            try
            {
                using (SqlConnection con = new SqlConnection(AppSecrets.ConnString))
                {
                    await con.OpenAsync();
                    // Store the template linked to this specific NGO
                    string query = @"INSERT INTO NGOs (NGOName, RegNo, Email, Phone, PasswordHash, BiometricID) 
                             VALUES (@name, @reg, @email, @phone, @pass, @bio)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", txtNGOName.Text.Trim());
                        cmd.Parameters.AddWithValue("@reg", txtRegNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", SecurityHelper.Encrypt(txtPass.Text));
                        cmd.Parameters.AddWithValue("@bio", capturedTemplate); // Unique ID saved here
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
                MessageBox.Show("NGO Registered with unique Biometric ID!");
                new NgoDashboard().Show();
                this.Hide();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            new landing().Show();

            this.Close();
        }
        // Navigation logic remains the same
    }
}