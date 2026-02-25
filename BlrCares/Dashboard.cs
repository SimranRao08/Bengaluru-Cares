using BlrCares;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace BengaluruCares
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            // Restore session data ⭐
            if (Session.ProfileImage != null)
            {
                picProfile.Image = Session.ProfileImage;
                picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (Session.UserName != null)
                lblUserName.Text = Session.UserName;

            if (Session.UserRole != null)
                lblUserRole.Text = Session.UserRole;

            lblUserName.ForeColor = Color.White;
            lblUserRole.ForeColor = Color.Silver;

            SetupRoundedProfile();
            SetupButtonHoverEffects();

            picProfile.Resize += (s, e) => SetupRoundedProfile();
        }

        // ---------------- PROFILE FIX ----------------

        private void SetupRoundedProfile()
        {
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            // StretchImage ensures it fills the circle properly

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picProfile.Width, picProfile.Height);
            picProfile.Region = new Region(path);
        }

        public void SetProfilePicture(Image? img)
        {
            if (img == null) return;

            const int ExifOrientationId = 0x0112;

            if (Array.Exists(img.PropertyIdList, id => id == ExifOrientationId))
            {
                PropertyItem prop = img.GetPropertyItem(ExifOrientationId);
                int orientationValue = BitConverter.ToUInt16(prop.Value, 0);

                switch (orientationValue)
                {
                    case 3:
                        img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        break;
                    case 6:
                        img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        break;
                    case 8:
                        img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        break;
                }
            }

            Session.ProfileImage = img;   // ⭐ SAVE IT

            picProfile.Image = img;
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;

            SetupRoundedProfile();
        }

        // ---------------- USER INFO ----------------

        public void SetUserName(string? name)
        {
            lblUserName.Text = name ?? "User";
            lblUserName.ForeColor = Color.White;
        }

        // ---------------- BUTTON EFFECTS ----------------

        private void SetupButtonHoverEffects()
        {
            Button[] cards = { btnFindOpp, btnVolGuide, btnRewards };

            foreach (Button btn in cards)
            {
                btn.MouseEnter += (s, e) =>
                {
                    btn.BackColor = Color.FromArgb(236, 240, 241);
                    btn.Cursor = Cursors.Hand;
                };

                btn.MouseLeave += (s, e) =>
                {
                    btn.BackColor = Color.White;
                };
            }
        }

        // ---------------- NAVIGATION ----------------

        //private void btnLogout_Click(object sender, EventArgs e)
        //{
        //    LoginPage login = new LoginPage();
        //    login.Show();
        //    this.Close();
        //}

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear session data
            Session.ProfileImage = null;
            Session.UserName = null;
            Session.UserRole = null;

            // Open Landing Page
            landing land = new landing();
            land.Show();

            // Close Dashboard
            this.Close();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            CalculatePage calcPage = new CalculatePage();
            calcPage.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            LogEvent vmsPage = new LogEvent();
            vmsPage.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsPage settings = new SettingsPage(this);
            settings.ShowDialog();
        }

        private void btnRewards_Click(object sender, EventArgs e)
        {
            RewardsPage rp = new RewardsPage();
            rp.Show();
        }

        private void btnFindOpp_Click(object sender, EventArgs e)
        {
            OpportunitiesPage op = new OpportunitiesPage();
            op.Show();
        }

        private void btnVolGuide_Click(object sender, EventArgs e)
        {
            GuidePage gp = new GuidePage();
            gp.Show();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
        }
    }
}