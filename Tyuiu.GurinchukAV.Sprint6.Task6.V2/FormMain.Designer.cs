namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblFilePath;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblCondition = new Label();
            lblInput = new Label();
            txtInput = new TextBox();
            btnOpenFile = new Button();
            btnExecute = new Button();
            btnHelp = new Button();
            groupBoxOutput = new GroupBox();
            txtOutput = new TextBox();
            lblFilePath = new Label();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // lblCondition
            // 
            lblCondition.BorderStyle = BorderStyle.FixedSingle;
            lblCondition.Location = new Point(10, 10);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(460, 108);
            lblCondition.TabIndex = 0;
            lblCondition.Text = "Вариант 2:\r\n\r\nЗагрузить файл InputFileTask6V2.txt через OpenFileDialog в textBoxIn.\r\nВывести второе слово каждой строки в результирующую строку и вывести её в textBoxOut.\r\nGUI оформить по образцу.";
            // 
            // lblInput
            // 
            lblInput.Location = new Point(10, 140);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(200, 20);
            lblInput.TabIndex = 2;
            lblInput.Text = "Входной текст (файл):";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Consolas", 10F);
            txtInput.Location = new Point(10, 165);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(460, 300);
            txtInput.TabIndex = 3;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(480, 30);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(140, 40);
            btnOpenFile.TabIndex = 4;
            btnOpenFile.Text = "Открыть файл";
            btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(630, 30);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(140, 40);
            btnExecute.TabIndex = 5;
            btnExecute.Text = "Выполнить";
            btnExecute.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(780, 30);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(140, 40);
            btnHelp.TabIndex = 6;
            btnHelp.Text = "Справка";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click_1;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(txtOutput);
            groupBoxOutput.Location = new Point(480, 100);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(500, 365);
            groupBoxOutput.TabIndex = 7;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Результат (вторые слова каждой строки)";
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Consolas", 10F);
            txtOutput.Location = new Point(10, 20);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(480, 335);
            txtOutput.TabIndex = 0;
            // 
            // lblFilePath
            // 
            lblFilePath.Location = new Point(10, 120);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(460, 20);
            lblFilePath.TabIndex = 1;
            lblFilePath.Text = "Файл: (не загружен)";
            // 
            // Form1
            // 
            ClientSize = new Size(1000, 480);
            Controls.Add(lblCondition);
            Controls.Add(lblFilePath);
            Controls.Add(lblInput);
            Controls.Add(txtInput);
            Controls.Add(btnOpenFile);
            Controls.Add(btnExecute);
            Controls.Add(btnHelp);
            Controls.Add(groupBoxOutput);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 2 | Гуринчук А.В";
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
