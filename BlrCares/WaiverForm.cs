using System;
using System.Drawing; // Core graphics
using System.Drawing.Imaging; // For saving JPG
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // For Database connection

namespace BlrCares
{
    public partial class WaiverForm : Form
    {
        // Drawing Variables
        Point lastPoint = Point.Empty;
        bool isMouseDown = false;
        bool hasSigned = false;

        // CRITICAL: The Bitmap that holds the signature in memory
        private Bitmap signatureBitmap;

        // Data for Receipt
        private string _receiptText;

        // Database Variables
        private int _logID;
        string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BengaluruCaresDB;Integrated Security=True";

        // Constructor with Data
        public WaiverForm(int logID, string name, string eventName, string date, decimal hours)
        {
            InitializeComponent();
            _logID = logID; // Save ID for the update later
            InitializeSignaturePad(); // Setup the drawing area
            GenerateReceiptText(name, eventName, date, hours);
        }

        public WaiverForm()
        {
            InitializeComponent();
            InitializeSignaturePad();
        }

        // 1. SETUP: Create a blank white image for the signature
        private void InitializeSignaturePad()
        {
            signatureBitmap = new Bitmap(picSignature.Width, picSignature.Height);
            using (Graphics g = Graphics.FromImage(signatureBitmap))
            {
                g.Clear(Color.White);
            }
            picSignature.Image = signatureBitmap;
        }

        private void GenerateReceiptText(string name, string eventName, string date, decimal hours)
        {
            decimal hourlyRate = 300;
            decimal totalAmount = hours * hourlyRate;

            _receiptText = $"--- BENGALURU CARES OFFICIAL RECEIPT ---\n\n" +
                           $"Date: {DateTime.Now.ToShortDateString()}\n" +
                           $"Receipt No: {new Random().Next(1000, 9999)}\n\n" +
                           $"Volunteer: {name}\n" +
                           $"Event: {eventName}\n" +
                           $"Work Date: {date}\n" +
                           $"Hours Logged: {hours}\n" +
                           $"Honorarium: ₹{totalAmount:N0}\n\n" +
                           $"Declaration:\nI hereby acknowledge receipt of the payment and\nconfirm that I have followed all safety guidelines\nduring the event.";

            rtbNotes.Text = _receiptText;
            tabControl1.SelectedIndex = 1; // Switch to Sign tab
        }

        // 2. DRAWING LOGIC
        private void picSignature_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMouseDown = true;
            hasSigned = true;
        }

        private void picSignature_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && lastPoint != Point.Empty)
            {
                using (Graphics g = Graphics.FromImage(signatureBitmap))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    using (Pen p = new Pen(Color.Black, 3))
                    {
                        g.DrawLine(p, lastPoint, e.Location);
                    }
                }
                picSignature.Invalidate();
                lastPoint = e.Location;
            }
        }

        private void picSignature_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            lastPoint = Point.Empty;
        }

        private void btnClearSign_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(signatureBitmap))
            {
                g.Clear(Color.White);
            }
            picSignature.Invalidate();
            hasSigned = false;
        }

        // 3. SAVING LOGIC (With DB Update)
        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            if (!hasSigned)
            {
                MessageBox.Show("Signature Required!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPG Image|*.jpg";
            sfd.FileName = $"Receipt_{_logID}.jpg";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // A. Create the Final Image
                    int width = 500; int height = 900;
                    Bitmap finalReceipt = new Bitmap(width, height);
                    using (Graphics g = Graphics.FromImage(finalReceipt))
                    {
                        g.Clear(Color.White);
                        g.DrawString("BENGALURU CARES", new Font("Arial", 16, FontStyle.Bold), Brushes.DarkGreen, new PointF(130, 20));
                        g.DrawString(_receiptText, new Font("Consolas", 12), Brushes.Black, new RectangleF(20, 70, width - 40, 600));
                        g.DrawImage(signatureBitmap, new Point(20, 670));
                    }
                    finalReceipt.Save(sfd.FileName, ImageFormat.Jpeg);

                    // B. Update Database Status to 'Done'
                    UpdateReceiptStatus();

                    MessageBox.Show("Receipt Saved! Status Updated to 'Done'.");

                    // C. Close Form successfully
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // 4. DATABASE UPDATE METHOD
        private void UpdateReceiptStatus()
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                string query = "UPDATE VolunteerLog SET ReceiptStatus='Done' WHERE LogID=@id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", _logID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}