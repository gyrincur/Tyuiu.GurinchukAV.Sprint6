namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;

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
            lblInput = new Label();
            lblStart = new Label();
            lblEnd = new Label();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            btnHelp = new Button();
            btnExecute = new Button();
            btnSaveToFile = new Button();
            groupBoxOutput = new GroupBox();
            txtResult = new TextBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // lblCondition
            // 
            lblCondition.BorderStyle = BorderStyle.FixedSingle;
            lblCondition.Location = new Point(10, 10);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(460, 220);
            lblCondition.TabIndex = 0;
            lblCondition.Text = resources.GetString("lblCondition.Text");
            // 
            // lblInput
            // 
            lblInput.Location = new Point(10, 240);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(200, 20);
            lblInput.TabIndex = 1;
            lblInput.Text = "Ввод данных:";
            // 
            // lblStart
            // 
            lblStart.Location = new Point(10, 270);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(120, 20);
            lblStart.TabIndex = 2;
            lblStart.Text = "Старт шага:";
            // 
            // lblEnd
            // 
            lblEnd.Location = new Point(230, 270);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(120, 20);
            lblEnd.TabIndex = 4;
            lblEnd.Text = "Конец шага:";
            // 
            // txtStart
            // 
            txtStart.Location = new Point(130, 266);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(80, 27);
            txtStart.TabIndex = 3;
            txtStart.Text = "-5";
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(350, 266);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(80, 27);
            txtEnd.TabIndex = 5;
            txtEnd.Text = "5";
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(10, 320);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(140, 40);
            btnHelp.TabIndex = 6;
            btnHelp.Text = "Справка";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click_1;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(160, 320);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(140, 40);
            btnExecute.TabIndex = 7;
            btnExecute.Text = "Выполнить";
            btnExecute.UseVisualStyleBackColor = true;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Location = new Point(10, 370);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(290, 40);
            btnSaveToFile.TabIndex = 8;
            btnSaveToFile.Text = "Сохранить в файл";
            btnSaveToFile.UseVisualStyleBackColor = true;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(txtResult);
            groupBoxOutput.Location = new Point(990, 10);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(300, 420);
            groupBoxOutput.TabIndex = 9;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Consolas", 10F);
            txtResult.Location = new Point(10, 20);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(280, 390);
            txtResult.TabIndex = 0;
            // 
            // chartFunction
            // 
            chartFunction.Location = new Point(480, 10);
            chartFunction.Name = "chartFunction";
            chartFunction.Size = new Size(500, 420);
            chartFunction.TabIndex = 0;
            chartFunction.Text = "chartFunction";
            // 
            // Form1
            // 
            ClientSize = new Size(1300, 480);
            Controls.Add(lblCondition);
            Controls.Add(lblInput);
            Controls.Add(lblStart);
            Controls.Add(txtStart);
            Controls.Add(lblEnd);
            Controls.Add(txtEnd);
            Controls.Add(btnHelp);
            Controls.Add(btnExecute);
            Controls.Add(btnSaveToFile);
            Controls.Add(chartFunction);
            Controls.Add(groupBoxOutput);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 3 | Гуринчук А.В";
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
