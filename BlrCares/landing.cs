using BengaluruCares;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlrCares
{
    public partial class landing : Form
    {
        public landing()
        {
            InitializeComponent();
        }

        // --- BUTTON CLICKS ---

        private void btnVolunteer_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();

        }

        private void btnNGO_Click(object sender, EventArgs e)
        {
            // TODO: Open the NGO Registration Form
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // TODO: Open the General Login Form
            MessageBox.Show("Redirecting to Login Page...", "Navigate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // --- UI HOVER EFFECTS FOR AESTHETICS ---

        // Makes the outlined NGO button fill with color when hovered over
        private void btnNGO_MouseEnter(object sender, EventArgs e)
        {
            btnNGO.BackColor = Color.FromArgb(0, 92, 83); // Deep Teal
            btnNGO.ForeColor = Color.White;
        }

        // Reverts the NGO button back to outlined when the mouse leaves
        private void btnNGO_MouseLeave(object sender, EventArgs e)
        {
            btnNGO.BackColor = Color.White;
            btnNGO.ForeColor = Color.FromArgb(0, 92, 83); // Deep Teal
        }
    }
}