
namespace Tyuiu.DeminDA.Sprint6.Task1.V14
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
            this.groupBoxTask_DDA = new System.Windows.Forms.GroupBox();
            this.pictureBoxCondition_DDA = new System.Windows.Forms.PictureBox();
            this.groupBoxInPutData_DDA = new System.Windows.Forms.GroupBox();
            this.groupBoxStopStep_DDA = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_DDA = new System.Windows.Forms.TextBox();
            this.groupBoxStartStep_DDA = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_DDA = new System.Windows.Forms.TextBox();
            this.buttonDone_DDA = new System.Windows.Forms.Button();
            this.buttonInfo_DDA = new System.Windows.Forms.Button();
            this.groupBoxResultOutPut_DDA = new System.Windows.Forms.GroupBox();
            this.groupBoxTextResult_DDA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_DDA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_DDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_DDA)).BeginInit();
            this.groupBoxInPutData_DDA.SuspendLayout();
            this.groupBoxStopStep_DDA.SuspendLayout();
            this.groupBoxStartStep_DDA.SuspendLayout();
            this.groupBoxResultOutPut_DDA.SuspendLayout();
            this.groupBoxTextResult_DDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_DDA
            // 
            this.groupBoxTask_DDA.Controls.Add(this.pictureBoxCondition_DDA);
            this.groupBoxTask_DDA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBoxTask_DDA.Location = new System.Drawing.Point(28, 14);
            this.groupBoxTask_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTask_DDA.Name = "groupBoxTask_DDA";
            this.groupBoxTask_DDA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTask_DDA.Size = new System.Drawing.Size(876, 304);
            this.groupBoxTask_DDA.TabIndex = 1;
            this.groupBoxTask_DDA.TabStop = false;
            this.groupBoxTask_DDA.Text = "Условие";
            // 
            // pictureBoxCondition_DDA
            // 
            this.pictureBoxCondition_DDA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCondition_DDA.Image")));
            this.pictureBoxCondition_DDA.Location = new System.Drawing.Point(5, 21);
            this.pictureBoxCondition_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCondition_DDA.Name = "pictureBoxCondition_DDA";
            this.pictureBoxCondition_DDA.Size = new System.Drawing.Size(864, 268);
            this.pictureBoxCondition_DDA.TabIndex = 1;
            this.pictureBoxCondition_DDA.TabStop = false;
            this.pictureBoxCondition_DDA.Click += new System.EventHandler(this.pictureBoxCondition_DDA_Click);
            // 
            // groupBoxInPutData_DDA
            // 
            this.groupBoxInPutData_DDA.Controls.Add(this.groupBoxStopStep_DDA);
            this.groupBoxInPutData_DDA.Controls.Add(this.groupBoxStartStep_DDA);
            this.groupBoxInPutData_DDA.Location = new System.Drawing.Point(28, 322);
            this.groupBoxInPutData_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInPutData_DDA.Name = "groupBoxInPutData_DDA";
            this.groupBoxInPutData_DDA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInPutData_DDA.Size = new System.Drawing.Size(421, 107);
            this.groupBoxInPutData_DDA.TabIndex = 2;
            this.groupBoxInPutData_DDA.TabStop = false;
            this.groupBoxInPutData_DDA.Text = "Ввод данных";
            // 
            // groupBoxStopStep_DDA
            // 
            this.groupBoxStopStep_DDA.Controls.Add(this.textBoxStopStep_DDA);
            this.groupBoxStopStep_DDA.Location = new System.Drawing.Point(212, 36);
            this.groupBoxStopStep_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStopStep_DDA.Name = "groupBoxStopStep_DDA";
            this.groupBoxStopStep_DDA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStopStep_DDA.Size = new System.Drawing.Size(200, 55);
            this.groupBoxStopStep_DDA.TabIndex = 1;
            this.groupBoxStopStep_DDA.TabStop = false;
            this.groupBoxStopStep_DDA.Text = "Конец шага:";
            // 
            // textBoxStopStep_DDA
            // 
            this.textBoxStopStep_DDA.Location = new System.Drawing.Point(5, 21);
            this.textBoxStopStep_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStopStep_DDA.Name = "textBoxStopStep_DDA";
            this.textBoxStopStep_DDA.Size = new System.Drawing.Size(188, 22);
            this.textBoxStopStep_DDA.TabIndex = 0;
            this.textBoxStopStep_DDA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStopStep_DDA__KeyPress);
            // 
            // groupBoxStartStep_DDA
            // 
            this.groupBoxStartStep_DDA.Controls.Add(this.textBoxStartStep_DDA);
            this.groupBoxStartStep_DDA.Location = new System.Drawing.Point(5, 36);
            this.groupBoxStartStep_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStartStep_DDA.Name = "groupBoxStartStep_DDA";
            this.groupBoxStartStep_DDA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStartStep_DDA.Size = new System.Drawing.Size(200, 55);
            this.groupBoxStartStep_DDA.TabIndex = 0;
            this.groupBoxStartStep_DDA.TabStop = false;
            this.groupBoxStartStep_DDA.Text = "Старт шага:";
            // 
            // textBoxStartStep_DDA
            // 
            this.textBoxStartStep_DDA.Location = new System.Drawing.Point(5, 21);
            this.textBoxStartStep_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStartStep_DDA.Name = "textBoxStartStep_DDA";
            this.textBoxStartStep_DDA.Size = new System.Drawing.Size(188, 22);
            this.textBoxStartStep_DDA.TabIndex = 0;
            this.textBoxStartStep_DDA.TextChanged += new System.EventHandler(this.textBoxStartStep_DDA_Text);
            this.textBoxStartStep_DDA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStopStep_DDA__KeyPress);
            // 
            // buttonDone_DDA
            // 
            this.buttonDone_DDA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_DDA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDone_DDA.Location = new System.Drawing.Point(561, 344);
            this.buttonDone_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDone_DDA.Name = "buttonDone_DDA";
            this.buttonDone_DDA.Size = new System.Drawing.Size(151, 85);
            this.buttonDone_DDA.TabIndex = 3;
            this.buttonDone_DDA.Text = "Выполнить";
            this.buttonDone_DDA.UseVisualStyleBackColor = false;
            this.buttonDone_DDA.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonInfo_DDA
            // 
            this.buttonInfo_DDA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonInfo_DDA.Location = new System.Drawing.Point(455, 358);
            this.buttonInfo_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInfo_DDA.Name = "buttonInfo_DDA";
            this.buttonInfo_DDA.Size = new System.Drawing.Size(100, 67);
            this.buttonInfo_DDA.TabIndex = 4;
            this.buttonInfo_DDA.Text = "Справка";
            this.buttonInfo_DDA.UseVisualStyleBackColor = false;
            this.buttonInfo_DDA.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // groupBoxResultOutPut_DDA
            // 
            this.groupBoxResultOutPut_DDA.Controls.Add(this.groupBoxTextResult_DDA);
            this.groupBoxResultOutPut_DDA.Location = new System.Drawing.Point(909, 14);
            this.groupBoxResultOutPut_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxResultOutPut_DDA.Name = "groupBoxResultOutPut_DDA";
            this.groupBoxResultOutPut_DDA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxResultOutPut_DDA.Size = new System.Drawing.Size(362, 546);
            this.groupBoxResultOutPut_DDA.TabIndex = 5;
            this.groupBoxResultOutPut_DDA.TabStop = false;
            this.groupBoxResultOutPut_DDA.Text = "Вывод данных:";
            // 
            // groupBoxTextResult_DDA
            // 
            this.groupBoxTextResult_DDA.Controls.Add(this.textBoxResult_DDA);
            this.groupBoxTextResult_DDA.Location = new System.Drawing.Point(5, 21);
            this.groupBoxTextResult_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTextResult_DDA.Name = "groupBoxTextResult_DDA";
            this.groupBoxTextResult_DDA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTextResult_DDA.Size = new System.Drawing.Size(351, 521);
            this.groupBoxTextResult_DDA.TabIndex = 0;
            this.groupBoxTextResult_DDA.TabStop = false;
            this.groupBoxTextResult_DDA.Text = "Результат:";
            // 
            // textBoxResult_DDA
            // 
            this.textBoxResult_DDA.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxResult_DDA.Location = new System.Drawing.Point(6, 26);
            this.textBoxResult_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxResult_DDA.Multiline = true;
            this.textBoxResult_DDA.Name = "textBoxResult_DDA";
            this.textBoxResult_DDA.ReadOnly = true;
            this.textBoxResult_DDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_DDA.Size = new System.Drawing.Size(345, 491);
            this.textBoxResult_DDA.TabIndex = 0;
            this.textBoxResult_DDA.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 571);
            this.Controls.Add(this.groupBoxResultOutPut_DDA);
            this.Controls.Add(this.buttonInfo_DDA);
            this.Controls.Add(this.buttonDone_DDA);
            this.Controls.Add(this.groupBoxInPutData_DDA);
            this.Controls.Add(this.groupBoxTask_DDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 14 | Дёмин Д. А.";
            this.groupBoxTask_DDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_DDA)).EndInit();
            this.groupBoxInPutData_DDA.ResumeLayout(false);
            this.groupBoxStopStep_DDA.ResumeLayout(false);
            this.groupBoxStopStep_DDA.PerformLayout();
            this.groupBoxStartStep_DDA.ResumeLayout(false);
            this.groupBoxStartStep_DDA.PerformLayout();
            this.groupBoxResultOutPut_DDA.ResumeLayout(false);
            this.groupBoxTextResult_DDA.ResumeLayout(false);
            this.groupBoxTextResult_DDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_DDA;
        private System.Windows.Forms.PictureBox pictureBoxCondition_DDA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_DDA;
        private System.Windows.Forms.GroupBox groupBoxStopStep_DDA;
        private System.Windows.Forms.TextBox textBoxStopStep_DDA;
        private System.Windows.Forms.GroupBox groupBoxStartStep_DDA;
        private System.Windows.Forms.TextBox textBoxStartStep_DDA;
        private System.Windows.Forms.Button buttonInfo_DDA;
        private System.Windows.Forms.Button buttonDone_DDA;
        private System.Windows.Forms.GroupBox groupBoxResultOutPut_DDA;
        private System.Windows.Forms.GroupBox groupBoxTextResult_DDA;
        private System.Windows.Forms.TextBox textBoxResult_DDA;
    }
}

