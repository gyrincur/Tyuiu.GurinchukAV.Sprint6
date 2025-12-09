using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.GurinchukAV.Sprint6.Task7.V28.Lib;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // В памяти храним исходную матрицу как список строк (каждая строка — список int)
        private List<List<int>> matrix = new List<List<int>>();
        // путь к открытому файлу (не обязателен, но удобно)
        private string openedFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();

            btnOpenFile.Click += BtnOpenFile_Click;
            btnExecute.Click += BtnExecute_Click;
            btnSaveFile.Click += BtnSaveFile_Click;
            btnHelp.Click += BtnHelp_Click;
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 7 выполнил студент группы ИБКСб25-1 Гуринчук Анастасия Витальевна\n",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                dlg.Title = "Открыть CSV файл матрицы";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        LoadMatrixFromCsv(dlg.FileName);
                        openedFilePath = dlg.FileName;
                        lblFilePath.Text = "Файл: " + dlg.FileName;
                        FillDataGridViewFromMatrix(dataGridViewIn, matrix);
                        dataGridViewOut.Columns.Clear();
                        dataGridViewOut.Rows.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при чтении файла:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            if (matrix == null || matrix.Count == 0)
            {
                MessageBox.Show("Матрица не загружена. Сначала откройте файл.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int targetRowIndex = 6;
            if (matrix.Count <= targetRowIndex)
            {
                MessageBox.Show($"В матрице меньше {targetRowIndex + 1} строк. Операция невозможна.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создаём копию матрицы для результата (чтобы исходную оставить)
            var result = matrix.Select(row => row.ToList()).ToList();

            // Приводим элементы 7-й строки: если элемент != 13 => 0
            for (int c = 0; c < result[targetRowIndex].Count; c++)
            {
                if (result[targetRowIndex][c] != 13)
                    result[targetRowIndex][c] = 0;
            }

            // Покажем результат в dataGridViewOut
            FillDataGridViewFromMatrix(dataGridViewOut, result);

            matrix = result;
            MessageBox.Show("Операция выполнена. Результат показан в правом поле.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            if (matrix == null || matrix.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения. Сначала загрузите и/или обработайте матрицу.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                dlg.FileName = "OutPutFileTask7.csv";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        SaveMatrixToCsv(dlg.FileName, matrix);
                        MessageBox.Show("Файл сохранён:\n" + dlg.FileName, "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при сохранении файла:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        /// Читает CSV (или разделённый ; ) файл и заполняет matrix (список строк).
        /// При нечисловых токенах выбрасывает исключение.

        private void LoadMatrixFromCsv(string path)
        {
            matrix.Clear();
            var allLines = File.ReadAllLines(path);

            foreach (var raw in allLines)
            {
                // Пропускаем пустые строки
                if (string.IsNullOrWhiteSpace(raw))
                    continue;

                // Разделители: запятая или точка с запятой
                var tokens = raw.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(t => t.Trim())
                                .ToArray();

                var row = new List<int>();
                foreach (var tok in tokens)
                {
                    if (int.TryParse(tok, NumberStyles.Integer, CultureInfo.InvariantCulture, out int v) ||
                        int.TryParse(tok, NumberStyles.Integer, CultureInfo.CurrentCulture, out v))
                    {
                        row.Add(v);
                    }
                    else
                    {
                        if (int.TryParse(tok.Replace(" ", ""), out v))
                        {
                            row.Add(v);
                        }
                        else
                        {
                            throw new InvalidDataException($"Невозможно распарсить значение '{tok}' в целое число.");
                        }
                    }
                }

                matrix.Add(row);
            }

            if (matrix.Count == 0)
                throw new InvalidDataException("Файл пуст или не содержит корректных строк матрицы.");
        }

        /// Показывает матрицу в переданном DataGridView.
        /// Каждый столбец — столбец матрицы

        private void FillDataGridViewFromMatrix(DataGridView dgv, List<List<int>> mat)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            // Определим максимальное количество столбцов в строках (на случай неравномерных строк)
            int maxCols = mat.Max(r => r.Count);

            for (int c = 0; c < maxCols; c++)
            {
                var col = new DataGridViewTextBoxColumn();
                col.HeaderText = (c + 1).ToString();
                col.Name = "c" + c;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col.ReadOnly = true;
                dgv.Columns.Add(col);
            }

            foreach (var row in mat)
            {
                // Подготовим объект[] длины maxCols, если в строке меньше элементов — заполним пустыми
                object[] cells = new object[maxCols];
                for (int c = 0; c < maxCols; c++)
                {
                    if (c < row.Count) cells[c] = row[c];
                    else cells[c] = "";
                }
                dgv.Rows.Add(cells);
            }

            dgv.AutoResizeColumns();
        }


        /// Сохраняет матрицу в CSV (запятые)

        private void SaveMatrixToCsv(string path, List<List<int>> mat)
        {
            using (var sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
            {
                foreach (var row in mat)
                {
                    // если строка пустая — записать пустую строку
                    if (row == null || row.Count == 0)
                    {
                        sw.WriteLine();
                        continue;
                    }
                    string line = string.Join(",", row.Select(v => v.ToString(CultureInfo.InvariantCulture)));
                    sw.WriteLine(line);
                }
            }
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {

        }
    }
}
