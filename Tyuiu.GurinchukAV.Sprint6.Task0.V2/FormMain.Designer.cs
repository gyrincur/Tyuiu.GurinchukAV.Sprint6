namespace Tyuiu.GurinchukAV.Sprint6.Task0.V2
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBox1 = new GroupBox();
            TextBoxTask = new TextBox();
            groupBox2 = new GroupBox();
            textBoxVarX = new TextBox();
            TextBoxpr = new TextBox();
            groupBox3 = new GroupBox();
            textBoxResult = new TextBox();
            textBoxRes = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHelp.Location = new Point(595, 399);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(45, 39);
            buttonHelp.TabIndex = 0;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(646, 399);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(142, 39);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TextBoxTask);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 242);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // TextBoxTask
            // 
            TextBoxTask.Location = new Point(12, 26);
            TextBoxTask.Multiline = true;
            TextBoxTask.Name = "TextBoxTask";
            TextBoxTask.ReadOnly = true;
            TextBoxTask.Size = new Size(514, 210);
            TextBoxTask.TabIndex = 3;
            TextBoxTask.Text = "Вычислить значение по формуле";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxVarX);
            groupBox2.Controls.Add(TextBoxpr);
            groupBox2.Location = new Point(0, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(519, 190);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(6, 63);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(125, 27);
            textBoxVarX.TabIndex = 5;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // TextBoxpr
            // 
            TextBoxpr.Location = new Point(8, 30);
            TextBoxpr.Name = "TextBoxpr";
            TextBoxpr.ReadOnly = true;
            TextBoxpr.Size = new Size(125, 27);
            TextBoxpr.TabIndex = 6;
            TextBoxpr.Text = "Переменная Х:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult);
            groupBox3.Controls.Add(textBoxRes);
            groupBox3.Location = new Point(525, 252);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(263, 141);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 69);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(125, 27);
            textBoxResult.TabIndex = 4;
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(6, 26);
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.Size = new Size(125, 27);
            textBoxRes.TabIndex = 7;
            textBoxRes.Text = "Результат:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(538, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 224);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 2 | Гуринчук А.В.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp;
        private Button buttonDone;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox TextBoxTask;
        private TextBox textBoxVarX;
        private TextBox TextBoxpr;
        private TextBox textBoxResult;
        private TextBox textBoxRes;
        private PictureBox pictureBox1;
    }
}
