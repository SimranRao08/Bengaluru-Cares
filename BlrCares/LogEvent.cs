using BengaluruCares;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BlrCares
{
    public partial class LogEvent : Form
    {
        string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BengaluruCaresDB;Integrated Security=True";

        public LogEvent() { InitializeComponent(); }

        private void LogEvent_Load(object sender, EventArgs e) { LoadData(); }

        private void LoadData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM VolunteerLog", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvData.DataSource = dt;
                }

                decimal total = 0;
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells["HoursWorked"].Value != DBNull.Value)
                        total += Convert.ToDecimal(row.Cells["HoursWorked"].Value);
                }
                lblTotalHours.Text = "Total Hours: " + total;
                lblImpact.Text = "Impact: ₹" + (total * 300).ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            CalculatePage calc = new CalculatePage();

            if (calc.ShowDialog() == DialogResult.OK)
            {
                txtHours.Text = calc.ResultHours.ToString();

                if (calc.ResultDate.Year > 2000)
                {
                    dtpDate.Value = calc.ResultDate;
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtHours.Text)) return;
            ExecuteQuery("INSERT INTO VolunteerLog (VolunteerName, EventName, DateWorked, HoursWorked, ReceiptStatus) VALUES (@name, @evt, @date, @hours, 'Pending')");
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0) return;
            ExecuteQuery("UPDATE VolunteerLog SET VolunteerName=@name, EventName=@evt, DateWorked=@date, HoursWorked=@hours, ReceiptStatus='Pending' WHERE LogID=@id", true);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0) return;
            if (MessageBox.Show("Delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                ExecuteQuery("DELETE FROM VolunteerLog WHERE LogID=@id", true);
        }

        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0) { MessageBox.Show("Select a row."); return; }

            string status = dgvData.SelectedRows[0].Cells["ReceiptStatus"].Value.ToString();
            if (status == "Upcoming") { MessageBox.Show("⚠ This event is marked 'Upcoming'.\n\nPlease enter hours and click 'Update Record' first."); return; }
            if (status == "Done") { MessageBox.Show("❌ Receipt already issued."); return; }

            try
            {
                int id = Convert.ToInt32(dgvData.SelectedRows[0].Cells["LogID"].Value);
                string name = dgvData.SelectedRows[0].Cells["VolunteerName"].Value.ToString();
                string evt = dgvData.SelectedRows[0].Cells["EventName"].Value.ToString();
                string date = Convert.ToDateTime(dgvData.SelectedRows[0].Cells["DateWorked"].Value).ToShortDateString();
                decimal hours = Convert.ToDecimal(dgvData.SelectedRows[0].Cells["HoursWorked"].Value);

                WaiverForm w = new WaiverForm(id, name, evt, date, hours);
                if (w.ShowDialog() == DialogResult.OK) LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void ExecuteQuery(string query, bool useId = false)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (useId) cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvData.SelectedRows[0].Cells["LogID"].Value));
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@evt", cmbEvent.Text);
                    cmd.Parameters.AddWithValue("@date", dtpDate.Value);
                    cmd.Parameters.AddWithValue("@hours", decimal.TryParse(txtHours.Text, out decimal h) ? h : 0);
                    cmd.ExecuteNonQuery();
                }
                LoadData();
                txtName.Clear(); txtHours.Clear(); cmbEvent.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                txtName.Text = dgvData.SelectedRows[0].Cells["VolunteerName"].Value.ToString();
                cmbEvent.Text = dgvData.SelectedRows[0].Cells["EventName"].Value.ToString();
                try { dtpDate.Value = Convert.ToDateTime(dgvData.SelectedRows[0].Cells["DateWorked"].Value); } catch { }
                txtHours.Text = dgvData.SelectedRows[0].Cells["HoursWorked"].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }
    }
}