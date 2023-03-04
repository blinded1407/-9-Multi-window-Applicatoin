using System;
using System.Windows.Forms;

namespace MassivAndResult
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            MassiveBox.ReadOnly = true;
            ChangedMassiveBox.ReadOnly = true;
            Result.ReadOnly = true;
            Change.Enabled = false;
            Calculate.Enabled = false;
            Clear.Enabled = false;
        }
        int[] array = new int[12];
        private void Fill_Click(object sender, EventArgs e)
        {
            MassiveBox.Clear();
            ChangedMassiveBox.Clear();
            Result.Clear();
            Change.Enabled = true;
            Clear.Enabled = true;
            Random numbers = new Random();
            for (int i = 0; i < 12; i++)
            {
                array[i] = numbers.Next(-1337, 1337);
                MassiveBox.Text += "Arr[" + i.ToString() + "] = " + array[i].ToString() + "\r\n";
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            ChangedMassiveBox.Clear();
            Fill.Enabled = false;
            Calculate.Enabled = true;
            Result.Clear();
            for (int i = 0; i < 12; i++)
            {
                if (array[i]%2 == 0)
                {
                    ChangedMassiveBox.Text += "Arr[" + i.ToString() + "] = " + array[i].ToString() + "\r\n";
                }
            }
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            Result.Clear();
            Fill.Enabled = true;
            Change.Enabled = false;
            Calculate.Enabled = false;
            int result = 0;
            for (int i = 0; i < 12; i++)
            {
                if (array[i] % 2 == 0)
                {
                    result += array[i];
                    Result.Text = "Result is " + result.ToString();
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            MassiveBox.Clear();
            MassiveBox.Text = "Waiting For Massive!";
            ChangedMassiveBox.Clear();
            ChangedMassiveBox.Text = "Waiting For Massive And Choose Even Numbers!";
            Result.Clear();
            Fill.Enabled = true;
            Change.Enabled = false;
            Calculate.Enabled = false;
            Clear.Enabled = false;
        }
    }
}
