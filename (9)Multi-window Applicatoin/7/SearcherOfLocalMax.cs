using System;
using System.Drawing;
using System.Windows.Forms;

namespace SearcherOfLocalMax
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            MainDataGrid.ReadOnly = true;
            WindowState = FormWindowState.Maximized;//Развернутое отображение окна
            TopMost = true;//Отображение окна на переднем плане 
            FormBorderStyle = FormBorderStyle.FixedSingle;//Стиль границы формы
        }

        private void Searcher_Click(object sender, EventArgs e)
        {
            //Создание dataGridView 20x20 путем задания значений из двумерного массива
            int Row, Col;
            MainDataGrid.RowCount = 20;
            MainDataGrid.ColumnCount = 20;

            int[,] array = new int[20, 20];

            Random random = new Random();
            for (Row = 0; Row < 20; Row++)
                for (Col = 0; Col < 20; Col++)
                    array[Row, Col] = random.Next(-1337, 1337);

            for (Row = 0; Row < 20; Row++)
                for (Col = 0; Col < 20; Col++)
                    MainDataGrid.Rows[Row].Cells[Col].Value = array[Row, Col].ToString();

            //Условие поиска максимальных значений, соседи числа сверху, справа, снизу, слева < числа, выделяемого желтым цветом
            for (Row = 0; Row < 20; Row++)
            {
                for (Col = 0; Col < 20; Col++)
                {
                    MainDataGrid.Rows[Row].Cells[Col].Style.BackColor = Color.White;
                    if (array[Row, Col] >= array[Row - 1 == -1 ? Row : Row - 1, Col] &&
                        array[Row, Col] >= array[Row + 1 == array.GetLength(0) ? Row : Row + 1, Col] &&
                        array[Row, Col] >= array[Row, Col - 1 == -1 ? Col : Col - 1] &&
                        array[Row, Col] >= array[Row, Col + 1 == array.GetLength(1) ? Col : Col + 1])
                    {
                        MainDataGrid.Rows[Row].Cells[Col].Style.BackColor = Color.Yellow;
                    }
                }
            }
        }
    }
}
