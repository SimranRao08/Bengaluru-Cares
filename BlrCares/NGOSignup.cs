using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BlrCares; // Ensure you can navigate to the Login form

namespace BengaluruCares
{
    public partial class NGOSignup : Form
    {
        private bool isDetailsValidated = false;

        public NGOSignup()
        {
            InitializeComponent();
        }

        // --- STEP 1: VALIDATE DETAILS ---
        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;
                isDetailsValidated = false;

                string ngoName = txtNGOName.Text;
                string regNo = txtRegNo.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string password = txtPass.Text;

                // Check for empty fields
                if (string.IsNullOrEmpty(ngoName) || string.IsNullOrEmpty(regNo) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) ||
                    string.IsNullOrEmpty(password))
                {
                    throw new ArgumentNullException("All fields are required.");
                }

                // Email Validation
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(email, emailPattern))
                {
                    throw new FormatException("Invalid Official Email format.");
                }

                // Phone Validation
                string phonePattern = @"^\d{10}$";
                if (!Regex.IsMatch(phone, phonePattern))
                {
                    throw new FormatException("Contact number must be exactly 10 digits.");
                }

                // Password Validation
                string passPattern = @"^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8,}$";
                if (!Regex.IsMatch(password, passPattern))
                {
                    throw new FormatException("Password must be 8+ chars, with 1 digit and 1 special char.");
                }

                // If everything passes
                isDetailsValidated = true;
                MessageBox.Show("NGO Details Validated Successfully!\n\nPlease proceed to scan the authorized representative's fingerprint to complete registration.", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Visually prompt the user to click the fingerprint button next
                btnFingerprint.BackColor = System.Drawing.Color.FromArgb(26, 188, 156); // Turns SeaGreen to highlight it
            }
            catch (ArgumentNullException ex)
            {
                lblError.Text = "Error: " + ex.ParamName;
                lblError.Visible = true;
            }
            catch (FormatException ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
            }
            catch (Exception ex)
            {
                lblError.Text = "Unexpected Error: " + ex.Message;
                lblError.Visible = true;
            }
        }

        // --- STEP 2: SCAN FINGERPRINT ---
        private void btnFingerprint_Click(object sender, EventArgs e)
        {
            if (!isDetailsValidated)
            {
                MessageBox.Show("Please fill out and validate the NGO details before scanning your fingerprint.", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simulate Hardware Fingerprint Scanning Process
            DialogResult result = MessageBox.Show("Place finger on the scanner and click OK...\n\n(Simulating hardware connection)", "Biometric Scanner", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Fingerprint captured and securely hashed!\n\nNGO Registration Complete.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect to Dashboard
                Dashboard dash = new Dashboard();
                dash.Show();
                this.Hide();
            }
        }

        // --- NAVIGATION ---
        private void lblGotoLogin_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}