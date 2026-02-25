using BlrCares;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BengaluruCares
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            SetupRoundedProfile();
            SetupButtonHoverEffects();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Signup login = new Signup();
            login.Show();
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


        private void SetupRoundedProfile()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, picProfile.Width, picProfile.Height);
            picProfile.Region = new Region(path);
        }
        private void SetupButtonHoverEffects()
        {
            Button[] cards = { btnFindOpp, btnVolGuide, btnRewards };

            foreach (Button btn in cards)
            {
                btn.MouseEnter += (s, e) =>
                {
                    btn.BackColor = Color.FromArgb(236, 240, 241); // Light gray hover
                    btn.Cursor = Cursors.Hand;
                };
                btn.MouseLeave += (s, e) =>
                {
                    btn.BackColor = Color.White;
                };
            }
        }

        private void btnRewards_Click(object sender, EventArgs e)
        {
            RewardsPage rp = new RewardsPage();
            rp.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

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
    }
}