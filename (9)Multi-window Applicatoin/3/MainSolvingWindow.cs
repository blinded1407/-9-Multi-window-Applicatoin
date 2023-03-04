using System;
using System.Windows.Forms;

namespace SolvingHardMath
{
    public partial class MainSolvingWindow : Form
    {
        public MainSolvingWindow()
        {
            InitializeComponent();
        }
        private void Calculate_Click(object sender, EventArgs e)
        {

            if (WriteX.Text == "" || WriteY.Text == "" || WriteZ.Text == "")
            {
                MessageBox.Show("Please, Enter any Meanings!");
            }
            else
            {
                double X = Convert.ToDouble(WriteX.Text);
                double Y = Convert.ToDouble(WriteY.Text);
                double Z = Convert.ToDouble(WriteZ.Text);
                if (sh.Checked)
                {
                    double AsinX = Math.Asin(X);
                    double Result1 = (Math.Abs(Math.Min(AsinX, Y) - Math.Max(Y, Z))) / 2;
                    Result.Text = $"p = {Result1}";
                }
                else if (x2.Checked)
                {
                    double PowX = Math.Pow(X, 2);
                    double Result2 = (Math.Abs(Math.Min(PowX, Y) - Math.Max(Y, Z))) / 2;
                    Result.Text = $"p = {Result2}";
                }
                else if (ex.Checked)
                {
                    double ExpX = Math.Exp(X);
                    double Result3 = (Math.Abs(Math.Min(ExpX, Y) - Math.Max(Y, Z))) / 2;
                    Result.Text = $"p = {Result3}";
                }
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            WriteX.Clear();
            WriteY.Clear();
            WriteZ.Clear();
            Result.Clear();
            sh.Checked = false;
            x2.Checked = false;
            ex.Checked = false;
            Result.Text = "READY FOR WORK!!!";
        }
    }
}
