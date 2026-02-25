namespace BengaluruCares
{
    partial class RewardsPage
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblNextGoal = new System.Windows.Forms.Label();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblBadgeIcon = new System.Windows.Forms.Label();
            this.btnClaim = new System.Windows.Forms.Button();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.DimGray;
            this.btnBack.Location = new System.Drawing.Point(30, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(150, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(296, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Volunteer Milestones";
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.btnClaim);
            this.panelCard.Controls.Add(this.lblNextGoal);
            this.panelCard.Controls.Add(this.progBar);
            this.panelCard.Controls.Add(this.lblHours);
            this.panelCard.Controls.Add(this.lblRank);
            this.panelCard.Controls.Add(this.lblBadgeIcon);
            this.panelCard.Location = new System.Drawing.Point(157, 100);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(500, 400);
            this.panelCard.TabIndex = 2;
            // 
            // lblNextGoal
            // 
            this.lblNextGoal.AutoSize = true;
            this.lblNextGoal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNextGoal.ForeColor = System.Drawing.Color.Gray;
            this.lblNextGoal.Location = new System.Drawing.Point(50, 280);
            this.lblNextGoal.Name = "lblNextGoal";
            this.lblNextGoal.Size = new System.Drawing.Size(186, 19);
            this.lblNextGoal.TabIndex = 4;
            this.lblNextGoal.Text = "5 more hours to reach Gold!";
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(50, 250);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(400, 23);
            this.progBar.TabIndex = 3;
            this.progBar.Value = 40;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblHours.ForeColor = System.Drawing.Color.DimGray;
            this.lblHours.Location = new System.Drawing.Point(180, 200);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(136, 21);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Total Hours: 0 Hrs";
            // 
            // lblRank
            // 
            this.lblRank.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblRank.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblRank.Location = new System.Drawing.Point(0, 150);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(500, 40);
            this.lblRank.TabIndex = 1;
            this.lblRank.Text = "Bronze Helper";
            this.lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBadgeIcon
            // 
            this.lblBadgeIcon.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.lblBadgeIcon.Location = new System.Drawing.Point(0, 30);
            this.lblBadgeIcon.Name = "lblBadgeIcon";
            this.lblBadgeIcon.Size = new System.Drawing.Size(500, 100);
            this.lblBadgeIcon.TabIndex = 0;
            this.lblBadgeIcon.Text = "🌱";
            this.lblBadgeIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClaim
            // 
            this.btnClaim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnClaim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClaim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClaim.ForeColor = System.Drawing.Color.White;
            this.btnClaim.Location = new System.Drawing.Point(50, 330);
            this.btnClaim.Name = "btnClaim";
            this.btnClaim.Size = new System.Drawing.Size(400, 50);
            this.btnClaim.TabIndex = 5;
            this.btnClaim.Text = "🎁 Claim Reward Coupon";
            this.btnClaim.UseVisualStyleBackColor = false;
            this.btnClaim.Visible = false;
            this.btnClaim.Click += new System.EventHandler(this.btnClaim_Click);
            // 
            // RewardsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "RewardsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Rewards";
            this.Load += new System.EventHandler(this.RewardsPage_Load);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblBadgeIcon;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Label lblNextGoal;
        private System.Windows.Forms.Button btnClaim;
    }
}