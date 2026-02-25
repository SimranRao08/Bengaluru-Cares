using System;
using System.Windows.Forms;

namespace BlrCares
{
    public partial class GuidePage : Form
    {
        public GuidePage()
        {
            InitializeComponent();

            // UX Feature: Automatically open all folders so users see sub-topics immediately
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // 1. Update the Big Title
            lblContentTitle.Text = e.Node.Text;

            // 2. Update the Body Content based on selection
            switch (e.Node.Text)
            {
                case "General Info":
                    rtbContent.Text = "Welcome to the Volunteer Guide.\n\nPlease select a specific sub-topic from the menu to learn more about our policies and tools.";
                    break;

                case "Code of Conduct":
                    rtbContent.Text = "• Respect: Treat all community members, staff, and fellow volunteers with dignity.\n\n" +
                                      "• Punctuality: Please arrive at least 15 minutes before your scheduled shift.\n\n" +
                                      "• Identity: Always wear your Bengaluru Cares ID badge while on duty.\n\n" +
                                      "• Substance Policy: Smoking and consumption of alcohol are strictly prohibited during events.";
                    break;

                case "Safety Protocols":
                    rtbContent.Text = "YOUR SAFETY IS OUR PRIORITY.\n\n" +
                                      "1. Always volunteer in groups of three or more.\n" +
                                      "2. Carry a fully charged phone and a basic first aid kit.\n" +
                                      "3. If you feel unsafe, leave the area immediately and contact your coordinator.\n" +
                                      "4. During night drives, wear the provided reflective vests.";
                    break;

                case "Emergency Contacts":
                    rtbContent.Text = "✆ Volunteer Coordinator: +91 99000 12345\n\n" +
                                      "🚑 Medical Emergency (Ambulance): 108\n\n" +
                                      "👮 Police Control Room: 100\n\n" +
                                      "🏢 Head Office: #45, MG Road, Bengaluru - 560001";
                    break;

                case "App Tutorials":
                    rtbContent.Text = "Learn how to use this application to manage your volunteering journey.";
                    break;

                case "How to log hours":
                    rtbContent.Text = "Step 1: Go to the 'Browse Events' page from the Dashboard.\n\n" +
                                      "Step 2: Fill in the Event Name, Date, and Hours worked.\n\n" +
                                      "Step 3: Click 'Save Record'.\n\n" +
                                      "Step 4: Once saved, you can generate a digital waiver receipt for your records.";
                    break;

                case "Claiming Rewards":
                    rtbContent.Text = "We appreciate your service! Here is how our reward system works:\n\n" +
                                      "🌱 Novice (0-10 Hrs): No certificate yet.\n\n" +
                                      "🥈 Silver Samaritan (10-50 Hrs): Unlocks Silver Badge & Certificate.\n\n" +
                                      "🏆 Gold Guardian (50+ Hrs): Unlocks Gold Badge & Special Gift Hamper.\n\n" +
                                      "Check the 'Rewards' page to track your progress!";
                    break;

                default:
                    rtbContent.Text = "Select a topic to view details.";
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Return to Dashboard
        }
    }
}