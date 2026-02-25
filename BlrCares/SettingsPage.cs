using BengaluruCares;
using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace BlrCares
{
    public partial class SettingsPage : Form
    {
        private Image? _selectedImage;
        private Dashboard _parentDashboard;

        public SettingsPage(Dashboard parent)
        {
            InitializeComponent();
            _parentDashboard = parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Profile Picture";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedImage = Image.FromFile(ofd.FileName);

                    // ---- FIX EXIF ROTATION ----
                    const int ExifOrientationId = 0x0112;

                    if (Array.Exists(_selectedImage.PropertyIdList, id => id == ExifOrientationId))
                    {
                        PropertyItem prop = _selectedImage.GetPropertyItem(ExifOrientationId);
                        int orientationValue = BitConverter.ToUInt16(prop.Value, 0);

                        switch (orientationValue)
                        {
                            case 3:
                                _selectedImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                                break;
                            case 6:
                                _selectedImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                break;
                            case 8:
                                _selectedImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                break;
                        }
                    }

                    // ---- SHOW PREVIEW ----
                    picPreview.Image = _selectedImage;
                    picPreview.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewName.Text))
                _parentDashboard.SetUserName(txtNewName.Text);

            if (_selectedImage != null)
                _parentDashboard.SetProfilePicture(_selectedImage);

            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        // SettingsPage.cs
        //private void LoadUserProfile()
        //{
        //    using (SqlConnection con = new SqlConnection(AppSecrets.ConnString))
        //    {
        //        con.Open();
        //        string query = "SELECT Username, Mobile, PinCode FROM Users WHERE Email = @email";
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        cmd.Parameters.AddWithValue("@email", Session.UserEmail);

        //        SqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            txtUsername.Text = reader["Username"].ToString();
        //            txtMobile.Text = reader["Mobile"].ToString();
        //            txtPin.Text = reader["PinCode"].ToString();
        //        }
        //    }
        //}

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click_1(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}