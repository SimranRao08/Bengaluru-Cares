using System;
using System.Text.RegularExpressions; 
using System.Windows.Forms;

namespace BengaluruCares
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;

                string username = txtUser.Text;
                string email = txtEmail.Text;
                string mobile = txtMobile.Text;
                string pin = txtPin.Text;
                string password = txtPass.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(mobile) || string.IsNullOrEmpty(pin) ||
                    string.IsNullOrEmpty(password))
                {
                    throw new ArgumentNullException("All fields are required.");
                }


                string userPattern = @"^[a-zA-Z0-9]+$";
                if (!Regex.IsMatch(username, userPattern))
                {
                    throw new FormatException("Username must contain only alphabets and numbers.");
                }

                //Email ID 
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(email, emailPattern))
                {
                    throw new FormatException("Invalid Email format (e.g., user@example.com).");
                }

                string mobilePattern = @"^\d{10}$";
                if (!Regex.IsMatch(mobile, mobilePattern))
                {
                    throw new FormatException("Mobile number must be exactly 10 digits.");
                }

                string pinPattern = @"^\d{6}$";
                if (!Regex.IsMatch(pin, pinPattern))
                {
                    throw new FormatException("PIN code must be exactly 6 digits.");
                }

                string passPattern = @"^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8,}$";
                if (!Regex.IsMatch(password, passPattern))
                {
                    throw new FormatException("Password must be 8+ chars, with 1 digit and 1 special char.");
                }

                MessageBox.Show("Validation Successful! Logging in...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dashboard dash = new Dashboard();
                dash.Show();

                this.Hide();
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

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}