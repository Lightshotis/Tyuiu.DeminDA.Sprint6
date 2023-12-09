
namespace Tyuiu.DeminDA.Sprint6.Task4.V4
{
    partial class FormMain_DDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_DDA));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxCondition_DDA = new System.Windows.Forms.GroupBox();
            this.pictureBoxCondition_DDA = new System.Windows.Forms.PictureBox();
            this.groupBoxInPutData_DDa = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_DDA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_DDA = new System.Windows.Forms.TextBox();
            this.labelStop_DDA = new System.Windows.Forms.Label();
            this.labelStart_DDA = new System.Windows.Forms.Label();
            this.buttonDone_DDA = new System.Windows.Forms.Button();
            this.buttonSaveFile_DDA = new System.Windows.Forms.Button();
            this.buttonInfo_DDA = new System.Windows.Forms.Button();
            this.textBoxResult_DDA = new System.Windows.Forms.TextBox();
            this.labelResult_DDA = new System.Windows.Forms.Label();
            this.chartFunction_DDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTask_DDA = new System.Windows.Forms.Panel();
            this.groupBoxCondition_DDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_DDA)).BeginInit();
            this.groupBoxInPutData_DDa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DDA)).BeginInit();
            this.panelTask_DDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_DDA
            // 
            this.groupBoxCondition_DDA.Controls.Add(this.pictureBoxCondition_DDA);
            this.groupBoxCondition_DDA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCondition_DDA.Name = "groupBoxCondition_DDA";
            this.groupBoxCondition_DDA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCondition_DDA.Size = new System.Drawing.Size(893, 325);
            this.groupBoxCondition_DDA.TabIndex = 1;
            this.groupBoxCondition_DDA.TabStop = false;
            this.groupBoxCondition_DDA.Text = "Условие";
            // 
            // pictureBoxCondition_DDA
            // 
            this.pictureBoxCondition_DDA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCondition_DDA.Image")));
            this.pictureBoxCondition_DDA.Location = new System.Drawing.Point(5, 21);
            this.pictureBoxCondition_DDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCondition_DDA.Name = "pictureBoxCondition_DDA";
            this.pictureBoxCondition_DDA.Size = new System.Drawing.Size(883, 295);
            this.pictureBoxCondition_DDA.TabIndex = 0;
            this.pictureBoxCondition_DDA.TabStop = false;
            // 
            // groupBoxInPutData_DDa
            // 
            this.groupBoxInPutData_DDa.Controls.Add(this.textBoxStopStep_DDA);
            this.groupBoxInPutData_DDa.Controls.Add(this.textBoxStartStep_DDA);
            this.groupBoxInPutData_DDa.Controls.Add(this.labelStop_DDA);
            this.groupBoxInPutData_DDa.Controls.Add(this.labelStart_DDA);
            this.groupBoxInPutData_DDa.Location = new System.Drawing.Point(911, 12);
            this.groupBoxInPutData_DDa.Name = "groupBoxInPutData_DDa";
            this.groupBoxInPutData_DDa.Size = new System.Drawing.Size(269, 73);
            this.groupBoxInPutData_DDa.TabIndex = 2;
            this.groupBoxInPutData_DDa.TabStop = false;
            this.groupBoxInPutData_DDa.Text = "Ввод данных :";
            // 
            // textBoxStopStep_DDA
            // 
            this.textBoxStopStep_DDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStopStep_DDA.Location = new System.Drawing.Point(113, 41);
            this.textBoxStopStep_DDA.Name = "textBoxStopStep_DDA";
            this.textBoxStopStep_DDA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStopStep_DDA.TabIndex = 3;
            // 
            // textBoxStartStep_DDA
            // 
            this.textBoxStartStep_DDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStartStep_DDA.Location = new System.Drawing.Point(3, 41);
            this.textBoxStartStep_DDA.Name = "textBoxStartStep_DDA";
            this.textBoxStartStep_DDA.Size = new System.Drawing.Size(97, 22);
            this.textBoxStartStep_DDA.TabIndex = 2;
            // 
            // labelStop_DDA
            // 
            this.labelStop_DDA.AutoSize = true;
            this.labelStop_DDA.Location = new System.Drawing.Point(110, 21);
            this.labelStop_DDA.Name = "labelStop_DDA";
            this.labelStop_DDA.Size = new System.Drawing.Size(89, 17);
            this.labelStop_DDA.TabIndex = 1;
            this.labelStop_DDA.Text = "Конец шага:\r\n";
            // 
            // labelStart_DDA
            // 
            this.labelStart_DDA.AutoSize = true;
            this.labelStart_DDA.Location = new System.Drawing.Point(6, 21);
            this.labelStart_DDA.Name = "labelStart_DDA";
            this.labelStart_DDA.Size = new System.Drawing.Size(87, 17);
            this.labelStart_DDA.TabIndex = 0;
            this.labelStart_DDA.Text = "Старт шага:\r\n";
            // 
            // buttonDone_DDA
            // 
            this.buttonDone_DDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_DDA.Location = new System.Drawing.Point(1186, 20);
            this.buttonDone_DDA.Name = "buttonDone_DDA";
            this.buttonDone_DDA.Size = new System.Drawing.Size(98, 65);
            this.buttonDone_DDA.TabIndex = 3;
            this.buttonDone_DDA.Text = "Выполнить";
            this.buttonDone_DDA.UseVisualStyleBackColor = false;
            this.buttonDone_DDA.Click += new System.EventHandler(this.buttonDone_DDA_Click);
            // 
            // buttonSaveFile_DDA
            // 
            this.buttonSaveFile_DDA.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSaveFile_DDA.Location = new System.Drawing.Point(1290, 20);
            this.buttonSaveFile_DDA.Name = "buttonSaveFile_DDA";
            this.buttonSaveFile_DDA.Size = new System.Drawing.Size(98, 65);
            this.buttonSaveFile_DDA.TabIndex = 4;
            this.buttonSaveFile_DDA.Text = "Сохранить";
            this.buttonSaveFile_DDA.UseVisualStyleBackColor = false;
            this.buttonSaveFile_DDA.Click += new System.EventHandler(this.buttonSaveFile_DDA_Click);
            // 
            // buttonInfo_DDA
            // 
            this.buttonInfo_DDA.BackColor = System.Drawing.Color.Yellow;
            this.buttonInfo_DDA.Location = new System.Drawing.Point(1394, 20);
            this.buttonInfo_DDA.Name = "buttonInfo_DDA";
            this.buttonInfo_DDA.Size = new System.Drawing.Size(98, 65);
            this.buttonInfo_DDA.TabIndex = 5;
            this.buttonInfo_DDA.Text = "Справка";
            this.buttonInfo_DDA.UseVisualStyleBackColor = false;
            this.buttonInfo_DDA.Click += new System.EventHandler(this.buttonInfo_DDA_Click);
            // 
            // textBoxResult_DDA
            // 
            this.textBoxResult_DDA.Location = new System.Drawing.Point(17, 359);
            this.textBoxResult_DDA.Multiline = true;
            this.textBoxResult_DDA.Name = "textBoxResult_DDA";
            this.textBoxResult_DDA.ReadOnly = true;
            this.textBoxResult_DDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_DDA.Size = new System.Drawing.Size(413, 453);
            this.textBoxResult_DDA.TabIndex = 6;
            // 
            // labelResult_DDA
            // 
            this.labelResult_DDA.AutoSize = true;
            this.labelResult_DDA.Location = new System.Drawing.Point(14, 339);
            this.labelResult_DDA.Name = "labelResult_DDA";
            this.labelResult_DDA.Size = new System.Drawing.Size(54, 17);
            this.labelResult_DDA.TabIndex = 7;
            this.labelResult_DDA.Text = "Вывод:";
            // 
            // chartFunction_DDA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_DDA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_DDA.Legends.Add(legend1);
            this.chartFunction_DDA.Location = new System.Drawing.Point(436, 339);
            this.chartFunction_DDA.Name = "chartFunction_DDA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "SeriesFunction_DDA";
            this.chartFunction_DDA.Series.Add(series1);
            this.chartFunction_DDA.Size = new System.Drawing.Size(1242, 479);
            this.chartFunction_DDA.TabIndex = 8;
            this.chartFunction_DDA.Text = "chartFunction";
            title1.Name = "TitleSin";
            title1.Text = "График функции";
            this.chartFunction_DDA.Titles.Add(title1);
            // 
            // panelTask_DDA
            // 
            this.panelTask_DDA.Controls.Add(this.buttonDone_DDA);
            this.panelTask_DDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_DDA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_DDA.Name = "panelTask_DDA";
            this.panelTask_DDA.Size = new System.Drawing.Size(1688, 328);
            this.panelTask_DDA.TabIndex = 9;
            // 
            // FormMain_DDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 824);
            this.Controls.Add(this.chartFunction_DDA);
            this.Controls.Add(this.labelResult_DDA);
            this.Controls.Add(this.textBoxResult_DDA);
            this.Controls.Add(this.buttonInfo_DDA);
            this.Controls.Add(this.buttonSaveFile_DDA);
            this.Controls.Add(this.groupBoxInPutData_DDa);
            this.Controls.Add(this.groupBoxCondition_DDA);
            this.Controls.Add(this.panelTask_DDA);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1706, 871);
            this.Name = "FormMain_DDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 4 | Дёмин Д. А.";
            this.groupBoxCondition_DDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_DDA)).EndInit();
            this.groupBoxInPutData_DDa.ResumeLayout(false);
            this.groupBoxInPutData_DDa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DDA)).EndInit();
            this.panelTask_DDA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCondition_DDA;
        private System.Windows.Forms.PictureBox pictureBoxCondition_DDA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_DDa;
        private System.Windows.Forms.Label labelStart_DDA;
        private System.Windows.Forms.TextBox textBoxStopStep_DDA;
        private System.Windows.Forms.TextBox textBoxStartStep_DDA;
        private System.Windows.Forms.Label labelStop_DDA;
        private System.Windows.Forms.Button buttonDone_DDA;
        private System.Windows.Forms.Button buttonSaveFile_DDA;
        private System.Windows.Forms.Button buttonInfo_DDA;
        private System.Windows.Forms.TextBox textBoxResult_DDA;
        private System.Windows.Forms.Label labelResult_DDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DDA;
        private System.Windows.Forms.Panel panelTask_DDA;
    }
}

