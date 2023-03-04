using System;
using System.Windows.Forms;

namespace MadeGraph
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void Creater_Click(object sender, EventArgs e)
        {

            MainChart.Series[0].Points.Clear();
            FirstError FirstError = new FirstError();
            SecondError SecondError = new SecondError();

            if (tbXmin.Text == "" || tbXmax.Text == "" || tbStep.Text == "")
            {
                FirstError.ShowDialog();
            }
            else
            {

                double Xmin = Convert.ToDouble(tbXmin.Text);
                double Xmax = Convert.ToDouble(tbXmax.Text);
                double Step = Convert.ToDouble(tbStep.Text);
                double b = 3.2;
                double x1 = Xmin;

                if (Xmin > Xmax)
                {
                    SecondError.ShowDialog();
                }

                int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
                double[] x = new double[count];
                double[] y = new double[count];

                for (int i = 0; i < count; i++)
                {
                    x[i] = Xmin + Step * i;
                    y[i] = 9 * (Math.Pow(x1, 3) + Math.Pow(b, 3)) * Math.Tan(x1);
                    x1 = x1 + Step;
                }

                MainChart.ChartAreas[0].AxisX.Minimum = Xmin;
                MainChart.ChartAreas[0].AxisX.Maximum = Xmax;
                MainChart.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
                MainChart.Series[0].Points.DataBindXY(x, y);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            MainChart.Series[0].Points.Clear();
            tbXmax.Clear();
            tbXmin.Clear();
            tbStep.Clear();
        }
    }
}
