using _9_Multi_window_Applicatoin;
using System;
using System.Linq;
using System.Windows.Forms;

namespace _1
{
    public partial class BothAverages : Form
    {
        Error Error = new Error();
        public BothAverages()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.Fixed3D;

            tbArray.ReadOnly = true;
            tbOdd.ReadOnly = true;
            tbAaver.ReadOnly = true;
            tbGaver.ReadOnly = true;
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            tbArray.Clear();
            tbOdd.Clear();
            tbAaver.Clear();
            tbGaver.Clear();

            if (tbMax.Text == "" || tbAmount.Text == "")
            {
                Error.ShowDialog();
            }

            else
            {
                int MaxMeaning = Convert.ToInt32(tbMax.Text);
                int ElementsAmount = Convert.ToInt32(tbAmount.Text);

                int[] array = new int[ElementsAmount];
                Random random = new Random();

                for (int meaning = 0; meaning < array.Length; meaning++)
                {
                    array[meaning] = random.Next(1, MaxMeaning);
                    tbArray.Text += "Arr[" + meaning.ToString() + "] = " + array[meaning].ToString() + "\r\n";

                    if (array[meaning] % 2 != 0)
                    {
                        tbOdd.Text += "Arr[" + meaning.ToString() + "] = " + array[meaning].ToString() + "\r\n";
                    }
                }

                var AverA = array.Where(a => a % 2 != 0).Average();
                var AverG = Math.Pow(array.Where(a => a % 2 != 0).Aggregate(1.0, (a, a1) => a * a1), 1.0 / array.Where(a => a % 2 != 0).Count());

                tbAaver.Text = $"{AverA:0.000}";
                tbGaver.Text = $"{AverG:0.000}";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            tbMax.Clear();
            tbAmount.Clear();
            tbArray.Clear();
            tbOdd.Clear();
            tbAaver.Clear();
            tbGaver.Clear();
        }

        private void InitializeComponent1()
        {
            this.SuspendLayout();
            // 
            // BothAverages
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "BothAverages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BothAverages_FormClosing);
            this.ResumeLayout(false);

        }
        MessageMoment messageMoment = new MessageMoment();

        private void BothAverages_FormClosing(object sender, FormClosingEventArgs e)
        {
            messageMoment.lbHistory.Items.Add("-First work was closed-");
        }
    }
}