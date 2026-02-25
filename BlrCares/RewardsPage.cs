using BlrCares;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BengaluruCares
{
    public partial class RewardsPage : Form
    {
        string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BengaluruCaresDB;Integrated Security=True";

        public RewardsPage()
        {
            InitializeComponent();
        }

        private void RewardsPage_Load(object sender, EventArgs e)
        {
            CalculateRank();
        }

        private void CalculateRank()
        {
            decimal totalHours = 0;

            // 1. Get Hours from Database
            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    // SUM all hours in the table
                    string query = "SELECT SUM(HoursWorked) FROM VolunteerLog";
                    SqlCommand cmd = new SqlCommand(query, con);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalHours = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching hours: " + ex.Message);
            }

            // 2. Update UI based on Logic
            lblHours.Text = $"Total Hours Contributed: {totalHours}";

            if (totalHours < 10)
            {
                // LEVEL 1: BRONZE
                lblBadgeIcon.Text = "🌱";
                lblRank.Text = "Novice Volunteer";
                lblRank.ForeColor = Color.Green;

                progBar.Maximum = 10;
                progBar.Value = (int)totalHours;
                lblNextGoal.Text = $"{10 - totalHours} hours to reach Silver!";
            }
            else if (totalHours >= 10 && totalHours < 50)
            {
                // LEVEL 2: SILVER
                lblBadgeIcon.Text = "🥈";
                lblRank.Text = "Silver Samaritan";
                lblRank.ForeColor = Color.SlateGray;

                progBar.Maximum = 50;
                progBar.Value = (int)totalHours;
                lblNextGoal.Text = $"{50 - totalHours} hours to reach Gold!";

                // Bonus: Unlock a button
                btnClaim.Visible = true;
                btnClaim.Text = "🎁 Claim Silver Badge Reward";
            }
            else
            {
                // LEVEL 3: GOLD
                lblBadgeIcon.Text = "🏆";
                lblRank.Text = "Gold Guardian";
                lblRank.ForeColor = Color.Gold;

                progBar.Maximum = 100;
                progBar.Value = 100;
                lblNextGoal.Text = "Maximum Rank Achieved! You are a hero!";

                btnClaim.Visible = true;
                btnClaim.Text = "🎁 Claim Gold Gift Hamper";
            }
        }

        private void btnClaim_Click(object sender, EventArgs e)
        {
            CertificatePage certPage = new CertificatePage();
            certPage.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Assuming you want to go back to Dashboard
            // (If you opened this from Dashboard)
        }
    }
}