using System;
using System.Globalization;
using System.Windows.Forms;
using Tyuiu.GurinchukAV.Sprint6.Task1.V20.Lib;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Подпишемся на события здесь, чтобы не дублировать вызовы в Designer
            btnExecute.Click += BtnExecute_Click;
            btnHelp.Click += BtnHelp_Click;
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 1 выполнил студент группы ИБКСб25-1 Гуринчук Анастасия Витальевна\n",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            txtResult.Clear();

            // Читаем диапазон
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

            double step = start <= end ? 1.0 : -1.0; // шаг фиксирован 1, учитываем направление

            txtResult.AppendText(string.Format("{0,-10} {1,12}\r\n", "x", "f(x)"));
            txtResult.AppendText(new string('-', 26) + "\r\n");

            const double eps = 1e-12;

            for (double x = start; step > 0 ? x <= end + 1e-9 : x >= end - 1e-9; x += step)
            {
                double denom = Math.Cos(x) - 2.0 * x;
                double fx;

                if (Math.Abs(denom) < eps)
                {
                    fx = 0.0; // при делении на (почти) ноль => 0
                }
                else
                {
                    fx = (2.0 * x - 3.0) / denom + 5.0 * x - Math.Sin(x);
                }

                double fxRounded = Math.Round(fx, 2);

                // Красивый вывод: x как целое если целое, иначе с двумя знаками
                string xs = (Math.Abs(x - Math.Round(x)) < 1e-9) ? ((int)Math.Round(x)).ToString() : x.ToString("F2", CultureInfo.CurrentCulture);
                string fxs = fxRounded.ToString("F2", CultureInfo.CurrentCulture);

                txtResult.AppendText(string.Format("{0,-10} {1,12}\r\n", xs, fxs));
            }
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {

        }
    }
}
