namespace BlrCares
{
    partial class landing
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnNGO = new System.Windows.Forms.Button();
            this.btnVolunteer = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(83))))); // Deep Teal Background
            this.panelBackground.Controls.Add(this.panelCard);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(900, 550);
            this.panelBackground.TabIndex = 0;
            // 
            // panelCard
            // 
            this.panelCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.btnLogin);
            this.panelCard.Controls.Add(this.btnNGO);
            this.panelCard.Controls.Add(this.btnVolunteer);
            this.panelCard.Controls.Add(this.lblSubtitle);
            this.panelCard.Controls.Add(this.lblBrand);
            this.panelCard.Controls.Add(this.lblWelcome);
            this.panelCard.Location = new System.Drawing.Point(225, 50);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(450, 450);
            this.panelCard.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogin.Location = new System.Drawing.Point(75, 370);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 35);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Already have an account? Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnNGO
            // 
            this.btnNGO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNGO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(83)))));
            this.btnNGO.FlatAppearance.BorderSize = 2;
            this.btnNGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNGO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNGO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(83)))));
            this.btnNGO.Location = new System.Drawing.Point(75, 290);
            this.btnNGO.Name = "btnNGO";
            this.btnNGO.Size = new System.Drawing.Size(300, 55);
            this.btnNGO.TabIndex = 4;
            this.btnNGO.Text = "Sign up as an NGO";
            this.btnNGO.UseVisualStyleBackColor = true;
            this.btnNGO.Click += new System.EventHandler(this.btnNGO_Click);
            this.btnNGO.MouseEnter += new System.EventHandler(this.btnNGO_MouseEnter);
            this.btnNGO.MouseLeave += new System.EventHandler(this.btnNGO_MouseLeave);
            // 
            // btnVolunteer
            // 
            this.btnVolunteer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(83)))));
            this.btnVolunteer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolunteer.FlatAppearance.BorderSize = 0;
            this.btnVolunteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolunteer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolunteer.ForeColor = System.Drawing.Color.White;
            this.btnVolunteer.Location = new System.Drawing.Point(75, 215);
            this.btnVolunteer.Name = "btnVolunteer";
            this.btnVolunteer.Size = new System.Drawing.Size(300, 55);
            this.btnVolunteer.TabIndex = 3;
            this.btnVolunteer.Text = "Sign up as a Volunteer";
            this.btnVolunteer.UseVisualStyleBackColor = false;
            this.btnVolunteer.Click += new System.EventHandler(this.btnVolunteer_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(0, 130);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(450, 25);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Connecting communities through service.";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(83)))));
            this.lblBrand.Location = new System.Drawing.Point(0, 75);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(450, 50);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Bengaluru Cares";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcome.Location = new System.Drawing.Point(0, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(450, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.panelBackground);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Landing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bengaluru Cares - Welcome";
            this.panelBackground.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnVolunteer;
        private System.Windows.Forms.Button btnNGO;
        private System.Windows.Forms.Button btnLogin;
    }
}