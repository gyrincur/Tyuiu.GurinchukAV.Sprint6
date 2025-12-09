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
        private System.Windows.Forms.DataGridView dgvResults;
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
            dgvResults = new DataGridView();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // lblCondition
            // 
            lblCondition.BorderStyle = BorderStyle.FixedSingle;
            lblCondition.Location = new Point(10, 10);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(460, 250);
            lblCondition.TabIndex = 0;
            lblCondition.Text = resources.GetString("lblCondition.Text");
            // 
            // lblInput
            // 
            lblInput.Location = new Point(10, 270);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(200, 20);
            lblInput.TabIndex = 1;
            lblInput.Text = "Ввод данных:";
            // 
            // lblStart
            // 
            lblStart.Location = new Point(10, 300);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(120, 20);
            lblStart.TabIndex = 2;
            lblStart.Text = "Старт шага:";
            // 
            // lblEnd
            // 
            lblEnd.Location = new Point(230, 300);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(120, 20);
            lblEnd.TabIndex = 4;
            lblEnd.Text = "Конец шага:";
            // 
            // txtStart
            // 
            txtStart.Location = new Point(130, 296);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(80, 27);
            txtStart.TabIndex = 3;
            txtStart.Text = "-5";
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(350, 296);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(80, 27);
            txtEnd.TabIndex = 5;
            txtEnd.Text = "5";
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(130, 340);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(100, 40);
            btnHelp.TabIndex = 6;
            btnHelp.Text = "Справка";
            btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(260, 340);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(120, 40);
            btnExecute.TabIndex = 7;
            btnExecute.Text = "Выполнить";
            btnExecute.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.ColumnHeadersHeight = 29;
            dgvResults.Location = new Point(480, 10);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersVisible = false;
            dgvResults.RowHeadersWidth = 51;
            dgvResults.Size = new Size(260, 420);
            dgvResults.TabIndex = 8;
            // 
            // chartFunction
            // 
            chartFunction.Location = new Point(760, 10);
            chartFunction.Name = "chartFunction";
            chartFunction.Size = new Size(320, 420);
            chartFunction.TabIndex = 0;
            chartFunction.Text = "chartFunction";
            // 
            // Form1
            // 
            ClientSize = new Size(1100, 460);
            Controls.Add(lblCondition);
            Controls.Add(lblInput);
            Controls.Add(lblStart);
            Controls.Add(txtStart);
            Controls.Add(lblEnd);
            Controls.Add(txtEnd);
            Controls.Add(btnHelp);
            Controls.Add(btnExecute);
            Controls.Add(dgvResults);
            Controls.Add(chartFunction);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 15 | Гуринчук А.В";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
