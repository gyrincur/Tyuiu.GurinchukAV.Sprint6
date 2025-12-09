namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.DataGridView dataGridViewIn;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblFilePath;

        /// <summary> Освободить ресурсы. </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblCondition = new Label();
            btnOpenFile = new Button();
            btnExecute = new Button();
            btnSaveFile = new Button();
            btnHelp = new Button();
            dataGridViewIn = new DataGridView();
            dataGridViewOut = new DataGridView();
            lblIn = new Label();
            lblOut = new Label();
            lblFilePath = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // lblCondition
            // 
            lblCondition.BorderStyle = BorderStyle.FixedSingle;
            lblCondition.Location = new Point(10, 10);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(560, 109);
            lblCondition.TabIndex = 0;
            lblCondition.Text = resources.GetString("lblCondition.Text");
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(580, 12);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(140, 35);
            btnOpenFile.TabIndex = 1;
            btnOpenFile.Text = "Открыть файл";
            btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(730, 12);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(140, 35);
            btnExecute.TabIndex = 2;
            btnExecute.Text = "Выполнить";
            btnExecute.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(880, 12);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(140, 35);
            btnSaveFile.TabIndex = 3;
            btnSaveFile.Text = "Сохранить";
            btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(580, 55);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(440, 35);
            btnHelp.TabIndex = 4;
            btnHelp.Text = "Справка";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click_1;
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.AllowUserToAddRows = false;
            dataGridViewIn.AllowUserToDeleteRows = false;
            dataGridViewIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewIn.ColumnHeadersHeight = 29;
            dataGridViewIn.Location = new Point(10, 161);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.ReadOnly = true;
            dataGridViewIn.RowHeadersVisible = false;
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.Size = new Size(540, 349);
            dataGridViewIn.TabIndex = 8;
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.AllowUserToAddRows = false;
            dataGridViewOut.AllowUserToDeleteRows = false;
            dataGridViewOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewOut.ColumnHeadersHeight = 29;
            dataGridViewOut.Location = new Point(560, 140);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.ReadOnly = true;
            dataGridViewOut.RowHeadersVisible = false;
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(560, 370);
            dataGridViewOut.TabIndex = 9;
            // 
            // lblIn
            // 
            lblIn.Location = new Point(10, 140);
            lblIn.Name = "lblIn";
            lblIn.Size = new Size(200, 18);
            lblIn.TabIndex = 6;
            lblIn.Text = "Исходная матрица (dataGridViewIn):";
            // 
            // lblOut
            // 
            lblOut.Location = new Point(560, 122);
            lblOut.Name = "lblOut";
            lblOut.Size = new Size(200, 18);
            lblOut.TabIndex = 7;
            lblOut.Text = "Результат (dataGridViewOut):";
            // 
            // lblFilePath
            // 
            lblFilePath.Location = new Point(10, 119);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(544, 21);
            lblFilePath.TabIndex = 5;
            lblFilePath.Text = "Файл: (не загружен)";
            // 
            // Form1
            // 
            ClientSize = new Size(1100, 520);
            Controls.Add(lblCondition);
            Controls.Add(btnOpenFile);
            Controls.Add(btnExecute);
            Controls.Add(btnSaveFile);
            Controls.Add(btnHelp);
            Controls.Add(lblFilePath);
            Controls.Add(lblIn);
            Controls.Add(lblOut);
            Controls.Add(dataGridViewIn);
            Controls.Add(dataGridViewOut);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 28 | Гуринчук А.В";
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
