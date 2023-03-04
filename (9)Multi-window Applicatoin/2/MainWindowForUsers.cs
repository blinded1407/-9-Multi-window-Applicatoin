using System;
using System.Windows.Forms;

namespace ButtonsAndHadlers
{
    public partial class MainWindowForUsers : Form
    {
        public MainWindowForUsers()
        {
            InitializeComponent();
        }

        private void UnactiveButton_Click(object sender, EventArgs e)
        {
            UnactiveButton.Enabled = false;
        }

        private void SecondBlocked_Click(object sender, EventArgs e)
        {
            SecondBlocked.Enabled = false;
        }

        private void EnablerResizer(object sender, EventArgs e)
        {
            UnactiveButton.Enabled=true;
            SecondBlocked.Enabled=true;
        }
    }
}
