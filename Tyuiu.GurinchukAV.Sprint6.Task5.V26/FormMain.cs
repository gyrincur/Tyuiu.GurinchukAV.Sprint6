using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.GurinchukAV.Sprint6.Task5.V26.Lib;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Храним все считанные числа здесь
        private List<double> allNumbers = new List<double>();

        public Form1()
        {
            InitializeComponent();

            btnOpenFile.Click += BtnOpenFile_Click;
            btnExecute.Click += BtnExecute_Click;
            btnHelp.Click += BtnHelp_Click;
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 5 выполнил студент группы ИБКСб25-1 Гуринчук Анастасия Витальевна\n",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Попытка открыть файл через диалог
        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
                dlg.FileName = "InPutDataFileTask5V26";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ReadNumbersFromFile(dlg.FileName);
                        MessageBox.Show($"Файл {Path.GetFileName(dlg.FileName)} успешно загружен. Нажмите \"Выполнить\" для обработки.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при чтении файла:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Если нажали Выполнить — либо используем уже загруженные числа, либо попробуем открыть файл с именем InPutFileTask5V26.txt в папке с приложением
        private void BtnExecute_Click(object sender, EventArgs e)
        {
            if (allNumbers == null || allNumbers.Count == 0)
            {
                // Попробуем загрузить файл из каталога приложения с именем InPutFileTask5V26.txt
                string exeDir = AppDomain.CurrentDomain.BaseDirectory;
                string defaultPath = Path.Combine(exeDir, "InPutDataFileTask5V26");
                if (File.Exists(defaultPath))
                {
                    try
                    {
                        ReadNumbersFromFile(defaultPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при чтении файла по умолчанию:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Данные не загружены. Нажмите 'Открыть файл' и выберите файл с числами или поместите InPutDataFileTask5V26 в папку приложения.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            ProcessAndShowMultiplesOfFive();
        }

        // Функция чтения чисел из файла
        private void ReadNumbersFromFile(string path)
        {
            allNumbers.Clear();

            string text = File.ReadAllText(path);
            if (string.IsNullOrWhiteSpace(text))
                return;

            // Разделители: пробел, таб, перевод строки, запятая, точка с запятой
            char[] seps = new char[] { ' ', '\t', '\r', '\n', ',', ';' };

            var tokens = text.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            foreach (var t in tokens)
            {
                // Попробуем распарсить с invariant culture (точка) и с текущей культурой (запятая)
                if (double.TryParse(t, NumberStyles.Any, CultureInfo.InvariantCulture, out double v) ||
                    double.TryParse(t, NumberStyles.Any, CultureInfo.CurrentCulture, out v))
                {
                    allNumbers.Add(v);
                }
                // Если не удалось распарсить — игнорируем токен
            }
        }

        // Отфильтровать числа кратные 5 и показать в таблице и на графике
        private void ProcessAndShowMultiplesOfFive()
        {
            dgvResults.Rows.Clear();
            dgvResults.Columns.Clear();
            chartValues.Series.Clear();
            chartValues.ChartAreas.Clear();

            // Добавим колонки: индекс и значение
            dgvResults.Columns.Add("idx", "№");
            dgvResults.Columns.Add("value", "Значение (кратное 5)");

            // Фильтрация: кратно 5 — используем проверку остатка (double %)
            const double eps = 1e-9;
            var multiples = allNumbers.Where(n => Math.Abs(n % 5.0) < eps).ToList();

            // Если нет подходящих значений — сообщаем
            if (multiples.Count == 0)
            {
                MessageBox.Show("В файле не найдено чисел, кратных 5.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Подготовим Chart
            ChartArea area = new ChartArea("Main");
            area.AxisX.Title = "№";
            area.AxisY.Title = "Значение";
            chartValues.ChartAreas.Add(area);

            Series series = new Series("Кратные 5");
            series.ChartType = SeriesChartType.Column;
            series.ChartArea = "Main";
            series.BorderWidth = 1;
            chartValues.Series.Add(series);

            // Заполнение DataGridView и Chart
            int idx = 1;
            foreach (var v in multiples)
            {
                double rounded = Math.Round(v, 3);
                string sVal = rounded.ToString("F3", CultureInfo.CurrentCulture);
                dgvResults.Rows.Add(idx.ToString(), sVal);

                // добавляем в график: X — индекс, Y — округленное значение
                series.Points.AddXY(idx, rounded);

                idx++;
            }

            // Немного форматируем оси
            chartValues.ChartAreas[0].RecalculateAxesScale();
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {

        }
    }
}
