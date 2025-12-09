namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Контроли, которыми будем пользоваться в коде
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox txtResult;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
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
            groupBoxOutput = new GroupBox();
            txtResult = new TextBox();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // lblCondition
            // 
            lblCondition.BorderStyle = BorderStyle.FixedSingle;
            lblCondition.Location = new Point(10, 10);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(520, 220);
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
            btnHelp.Location = new Point(10, 310);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(90, 40);
            btnHelp.TabIndex = 6;
            btnHelp.Text = "Справка";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click_1;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(110, 310);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(110, 40);
            btnExecute.TabIndex = 7;
            btnExecute.Text = "Выполнить";
            btnExecute.UseVisualStyleBackColor = true;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(txtResult);
            groupBoxOutput.Location = new Point(540, 10);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(330, 400);
            groupBoxOutput.TabIndex = 8;
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
            txtResult.Size = new Size(310, 370);
            txtResult.TabIndex = 0;
            // 
            // Form1
            // 
            ClientSize = new Size(900, 420);
            Controls.Add(lblCondition);
            Controls.Add(lblInput);
            Controls.Add(lblStart);
            Controls.Add(txtStart);
            Controls.Add(lblEnd);
            Controls.Add(txtEnd);
            Controls.Add(btnHelp);
            Controls.Add(btnExecute);
            Controls.Add(groupBoxOutput);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 20 | Гуринчук А.В";
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
