namespace BlrCares
{
    partial class SettingsPage
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
            panelSidebar = new Panel();
            btnBack = new Button();
            lblSidebarTitle = new Label();
            panelContent = new Panel();
            pnlCard = new Panel();
            label1 = new Label();
            picPreview = new PictureBox();
            lblTitle = new Label();
            txtNewName = new TextBox();
            lblTheme = new Label();
            btnUploadPhoto = new Button();
            btnSave = new Button();
            panelSidebar.SuspendLayout();
            panelContent.SuspendLayout();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 40, 50);
            panelSidebar.Controls.Add(btnBack);
            panelSidebar.Controls.Add(lblSidebarTitle);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(5, 6, 5, 6);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(667, 1046);
            panelSidebar.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(0, 248);
            btnBack.Margin = new Padding(5, 6, 5, 6);
            btnBack.Name = "btnBack";
            btnBack.Padding = new Padding(33, 0, 0, 0);
            btnBack.Size = new Size(667, 96);
            btnBack.TabIndex = 0;
            btnBack.Text = "← Back to Dashboard";
            btnBack.TextAlign = ContentAlignment.MiddleLeft;
            btnBack.Click += btnBack_Click_1;
            // 
            // lblSidebarTitle
            // 
            lblSidebarTitle.AutoSize = true;
            lblSidebarTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblSidebarTitle.ForeColor = Color.White;
            lblSidebarTitle.Location = new Point(105, 88);
            lblSidebarTitle.Name = "lblSidebarTitle";
            lblSidebarTitle.Size = new Size(426, 70);
            lblSidebarTitle.TabIndex = 1;
            lblSidebarTitle.Text = "Bengaluru Cares";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(240, 242, 245);
            panelContent.Controls.Add(pnlCard);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(667, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1253, 1046);
            panelContent.TabIndex = 1;
            panelContent.Paint += panelContent_Paint;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(label1);
            pnlCard.Controls.Add(picPreview);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(txtNewName);
            pnlCard.Controls.Add(lblTheme);
            pnlCard.Controls.Add(btnUploadPhoto);
            pnlCard.Controls.Add(btnSave);
            pnlCard.Location = new Point(174, 134);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(900, 750);
            pnlCard.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(158, 283);
            label1.Name = "label1";
            label1.Size = new Size(167, 30);
            label1.TabIndex = 6;
            label1.Text = "Image Preview: ";
            // 
            // picPreview
            // 
            picPreview.Location = new Point(158, 316);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(160, 160);
            picPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            picPreview.TabIndex = 5;
            picPreview.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Palatino Linotype", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(26, 188, 156);
            lblTitle.Location = new Point(339, 61);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(239, 76);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Settings";
            lblTitle.Click += lblTitle_Click_1;
            // 
            // txtNewName
            // 
            txtNewName.Font = new Font("Segoe UI", 12F);
            txtNewName.Location = new Point(158, 219);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(600, 39);
            txtNewName.TabIndex = 0;
            // 
            // lblTheme
            // 
            lblTheme.AutoSize = true;
            lblTheme.Font = new Font("Segoe UI", 11F);
            lblTheme.ForeColor = Color.Gray;
            lblTheme.Location = new Point(158, 176);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new Size(188, 30);
            lblTheme.TabIndex = 2;
            lblTheme.Text = "Enter New Name: ";
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.BackColor = Color.FromArgb(30, 40, 50);
            btnUploadPhoto.FlatStyle = FlatStyle.Flat;
            btnUploadPhoto.Font = new Font("Segoe UI", 11F);
            btnUploadPhoto.ForeColor = Color.White;
            btnUploadPhoto.Location = new Point(158, 506);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(600, 60);
            btnUploadPhoto.TabIndex = 3;
            btnUploadPhoto.Text = "Update Profile Photo";
            btnUploadPhoto.UseVisualStyleBackColor = false;
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(26, 188, 156);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(158, 596);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(600, 80);
            btnSave.TabIndex = 4;
            btnSave.Text = "SAVE SETTINGS";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1046);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "SettingsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelContent.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Label lblSidebarTitle;
        private Button btnBack;
        private Panel panelContent;
        private Panel pnlCard;
        private Label lblTitle;
        private TextBox txtNewName;
        private Button btnUploadPhoto;
        private Button btnSave;
        private Label lblTheme;
        private Label label1;
        private PictureBox picPreview;
    }
}