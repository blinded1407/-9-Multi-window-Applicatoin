using System;
using System.Windows.Forms;

namespace Tabulation
{
    public partial class Tabulation : Form
    {
        public Tabulation()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (WriteX0.Text == "" || WriteXk.Text == "" || WritedX.Text == "" || Writeb.Text == "")
            {
                MessageBox.Show("You need to write any meanings!!!");
            }
            else
            {
                double X0 = Convert.ToDouble(WriteX0.Text);
                double Xk = Convert.ToDouble(WriteXk.Text);
                double dX = Convert.ToDouble(WritedX.Text);
                double b = Convert.ToDouble(Writeb.Text);
                double x = X0;

                if (X0 > Xk)
                {
                    MessageBox.Show("X₀ must be more then Xk!!!");
                }
                else
                {
                    while (x <= (Xk + dX / 2))
                    {
                        double Y = 9 * (Math.Pow(x, 3) + Math.Pow(b, 3)) * Math.Tan(x);
                        Result.Text += "X = " + Convert.ToString(x) + ";Y = " + Convert.ToString(Y) + Environment.NewLine;
                        x = x + dX;
                    }
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            WriteX0.Clear();
            WriteXk.Clear();
            WritedX.Clear();
            Writeb.Clear();
            Result.Clear();
        }
    }
}
