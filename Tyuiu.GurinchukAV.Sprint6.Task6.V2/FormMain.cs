using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tyuiu.GurinchukAV.Sprint6.Task6.V2.Lib;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
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
                "Таск 6 выполнил студент группы ИБКСб25-1 Гуринчук Анастасия Витальевна\n",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Открыть файл InPutDataFileTask6V2 (или любой другой)";
                dlg.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // читаем весь файл и показываем в textBoxIn (с кодировкой по умолчанию)
                        string text = File.ReadAllText(dlg.FileName, Encoding.Default);
                        txtInput.Text = text;
                        lblFilePath.Text = "Файл: " + dlg.FileName;
                        txtOutput.Clear();
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
            txtOutput.Clear();

            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Входное поле пустое. Сначала загрузите файл или вставьте текст в левое поле.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lines = txtInput.Lines;
            var seconds = lines
                .Select(line =>
                {
                    if (string.IsNullOrWhiteSpace(line)) return null;
                    // разбиваем по пробелам/табуляции, удаляем пустые
                    var parts = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length < 2) return null;
                    // очистим слово от лишних нач./конечных знаков пунктуации
                    var second = parts[1].Trim().Trim(new char[] { ',', ';', '.', ':', '\"', '\'', '(', ')', '[', ']', '{', '}', '<', '>' });
                    return string.IsNullOrEmpty(second) ? null : second;
                })
                .Where(s => s != null)
                .ToArray();

            string result = string.Join(" ", seconds);
            txtOutput.Text = result;

            MessageBox.Show($"Обработано строк: {lines.Length}. Найдено вторых слов: {seconds.Length}.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {

        }
    }
}
