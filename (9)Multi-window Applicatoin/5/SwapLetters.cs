using System;
using System.Windows.Forms;

namespace SwapLetters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool MyMessageBox(string title, string message)
        {
            var msgBox = new MyMessageBox(title, message);
            msgBox.ShowDialog();
            return true;
        } 
        private void SwapLetters_Click(object sender, EventArgs e)
        {
            if (WriteI.Text == "" || WriteI.Text == "")
            {
                MyMessageBox("Error!!!", "Write any meanings, Please!");
                return;
            }
            if (engText.Text.Length == 0)
            {
                MyMessageBox("What the hell is going on!?!??!?!?!", "Write something, please!!!");
            }
            else 
            {
                int i, j;
                i = Convert.ToInt32(WriteI.Text);
                j = Convert.ToInt32(WriteJ.Text);
                char[] s = engText.Text.ToCharArray();
                char something = s[i];
                s[i] = s[j];
                s[j] = something;
                engText.Text = new string(s);
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            WriteI.Clear();
            WriteJ.Clear();
            engText.Clear();
        }
    }
}
