
namespace Tyuiu.DeminDA.Sprint6.Task0.V18
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTaskDDA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_DDA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_DDA = new System.Windows.Forms.TextBox();
            this.groupBoxVarInPut_DDA = new System.Windows.Forms.GroupBox();
            this.groupBoxVarX_DDA = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_DDA = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxOutPut_DDA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPutResult_DDA = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutResult_DDA = new System.Windows.Forms.TextBox();
            this.buttonDone_DDA = new System.Windows.Forms.Button();
            this.buttonHelp_DDA = new System.Windows.Forms.Button();
            this.groupBoxTaskDDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_DDA)).BeginInit();
            this.groupBoxVarInPut_DDA.SuspendLayout();
            this.groupBoxVarX_DDA.SuspendLayout();
            this.groupBoxOutPut_DDA.SuspendLayout();
            this.groupBoxOutPutResult_DDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTaskDDA
            // 
            this.groupBoxTaskDDA.Controls.Add(this.pictureBoxFormula_DDA);
            this.groupBoxTaskDDA.Controls.Add(this.textBoxTask_DDA);
            this.groupBoxTaskDDA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBoxTaskDDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTaskDDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTaskDDA.Name = "groupBoxTaskDDA";
            this.groupBoxTaskDDA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTaskDDA.Size = new System.Drawing.Size(800, 254);
            this.groupBoxTaskDDA.TabIndex = 0;
            this.groupBoxTaskDDA.TabStop = false;
            this.groupBoxTaskDDA.Text = "Условие";
            this.groupBoxTaskDDA.Enter += new System.EventHandler(this.groupBoxTaskDDA_Enter);
            // 
            // pictureBoxFormula_DDA
            // 
            this.pictureBoxFormula_DDA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_DDA.Image")));
            this.pictureBoxFormula_DDA.Location = new System.Drawing.Point(527, 19);
            this.pictureBoxFormula_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFormula_DDA.Name = "pictureBoxFormula_DDA";
            this.pictureBoxFormula_DDA.Size = new System.Drawing.Size(263, 134);
            this.pictureBoxFormula_DDA.TabIndex = 1;
            this.pictureBoxFormula_DDA.TabStop = false;
            // 
            // textBoxTask_DDA
            // 
            this.textBoxTask_DDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_DDA.Location = new System.Drawing.Point(11, 21);
            this.textBoxTask_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTask_DDA.Multiline = true;
            this.textBoxTask_DDA.Name = "textBoxTask_DDA";
            this.textBoxTask_DDA.ReadOnly = true;
            this.textBoxTask_DDA.Size = new System.Drawing.Size(503, 229);
            this.textBoxTask_DDA.TabIndex = 0;
            this.textBoxTask_DDA.TabStop = false;
            this.textBoxTask_DDA.Text = "Вычислить выражение по формуле";
            this.textBoxTask_DDA.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // groupBoxVarInPut_DDA
            // 
            this.groupBoxVarInPut_DDA.Controls.Add(this.groupBoxVarX_DDA);
            this.groupBoxVarInPut_DDA.Location = new System.Drawing.Point(12, 260);
            this.groupBoxVarInPut_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxVarInPut_DDA.Name = "groupBoxVarInPut_DDA";
            this.groupBoxVarInPut_DDA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxVarInPut_DDA.Size = new System.Drawing.Size(413, 167);
            this.groupBoxVarInPut_DDA.TabIndex = 1;
            this.groupBoxVarInPut_DDA.TabStop = false;
            this.groupBoxVarInPut_DDA.Text = "Ввод данных";
            this.groupBoxVarInPut_DDA.Enter += new System.EventHandler(this.groupBoxDataInPut_DDA_Enter);
            // 
            // groupBoxVarX_DDA
            // 
            this.groupBoxVarX_DDA.Controls.Add(this.textBoxVarX_DDA);
            this.groupBoxVarX_DDA.Location = new System.Drawing.Point(5, 21);
            this.groupBoxVarX_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxVarX_DDA.Name = "groupBoxVarX_DDA";
            this.groupBoxVarX_DDA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxVarX_DDA.Size = new System.Drawing.Size(168, 79);
            this.groupBoxVarX_DDA.TabIndex = 0;
            this.groupBoxVarX_DDA.TabStop = false;
            this.groupBoxVarX_DDA.Text = "Переменная X :";
            // 
            // textBoxVarX_DDA
            // 
            this.textBoxVarX_DDA.Location = new System.Drawing.Point(16, 30);
            this.textBoxVarX_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVarX_DDA.Name = "textBoxVarX_DDA";
            this.textBoxVarX_DDA.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarX_DDA.TabIndex = 0;
            this.textBoxVarX_DDA.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            this.textBoxVarX_DDA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarXInPut_DDA_KeyPress);
            // 
            // groupBoxOutPut_DDA
            // 
            this.groupBoxOutPut_DDA.Controls.Add(this.groupBoxOutPutResult_DDA);
            this.groupBoxOutPut_DDA.Location = new System.Drawing.Point(469, 260);
            this.groupBoxOutPut_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOutPut_DDA.Name = "groupBoxOutPut_DDA";
            this.groupBoxOutPut_DDA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOutPut_DDA.Size = new System.Drawing.Size(317, 126);
            this.groupBoxOutPut_DDA.TabIndex = 2;
            this.groupBoxOutPut_DDA.TabStop = false;
            this.groupBoxOutPut_DDA.Text = "Вывод данных:";
            // 
            // groupBoxOutPutResult_DDA
            // 
            this.groupBoxOutPutResult_DDA.Controls.Add(this.textBoxOutPutResult_DDA);
            this.groupBoxOutPutResult_DDA.Location = new System.Drawing.Point(5, 50);
            this.groupBoxOutPutResult_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOutPutResult_DDA.Name = "groupBoxOutPutResult_DDA";
            this.groupBoxOutPutResult_DDA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOutPutResult_DDA.Size = new System.Drawing.Size(307, 69);
            this.groupBoxOutPutResult_DDA.TabIndex = 1;
            this.groupBoxOutPutResult_DDA.TabStop = false;
            this.groupBoxOutPutResult_DDA.Text = "Результат:";
            this.groupBoxOutPutResult_DDA.Enter += new System.EventHandler(this.groupBoxOutPutResult_DDA_Enter);
            // 
            // textBoxOutPutResult_DDA
            // 
            this.textBoxOutPutResult_DDA.Location = new System.Drawing.Point(5, 27);
            this.textBoxOutPutResult_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOutPutResult_DDA.Name = "textBoxOutPutResult_DDA";
            this.textBoxOutPutResult_DDA.ReadOnly = true;
            this.textBoxOutPutResult_DDA.Size = new System.Drawing.Size(279, 22);
            this.textBoxOutPutResult_DDA.TabIndex = 0;
            this.textBoxOutPutResult_DDA.TextChanged += new System.EventHandler(this.textBoxOutPutResult_DDA_TextChanged);
            // 
            // buttonDone_DDA
            // 
            this.buttonDone_DDA.Location = new System.Drawing.Point(619, 386);
            this.buttonDone_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDone_DDA.Name = "buttonDone_DDA";
            this.buttonDone_DDA.Size = new System.Drawing.Size(171, 52);
            this.buttonDone_DDA.TabIndex = 3;
            this.buttonDone_DDA.Text = "Выполнить!";
            this.buttonDone_DDA.UseVisualStyleBackColor = true;
            this.buttonDone_DDA.Click += new System.EventHandler(this.buttonDone_DDA_Click);
            // 
            // buttonHelp_DDA
            // 
            this.buttonHelp_DDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_DDA.Location = new System.Drawing.Point(556, 386);
            this.buttonHelp_DDA.Name = "buttonHelp_DDA";
            this.buttonHelp_DDA.Size = new System.Drawing.Size(57, 52);
            this.buttonHelp_DDA.TabIndex = 4;
            this.buttonHelp_DDA.Text = "?";
            this.buttonHelp_DDA.UseVisualStyleBackColor = true;
            this.buttonHelp_DDA.Click += new System.EventHandler(this.buttonHelp_DDA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.buttonHelp_DDA);
            this.Controls.Add(this.buttonDone_DDA);
            this.Controls.Add(this.groupBoxOutPut_DDA);
            this.Controls.Add(this.groupBoxVarInPut_DDA);
            this.Controls.Add(this.groupBoxTaskDDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 18 | Дёмин Д. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTaskDDA.ResumeLayout(false);
            this.groupBoxTaskDDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_DDA)).EndInit();
            this.groupBoxVarInPut_DDA.ResumeLayout(false);
            this.groupBoxVarX_DDA.ResumeLayout(false);
            this.groupBoxVarX_DDA.PerformLayout();
            this.groupBoxOutPut_DDA.ResumeLayout(false);
            this.groupBoxOutPutResult_DDA.ResumeLayout(false);
            this.groupBoxOutPutResult_DDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTaskDDA;
        private System.Windows.Forms.GroupBox groupBoxVarInPut_DDA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxVarX_DDA;
        private System.Windows.Forms.TextBox textBoxVarX_DDA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_DDA;
        private System.Windows.Forms.GroupBox groupBoxOutPutResult_DDA;
        private System.Windows.Forms.TextBox textBoxOutPutResult_DDA;
        private System.Windows.Forms.Button buttonDone_DDA;
        private System.Windows.Forms.TextBox textBoxTask_DDA;
        protected System.Windows.Forms.PictureBox pictureBoxFormula_DDA;
        private System.Windows.Forms.Button buttonHelp_DDA;
    }
}

