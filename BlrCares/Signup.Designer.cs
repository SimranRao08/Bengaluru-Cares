namespace BengaluruCares
{
    partial class Signup
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
            panelLeft = new System.Windows.Forms.Panel();
            lblTagline = new System.Windows.Forms.Label();
            lblLogo = new System.Windows.Forms.Label();
            panelRight = new System.Windows.Forms.Panel();
            lblClose = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            lblError = new System.Windows.Forms.Label();

            txtUser = new System.Windows.Forms.TextBox();
            lblUser = new System.Windows.Forms.Label();
            txtPass = new System.Windows.Forms.TextBox();
            lblPass = new System.Windows.Forms.Label();

            txtEmail = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtMobile = new System.Windows.Forms.TextBox();
            lblMobile = new System.Windows.Forms.Label();
            txtPin = new System.Windows.Forms.TextBox();
            lblPin = new System.Windows.Forms.Label();

            lblTitle = new System.Windows.Forms.Label();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();

            panelLeft.BackColor = System.Drawing.Color.SeaGreen;
            panelLeft.Controls.Add(lblTagline);
            panelLeft.Controls.Add(lblLogo);
            panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            panelLeft.Location = new System.Drawing.Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new System.Drawing.Size(400, 800);
            panelLeft.TabIndex = 0;

            lblTagline.AutoSize = true;
            lblTagline.Font = new System.Drawing.Font("Segoe UI", 14F);
            lblTagline.ForeColor = System.Drawing.Color.White;
            lblTagline.Location = new System.Drawing.Point(30, 400);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new System.Drawing.Size(277, 25);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "Volunteer Management System";

            lblLogo.AutoSize = true;
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            lblLogo.ForeColor = System.Drawing.Color.White;
            lblLogo.Location = new System.Drawing.Point(30, 200);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(207, 102);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Bengaluru\r\nCares";

            panelRight.BackColor = System.Drawing.Color.White;
            panelRight.Controls.Add(lblClose);
            panelRight.Controls.Add(btnLogin);
            panelRight.Controls.Add(lblError);

            panelRight.Controls.Add(txtPin);
            panelRight.Controls.Add(lblPin);
            panelRight.Controls.Add(txtMobile);
            panelRight.Controls.Add(lblMobile);
            panelRight.Controls.Add(txtEmail);
            panelRight.Controls.Add(lblEmail);
            panelRight.Controls.Add(txtPass);
            panelRight.Controls.Add(lblPass);
            panelRight.Controls.Add(txtUser);
            panelRight.Controls.Add(lblUser);
            panelRight.Controls.Add(lblTitle);

            panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            panelRight.Location = new System.Drawing.Point(400, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new System.Drawing.Size(600, 800);
            panelRight.TabIndex = 1;

            lblClose.AutoSize = true;
            lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            lblClose.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblClose.ForeColor = System.Drawing.Color.Gray;
            lblClose.Location = new System.Drawing.Point(550, 10);
            lblClose.Name = "lblClose";
            lblClose.Size = new System.Drawing.Size(27, 30);
            lblClose.TabIndex = 15;
            lblClose.Text = "X";
            lblClose.Click += new System.EventHandler(this.lblClose_Click);

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            lblTitle.Location = new System.Drawing.Point(50, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(248, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registration Demo";

            lblUser.AutoSize = true;
            lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblUser.ForeColor = System.Drawing.Color.Gray;
            lblUser.Location = new System.Drawing.Point(50, 100);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(64, 15);
            lblUser.TabIndex = 1;
            lblUser.Text = "Username";

            txtUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtUser.Location = new System.Drawing.Point(50, 120);
            txtUser.Name = "txtUser";
            txtUser.Size = new System.Drawing.Size(500, 27);
            txtUser.TabIndex = 2;

            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblEmail.ForeColor = System.Drawing.Color.Gray;
            lblEmail.Location = new System.Drawing.Point(50, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";

            txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtEmail.Location = new System.Drawing.Point(50, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(500, 27);
            txtEmail.TabIndex = 4;

            lblMobile.AutoSize = true;
            lblMobile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblMobile.ForeColor = System.Drawing.Color.Gray;
            lblMobile.Location = new System.Drawing.Point(50, 220);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new System.Drawing.Size(45, 15);
            lblMobile.TabIndex = 5;
            lblMobile.Text = "Mobile";

            txtMobile.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtMobile.Location = new System.Drawing.Point(50, 240);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new System.Drawing.Size(500, 27);
            txtMobile.TabIndex = 6;

            lblPin.AutoSize = true;
            lblPin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblPin.ForeColor = System.Drawing.Color.Gray;
            lblPin.Location = new System.Drawing.Point(50, 280);
            lblPin.Name = "lblPin";
            lblPin.Size = new System.Drawing.Size(58, 15);
            lblPin.TabIndex = 7;
            lblPin.Text = "PIN Code";

            txtPin.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtPin.Location = new System.Drawing.Point(50, 300);
            txtPin.Name = "txtPin";
            txtPin.Size = new System.Drawing.Size(500, 27);
            txtPin.TabIndex = 8;

            lblPass.AutoSize = true;
            lblPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblPass.ForeColor = System.Drawing.Color.Gray;
            lblPass.Location = new System.Drawing.Point(50, 340);
            lblPass.Name = "lblPass";
            lblPass.Size = new System.Drawing.Size(59, 15);
            lblPass.TabIndex = 9;
            lblPass.Text = "Password";

            txtPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtPass.Location = new System.Drawing.Point(50, 360);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.Size = new System.Drawing.Size(500, 27);
            txtPass.TabIndex = 10;

            lblError.AutoSize = true;
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Location = new System.Drawing.Point(50, 400);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(120, 15);
            lblError.TabIndex = 11;
            lblError.Text = "Error Message Here";
            lblError.Visible = false;

            btnLogin.BackColor = System.Drawing.Color.FromArgb(26, 188, 156);
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(50, 440);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(500, 50);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "VALIDATE & LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1000, 800);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
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
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblTitle;
    }
}