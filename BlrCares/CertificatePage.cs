using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace BlrCares
{
    public partial class CertificatePage : Form
    {
        public CertificatePage()
        {
            InitializeComponent();
        }

        // 1. GENERATE TEMPLATE (Resets the text with a nice format)
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();

            // A. Title
            rtbEditor.SelectionAlignment = HorizontalAlignment.Center;
            rtbEditor.SelectionFont = new Font("Segoe UI", 36, FontStyle.Bold);
            rtbEditor.SelectionColor = Color.DarkBlue;
            rtbEditor.AppendText("\nCERTIFICATE OF APPRECIATION\n\n");

            // B. Subtitle
            rtbEditor.SelectionFont = new Font("Segoe UI", 14, FontStyle.Regular);
            rtbEditor.SelectionColor = Color.Gray;
            rtbEditor.AppendText("This certificate is proudly presented to\n\n");

            // C. Place to Insert Photo
            rtbEditor.SelectionFont = new Font("Segoe UI", 10, FontStyle.Italic);
            rtbEditor.SelectionColor = Color.Red;
            rtbEditor.AppendText("[ Click here and press 'Insert Photo' ]\n\n");

            // D. Name
            rtbEditor.SelectionFont = new Font("Segoe UI", 28, FontStyle.Bold | FontStyle.Italic);
            rtbEditor.SelectionColor = Color.Black;
            rtbEditor.AppendText("VOLUNTEER NAME\n\n");

            // E. Footer
            rtbEditor.SelectionFont = new Font("Segoe UI", 14, FontStyle.Regular);
            rtbEditor.SelectionColor = Color.Gray;
            rtbEditor.AppendText("For outstanding service at Bengaluru Cares.\n\n\n");

            // F. Signature Area
            rtbEditor.SelectionFont = new Font("Segoe UI", 12, FontStyle.Regular);
            rtbEditor.SelectionColor = Color.Black;
            rtbEditor.AppendText("_________________________\nAuthorized Signature\n");

            // G. Date
            rtbEditor.AppendText("\nDate: " + DateTime.Now.ToShortDateString());
        }

        // 2. INSERT PHOTO AT CURSOR POSITION
        private void btnInsertPhoto_Click(object sender, EventArgs e)
        {
            InsertImageToRichTextBox();
        }

        private void btnInsertSign_Click(object sender, EventArgs e)
        {
            InsertImageToRichTextBox();
        }

        private void InsertImageToRichTextBox()
        {
            openFileDialog1.Filter = "Images|*.jpg;*.png;*.jpeg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image img = Image.FromFile(openFileDialog1.FileName);

                    // Copy to clipboard
                    Clipboard.SetImage(img);

                    // Paste at current cursor position
                    rtbEditor.Paste();

                    // Clear clipboard to save memory
                    Clipboard.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting image: " + ex.Message);
                }
            }
        }

        // 3. TEXT EDITOR TOOLS (Font, Color)
        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (rtbEditor.SelectionLength > 0)
                    rtbEditor.SelectionFont = fontDialog1.Font;
                else
                    rtbEditor.Font = fontDialog1.Font;
            }
        }

        private void btnTextColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                rtbEditor.SelectionColor = colorDialog1.Color;
        }

        private void btnBgColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                rtbEditor.BackColor = colorDialog1.Color;
        }

        // 4. SAVE AS IMAGE (Requirement met!)
        private void btnSaveImg_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG Image|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Create a Bitmap from the RichTextBox
                    Bitmap bmp = new Bitmap(rtbEditor.Width, rtbEditor.Height);

                    // Draw the RichTextBox onto the bitmap
                    rtbEditor.DrawToBitmap(bmp, new Rectangle(0, 0, rtbEditor.Width, rtbEditor.Height));

                    // Save
                    bmp.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                    MessageBox.Show("Certificate Saved as Image!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}