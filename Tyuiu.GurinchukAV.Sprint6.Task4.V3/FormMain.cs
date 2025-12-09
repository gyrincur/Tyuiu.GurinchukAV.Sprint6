using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.GurinchukAV.Sprint6.Task4.V3.Lib;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Подписки на события
            btnExecute.Click += BtnExecute_Click;
            btnHelp.Click += BtnHelp_Click;
            btnSaveToFile.Click += BtnSaveToFile_Click;
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 4 выполнил студент группы ИБКСб25-1 Гуринчук Анастасия Витальевна\n",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            chartFunction.Series.Clear();
            chartFunction.ChartAreas.Clear();

            // Читаем границы
            if (!double.TryParse(txtStart.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double start))
            {
                MessageBox.Show("Неверный формат стартового значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtEnd.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double end))
            {
                MessageBox.Show("Неверный формат конечного значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double step = start <= end ? 1.0 : -1.0;
            const double eps = 1e-12;

            // Настроим Chart
            ChartArea area = new ChartArea("Main");
            area.AxisX.Title = "X";
            area.AxisY.Title = "Y";
            chartFunction.ChartAreas.Add(area);

            Series series = new Series("f(x)");
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            series.ChartArea = "Main";
            chartFunction.Series.Add(series);

            // Заголовок таблицы в TextBox
            txtResult.AppendText(string.Format("{0,-8} {1,12}\r\n", "x", "f(x)"));
            txtResult.AppendText(new string('-', 24) + "\r\n");

            for (double x = start; step > 0 ? x <= end + 1e-9 : x >= end - 1e-9; x += step)
            {
                double denom = Math.Sin(x) - 3.0 + x;
                double fx;

                if (Math.Abs(denom) < eps)
                {
                    fx = 0.0; // деление на ноль -> 0
                }
                else
                {
                    fx = (3.0 * x - 1.5) / denom + 2.0;
                }

                double fxRounded = Math.Round(fx, 2);

                string xs = (Math.Abs(x - Math.Round(x)) < 1e-9) ? ((int)Math.Round(x)).ToString() : x.ToString("F2", CultureInfo.CurrentCulture);
                string fxs = fxRounded.ToString("F2", CultureInfo.CurrentCulture);

                txtResult.AppendText(string.Format("{0,-8} {1,12}\r\n", xs, fxs));

                // Добавляем точку на график (используем исходное x и округленное значение y)
                series.Points.AddXY(x, fxRounded);
            }

            chartFunction.ChartAreas[0].RecalculateAxesScale();
        }

        private void BtnSaveToFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtResult.Text))
            {
                MessageBox.Show("Нечего сохранять. Сначала выполните табулирование.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string filename = Path.Combine(desktop, "OutputFile Task4V3.txt");
                File.WriteAllText(filename, txtResult.Text);
                MessageBox.Show($"Файл сохранён:\n{filename}", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {

        }
    }
}
