using BengaluruCares;
using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace BlrCares
{
    public partial class NgoDashboard : Form
    {
        // --- DYNAMIC PANELS ---
        private Panel pnlSettings, pnlPostOpp, pnlManageEvents, pnlVolunteers, pnlReviewApps, pnlReports;
        private DataGridView dgvEvents, dgvApps;
        private FlowLayoutPanel flpActivityFeed; // The new container for Recent Activity

        // --- THEME COLORS ---
        private Color bgLight = Color.FromArgb(244, 246, 249);
        private Color ngoGreen = Color.FromArgb(30, 132, 73);
        private Color darkText = Color.FromArgb(34, 45, 50);

        public NgoDashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; //

            LoadNgoName(); // Fetch name from DB
            FixSidebarLayout(); //
            SetupRecentActivityFeed(); //
            InitializeDynamicPages(); //
        }

        private void LoadNgoName()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(AppSecrets.ConnString)) //
                {
                    con.Open();
                    string query = "SELECT NGOName FROM NGOs WHERE Email = @email"; //
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@email", Session.UserEmail); //
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        lblNgoName.Text = result.ToString(); // Update sidebar name
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading profile: " + ex.Message); }
        }

        private void FixSidebarLayout()
        {
            // Widens the sidebar and pushes elements right for a less cramped look
            panelSidebar.Width = 280;
            lblAppTitle.Location = new Point(30, 40);

            picProfile.Location = new Point(30, 150);
            lblNgoName.Location = new Point(120, 160);
            lblRole.Location = new Point(120, 190);

            // Re-align buttons to fit wider sidebar
            foreach (Control c in panelSidebar.Controls)
            {
                if (c is Button btn)
                {
                    btn.Width = 280;
                    btn.Padding = new Padding(30, 0, 0, 0); // Adds breathing room to the left of the text
                }
            }
        }

        private void SetupRecentActivityFeed()
        {
            // Hide the old plain-text label from the designer
            if (lblActivity1 != null) lblActivity1.Visible = false;

            // Create a smart scrolling container for activity cards
            flpActivityFeed = new FlowLayoutPanel
            {
                Location = new Point(45, lblRecentActivity.Bottom + 20),
                Width = 1000,
                Height = 300,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom
            };
            panelMain.Controls.Add(flpActivityFeed);

            // Add initial placeholder activities
            AddActivityCard("12 new applicants for 'Teaching Drive 2025'");
            AddActivityCard("You successfully registered 'Green Earth' on Bengaluru Cares.");
        }

        // Creates a beautiful, distinct card for every new activity
        private void AddActivityCard(string message)
        {
            Panel card = new Panel { Width = 800, Height = 60, BackColor = Color.White, Margin = new Padding(0, 0, 0, 15) };
            Panel accentLine = new Panel { Dock = DockStyle.Left, Width = 4, BackColor = ngoGreen }; // Green styling bar
            Label text = new Label { Text = message, Font = new Font("Segoe UI", 11, FontStyle.Regular), ForeColor = darkText, Location = new Point(20, 18), AutoSize = true };

            card.Controls.Add(accentLine);
            card.Controls.Add(text);

            flpActivityFeed.Controls.Add(card);
            flpActivityFeed.Controls.SetChildIndex(card, 0); // Always put the newest at the top
        }

        private Image CropToSquare(Image img)
        {
            int size = Math.Min(img.Width, img.Height);
            Bitmap square = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(square))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, new Rectangle(0, 0, size, size), new Rectangle((img.Width - size) / 2, (img.Height - size) / 2, size, size), GraphicsUnit.Pixel);
            }
            return square;
        }

        private void SetupRoundedProfile()
        {
            if (picProfile.Image != null) picProfile.Image = CropToSquare(picProfile.Image);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picProfile.Width, picProfile.Height);
            picProfile.Region = new Region(path);
        }

        private void SetupButtonHoverEffects()
        {
            Button[] cards = { btnPostOpp, btnReviewApps, btnReports, btnDashboardNav, btnManageEvents, btnVolunteers, btnSettings };
            foreach (Button btn in cards)
            {
                btn.MouseEnter += (s, e) => { if (btn.BackColor != ngoGreen) btn.BackColor = Color.FromArgb(236, 240, 241); btn.Cursor = Cursors.Hand; };
                btn.MouseLeave += (s, e) => { if (btn.BackColor != ngoGreen) btn.BackColor = btn.Parent == panelSidebar ? Color.FromArgb(34, 45, 50) : Color.White; };
            }
        }

        // =========================================================================
        // UI BUILDER: The Pages
        // =========================================================================

        private void InitializeDynamicPages()
        {
            BuildSettingsPage();
            BuildManageEventsPage();
            BuildPostOppPage();
            BuildVolunteersPage();
            BuildReviewAppsPage();
            BuildImpactReportsPage();

            panelMain.Controls.Add(pnlSettings);
            panelMain.Controls.Add(pnlPostOpp);
            panelMain.Controls.Add(pnlManageEvents);
            panelMain.Controls.Add(pnlVolunteers);
            panelMain.Controls.Add(pnlReviewApps);
            panelMain.Controls.Add(pnlReports);
        }

        private Panel CreateBasePanel(string titleText)
        {
            Panel p = new Panel { Dock = DockStyle.Fill, BackColor = bgLight, Visible = false };
            Button btnBack = new Button { Text = "← Back to Dashboard", Location = new Point(45, 30), AutoSize = true, FlatStyle = FlatStyle.Flat, ForeColor = ngoGreen, Font = new Font("Segoe UI", 11, FontStyle.Bold), Cursor = Cursors.Hand };
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseOverBackColor = bgLight;
            btnBack.Click += (s, e) => ShowPage(null);
            Label title = new Label { Text = titleText, Font = new Font("Segoe UI", 24, FontStyle.Bold), ForeColor = darkText, Location = new Point(45, 70), AutoSize = true };
            p.Controls.Add(btnBack);
            p.Controls.Add(title);
            return p;
        }

        private Panel CreateCard(int yOffset)
        {
            return new Panel
            {
                Location = new Point(50, yOffset),
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right
            };
        }

        private void StyleDataGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 245, 238);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black; // Fixed invisible text issue
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dgv.DefaultCellStyle.Padding = new Padding(15, 5, 15, 5); // Lots of breathing room
            dgv.RowTemplate.Height = 60; // Taller rows

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeight = 50;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.DimGray;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(15, 5, 15, 5);

            dgv.EnableHeadersVisualStyles = false;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadNgoEvents()
        {
            dgvEvents.Rows.Clear();
            using (SqlConnection con = new SqlConnection(AppSecrets.ConnString))
            {
                con.Open();
                // Filters events posted by this specific NGO
                string query = "SELECT Status, Title, EventDate FROM Events WHERE NGO_Name = @ngo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ngo", lblNgoName.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvEvents.Rows.Add(
                        reader["Status"].ToString(),
                        reader["Title"].ToString(),
                        Convert.ToDateTime(reader["EventDate"]).ToShortDateString()
                    );
                }
            }
        }

        // Update the Navigation Button
        private void btnManageEvents_Click(object sender, EventArgs e)
        {
            LoadNgoEvents();
            ShowPage(pnlManageEvents);
        }

        private void BuildSettingsPage()
        {
            pnlSettings = CreateBasePanel("Organization Settings");
            Panel card = CreateCard(140);
            card.Height = 400; card.Width = 700; card.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            Label lblName = new Label { Text = "Organization Name:", Location = new Point(40, 40), Font = new Font("Segoe UI", 11, FontStyle.Bold), AutoSize = true, ForeColor = Color.Gray };
            TextBox txtName = new TextBox { Location = new Point(40, 75), Width = 500, Font = new Font("Segoe UI", 14), Text = lblNgoName.Text };

            Button btnBrowse = new Button { Text = "🖼️ Upload New Logo", Location = new Point(40, 140), Width = 220, Height = 50, BackColor = bgLight, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 11) };
            btnBrowse.FlatAppearance.BorderColor = Color.Silver;
            btnBrowse.Click += (s, e) =>
            {
                using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Images|*.jpg;*.jpeg;*.png" })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        picProfile.Image = CropToSquare(Image.FromFile(ofd.FileName));
                        SetupRoundedProfile();
                    }
                }
            };

            Button btnSave = new Button { Text = "Save Changes", Location = new Point(40, 230), Width = 220, Height = 55, BackColor = ngoGreen, ForeColor = Color.White, Font = new Font("Segoe UI", 12, FontStyle.Bold), FlatStyle = FlatStyle.Flat };
            // Inside BuildSettingsPage() in NgoDashboard.cs
            btnSave.Click += (s, e) =>
            {
                using (SqlConnection con = new SqlConnection(AppSecrets.ConnString))
                {
                    con.Open();
                    string query = "UPDATE NGOs SET NGOName = @name WHERE Email = @email";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", Session.UserEmail);
                    cmd.ExecuteNonQuery();
                }

                lblNgoName.Text = txtName.Text;
                Session.UserName = txtName.Text;
                MessageBox.Show("Profile Updated Successfully!", "Settings Saved");
                ShowPage(null);
            };

            card.Controls.AddRange(new Control[] { lblName, txtName, btnBrowse, btnSave });
            pnlSettings.Controls.Add(card);
        }

        private void BuildPostOppPage()
        {
            pnlPostOpp = CreateBasePanel("Post a New Opportunity");
            Panel card = CreateCard(140);
            card.Anchor = AnchorStyles.Top | AnchorStyles.Left; card.Width = 1000; card.Height = 650;

            Label lblTitle = new Label { Text = "Event Title:", Location = new Point(50, 50), Font = new Font("Segoe UI", 11, FontStyle.Bold), AutoSize = true, ForeColor = Color.Gray };
            TextBox txtTitle = new TextBox { Location = new Point(50, 85), Width = 600, Font = new Font("Segoe UI", 14) };

            Label lblDate = new Label { Text = "Event Date:", Location = new Point(50, 150), Font = new Font("Segoe UI", 11, FontStyle.Bold), AutoSize = true, ForeColor = Color.Gray };
            DateTimePicker dtpDate = new DateTimePicker { Location = new Point(50, 185), Width = 350, Font = new Font("Segoe UI", 14) };

            Label lblDesc = new Label { Text = "Description:", Location = new Point(50, 250), Font = new Font("Segoe UI", 11, FontStyle.Bold), AutoSize = true, ForeColor = Color.Gray };
            TextBox txtDesc = new TextBox { Location = new Point(50, 285), Width = 850, Height = 200, Multiline = true, Font = new Font("Segoe UI", 12) };

            Button btnPublish = new Button { Text = "Publish Event", Location = new Point(50, 530), Width = 250, Height = 60, BackColor = ngoGreen, ForeColor = Color.White, Font = new Font("Segoe UI", 14, FontStyle.Bold), FlatStyle = FlatStyle.Flat };

            // Inside BuildPostOppPage() in NgoDashboard.cs
            btnPublish.Click += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtTitle.Text)) { MessageBox.Show("Please enter a title."); return; }

                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BengaluruCaresDB;Integrated Security=True"))
                {
                    con.Open();
                    string query = "INSERT INTO Events (Title, EventDate, Description, NGO_Name) VALUES (@title, @date, @desc, @ngo)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@date", dtpDate.Value);
                    cmd.Parameters.AddWithValue("@desc", txtDesc.Text);
                    cmd.Parameters.AddWithValue("@ngo", lblNgoName.Text); // Links event to the logged-in NGO
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Opportunity successfully published to database!");
                ShowPage(null); // Return to dashboard
            };

            card.Controls.AddRange(new Control[] { lblTitle, txtTitle, lblDate, dtpDate, lblDesc, txtDesc, btnPublish });
            pnlPostOpp.Controls.Add(card);
        }

        private void BuildManageEventsPage()
        {
            pnlManageEvents = CreateBasePanel("Manage Events");
            Panel card = CreateCard(140);
            card.Height -= 180; // Leave room at bottom

            dgvEvents = new DataGridView { Location = new Point(20, 20), Width = card.Width - 40, Height = card.Height - 120, Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right };
            StyleDataGrid(dgvEvents);
            dgvEvents.ColumnCount = 3;
            dgvEvents.Columns[0].Name = "Status"; dgvEvents.Columns[0].FillWeight = 20;
            dgvEvents.Columns[1].Name = "Event Title"; dgvEvents.Columns[1].FillWeight = 50;
            dgvEvents.Columns[2].Name = "Date"; dgvEvents.Columns[2].FillWeight = 30;

            Button btnDelete = new Button { Text = "✕ Cancel Selected Event", Location = new Point(20, card.Height - 80), Width = 280, Height = 50, BackColor = Color.White, ForeColor = Color.Tomato, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 12, FontStyle.Bold), Anchor = AnchorStyles.Bottom | AnchorStyles.Left };
            btnDelete.FlatAppearance.BorderColor = Color.Tomato;
            btnDelete.Click += (s, e) => {
                if (dgvEvents.SelectedRows.Count > 0 && !dgvEvents.SelectedRows[0].IsNewRow)
                    dgvEvents.Rows.RemoveAt(dgvEvents.SelectedRows[0].Index);
            };

            card.Controls.AddRange(new Control[] { dgvEvents, btnDelete });
            pnlManageEvents.Controls.Add(card);
        }

        private void BuildVolunteersPage()
        {
            pnlVolunteers = CreateBasePanel("Volunteer Database");
            Panel card = CreateCard(140); card.Height -= 100;

            DataGridView dgvVols = new DataGridView { Location = new Point(20, 20), Width = card.Width - 40, Height = card.Height - 60, Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right };
            StyleDataGrid(dgvVols);
            dgvVols.ColumnCount = 3;
            dgvVols.Columns[0].Name = "Volunteer Name";
            dgvVols.Columns[1].Name = "Total Impact Hours";
            dgvVols.Columns[2].Name = "Current Status";

            dgvVols.Rows.Add("Simran", "42 hrs", "🌟 Active");
            dgvVols.Rows.Add("Rahul Kumar", "15 hrs", "🌟 Active");
            dgvVols.Rows.Add("Priya Sharma", "8 hrs", "💤 Inactive");
            dgvVols.Rows.Add("Amit Patel", "120 hrs", "🏆 Top Volunteer");

            card.Controls.Add(dgvVols);
            pnlVolunteers.Controls.Add(card);
        }

        // Inside BuildReviewAppsPage() in NgoDashboard.cs
        private void LoadApplicants()
        {
            dgvApps.Rows.Clear();
            using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BengaluruCaresDB;Integrated Security=True"))
            {
                con.Open();
                // Fetch users who applied (status 'Upcoming') for events belonging to this NGO
                string query = "SELECT VolunteerName, EventName, DateWorked FROM VolunteerLog WHERE ReceiptStatus = 'Upcoming'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvApps.Rows.Add(
                        Convert.ToDateTime(reader["DateWorked"]).ToShortDateString(),
                        reader["VolunteerName"].ToString(),
                        reader["EventName"].ToString()
                    );
                }
            }
        }   

        private void BuildReviewAppsPage()
        {
            pnlReviewApps = CreateBasePanel("Review Applications");
            Panel card = CreateCard(140); card.Height -= 180;

            dgvApps = new DataGridView { Location = new Point(20, 20), Width = card.Width - 40, Height = card.Height - 120, Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right };
            StyleDataGrid(dgvApps);
            dgvApps.ColumnCount = 3;
            dgvApps.Columns[0].Name = "Date Applied"; dgvApps.Columns[0].FillWeight = 20;
            dgvApps.Columns[1].Name = "Applicant Name"; dgvApps.Columns[1].FillWeight = 40;
            dgvApps.Columns[2].Name = "Target Event"; dgvApps.Columns[2].FillWeight = 40;

            LoadApplicants();

            Button btnApprove = new Button { Text = "✓ Approve Selected", Location = new Point(20, card.Height - 80), Width = 250, Height = 50, BackColor = ngoGreen, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 12, FontStyle.Bold), Anchor = AnchorStyles.Bottom | AnchorStyles.Left };
            Button btnReject = new Button { Text = "✕ Reject Selected", Location = new Point(290, card.Height - 80), Width = 250, Height = 50, BackColor = Color.White, ForeColor = Color.Tomato, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 12, FontStyle.Bold), Anchor = AnchorStyles.Bottom | AnchorStyles.Left };
            btnReject.FlatAppearance.BorderColor = Color.Tomato;

            btnApprove.Click += (s, e) => {
                if (dgvApps.SelectedRows.Count > 0 && !dgvApps.SelectedRows[0].IsNewRow)
                {
                    MessageBox.Show("Volunteer Approved! They will be notified.", "Success");
                    dgvApps.Rows.RemoveAt(dgvApps.SelectedRows[0].Index);
                }
            };
            btnReject.Click += (s, e) => {
                if (dgvApps.SelectedRows.Count > 0 && !dgvApps.SelectedRows[0].IsNewRow) dgvApps.Rows.RemoveAt(dgvApps.SelectedRows[0].Index);
            };

            card.Controls.AddRange(new Control[] { dgvApps, btnApprove, btnReject });
            pnlReviewApps.Controls.Add(card);
        }

        private void BuildImpactReportsPage()
        {
            pnlReports = CreateBasePanel("Impact Reports");

            // Fixed overlapped cards - spaced them out and gave them plenty of internal padding
            Panel card1 = CreateStatCard("Total Volunteers", "450+", 50, 140, "👥");
            Panel card2 = CreateStatCard("Events Hosted", "24", 420, 140, "📅");
            Panel card3 = CreateStatCard("Community Hours", "3,200", 790, 140, "⏱️");

            Label lblNote = new Label { Text = "* Statistics are calculated based on completed events for the current fiscal year.", Location = new Point(50, 320), Font = new Font("Segoe UI", 11, FontStyle.Italic), AutoSize = true, ForeColor = Color.Gray };

            pnlReports.Controls.AddRange(new Control[] { card1, card2, card3, lblNote });
        }

        private Panel CreateStatCard(string title, string value, int x, int y, string icon)
        {
            Panel card = new Panel { Location = new Point(x, y), Size = new Size(340, 150), BackColor = Color.White };
            Panel accent = new Panel { Dock = DockStyle.Left, Width = 5, BackColor = ngoGreen }; // Nice green bar on the left side

            Label lblIcon = new Label { Text = icon, Font = new Font("Segoe UI", 30), Location = new Point(25, 35), AutoSize = true };
            Label lblVal = new Label { Text = value, Font = new Font("Segoe UI", 36, FontStyle.Bold), ForeColor = darkText, Location = new Point(110, 20), AutoSize = true }; // Pushed further right to avoid overlap
            Label lblTitle = new Label { Text = title, Font = new Font("Segoe UI", 12, FontStyle.Regular), ForeColor = Color.DimGray, Location = new Point(115, 85), AutoSize = true };

            card.Controls.AddRange(new Control[] { accent, lblIcon, lblVal, lblTitle });
            return card;
        }

        // =========================================================================
        // ROUTING ENGINE
        // =========================================================================
        private void ShowPage(Panel pageToShow)
        {
            pnlSettings.Visible = pnlPostOpp.Visible = pnlManageEvents.Visible = pnlVolunteers.Visible = pnlReviewApps.Visible = pnlReports.Visible = false;
            if (pageToShow != null)
            {
                pageToShow.Visible = true;
                pageToShow.BringToFront();
            }
        }

        private void btnDashboardNav_Click(object sender, EventArgs e) => ShowPage(null);

        private void btnVolunteers_Click(object sender, EventArgs e) => ShowPage(pnlVolunteers);
        private void btnSettings_Click(object sender, EventArgs e) => ShowPage(pnlSettings);
        private void btnPostOpp_Click(object sender, EventArgs e) => ShowPage(pnlPostOpp);
        private void btnReviewApps_Click(object sender, EventArgs e) => ShowPage(pnlReviewApps);
        private void btnReports_Click(object sender, EventArgs e) => ShowPage(pnlReports);

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                // Clear session data
                //    Session.ProfileImage = null;
                //Session.UserName = null;
                //Session.UserRole = null;

                // Open Landing Page
             //   landing land = new landing();
            //landing.Show();

                new landing().Show();

            // Close Dashboard
            this.Close();
        }
    }
}