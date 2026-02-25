namespace BlrCares
{
    partial class GuidePage
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Code of Conduct");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Safety Protocols");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Emergency Contacts");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("General Info", new System.Windows.Forms.TreeNode[] { treeNode1, treeNode2, treeNode3 });
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("How to log hours");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Claiming Rewards");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("App Tutorials", new System.Windows.Forms.TreeNode[] { treeNode5, treeNode6 });

            this.panelSidebar = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.lblContentTitle = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(30, 40, 50);
            this.panelSidebar.Controls.Add(this.treeView1);
            this.panelSidebar.Controls.Add(this.lblMenuTitle);
            this.panelSidebar.Controls.Add(this.btnBack);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Size = new System.Drawing.Size(400, 1050);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 30);
            this.btnBack.Size = new System.Drawing.Size(400, 50);
            this.btnBack.Text = "← Back to Dashboard";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblMenuTitle.Location = new System.Drawing.Point(25, 120);
            this.lblMenuTitle.Text = "HELP TOPICS";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(30, 40, 50);
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Indent = 30;
            this.treeView1.ItemHeight = 40;
            this.treeView1.Location = new System.Drawing.Point(20, 160);
            this.treeView1.Size = new System.Drawing.Size(360, 800);
            treeNode1.Name = "NodeCode"; treeNode1.Text = "Code of Conduct";
            treeNode2.Name = "NodeSafety"; treeNode2.Text = "Safety Protocols";
            treeNode3.Name = "NodeEmergency"; treeNode3.Text = "Emergency Contacts";
            treeNode4.Name = "NodeGeneral"; treeNode4.Text = "General Info";
            treeNode5.Name = "NodeLog"; treeNode5.Text = "How to log hours";
            treeNode6.Name = "NodeRewards"; treeNode6.Text = "Claiming Rewards";
            treeNode7.Name = "NodeApp"; treeNode7.Text = "App Tutorials";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode4, treeNode7 });
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.panelContent.Controls.Add(this.pnlCard);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(400, 0);
            this.panelContent.Size = new System.Drawing.Size(1524, 1050);
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lblContentTitle);
            this.pnlCard.Controls.Add(this.rtbContent);
            this.pnlCard.Location = new System.Drawing.Point(100, 100);
            this.pnlCard.Size = new System.Drawing.Size(1300, 800);
            // 
            // lblContentTitle
            // 
            this.lblContentTitle.AutoSize = true;
            this.lblContentTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblContentTitle.ForeColor = System.Drawing.Color.FromArgb(26, 188, 156);
            this.lblContentTitle.Location = new System.Drawing.Point(50, 50);
            this.lblContentTitle.Text = "Welcome Volunteer";
            // 
            // rtbContent
            // 
            this.rtbContent.BackColor = System.Drawing.Color.White;
            this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContent.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.rtbContent.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.rtbContent.Location = new System.Drawing.Point(60, 150);
            this.rtbContent.Size = new System.Drawing.Size(1100, 600);
            this.rtbContent.Text = "Select a topic from the left menu to view details.";
            // 
            // GuidePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volunteer Guide";
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblContentTitle;
        private System.Windows.Forms.RichTextBox rtbContent;
    }
}