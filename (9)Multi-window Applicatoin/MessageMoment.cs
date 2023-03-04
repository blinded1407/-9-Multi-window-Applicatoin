using System;
using System.Windows.Forms;

namespace _9_Multi_window_Applicatoin
{
    public partial class MessageMoment : Form
    {
        public MessageMoment()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.Sizable;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            lbHistory.Items.Clear();
        }

        private void MiniOrMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
