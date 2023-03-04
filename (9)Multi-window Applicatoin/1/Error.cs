using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void Closer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
