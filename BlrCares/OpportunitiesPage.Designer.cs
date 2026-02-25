namespace BlrCares
{
    partial class OpportunitiesPage
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lstApplied = new System.Windows.Forms.ListBox();
            this.lblAppliedTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(30, 40, 50);
            this.panelSidebar.Controls.Add(this.lstApplied);
            this.panelSidebar.Controls.Add(this.lblAppliedTitle);
            this.panelSidebar.Controls.Add(this.btnBack);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Size = new System.Drawing.Size(300, 1050);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Size = new System.Drawing.Size(300, 80);
            this.btnBack.Text = "← Back to Dashboard";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAppliedTitle
            // 
            this.lblAppliedTitle.AutoSize = true;
            this.lblAppliedTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAppliedTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblAppliedTitle.Location = new System.Drawing.Point(20, 100);
            this.lblAppliedTitle.Text = "✅ My Applications";
            // 
            // lstApplied
            // 
            this.lstApplied.BackColor = System.Drawing.Color.FromArgb(30, 40, 50);
            this.lstApplied.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstApplied.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstApplied.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstApplied.FormattingEnabled = true;
            this.lstApplied.ItemHeight = 20;
            this.lstApplied.Location = new System.Drawing.Point(25, 140);
            this.lstApplied.Size = new System.Drawing.Size(250, 800);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(300, 0);
            this.panelHeader.Size = new System.Drawing.Size(1624, 100);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.Location = new System.Drawing.Point(40, 30);
            this.lblTitle.Text = "Upcoming Opportunities";
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(300, 100);
            this.flowPanel.Padding = new System.Windows.Forms.Padding(50);
            this.flowPanel.Size = new System.Drawing.Size(1624, 950);
            // 
            // OpportunitiesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; // FULL SCREEN
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Opportunities";
            this.Load += new System.EventHandler(this.OpportunitiesPage_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Label lblAppliedTitle;
        private System.Windows.Forms.ListBox lstApplied;
    }
}