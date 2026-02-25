namespace BlrCares
{
    partial class CertificatePage
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnInsertPhoto = new System.Windows.Forms.Button();
            this.btnInsertSign = new System.Windows.Forms.Button();
            this.btnSaveImg = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBgColor = new System.Windows.Forms.Button();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelSideMenu.Controls.Add(this.btnGenerate);
            this.panelSideMenu.Controls.Add(this.btnInsertPhoto);
            this.panelSideMenu.Controls.Add(this.btnInsertSign);
            this.panelSideMenu.Controls.Add(this.btnSaveImg);
            this.panelSideMenu.Controls.Add(this.btnBack);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(260, 1050);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.Gold;
            this.btnGenerate.Location = new System.Drawing.Point(0, 320);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnGenerate.Size = new System.Drawing.Size(260, 60);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "✨ Load Template";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnInsertPhoto
            // 
            this.btnInsertPhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsertPhoto.FlatAppearance.BorderSize = 0;
            this.btnInsertPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertPhoto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnInsertPhoto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInsertPhoto.Location = new System.Drawing.Point(0, 260);
            this.btnInsertPhoto.Name = "btnInsertPhoto";
            this.btnInsertPhoto.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnInsertPhoto.Size = new System.Drawing.Size(260, 60);
            this.btnInsertPhoto.TabIndex = 4;
            this.btnInsertPhoto.Text = "📷 Insert Photo";
            this.btnInsertPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertPhoto.UseVisualStyleBackColor = true;
            this.btnInsertPhoto.Click += new System.EventHandler(this.btnInsertPhoto_Click);
            // 
            // btnInsertSign
            // 
            this.btnInsertSign.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsertSign.FlatAppearance.BorderSize = 0;
            this.btnInsertSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertSign.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnInsertSign.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInsertSign.Location = new System.Drawing.Point(0, 200);
            this.btnInsertSign.Name = "btnInsertSign";
            this.btnInsertSign.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnInsertSign.Size = new System.Drawing.Size(260, 60);
            this.btnInsertSign.TabIndex = 3;
            this.btnInsertSign.Text = "✍ Insert Signature";
            this.btnInsertSign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertSign.UseVisualStyleBackColor = true;
            this.btnInsertSign.Click += new System.EventHandler(this.btnInsertSign_Click);
            // 
            // btnSaveImg
            // 
            this.btnSaveImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveImg.FlatAppearance.BorderSize = 0;
            this.btnSaveImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveImg.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSaveImg.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSaveImg.Location = new System.Drawing.Point(0, 140);
            this.btnSaveImg.Name = "btnSaveImg";
            this.btnSaveImg.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSaveImg.Size = new System.Drawing.Size(260, 60);
            this.btnSaveImg.TabIndex = 2;
            this.btnSaveImg.Text = "💾 Save as Image";
            this.btnSaveImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveImg.UseVisualStyleBackColor = true;
            this.btnSaveImg.Click += new System.EventHandler(this.btnSaveImg_Click);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBack.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBack.Location = new System.Drawing.Point(0, 80);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBack.Size = new System.Drawing.Size(260, 60);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "← Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lblBrand);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(260, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(22, 28);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(206, 25);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Text Certificate Editor";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnBgColor);
            this.panelHeader.Controls.Add(this.btnTextColor);
            this.panelHeader.Controls.Add(this.btnFont);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(260, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1664, 80);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 30);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Edit && Print";
            // 
            // btnBgColor
            // 
            this.btnBgColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBgColor.BackColor = System.Drawing.Color.White;
            this.btnBgColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBgColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBgColor.Location = new System.Drawing.Point(1520, 20);
            this.btnBgColor.Name = "btnBgColor";
            this.btnBgColor.Size = new System.Drawing.Size(120, 40);
            this.btnBgColor.TabIndex = 2;
            this.btnBgColor.Text = "🎨 Page Color";
            this.btnBgColor.UseVisualStyleBackColor = false;
            this.btnBgColor.Click += new System.EventHandler(this.btnBgColor_Click);
            // 
            // btnTextColor
            // 
            this.btnTextColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTextColor.BackColor = System.Drawing.Color.White;
            this.btnTextColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTextColor.Location = new System.Drawing.Point(1380, 20);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(120, 40);
            this.btnTextColor.TabIndex = 1;
            this.btnTextColor.Text = "✒ Text Color";
            this.btnTextColor.UseVisualStyleBackColor = false;
            this.btnTextColor.Click += new System.EventHandler(this.btnTextColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFont.BackColor = System.Drawing.Color.White;
            this.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFont.Location = new System.Drawing.Point(1240, 20);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(120, 40);
            this.btnFont.TabIndex = 0;
            this.btnFont.Text = "🔠 Font";
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // rtbEditor
            // 
            this.rtbEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEditor.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.rtbEditor.Location = new System.Drawing.Point(260, 80);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Padding = new System.Windows.Forms.Padding(50);
            this.rtbEditor.Size = new System.Drawing.Size(1664, 970);
            this.rtbEditor.TabIndex = 2;
            this.rtbEditor.Text = "";
            // 
            // CertificatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.rtbEditor);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "CertificatePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificate Text Editor";
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnInsertSign;
        private System.Windows.Forms.Button btnSaveImg;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBgColor;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.RichTextBox rtbEditor;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnInsertPhoto;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}