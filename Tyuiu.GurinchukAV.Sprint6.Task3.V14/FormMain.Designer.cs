namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.Label lblResult;

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
            dgvMatrix = new DataGridView();
            btnHelp = new Button();
            btnExecute = new Button();
            lblResultTitle = new Label();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).BeginInit();
            SuspendLayout();
            // 
            // lblCondition
            // 
            lblCondition.BorderStyle = BorderStyle.FixedSingle;
            lblCondition.Location = new Point(10, 10);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(360, 220);
            lblCondition.TabIndex = 0;
            lblCondition.Text = resources.GetString("lblCondition.Text");
            // 
            // dgvMatrix
            // 
            dgvMatrix.AllowUserToAddRows = false;
            dgvMatrix.AllowUserToDeleteRows = false;
            dgvMatrix.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatrix.ColumnHeadersHeight = 29;
            dgvMatrix.Location = new Point(380, 10);
            dgvMatrix.Name = "dgvMatrix";
            dgvMatrix.ReadOnly = true;
            dgvMatrix.RowHeadersVisible = false;
            dgvMatrix.RowHeadersWidth = 51;
            dgvMatrix.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvMatrix.Size = new Size(420, 260);
            dgvMatrix.TabIndex = 1;
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(30, 250);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(100, 40);
            btnHelp.TabIndex = 2;
            btnHelp.Text = "Справка";
            btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(150, 250);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(130, 40);
            btnExecute.TabIndex = 3;
            btnExecute.Text = "Выполнить";
            btnExecute.UseVisualStyleBackColor = true;
            // 
            // lblResultTitle
            // 
            lblResultTitle.Location = new Point(10, 240);
            lblResultTitle.Name = "lblResultTitle";
            lblResultTitle.Size = new Size(1, 1);
            lblResultTitle.TabIndex = 0;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(10, 300);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(760, 20);
            lblResult.TabIndex = 4;
            lblResult.Text = "Результат:";
            // 
            // Form1
            // 
            ClientSize = new Size(820, 320);
            Controls.Add(lblCondition);
            Controls.Add(dgvMatrix);
            Controls.Add(btnHelp);
            Controls.Add(btnExecute);
            Controls.Add(lblResult);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 14 | Гуринчук А.В";
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
