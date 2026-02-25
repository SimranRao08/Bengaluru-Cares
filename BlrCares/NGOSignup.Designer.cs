namespace BengaluruCares
{
    partial class NGOSignup
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelLeft = new Panel();
            lblTagline = new Label();
            lblLogo = new Label();
            panelRight = new Panel();
            btnFingerprint = new Button();
            lblGotoLogin = new Label();
            lblClose = new Label();
            btnSignup = new Button();
            lblError = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPass = new TextBox();
            lblPass = new Label();
            txtRegNo = new TextBox();
            lblRegNo = new Label();
            txtNGOName = new TextBox();
            lblNGOName = new Label();
            lblTitle = new Label();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(0, 92, 83);
            panelLeft.Controls.Add(lblTagline);
            panelLeft.Controls.Add(lblLogo);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(5, 6, 5, 6);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(667, 1106);
            panelLeft.TabIndex = 0;
            // 
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTagline.ForeColor = Color.LightGray;
            lblTagline.Location = new Point(83, 596);
            lblTagline.Margin = new Padding(5, 0, 5, 0);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(391, 64);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "Empower your mission.\r\nConnect with dedicated volunteers.";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(67, 385);
            lblLogo.Margin = new Padding(5, 0, 5, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(303, 148);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Bengaluru\r\nCares";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(btnFingerprint);
            panelRight.Controls.Add(lblGotoLogin);
            panelRight.Controls.Add(lblClose);
            panelRight.Controls.Add(btnSignup);
            panelRight.Controls.Add(lblError);
            panelRight.Controls.Add(txtPhone);
            panelRight.Controls.Add(lblPhone);
            panelRight.Controls.Add(txtEmail);
            panelRight.Controls.Add(lblEmail);
            panelRight.Controls.Add(txtPass);
            panelRight.Controls.Add(lblPass);
            panelRight.Controls.Add(txtRegNo);
            panelRight.Controls.Add(lblRegNo);
            panelRight.Controls.Add(txtNGOName);
            panelRight.Controls.Add(lblNGOName);
            panelRight.Controls.Add(lblTitle);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(667, 0);
            panelRight.Margin = new Padding(5, 6, 5, 6);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(833, 1106);
            panelRight.TabIndex = 1;
            // 
            // btnFingerprint
            // 
            btnFingerprint.BackColor = Color.FromArgb(44, 62, 80);
            btnFingerprint.Cursor = Cursors.Hand;
            btnFingerprint.FlatAppearance.BorderSize = 0;
            btnFingerprint.FlatStyle = FlatStyle.Flat;
            btnFingerprint.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFingerprint.ForeColor = Color.White;
            btnFingerprint.Location = new Point(83, 1000);
            btnFingerprint.Margin = new Padding(5, 6, 5, 6);
            btnFingerprint.Name = "btnFingerprint";
            btnFingerprint.Size = new Size(667, 87);
            btnFingerprint.TabIndex = 17;
            btnFingerprint.Text = "🖙 SCAN FINGERPRINT";
            btnFingerprint.UseVisualStyleBackColor = false;
            btnFingerprint.Click += btnFingerprint_Click;
            // 
            // lblGotoLogin
            // 
            lblGotoLogin.AutoSize = true;
            lblGotoLogin.Cursor = Cursors.Hand;
            lblGotoLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblGotoLogin.ForeColor = Color.Gray;
            lblGotoLogin.Location = new Point(242, 1135);
            lblGotoLogin.Margin = new Padding(5, 0, 5, 0);
            lblGotoLogin.Name = "lblGotoLogin";
            lblGotoLogin.Size = new Size(318, 28);
            lblGotoLogin.TabIndex = 16;
            lblGotoLogin.Text = "Already have an account? Log in";
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Cursor = Cursors.Hand;
            lblClose.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClose.ForeColor = Color.Silver;
            lblClose.Location = new Point(750, 29);
            lblClose.Margin = new Padding(5, 0, 5, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(41, 45);
            lblClose.TabIndex = 15;
            lblClose.Text = "X";
            lblClose.Click += lblClose_Click;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(26, 188, 156);
            btnSignup.Cursor = Cursors.Hand;
            btnSignup.FlatAppearance.BorderSize = 0;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(83, 885);
            btnSignup.Margin = new Padding(5, 6, 5, 6);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(667, 96);
            btnSignup.TabIndex = 12;
            btnSignup.Text = "VALIDATE DETAILS";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(83, 808);
            lblError.Margin = new Padding(5, 0, 5, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(667, 62);
            lblError.TabIndex = 11;
            lblError.Text = "Error Message Here";
            lblError.Visible = false;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(83, 615);
            txtPhone.Margin = new Padding(5, 6, 5, 6);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(664, 37);
            txtPhone.TabIndex = 8;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.Gray;
            lblPhone.Location = new Point(83, 577);
            lblPhone.Margin = new Padding(5, 0, 5, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(152, 25);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Contact Number";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(83, 500);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(664, 37);
            txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Gray;
            lblEmail.Location = new Point(83, 462);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(125, 25);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Official Email";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(83, 731);
            txtPass.Margin = new Padding(5, 6, 5, 6);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.Size = new Size(664, 37);
            txtPass.TabIndex = 10;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPass.ForeColor = Color.Gray;
            lblPass.Location = new Point(83, 692);
            lblPass.Margin = new Padding(5, 0, 5, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(92, 25);
            lblPass.TabIndex = 9;
            lblPass.Text = "Password";
            // 
            // txtRegNo
            // 
            txtRegNo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegNo.Location = new Point(83, 385);
            txtRegNo.Margin = new Padding(5, 6, 5, 6);
            txtRegNo.Name = "txtRegNo";
            txtRegNo.Size = new Size(664, 37);
            txtRegNo.TabIndex = 4;
            // 
            // lblRegNo
            // 
            lblRegNo.AutoSize = true;
            lblRegNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegNo.ForeColor = Color.Gray;
            lblRegNo.Location = new Point(83, 346);
            lblRegNo.Margin = new Padding(5, 0, 5, 0);
            lblRegNo.Name = "lblRegNo";
            lblRegNo.Size = new Size(197, 25);
            lblRegNo.TabIndex = 3;
            lblRegNo.Text = "NGO Registration No.";
            // 
            // txtNGOName
            // 
            txtNGOName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNGOName.Location = new Point(83, 269);
            txtNGOName.Margin = new Padding(5, 6, 5, 6);
            txtNGOName.Name = "txtNGOName";
            txtNGOName.Size = new Size(664, 37);
            txtNGOName.TabIndex = 2;
            // 
            // lblNGOName
            // 
            lblNGOName.AutoSize = true;
            lblNGOName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNGOName.ForeColor = Color.Gray;
            lblNGOName.Location = new Point(83, 231);
            lblNGOName.Margin = new Padding(5, 0, 5, 0);
            lblNGOName.Name = "lblNGOName";
            lblNGOName.Size = new Size(178, 25);
            lblNGOName.TabIndex = 1;
            lblNGOName.Text = "Organization Name";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(67, 96);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(466, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "NGO Partner Sign Up";
            // 
            // NGOSignup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 1106);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "NGOSignup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NGO Signup";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnFingerprint;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtNGOName;
        private System.Windows.Forms.Label lblNGOName;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGotoLogin;
    }
}