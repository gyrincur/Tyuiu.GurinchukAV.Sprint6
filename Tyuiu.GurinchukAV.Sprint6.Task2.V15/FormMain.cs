using System;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.GurinchukAV.Sprint6.Task2.V15.Lib;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnExecute.Click += BtnExecute_Click;
            btnHelp.Click += BtnHelp_Click;
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 2 выполнил студент группы ИБКСб25-1 Гуринчук Анастасия Витальевна\n", "Справка",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            // Очистка таблицы и графика
            dgvResults.Rows.Clear();
            dgvResults.Columns.Clear();
            chartFunction.Series.Clear();
            chartFunction.ChartAreas.Clear();

            // Подготовка DataGridView
            dgvResults.Columns.Add("colX", "X");
            dgvResults.Columns.Add("colFx", "F(X)");

            // Подготовка Chart
            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Title = "Ось X";
            area.AxisY.Title = "Ось Y";
            chartFunction.ChartAreas.Add(area);

            Series series = new Series("f(x)");
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            series.ChartArea = "MainArea";
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 5;
            chartFunction.Series.Add(series);

            // Чтение границ диапазона
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

            // Итерация по x
            for (double x = start; step > 0 ? x <= end + 1e-9 : x >= end - 1e-9; x += step)
            {
                double denom = 3.0 * x + 1.2;
                double fx;
                if (Math.Abs(denom) < eps)
                {
                    fx = 0.0; // деление на ноль => вернуть 0
                }
                else
                {
                    // f(x) = (2*sin x)/(3x+1.2) + cos x - 7*x^2
                    fx = (2.0 * Math.Sin(x)) / denom + Math.Cos(x) - 7.0 * x * x;
                }

                double fxRounded = Math.Round(fx, 2);

                // Добавляем в таблицу (в строковом виде с двумя знаками)
                string xs = (Math.Abs(x - Math.Round(x)) < 1e-9) ? ((int)Math.Round(x)).ToString() : x.ToString("F2", CultureInfo.CurrentCulture);
                string fxs = fxRounded.ToString("F2", CultureInfo.CurrentCulture);
                dgvResults.Rows.Add(xs, fxs);

                // Добавляем точку в график (используем исходные значения x и округлённое fx для визуализации)
                series.Points.AddXY(x, fxRounded);
            }

            // Немного форматируем оси (авто-масштаб)
            chartFunction.ChartAreas[0].RecalculateAxesScale();
        }
    }
}
