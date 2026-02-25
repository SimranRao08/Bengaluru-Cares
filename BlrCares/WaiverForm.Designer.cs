namespace BlrCares
{
    partial class WaiverForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNotepad = new System.Windows.Forms.TabPage();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lblNoteTitle = new System.Windows.Forms.Label();
            this.tabSignature = new System.Windows.Forms.TabPage();
            this.btnSaveNote = new System.Windows.Forms.Button();
            this.btnClearSign = new System.Windows.Forms.Button();
            this.picSignature = new System.Windows.Forms.PictureBox();
            this.lblSignTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabNotepad.SuspendLayout();
            this.tabSignature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSignature)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNotepad);
            this.tabControl1.Controls.Add(this.tabSignature);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // tabNotepad
            // 
            this.tabNotepad.Controls.Add(this.rtbNotes);
            this.tabNotepad.Controls.Add(this.lblNoteTitle);
            this.tabNotepad.Location = new System.Drawing.Point(4, 24);
            this.tabNotepad.Name = "tabNotepad";
            this.tabNotepad.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotepad.Size = new System.Drawing.Size(492, 572);
            this.tabNotepad.TabIndex = 0;
            this.tabNotepad.Text = "Review Receipt";
            this.tabNotepad.UseVisualStyleBackColor = true;
            // 
            // rtbNotes
            // 
            this.rtbNotes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNotes.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbNotes.Location = new System.Drawing.Point(20, 50);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.ReadOnly = true;
            this.rtbNotes.Size = new System.Drawing.Size(450, 480);
            this.rtbNotes.TabIndex = 1;
            this.rtbNotes.Text = "";
            // 
            // lblNoteTitle
            // 
            this.lblNoteTitle.AutoSize = true;
            this.lblNoteTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoteTitle.Location = new System.Drawing.Point(20, 15);
            this.lblNoteTitle.Name = "lblNoteTitle";
            this.lblNoteTitle.Size = new System.Drawing.Size(127, 21);
            this.lblNoteTitle.TabIndex = 0;
            this.lblNoteTitle.Text = "Receipt Details";
            // 
            // tabSignature
            // 
            this.tabSignature.Controls.Add(this.btnSaveNote);
            this.tabSignature.Controls.Add(this.btnClearSign);
            this.tabSignature.Controls.Add(this.picSignature);
            this.tabSignature.Controls.Add(this.lblSignTitle);
            this.tabSignature.Location = new System.Drawing.Point(4, 24);
            this.tabSignature.Name = "tabSignature";
            this.tabSignature.Padding = new System.Windows.Forms.Padding(3);
            this.tabSignature.Size = new System.Drawing.Size(492, 572);
            this.tabSignature.TabIndex = 1;
            this.tabSignature.Text = "Sign & Save";
            this.tabSignature.UseVisualStyleBackColor = true;
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSaveNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNote.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveNote.ForeColor = System.Drawing.Color.White;
            this.btnSaveNote.Location = new System.Drawing.Point(20, 450);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(450, 45);
            this.btnSaveNote.TabIndex = 3;
            this.btnSaveNote.Text = "✔ Validate & Download Receipt";
            this.btnSaveNote.UseVisualStyleBackColor = false;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // btnClearSign
            // 
            this.btnClearSign.BackColor = System.Drawing.Color.IndianRed;
            this.btnClearSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearSign.ForeColor = System.Drawing.Color.White;
            this.btnClearSign.Location = new System.Drawing.Point(350, 20);
            this.btnClearSign.Name = "btnClearSign";
            this.btnClearSign.Size = new System.Drawing.Size(120, 30);
            this.btnClearSign.TabIndex = 2;
            this.btnClearSign.Text = "Clear Signature";
            this.btnClearSign.UseVisualStyleBackColor = false;
            this.btnClearSign.Click += new System.EventHandler(this.btnClearSign_Click);
            // 
            // picSignature
            // 
            this.picSignature.BackColor = System.Drawing.Color.White;
            this.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSignature.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picSignature.Location = new System.Drawing.Point(20, 60);
            this.picSignature.Name = "picSignature";
            this.picSignature.Size = new System.Drawing.Size(450, 350);
            this.picSignature.TabIndex = 1;
            this.picSignature.TabStop = false;
            this.picSignature.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picSignature_MouseDown);
            this.picSignature.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picSignature_MouseMove);
            this.picSignature.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picSignature_MouseUp);
            // 
            // lblSignTitle
            // 
            this.lblSignTitle.AutoSize = true;
            this.lblSignTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSignTitle.Location = new System.Drawing.Point(20, 25);
            this.lblSignTitle.Name = "lblSignTitle";
            this.lblSignTitle.Size = new System.Drawing.Size(176, 20);
            this.lblSignTitle.TabIndex = 0;
            this.lblSignTitle.Text = "Digital Signature Box ✍";
            // 
            // WaiverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.tabControl1);
            this.Name = "WaiverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bengaluru Cares: Receipt Generator";
            this.tabControl1.ResumeLayout(false);
            this.tabNotepad.ResumeLayout(false);
            this.tabNotepad.PerformLayout();
            this.tabSignature.ResumeLayout(false);
            this.tabSignature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSignature)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNotepad;
        private System.Windows.Forms.TabPage tabSignature;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label lblNoteTitle;
        private System.Windows.Forms.Label lblSignTitle;
        private System.Windows.Forms.PictureBox picSignature;
        private System.Windows.Forms.Button btnClearSign;
        private System.Windows.Forms.Button btnSaveNote;
    }
}