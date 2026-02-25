//using System;
//using System.Text.RegularExpressions;
//using System.Windows.Forms;
//using Microsoft.Data.SqlClient; // Required for database connection
//using BlrCares;

//namespace BengaluruCares
//{
//    public partial class Signup : Form
//    {
//        // Uses the centralized connection string from AppSecrets.cs
//        string connString = AppSecrets.ConnString;

//        public Signup()
//        {
//            InitializeComponent();
//        }

//        private void btnSignup_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                lblError.Visible = false;

//                string username = txtUser.Text.Trim();
//                string email = txtEmail.Text.Trim();
//                string mobile = txtMobile.Text.Trim();
//                string pin = txtPin.Text.Trim();
//                string password = txtPass.Text;

//                // 1. Validation Logic
//                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
//                    string.IsNullOrEmpty(mobile) || string.IsNullOrEmpty(pin) ||
//                    string.IsNullOrEmpty(password))
//                {
//                    throw new ArgumentNullException("All fields are required.");
//                }

//                if (!Regex.IsMatch(username, @"^[a-zA-Z0-9]+$"))
//                    throw new FormatException("Username must contain only alphabets and numbers.");

//                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
//                    throw new FormatException("Invalid Email format.");

//                if (!Regex.IsMatch(mobile, @"^\d{10}$"))
//                    throw new FormatException("Mobile number must be 10 digits.");

//                if (!Regex.IsMatch(pin, @"^\d{6}$"))
//                    throw new FormatException("PIN code must be 6 digits.");

//                if (!Regex.IsMatch(password, @"^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8,}$"))
//                    throw new FormatException("Password must be 8+ chars with 1 digit and 1 special char.");

//                // 2. Encrypt Password using SecurityHelper.cs
//                string hashedPassword = SecurityHelper.Encrypt(password);

//                // 3. Database Insertion into the Users table
//                using (SqlConnection con = new SqlConnection(connString))
//                {
//                    con.Open();

//                    // Check if username or email already exists
//                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@user OR Email=@email";
//                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
//                    {
//                        checkCmd.Parameters.AddWithValue("@user", username);
//                        checkCmd.Parameters.AddWithValue("@email", email);
//                        int exists = (int)checkCmd.ExecuteScalar();
//                        if (exists > 0) throw new Exception("Username or Email already registered.");
//                    }

//                    // Insert new user
//                    string query = "INSERT INTO Users (Username, Email, Mobile, PinCode, PasswordHash) " +
//                                   "VALUES (@user, @email, @mobile, @pin, @pass)";

//                    using (SqlCommand cmd = new SqlCommand(query, con))
//                    {
//                        cmd.Parameters.AddWithValue("@user", username);
//                        cmd.Parameters.AddWithValue("@email", email);
//                        cmd.Parameters.AddWithValue("@mobile", mobile);
//                        cmd.Parameters.AddWithValue("@pin", pin);
//                        cmd.Parameters.AddWithValue("@pass", hashedPassword);

//                        cmd.ExecuteNonQuery();
//                    }
//                }

//                MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

//                Dashboard dash = new Dashboard();
//                dash.Show();
//                this.Hide();
//            }
//            catch (Exception ex)
//            {
//                lblError.Text = "Error: " + ex.Message;
//                lblError.Visible = true;
//            }
//        }

//        private void lblGotoLogin_Click(object sender, EventArgs e)
//        {
//            new Login().Show();
//            this.Hide();
//        }

//        private void lblClose_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }
//    }
//}

using BlrCares;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Required for SQL Server access

namespace BengaluruCares
{
    public partial class Signup : Form
    {
        // --- DATABASE CONNECTION ---
        // Uses the centralized connection string from your AppSecrets file
        private string connString = AppSecrets.ConnString;

        // --- DYNAMIC UI CONTROLS ---
        private System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer signupTimer = new System.Windows.Forms.Timer();
        private ProgressBar progressBarStrength = new ProgressBar();
        private ProgressBar progressBarLoading = new ProgressBar();
        private Label lblShowPass = new Label();

        // Custom border panels for textboxes
        private Panel pnlEmailBorder = new Panel();
        private Panel pnlMobileBorder = new Panel();
        private Panel pnlPinBorder = new Panel();

        // Theme colors for validation states
        private Color borderNeutral = Color.LightGray;
        private Color borderError = Color.IndianRed;
        private Color borderSuccess = Color.MediumSeaGreen;

        public Signup()
        {
            InitializeComponent();
            SetupCustomBorders();
            FixClampyUI();
            InitializeDynamicControls();
            SetupEventsAndEffects();
        }

        // --- UI INITIALIZATION METHODS ---

        private void SetupCustomBorders()
        {
            Action<TextBox, Panel> wrapControl = (tb, pnl) =>
            {
                if (tb.Parent != null)
                {
                    pnl.Parent = tb.Parent;
                    tb.Parent.Controls.Remove(tb);
                }
                else
                {
                    this.Controls.Add(pnl);
                }

                pnl.BackColor = borderNeutral;
                pnl.Padding = new Padding(2);
                tb.BorderStyle = BorderStyle.None;
                tb.Dock = DockStyle.Fill;
                pnl.Controls.Add(tb);
                pnl.Size = new Size(tb.Width + 4, tb.Height + 4);
            };

            wrapControl(txtEmail, pnlEmailBorder);
            wrapControl(txtMobile, pnlMobileBorder);
            wrapControl(txtPin, pnlPinBorder);
        }

        private void FixClampyUI()
        {
            this.Size = new Size(1000, 720);
            lblLogo.AutoSize = true;
            lblTagline.AutoSize = true;
            lblTagline.Location = new Point(lblLogo.Left + 10, lblLogo.Bottom + 20);

            int startX = 60, startY = 120, gap = 80, inputWidth = 420;

            lblTitle.Location = new Point(startX - 10, 45);
            lblClose.Location = new Point(540, 20);

            lblUser.Location = new Point(startX, startY);
            txtUser.Location = new Point(startX, startY + 25);
            txtUser.Width = inputWidth;

            lblEmail.Location = new Point(startX, startY + gap);
            pnlEmailBorder.Location = new Point(startX, startY + gap + 25);
            pnlEmailBorder.Width = inputWidth;

            lblMobile.Location = new Point(startX, startY + (gap * 2));
            pnlMobileBorder.Location = new Point(startX, startY + (gap * 2) + 25);
            pnlMobileBorder.Width = inputWidth;

            lblPin.Location = new Point(startX, startY + (gap * 3));
            pnlPinBorder.Location = new Point(startX, startY + (gap * 3) + 25);
            pnlPinBorder.Width = inputWidth;

            lblPass.Location = new Point(startX, startY + (gap * 4));
            txtPass.Location = new Point(startX, startY + (gap * 4) + 25);
            txtPass.Width = inputWidth;

            lblError.Location = new Point(startX, startY + (gap * 5) - 5);
            btnSignup.Location = new Point(startX, startY + (gap * 5) + 30);
            btnSignup.Width = inputWidth;
            btnSignup.Height = 50;

            lblGotoLogin.AutoSize = true;
            lblGotoLogin.Location = new Point(
                btnSignup.Left + (btnSignup.Width / 2) - (lblGotoLogin.Width / 2),
                btnSignup.Bottom + 20
            );
        }

        private void InitializeDynamicControls()
        {
            fadeTimer.Interval = 30;
            fadeTimer.Tick += fadeTimer_Tick;

            progressBarStrength.Size = new Size(txtPass.Width, 6);
            progressBarStrength.Location = new Point(txtPass.Left, txtPass.Bottom + 5);
            progressBarStrength.Maximum = 100;
            progressBarStrength.Visible = false;
            this.panelRight.Controls.Add(progressBarStrength);
            progressBarStrength.BringToFront();

            lblShowPass.Text = "👁️";
            lblShowPass.Font = new Font("Segoe UI Emoji", 12);
            lblShowPass.Cursor = Cursors.Hand;
            lblShowPass.AutoSize = true;
            lblShowPass.Location = new Point(txtPass.Right + 5, txtPass.Top + 1);
            lblShowPass.Click += lblShowPass_Click;
            this.panelRight.Controls.Add(lblShowPass);

            txtPass.UseSystemPasswordChar = true;

            progressBarLoading.Style = ProgressBarStyle.Marquee;
            progressBarLoading.Size = new Size(btnSignup.Width, 10);
            progressBarLoading.Location = new Point(btnSignup.Left, btnSignup.Bottom + 10);
            progressBarLoading.Visible = false;
            this.panelRight.Controls.Add(progressBarLoading);

            signupTimer.Interval = 1500;
            signupTimer.Tick += signupTimer_Tick;
        }

        private void SetupEventsAndEffects()
        {
            this.Opacity = 0;
            fadeTimer.Start();

            txtUser.Enter += TextBox_Enter; txtUser.Leave += TextBox_Leave;
            txtEmail.Enter += TextBox_Enter; txtEmail.Leave += TextBox_Leave;
            txtMobile.Enter += TextBox_Enter; txtMobile.Leave += TextBox_Leave;
            txtPin.Enter += TextBox_Enter; txtPin.Leave += TextBox_Leave;
            txtPass.Enter += TextBox_Enter; txtPass.Leave += TextBox_Leave;

            btnSignup.MouseEnter += (s, e) => btnSignup.BackColor = Color.MediumSeaGreen;
            btnSignup.MouseLeave += (s, e) => btnSignup.BackColor = Color.FromArgb(26, 188, 156);

            txtPass.TextChanged += txtPass_TextChanged;
            txtEmail.TextChanged += (s, e) => ValidateField(txtEmail, pnlEmailBorder, txtEmail.Text.Contains("@") && txtEmail.Text.Contains("."));
            txtMobile.TextChanged += (s, e) => ValidateField(txtMobile, pnlMobileBorder, Regex.IsMatch(txtMobile.Text, @"^\d{10}$"));
            txtPin.TextChanged += (s, e) => ValidateField(txtPin, pnlPinBorder, Regex.IsMatch(txtPin.Text, @"^\d{6}$"));
        }

        private void ValidateField(TextBox tb, Panel pnl, bool isValid)
        {
            if (tb.Text.Length == 0) pnl.BackColor = borderNeutral;
            else pnl.BackColor = isValid ? borderSuccess : borderError;
        }

        // --- CORE FUNCTIONALITY: SIGNUP & DATABASE ---

        private void btnSignup_Click(object? sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;

                // 1. Mandatory Field Validation
                if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtMobile.Text) || string.IsNullOrWhiteSpace(txtPin.Text) ||
                    string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    throw new Exception("All fields are required.");
                }

                // 2. Format Validation
                if (!Regex.IsMatch(txtMobile.Text, @"^\d{10}$")) throw new Exception("Mobile must be 10 digits.");
                if (!Regex.IsMatch(txtPin.Text, @"^\d{6}$")) throw new Exception("PIN must be 6 digits.");
                if (txtPass.Text.Length < 8) throw new Exception("Password must be at least 8 characters.");

                // 3. UI Feedback
                btnSignup.Enabled = false;
                btnSignup.Text = "Creating Secure Account...";
                progressBarLoading.Visible = true;
                signupTimer.Start();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
            }
        }

        private void signupTimer_Tick(object? sender, EventArgs e)
        {
            signupTimer.Stop();
            try
            {
                // 4. Encrypt Password
                string hashedPassword = SecurityHelper.Encrypt(txtPass.Text);

                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();

                    // 5. Check for Existing Users
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@user OR Email=@email";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@user", txtUser.Text.Trim());
                        checkCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        if ((int)checkCmd.ExecuteScalar() > 0) throw new Exception("Username or Email already exists.");
                    }

                    // 6. Database Insertion
                    string query = "INSERT INTO Users (Username, Email, Mobile, PinCode, PasswordHash) VALUES (@user, @email, @mobile, @pin, @pass)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@user", txtUser.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@mobile", txtMobile.Text.Trim());
                        cmd.Parameters.AddWithValue("@pin", txtPin.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", hashedPassword);
                        cmd.ExecuteNonQuery();
                    }
                }

                // 7. Success & Session Setup
                Session.UserName = txtUser.Text.Trim();
                Session.UserRole = "Volunteer";
                MessageBox.Show("Welcome to Bengaluru Cares!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                new Dashboard().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                progressBarLoading.Visible = false;
                btnSignup.Enabled = true;
                btnSignup.Text = "SECURE SIGN UP";
                lblError.Text = "Database Error: " + ex.Message;
                lblError.Visible = true;
            }
        }

        // --- UI HELPERS ---

        private void fadeTimer_Tick(object? sender, EventArgs e)
        {
            if (this.Opacity < 1.0) this.Opacity += 0.05;
            else fadeTimer.Stop();
        }

        private void txtPass_TextChanged(object? sender, EventArgs e)
        {
            string pass = txtPass.Text;
            if (pass.Length == 0) { progressBarStrength.Visible = false; return; }
            progressBarStrength.Visible = true;
            int score = 0;
            if (pass.Length >= 8) score += 25;
            if (Regex.IsMatch(pass, @"[0-9]")) score += 25;
            if (Regex.IsMatch(pass, @"[!@#$%^&*]")) score += 25;
            if (Regex.IsMatch(pass, @"[A-Z]")) score += 25;
            progressBarStrength.Value = score;
        }

        private void lblShowPass_Click(object? sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !txtPass.UseSystemPasswordChar;
            lblShowPass.ForeColor = txtPass.UseSystemPasswordChar ? Color.Gray : Color.MediumSeaGreen;
        }

        private void TextBox_Enter(object? sender, EventArgs e) { if (sender is TextBox tb) tb.BackColor = Color.Honeydew; }
        private void TextBox_Leave(object? sender, EventArgs e) { if (sender is TextBox tb) tb.BackColor = Color.White; }
        private void lblClose_Click(object? sender, EventArgs e) => Application.Exit();
        private void lblGotoLogin_Click(object? sender, EventArgs e) { new Login().Show(); this.Hide(); }
    }
}