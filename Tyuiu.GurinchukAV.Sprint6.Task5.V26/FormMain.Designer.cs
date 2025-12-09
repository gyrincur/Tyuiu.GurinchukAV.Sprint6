namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartValues;
        private System.Windows.Forms.Label lblResultTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        private void InitializeComponent()
        {
            lblCondition = new Label();
            btnExecute = new Button();
            btnOpenFile = new Button();
            btnHelp = new Button();
            dgvResults = new DataGridView();
            chartValues = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblResultTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartValues).BeginInit();
            SuspendLayout();
            // 
            // lblCondition
            // 
            lblCondition.BorderStyle = BorderStyle.FixedSingle;
            lblCondition.Location = new Point(10, 10);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(447, 87);
            lblCondition.TabIndex = 0;
            lblCondition.Text = "Прочитать данные из файла InPutFileTask5V26.txt.\r\nВывести в DataGridView все числа, кратные 5.\r\nПостроить диаграмму по этим значениям.\r\nВещественные значения округлить до 3 знаков.";
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(610, 10);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(120, 40);
            btnExecute.TabIndex = 2;
            btnExecute.Text = "Выполнить";
            btnExecute.UseVisualStyleBackColor = true;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(480, 10);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(120, 40);
            btnOpenFile.TabIndex = 1;
            btnOpenFile.Text = "Открыть файл";
            btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(740, 10);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(120, 40);
            btnHelp.TabIndex = 3;
            btnHelp.Text = "Справка";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click_1;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.ColumnHeadersHeight = 29;
            dgvResults.Location = new Point(10, 140);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersVisible = false;
            dgvResults.RowHeadersWidth = 51;
            dgvResults.Size = new Size(220, 320);
            dgvResults.TabIndex = 4;
            // 
            // chartValues
            // 
            chartValues.Location = new Point(240, 100);
            chartValues.Name = "chartValues";
            chartValues.Size = new Size(640, 380);
            chartValues.TabIndex = 5;
            chartValues.Text = "chartValues";
            // 
            // lblResultTitle
            // 
            lblResultTitle.Location = new Point(10, 120);
            lblResultTitle.Name = "lblResultTitle";
            lblResultTitle.Size = new Size(220, 20);
            lblResultTitle.TabIndex = 6;
            lblResultTitle.Text = "Результат (кратные 5):";
            // 
            // Form1
            // 
            ClientSize = new Size(1100, 480);
            Controls.Add(lblCondition);
            Controls.Add(btnOpenFile);
            Controls.Add(btnExecute);
            Controls.Add(btnHelp);
            Controls.Add(dgvResults);
            Controls.Add(chartValues);
            Controls.Add(lblResultTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 26 | Гуринчук А.В";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartValues).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
