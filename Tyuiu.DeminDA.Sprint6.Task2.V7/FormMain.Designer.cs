
namespace Tyuiu.DeminDA.Sprint6.Task2.V7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_DDA = new System.Windows.Forms.GroupBox();
            this.pictureBoxCondition_DDA = new System.Windows.Forms.PictureBox();
            this.groupBoxInPutData_DDA = new System.Windows.Forms.GroupBox();
            this.groupBoxStopStep_DDA = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_DDA = new System.Windows.Forms.TextBox();
            this.groupBoxStartStep_DDA = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_DDA = new System.Windows.Forms.TextBox();
            this.buttonInfo_DDA = new System.Windows.Forms.Button();
            this.buttonDone_DDA = new System.Windows.Forms.Button();
            this.groupBoxResultOutPut_DDA = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_DDA = new System.Windows.Forms.GroupBox();
            this.chartFunction_DDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_DDA = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_DDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_DDA)).BeginInit();
            this.groupBoxInPutData_DDA.SuspendLayout();
            this.groupBoxStopStep_DDA.SuspendLayout();
            this.groupBoxStartStep_DDA.SuspendLayout();
            this.groupBoxResultOutPut_DDA.SuspendLayout();
            this.groupBoxResult_DDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_DDA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_DDA
            // 
            this.groupBoxTask_DDA.Controls.Add(this.pictureBoxCondition_DDA);
            this.groupBoxTask_DDA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBoxTask_DDA.Location = new System.Drawing.Point(12, 11);
            this.groupBoxTask_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTask_DDA.Name = "groupBoxTask_DDA";
            this.groupBoxTask_DDA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTask_DDA.Size = new System.Drawing.Size(876, 304);
            this.groupBoxTask_DDA.TabIndex = 2;
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
            // 
            // groupBoxInPutData_DDA
            // 
            this.groupBoxInPutData_DDA.Controls.Add(this.groupBoxStopStep_DDA);
            this.groupBoxInPutData_DDA.Controls.Add(this.groupBoxStartStep_DDA);
            this.groupBoxInPutData_DDA.Location = new System.Drawing.Point(12, 319);
            this.groupBoxInPutData_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInPutData_DDA.Name = "groupBoxInPutData_DDA";
            this.groupBoxInPutData_DDA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInPutData_DDA.Size = new System.Drawing.Size(426, 107);
            this.groupBoxInPutData_DDA.TabIndex = 3;
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
            this.textBoxStartStep_DDA.TextChanged += new System.EventHandler(this.textBoxStartStep_DDA_TextChanged);
            // 
            // buttonInfo_DDA
            // 
            this.buttonInfo_DDA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonInfo_DDA.Location = new System.Drawing.Point(456, 359);
            this.buttonInfo_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInfo_DDA.Name = "buttonInfo_DDA";
            this.buttonInfo_DDA.Size = new System.Drawing.Size(100, 67);
            this.buttonInfo_DDA.TabIndex = 5;
            this.buttonInfo_DDA.Text = "Справка";
            this.buttonInfo_DDA.UseVisualStyleBackColor = false;
            this.buttonInfo_DDA.Click += new System.EventHandler(this.buttonInfo_DDA_Click);
            // 
            // buttonDone_DDA
            // 
            this.buttonDone_DDA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_DDA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDone_DDA.Location = new System.Drawing.Point(562, 341);
            this.buttonDone_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDone_DDA.Name = "buttonDone_DDA";
            this.buttonDone_DDA.Size = new System.Drawing.Size(151, 85);
            this.buttonDone_DDA.TabIndex = 6;
            this.buttonDone_DDA.Text = "Выполнить";
            this.buttonDone_DDA.UseVisualStyleBackColor = false;
            this.buttonDone_DDA.Click += new System.EventHandler(this.buttonDone_DDA_Click);
            this.buttonDone_DDA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_DDA_MouseDown);
            this.buttonDone_DDA.MouseEnter += new System.EventHandler(this.buttonDone_DDA_MouseEnter);
            this.buttonDone_DDA.MouseLeave += new System.EventHandler(this.buttonDone_DDA_MouseLeave);
            // 
            // groupBoxResultOutPut_DDA
            // 
            this.groupBoxResultOutPut_DDA.Controls.Add(this.groupBoxResult_DDA);
            this.groupBoxResultOutPut_DDA.Location = new System.Drawing.Point(894, 11);
            this.groupBoxResultOutPut_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxResultOutPut_DDA.Name = "groupBoxResultOutPut_DDA";
            this.groupBoxResultOutPut_DDA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxResultOutPut_DDA.Size = new System.Drawing.Size(580, 415);
            this.groupBoxResultOutPut_DDA.TabIndex = 7;
            this.groupBoxResultOutPut_DDA.TabStop = false;
            this.groupBoxResultOutPut_DDA.Text = "Вывод данных:";
            // 
            // groupBoxResult_DDA
            // 
            this.groupBoxResult_DDA.Controls.Add(this.chartFunction_DDA);
            this.groupBoxResult_DDA.Controls.Add(this.dataGridViewFunction_DDA);
            this.groupBoxResult_DDA.Location = new System.Drawing.Point(6, 20);
            this.groupBoxResult_DDA.Name = "groupBoxResult_DDA";
            this.groupBoxResult_DDA.Size = new System.Drawing.Size(569, 390);
            this.groupBoxResult_DDA.TabIndex = 0;
            this.groupBoxResult_DDA.TabStop = false;
            this.groupBoxResult_DDA.Text = "Результат:";
            // 
            // chartFunction_DDA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_DDA.ChartAreas.Add(chartArea2);
            this.chartFunction_DDA.Location = new System.Drawing.Point(213, 21);
            this.chartFunction_DDA.Name = "chartFunction_DDA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Name = "Series1";
            this.chartFunction_DDA.Series.Add(series2);
            this.chartFunction_DDA.Size = new System.Drawing.Size(351, 352);
            this.chartFunction_DDA.TabIndex = 8;
            this.chartFunction_DDA.Text = "chart1";
            this.chartFunction_DDA.Click += new System.EventHandler(this.chartFunction_Click);
            // 
            // dataGridViewFunction_DDA
            // 
            this.dataGridViewFunction_DDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_DDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnY});
            this.dataGridViewFunction_DDA.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewFunction_DDA.Name = "dataGridViewFunction_DDA";
            this.dataGridViewFunction_DDA.RowHeadersVisible = false;
            this.dataGridViewFunction_DDA.RowHeadersWidth = 51;
            this.dataGridViewFunction_DDA.RowTemplate.Height = 24;
            this.dataGridViewFunction_DDA.Size = new System.Drawing.Size(201, 352);
            this.dataGridViewFunction_DDA.TabIndex = 0;
            this.dataGridViewFunction_DDA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.MinimumWidth = 6;
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.Width = 65;
            // 
            // ColumnY
            // 
            this.ColumnY.HeaderText = "F(X)";
            this.ColumnY.MinimumWidth = 6;
            this.ColumnY.Name = "ColumnY";
            this.ColumnY.Width = 65;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 588);
            this.Controls.Add(this.groupBoxResultOutPut_DDA);
            this.Controls.Add(this.buttonDone_DDA);
            this.Controls.Add(this.buttonInfo_DDA);
            this.Controls.Add(this.groupBoxInPutData_DDA);
            this.Controls.Add(this.groupBoxTask_DDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 7 | Дёмин Д. А.";
            this.groupBoxTask_DDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_DDA)).EndInit();
            this.groupBoxInPutData_DDA.ResumeLayout(false);
            this.groupBoxStopStep_DDA.ResumeLayout(false);
            this.groupBoxStopStep_DDA.PerformLayout();
            this.groupBoxStartStep_DDA.ResumeLayout(false);
            this.groupBoxStartStep_DDA.PerformLayout();
            this.groupBoxResultOutPut_DDA.ResumeLayout(false);
            this.groupBoxResult_DDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_DDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_DDA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_DDA;
        private System.Windows.Forms.GroupBox groupBoxStopStep_DDA;
        private System.Windows.Forms.TextBox textBoxStopStep_DDA;
        private System.Windows.Forms.GroupBox groupBoxStartStep_DDA;
        private System.Windows.Forms.TextBox textBoxStartStep_DDA;
        private System.Windows.Forms.Button buttonInfo_DDA;
        private System.Windows.Forms.Button buttonDone_DDA;
        private System.Windows.Forms.PictureBox pictureBoxCondition_DDA;
        private System.Windows.Forms.GroupBox groupBoxResultOutPut_DDA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_DDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;
        private System.Windows.Forms.GroupBox groupBoxResult_DDA;
    }
}

