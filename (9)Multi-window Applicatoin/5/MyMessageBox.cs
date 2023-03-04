using System.Windows.Forms;

namespace SwapLetters
{
    public partial class MyMessageBox : Form
    {
        public MyMessageBox(string title, string message) : base()
        {
            InitializeComponent();
            this.Text = title;
            smthTXT.Text = message;
        }
    }
}
