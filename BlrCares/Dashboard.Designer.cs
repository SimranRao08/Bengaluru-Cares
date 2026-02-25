namespace BengaluruCares
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            pnlNavHighlight = new Panel();
            btnLogout = new Button();
            btnSettings = new Button();
            btnHistory = new Button();
            btnEvents = new Button();
            btnHome = new Button();
            panelProfile = new Panel();
            lblUserRole = new Label();
            lblUserName = new Label();
            picProfile = new PictureBox();
            lblLogo = new Label();
            panelMain = new Panel();
            panelActivity = new Panel();
            lblActivityList = new Label();
            lblActivityTitle = new Label();
            panelBanner = new Panel();
            lblBannerDate = new Label();
            lblBannerTitle = new Label();
            lblBannerHeader = new Label();
            btnFindOpp = new Button();
            btnVolGuide = new Button();
            btnRewards = new Button();
            panelHeader = new Panel();
            lblPageTitle = new Label();
            panelSidebar.SuspendLayout();
            panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            panelMain.SuspendLayout();
            panelActivity.SuspendLayout();
            panelBanner.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 40, 50);
            panelSidebar.Controls.Add(pnlNavHighlight);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnSettings);
            panelSidebar.Controls.Add(btnHistory);
            panelSidebar.Controls.Add(btnEvents);
            panelSidebar.Controls.Add(btnHome);
            panelSidebar.Controls.Add(panelProfile);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(5, 6, 5, 6);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(433, 1050);
            panelSidebar.TabIndex = 0;
            // 
            // pnlNavHighlight
            // 
            pnlNavHighlight.BackColor = Color.FromArgb(26, 188, 156);
            pnlNavHighlight.Location = new Point(0, 385);
            pnlNavHighlight.Margin = new Padding(5, 6, 5, 6);
            pnlNavHighlight.Name = "pnlNavHighlight";
            pnlNavHighlight.Size = new Size(8, 96);
            pnlNavHighlight.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(25, 35, 45);
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(231, 76, 60);
            btnLogout.Location = new Point(0, 944);
            btnLogout.Margin = new Padding(5, 6, 5, 6);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(433, 106);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 11F);
            btnSettings.ForeColor = Color.Silver;
            btnSettings.Location = new Point(0, 673);
            btnSettings.Margin = new Padding(5, 6, 5, 6);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(33, 0, 0, 0);
            btnSettings.Size = new Size(433, 96);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnHistory
            // 
            btnHistory.Dock = DockStyle.Top;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 11F);
            btnHistory.ForeColor = Color.Silver;
            btnHistory.Location = new Point(0, 577);
            btnHistory.Margin = new Padding(5, 6, 5, 6);
            btnHistory.Name = "btnHistory";
            btnHistory.Padding = new Padding(33, 0, 0, 0);
            btnHistory.Size = new Size(433, 96);
            btnHistory.TabIndex = 4;
            btnHistory.Text = "My History";
            btnHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnEvents
            // 
            btnEvents.Dock = DockStyle.Top;
            btnEvents.FlatAppearance.BorderSize = 0;
            btnEvents.FlatStyle = FlatStyle.Flat;
            btnEvents.Font = new Font("Segoe UI", 11F);
            btnEvents.ForeColor = Color.Silver;
            btnEvents.Location = new Point(0, 481);
            btnEvents.Margin = new Padding(5, 6, 5, 6);
            btnEvents.Name = "btnEvents";
            btnEvents.Padding = new Padding(33, 0, 0, 0);
            btnEvents.Size = new Size(433, 96);
            btnEvents.TabIndex = 3;
            btnEvents.Text = "Calculate";
            btnEvents.TextAlign = ContentAlignment.MiddleLeft;
            btnEvents.UseVisualStyleBackColor = true;
            btnEvents.Click += btnEvents_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(44, 62, 80);
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(0, 385);
            btnHome.Margin = new Padding(5, 6, 5, 6);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(33, 0, 0, 0);
            btnHome.Size = new Size(433, 96);
            btnHome.TabIndex = 2;
            btnHome.Text = "Dashboard";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // panelProfile
            // 
            panelProfile.Controls.Add(lblUserRole);
            panelProfile.Controls.Add(lblUserName);
            panelProfile.Controls.Add(picProfile);
            panelProfile.Dock = DockStyle.Top;
            panelProfile.Location = new Point(0, 154);
            panelProfile.Margin = new Padding(5, 6, 5, 6);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(433, 231);
            panelProfile.TabIndex = 1;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Segoe UI", 9F);
            lblUserRole.ForeColor = Color.Silver;
            lblUserRole.Location = new Point(150, 125);
            lblUserRole.Margin = new Padding(5, 0, 5, 0);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(87, 25);
            lblUserRole.TabIndex = 2;
            lblUserRole.Text = "Volunteer";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(150, 77);
            lblUserName.Margin = new Padding(5, 0, 5, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(85, 30);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Simran";
            lblUserName.Click += lblUserName_Click;
            // 
            // picProfile
            // 
            picProfile.BackColor = Color.FromArgb(60, 70, 80);
            picProfile.Location = new Point(33, 67);
            picProfile.Margin = new Padding(5, 6, 5, 6);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(100, 100);  // MUST be square
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfile.TabIndex = 0;
            picProfile.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Top;
            lblLogo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Margin = new Padding(5, 0, 5, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(433, 154);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Bengaluru Cares";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(240, 242, 245);
            panelMain.Controls.Add(panelActivity);
            panelMain.Controls.Add(panelBanner);
            panelMain.Controls.Add(btnFindOpp);
            panelMain.Controls.Add(btnVolGuide);
            panelMain.Controls.Add(btnRewards);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(433, 0);
            panelMain.Margin = new Padding(5, 6, 5, 6);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1491, 1050);
            panelMain.TabIndex = 1;
            // 
            // panelActivity
            // 
            panelActivity.BackColor = Color.White;
            panelActivity.Controls.Add(lblActivityList);
            panelActivity.Controls.Add(lblActivityTitle);
            panelActivity.Location = new Point(67, 846);
            panelActivity.Margin = new Padding(5, 6, 5, 6);
            panelActivity.Name = "panelActivity";
            panelActivity.Size = new Size(1400, 423);
            panelActivity.TabIndex = 5;
            // 
            // lblActivityList
            // 
            lblActivityList.Font = new Font("Segoe UI", 10F);
            lblActivityList.ForeColor = Color.FromArgb(64, 64, 64);
            lblActivityList.Location = new Point(33, 96);
            lblActivityList.Margin = new Padding(5, 0, 5, 0);
            lblActivityList.Name = "lblActivityList";
            lblActivityList.Size = new Size(1333, 288);
            lblActivityList.TabIndex = 1;
            lblActivityList.Text = "• Completed 4 hours at 'Cubbon Park Cleanup'\r\n\r\n• Registered for 'Teaching Drive 2025'\r\n\r\n• Badge Unlocked: Early Bird Volunteer\r\n\r\n• Profile updated successfully";
            // 
            // lblActivityTitle
            // 
            lblActivityTitle.AutoSize = true;
            lblActivityTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblActivityTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblActivityTitle.Location = new Point(33, 38);
            lblActivityTitle.Margin = new Padding(5, 0, 5, 0);
            lblActivityTitle.Name = "lblActivityTitle";
            lblActivityTitle.Size = new Size(185, 32);
            lblActivityTitle.TabIndex = 0;
            lblActivityTitle.Text = "Recent Activity";
            // 
            // panelBanner
            // 
            panelBanner.BackColor = Color.FromArgb(26, 188, 156);
            panelBanner.Controls.Add(lblBannerDate);
            panelBanner.Controls.Add(lblBannerTitle);
            panelBanner.Controls.Add(lblBannerHeader);
            panelBanner.Location = new Point(67, 192);
            panelBanner.Margin = new Padding(5, 6, 5, 6);
            panelBanner.Name = "panelBanner";
            panelBanner.Size = new Size(1400, 269);
            panelBanner.TabIndex = 4;
            // 
            // lblBannerDate
            // 
            lblBannerDate.AutoSize = true;
            lblBannerDate.Font = new Font("Segoe UI", 10F);
            lblBannerDate.ForeColor = Color.WhiteSmoke;
            lblBannerDate.Location = new Point(50, 173);
            lblBannerDate.Margin = new Padding(5, 0, 5, 0);
            lblBannerDate.Name = "lblBannerDate";
            lblBannerDate.Size = new Size(268, 28);
            lblBannerDate.TabIndex = 2;
            lblBannerDate.Text = "Saturday, 12th Dec • 9:00 AM";
            // 
            // lblBannerTitle
            // 
            lblBannerTitle.AutoSize = true;
            lblBannerTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBannerTitle.ForeColor = Color.White;
            lblBannerTitle.Location = new Point(42, 87);
            lblBannerTitle.Margin = new Padding(5, 0, 5, 0);
            lblBannerTitle.Name = "lblBannerTitle";
            lblBannerTitle.Size = new Size(386, 54);
            lblBannerTitle.TabIndex = 1;
            lblBannerTitle.Text = "Tree Plantation MG";
            // 
            // lblBannerHeader
            // 
            lblBannerHeader.AutoSize = true;
            lblBannerHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBannerHeader.ForeColor = Color.FromArgb(200, 255, 240);
            lblBannerHeader.Location = new Point(50, 38);
            lblBannerHeader.Margin = new Padding(5, 0, 5, 0);
            lblBannerHeader.Name = "lblBannerHeader";
            lblBannerHeader.Size = new Size(189, 28);
            lblBannerHeader.TabIndex = 0;
            lblBannerHeader.Text = "UPCOMING EVENT";
            // 
            // btnFindOpp
            // 
            btnFindOpp.BackColor = Color.White;
            btnFindOpp.FlatStyle = FlatStyle.Flat;
            btnFindOpp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFindOpp.ForeColor = Color.FromArgb(44, 62, 80);
            btnFindOpp.Location = new Point(67, 519);
            btnFindOpp.Margin = new Padding(5, 6, 5, 6);
            btnFindOpp.Name = "btnFindOpp";
            btnFindOpp.Size = new Size(433, 269);
            btnFindOpp.TabIndex = 1;
            btnFindOpp.Text = "Find Opportunities\r\n\r\n🔍 Search";
            btnFindOpp.UseVisualStyleBackColor = false;
            btnFindOpp.Click += btnFindOpp_Click;
            // 
            // btnVolGuide
            // 
            btnVolGuide.BackColor = Color.White;
            btnVolGuide.FlatStyle = FlatStyle.Flat;
            btnVolGuide.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVolGuide.ForeColor = Color.FromArgb(44, 62, 80);
            btnVolGuide.Location = new Point(550, 519);
            btnVolGuide.Margin = new Padding(5, 6, 5, 6);
            btnVolGuide.Name = "btnVolGuide";
            btnVolGuide.Size = new Size(433, 269);
            btnVolGuide.TabIndex = 2;
            btnVolGuide.Text = "Volunteer Guide\r\n\r\n📖 Read";
            btnVolGuide.UseVisualStyleBackColor = false;
            btnVolGuide.Click += btnVolGuide_Click;
            // 
            // btnRewards
            // 
            btnRewards.BackColor = Color.White;
            btnRewards.FlatStyle = FlatStyle.Flat;
            btnRewards.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRewards.ForeColor = Color.FromArgb(44, 62, 80);
            btnRewards.Location = new Point(1033, 519);
            btnRewards.Margin = new Padding(5, 6, 5, 6);
            btnRewards.Name = "btnRewards";
            btnRewards.Size = new Size(433, 269);
            btnRewards.TabIndex = 3;
            btnRewards.Text = "Rewards\r\n\r\n🏆 View";
            btnRewards.UseVisualStyleBackColor = false;
            btnRewards.Click += btnRewards_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblPageTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(5, 6, 5, 6);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1491, 135);
            panelHeader.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPageTitle.Location = new Point(50, 38);
            lblPageTitle.Margin = new Padding(5, 0, 5, 0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(184, 45);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bengaluru Cares Dashboard";
            panelSidebar.ResumeLayout(false);
            panelProfile.ResumeLayout(false);
            panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            panelMain.ResumeLayout(false);
            panelActivity.ResumeLayout(false);
            panelActivity.PerformLayout();
            panelBanner.ResumeLayout(false);
            panelBanner.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Panel pnlNavHighlight;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Button btnRewards;
        private System.Windows.Forms.Button btnVolGuide;
        private System.Windows.Forms.Button btnFindOpp;
        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.Label lblBannerTitle;
        private System.Windows.Forms.Label lblBannerHeader;
        private System.Windows.Forms.Label lblBannerDate;
        private System.Windows.Forms.Panel panelActivity;
        private System.Windows.Forms.Label lblActivityTitle;
        private System.Windows.Forms.Label lblActivityList;
    }
}