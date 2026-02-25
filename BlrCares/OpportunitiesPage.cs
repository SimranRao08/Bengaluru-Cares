using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BlrCares
{
    public partial class OpportunitiesPage : Form
    {
        string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BengaluruCaresDB;Integrated Security=True";

        public OpportunitiesPage()
        {
            InitializeComponent();
        }

        // Inside OpportunitiesPage.cs
        private void OpportunitiesPage_Load(object sender, EventArgs e)
        {
            LoadEventsFromDatabase();
            LoadAppliedEvents();
        }

        private void LoadEventsFromDatabase()
        {
            flowPanel.Controls.Clear(); // Clear existing cards
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                string query = "SELECT Title, EventDate, Description FROM Events WHERE Status = 'ACTIVE'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CreateCard(
                        reader["Title"].ToString(),
                        "Bengaluru", // Location could be added to table later
                        Convert.ToDateTime(reader["EventDate"]).ToShortDateString(),
                        0,
                        reader["Description"].ToString()
                    );
                }
            }
        }

        private void LoadAppliedEvents()
        {
            lstApplied.Items.Clear();
            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    string query = "SELECT EventName FROM VolunteerLog WHERE ReceiptStatus = 'Upcoming'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lstApplied.Items.Add("• " + reader["EventName"].ToString());
                    }
                }
            }
            catch { }
        }

        private void CreateCard(string title, string location, string date, int hours, string desc)
        {
            Panel card = new Panel { Size = new Size(400, 250), BackColor = Color.White, Margin = new Padding(20) };

            Label lblTitle = new Label { Text = title, Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.Teal, Location = new Point(20, 20), AutoSize = true };
            Label lblMeta = new Label { Text = $"📅 {date}", Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Color.Gray, Location = new Point(20, 55), AutoSize = true };
            Label lblDesc = new Label { Text = desc, Font = new Font("Segoe UI", 10), Location = new Point(20, 85), Size = new Size(360, 60) };

            Button btnApply = new Button { Text = "Apply Now", BackColor = Color.FromArgb(44, 62, 80), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Size = new Size(150, 40), Location = new Point(20, 180) };

            btnApply.Tag = new { Title = title, Date = date };
            btnApply.Click += (s, e) => ApplyForEvent(s);

            card.Controls.Add(lblTitle); card.Controls.Add(lblMeta); card.Controls.Add(lblDesc); card.Controls.Add(btnApply);
            flowPanel.Controls.Add(card);
        }

        private void ApplyForEvent(object sender)
        {
            Button btn = (Button)sender;
            dynamic data = btn.Tag;

            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    // SAVE AS UPCOMING (0 Hours)
                    string query = "INSERT INTO VolunteerLog (VolunteerName, EventName, DateWorked, HoursWorked, ReceiptStatus) VALUES (@name, @evt, @date, 0, 'Upcoming')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", "Simran");
                    cmd.Parameters.AddWithValue("@evt", data.Title);
                    cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(data.Date));
                    cmd.ExecuteNonQuery();

                    btn.Text = "Applied ✔"; btn.Enabled = false; btn.BackColor = Color.Gray;
                    lstApplied.Items.Add("• " + data.Title);
                    MessageBox.Show("Applied! Check 'History' to log hours later.");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnBack_Click(object sender, EventArgs e) { this.Close(); }
    }
}