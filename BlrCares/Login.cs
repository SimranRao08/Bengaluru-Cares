using System;
using System.Drawing;
using System.Windows.Forms;
using BengaluruCares; // Needed to access the Dashboard form

namespace BlrCares
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // --- CORE LOGIN LOGIC ---
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Please enter both Email and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mock Validation Success
            MessageBox.Show("Login Successful! Welcome back.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Redirect to the existing Dashboard
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        // --- FORGOT PASSWORD / OTP REVEAL LOGIC ---
        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter your registered email address first to receive an OTP.", "Email Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }

            // Simulate sending an email
            MessageBox.Show($"A 4-digit OTP has been sent to {txtEmail.Text}.", "OTP Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reveal the sleek OTP panel below the login button
            pnlOTP.Visible = true;
            txtOTP.Clear();
            txtOTP.Focus();
        }

        private void btnVerifyOTP_Click(object sender, EventArgs e)
        {
            // The TextBox restricts length to 4 via MaxLength in the Designer
            if (txtOTP.Text.Length == 4)
            {
                MessageBox.Show("OTP Verified successfully! You can now reset your password.", "Security Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide panel again after success
                pnlOTP.Visible = false;
                txtPass.Focus();
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please enter exactly 4 digits.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOTP.Clear();
            }
        }

        // --- CLOSE BUTTON ---
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}