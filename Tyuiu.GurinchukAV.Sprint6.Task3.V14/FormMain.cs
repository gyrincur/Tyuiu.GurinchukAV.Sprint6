using System;
using System.Windows.Forms;
using Tyuiu.GurinchukAV.Sprint6.Task3.V14.Lib;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Исходная матрица 5x5 (взята из задания)
        private int[,] matrix = new int[5, 5]
        {
            {  1,   4,  -5, -12,  -8 },
            { -7, -20,  11, -13,   6 },
            {  2, -12,   1, -12,   3 },
            { -1,  -7, -20,  -6,  17 },
            { -3,   3,   2,  13, -17 }
        };

        public Form1()
        {
            InitializeComponent();

            // Подписываем события
            this.Load += Form1_Load;
            btnHelp.Click += BtnHelp_Click;
            btnExecute.Click += BtnExecute_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        // Заполнить DataGridView значениями matrix
        private void PopulateGrid()
        {
            dgvMatrix.Rows.Clear();
            dgvMatrix.Columns.Clear();

            // создаём 5 колонок
            for (int c = 0; c < 5; c++)
            {
                var col = new DataGridViewTextBoxColumn();
                col.HeaderText = (c + 1).ToString();
                col.Width = 60;
                col.ReadOnly = true;
                dgvMatrix.Columns.Add(col);
            }

            // добавляем строки
            for (int r = 0; r < 5; r++)
            {
                object[] row = new object[5];
                for (int c = 0; c < 5; c++)
                    row[c] = matrix[r, c];
                dgvMatrix.Rows.Add(row);
            }
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 3 выполнил студент группы ИБКСб25-1 Гуринчук Анастасия Витальевна\n",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            int replaced = 0;
            int rowIndex = 1; // вторая строка (0-based index)

            for (int c = 0; c < 5; c++)
            {
                if (matrix[rowIndex, c] % 2 == 0) // чётное
                {
                    matrix[rowIndex, c] = 0;
                    replaced++;
                }
            }

            PopulateGrid();

            lblResult.Text = $"Заменено чётных элементов во 2-й строке: {replaced}";
        }
    }
}
