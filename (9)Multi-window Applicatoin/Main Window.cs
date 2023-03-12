using _1;
using SolvingHardMath;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _9_Multi_window_Applicatoin
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        MessageMoment messageMoment = new MessageMoment();
        private void First_Click(object sender, EventArgs e)
        {
            BothAverages QueOtta = new BothAverages();
            QueOtta.MdiParent = this;
            QueOtta.Show();
            messageMoment.lbHistory.Items.Add("-First work was opened-");
        }

        private void Second_Click(object sender, EventArgs e)
        {
            ButtonsAndHadlers.MainWindowForUsers QueOtta = new ButtonsAndHadlers.MainWindowForUsers();
            QueOtta.MdiParent = this;
            QueOtta.Show();
            messageMoment.lbHistory.Items.Add("-Second work was opened-");
        }

        private void Third_Click(object sender, EventArgs e)
        {
            MainSolvingWindow QueOtta = new MainSolvingWindow();
            QueOtta.MdiParent = this;
            QueOtta.Show();
            messageMoment.lbHistory.Items.Add("-Third work was opened-");
        }

        private void Forth_Click(object sender, EventArgs e)
        {
            Tabulation.Tabulation QueOtta = new Tabulation.Tabulation();
            QueOtta.MdiParent = this;
            QueOtta.Show();
            messageMoment.lbHistory.Items.Add("-Forth work was opened-");
        }

        private void Fifth_Click(object sender, EventArgs e)
        {
            SwapLetters.Form1 QueOtta = new SwapLetters.Form1();
            QueOtta.MdiParent = this;
            QueOtta.Show();
            messageMoment.lbHistory.Items.Add("-Fifth work was opened-");
        }

        private void Sixth_Click(object sender, EventArgs e)
        {
            MassivAndResult.MainWindow QueOtta = new MassivAndResult.MainWindow();
            QueOtta.MdiParent = this;
            QueOtta.Show();
            messageMoment.lbHistory.Items.Add("-Sixth work was opened-");
        }

        private void Seventh_Click(object sender, EventArgs e)
        {
            SearcherOfLocalMax.MainWindow QueOtta = new SearcherOfLocalMax.MainWindow();
            QueOtta.MdiParent = this;
            QueOtta.Show();
            messageMoment.lbHistory.Items.Add("-Seventh work was opened-");
        }

        private void Eighth_Click(object sender, EventArgs e)
        {
            MadeGraph.MainWindow QueOtta = new MadeGraph.MainWindow();
            QueOtta.MdiParent = this;
            QueOtta.Show();
            messageMoment.lbHistory.Items.Add("-Eighth work was opened-");
        }

        private void messageMomentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            messageMoment.Show();
            messageMomentToolStripMenuItem.Enabled = false;
        }

        private void closeAnyFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form QueOtta in MdiChildren)
            {
                QueOtta.Close();
                if (QueOtta == messageMoment)
                {
                    messageMoment.Show();
                }
            }
            messageMoment.lbHistory.Items.Add("→All windows was closed!←");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.LightBlue;
        }
    }
}
