using BengaluruCares;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlrCares
{
    public partial class CalculatePage : Form
    {
        // Properties to store data for the main page
        public decimal ResultHours { get; private set; } = 0;
        public DateTime ResultDate { get; private set; } = DateTime.Now;

        public CalculatePage()
        {
            InitializeComponent();

            // Set default values to avoid crashes
            dtpStartTime.Value = DateTime.Now;
            dtpEndTime.Value = DateTime.Now.AddHours(1);
            dtpDate.Value = DateTime.Now;

            // Wire up the calculation logic
            dtpStartTime.ValueChanged += Recalc;
            dtpEndTime.ValueChanged += Recalc;
        }

        // 1. Logic to Calculate Hours automatically
        private void Recalc(object sender, EventArgs e)
        {
            TimeSpan duration = dtpEndTime.Value - dtpStartTime.Value;

            if (duration.TotalHours <= 0)
            {
                lblTotalHours.Text = "0.00";
                btnSubmit.Enabled = false;
                btnSubmit.BackColor = Color.Gray;
                return;
            }

            lblTotalHours.Text = Math.Round(duration.TotalHours, 2).ToString("0.00");
            btnSubmit.Enabled = true;
            btnSubmit.BackColor = Color.Teal;
        }

        // 2. THIS IS THE MISSING FUNCTION THAT CAUSED THE ERROR
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Save the values to our public properties
                ResultHours = Convert.ToDecimal(lblTotalHours.Text);
                ResultDate = dtpDate.Value;

                // Close the form and say "OK"
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // 3. Back Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }
    }
}