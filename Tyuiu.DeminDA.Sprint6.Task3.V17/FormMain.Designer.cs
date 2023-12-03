
namespace Tyuiu.DeminDA.Sprint6.Task3.V17
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
            this.dataGridViewInPutMatrix_DDA = new System.Windows.Forms.DataGridView();
            this.textBoxCondition_DDA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPutResult_DDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPutMatrix_DDA = new System.Windows.Forms.DataGridView();
            this.labelResult_DDA = new System.Windows.Forms.Label();
            this.buttonDone_DDA = new System.Windows.Forms.Button();
            this.buttonInfo_DDA = new System.Windows.Forms.Button();
            this.groupBoxTask_DDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutMatrix_DDA)).BeginInit();
            this.groupBoxOutPutResult_DDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutMatrix_DDA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_DDA
            // 
            this.groupBoxTask_DDA.Controls.Add(this.dataGridViewInPutMatrix_DDA);
            this.groupBoxTask_DDA.Controls.Add(this.textBoxCondition_DDA);
            this.groupBoxTask_DDA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxTask_DDA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_DDA.Name = "groupBoxTask_DDA";
            this.groupBoxTask_DDA.Size = new System.Drawing.Size(814, 327);
            this.groupBoxTask_DDA.TabIndex = 0;
            this.groupBoxTask_DDA.TabStop = false;
            this.groupBoxTask_DDA.Text = "Условие";
            // 
            // dataGridViewInPutMatrix_DDA
            // 
            this.dataGridViewInPutMatrix_DDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPutMatrix_DDA.ColumnHeadersVisible = false;
            this.dataGridViewInPutMatrix_DDA.Location = new System.Drawing.Point(433, 28);
            this.dataGridViewInPutMatrix_DDA.Name = "dataGridViewInPutMatrix_DDA";
            this.dataGridViewInPutMatrix_DDA.RowHeadersVisible = false;
            this.dataGridViewInPutMatrix_DDA.RowHeadersWidth = 50;
            this.dataGridViewInPutMatrix_DDA.RowTemplate.Height = 24;
            this.dataGridViewInPutMatrix_DDA.Size = new System.Drawing.Size(381, 299);
            this.dataGridViewInPutMatrix_DDA.TabIndex = 1;
            this.dataGridViewInPutMatrix_DDA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInPutMatrix_DDA_CellContentClick);
            // 
            // textBoxCondition_DDA
            // 
            this.textBoxCondition_DDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_DDA.Location = new System.Drawing.Point(6, 21);
            this.textBoxCondition_DDA.Multiline = true;
            this.textBoxCondition_DDA.Name = "textBoxCondition_DDA";
            this.textBoxCondition_DDA.ReadOnly = true;
            this.textBoxCondition_DDA.Size = new System.Drawing.Size(415, 209);
            this.textBoxCondition_DDA.TabIndex = 0;
            this.textBoxCondition_DDA.TabStop = false;
            this.textBoxCondition_DDA.Text = resources.GetString("textBoxCondition_DDA.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(1261, 803);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBoxOutPutResult_DDA
            // 
            this.groupBoxOutPutResult_DDA.Controls.Add(this.dataGridViewOutPutMatrix_DDA);
            this.groupBoxOutPutResult_DDA.Controls.Add(this.labelResult_DDA);
            this.groupBoxOutPutResult_DDA.Location = new System.Drawing.Point(848, 12);
            this.groupBoxOutPutResult_DDA.Name = "groupBoxOutPutResult_DDA";
            this.groupBoxOutPutResult_DDA.Size = new System.Drawing.Size(381, 327);
            this.groupBoxOutPutResult_DDA.TabIndex = 1;
            this.groupBoxOutPutResult_DDA.TabStop = false;
            this.groupBoxOutPutResult_DDA.Text = "Вывод данных";
            // 
            // dataGridViewOutPutMatrix_DDA
            // 
            this.dataGridViewOutPutMatrix_DDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutMatrix_DDA.ColumnHeadersVisible = false;
            this.dataGridViewOutPutMatrix_DDA.Location = new System.Drawing.Point(6, 48);
            this.dataGridViewOutPutMatrix_DDA.Name = "dataGridViewOutPutMatrix_DDA";
            this.dataGridViewOutPutMatrix_DDA.ReadOnly = true;
            this.dataGridViewOutPutMatrix_DDA.RowHeadersVisible = false;
            this.dataGridViewOutPutMatrix_DDA.RowHeadersWidth = 50;
            this.dataGridViewOutPutMatrix_DDA.RowTemplate.Height = 24;
            this.dataGridViewOutPutMatrix_DDA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewOutPutMatrix_DDA.Size = new System.Drawing.Size(369, 279);
            this.dataGridViewOutPutMatrix_DDA.TabIndex = 1;
            // 
            // labelResult_DDA
            // 
            this.labelResult_DDA.AutoSize = true;
            this.labelResult_DDA.Location = new System.Drawing.Point(6, 21);
            this.labelResult_DDA.Name = "labelResult_DDA";
            this.labelResult_DDA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_DDA.TabIndex = 0;
            this.labelResult_DDA.Text = "Результат:";
            // 
            // buttonDone_DDA
            // 
            this.buttonDone_DDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone_DDA.Location = new System.Drawing.Point(1078, 345);
            this.buttonDone_DDA.Name = "buttonDone_DDA";
            this.buttonDone_DDA.Size = new System.Drawing.Size(151, 48);
            this.buttonDone_DDA.TabIndex = 2;
            this.buttonDone_DDA.Text = "Выполнить";
            this.buttonDone_DDA.UseVisualStyleBackColor = true;
            this.buttonDone_DDA.Click += new System.EventHandler(this.buttonDone_DDA_Click);
            // 
            // buttonInfo_DDA
            // 
            this.buttonInfo_DDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInfo_DDA.Location = new System.Drawing.Point(1013, 345);
            this.buttonInfo_DDA.Name = "buttonInfo_DDA";
            this.buttonInfo_DDA.Size = new System.Drawing.Size(59, 48);
            this.buttonInfo_DDA.TabIndex = 3;
            this.buttonInfo_DDA.Text = "?";
            this.buttonInfo_DDA.UseVisualStyleBackColor = true;
            this.buttonInfo_DDA.Click += new System.EventHandler(this.buttonInfo_DDA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 401);
            this.Controls.Add(this.buttonInfo_DDA);
            this.Controls.Add(this.buttonDone_DDA);
            this.Controls.Add(this.groupBoxOutPutResult_DDA);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxTask_DDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 7 | Дёмин Д. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_DDA.ResumeLayout(false);
            this.groupBoxTask_DDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutMatrix_DDA)).EndInit();
            this.groupBoxOutPutResult_DDA.ResumeLayout(false);
            this.groupBoxOutPutResult_DDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutMatrix_DDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_DDA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCondition_DDA;
        private System.Windows.Forms.GroupBox groupBoxOutPutResult_DDA;
        private System.Windows.Forms.Label labelResult_DDA;
        private System.Windows.Forms.Button buttonDone_DDA;
        private System.Windows.Forms.Button buttonInfo_DDA;
        private System.Windows.Forms.DataGridView dataGridViewInPutMatrix_DDA;
        private System.Windows.Forms.DataGridView dataGridViewOutPutMatrix_DDA;
    }
}

