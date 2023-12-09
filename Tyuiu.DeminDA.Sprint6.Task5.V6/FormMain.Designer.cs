
namespace Tyuiu.DeminDA.Sprint6.Task5.V6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask_DDA = new System.Windows.Forms.Panel();
            this.groupBoxCondition_DDA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_DDA = new System.Windows.Forms.TextBox();
            this.buttonInfo_DDA = new System.Windows.Forms.Button();
            this.buttonOpenFile_DDA = new System.Windows.Forms.Button();
            this.buttonDone_DDA = new System.Windows.Forms.Button();
            this.panelOutPut_DDA = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_DDA = new System.Windows.Forms.DataGridView();
            this.panelChart_DDA = new System.Windows.Forms.Panel();
            this.chartResult_DDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTask_DDA.SuspendLayout();
            this.groupBoxCondition_DDA.SuspendLayout();
            this.panelOutPut_DDA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_DDA)).BeginInit();
            this.panelChart_DDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_DDA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_DDA
            // 
            this.panelTask_DDA.Controls.Add(this.groupBoxCondition_DDA);
            this.panelTask_DDA.Controls.Add(this.buttonInfo_DDA);
            this.panelTask_DDA.Controls.Add(this.buttonOpenFile_DDA);
            this.panelTask_DDA.Controls.Add(this.buttonDone_DDA);
            this.panelTask_DDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_DDA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_DDA.Name = "panelTask_DDA";
            this.panelTask_DDA.Size = new System.Drawing.Size(1472, 139);
            this.panelTask_DDA.TabIndex = 0;
            // 
            // groupBoxCondition_DDA
            // 
            this.groupBoxCondition_DDA.Controls.Add(this.textBoxCondition_DDA);
            this.groupBoxCondition_DDA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_DDA.Name = "groupBoxCondition_DDA";
            this.groupBoxCondition_DDA.Size = new System.Drawing.Size(642, 121);
            this.groupBoxCondition_DDA.TabIndex = 5;
            this.groupBoxCondition_DDA.TabStop = false;
            this.groupBoxCondition_DDA.Text = "Условие:";
            // 
            // textBoxCondition_DDA
            // 
            this.textBoxCondition_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCondition_DDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCondition_DDA.Location = new System.Drawing.Point(3, 18);
            this.textBoxCondition_DDA.Multiline = true;
            this.textBoxCondition_DDA.Name = "textBoxCondition_DDA";
            this.textBoxCondition_DDA.ReadOnly = true;
            this.textBoxCondition_DDA.Size = new System.Drawing.Size(636, 100);
            this.textBoxCondition_DDA.TabIndex = 0;
            this.textBoxCondition_DDA.Text = resources.GetString("textBoxCondition_DDA.Text");
            // 
            // buttonInfo_DDA
            // 
            this.buttonInfo_DDA.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInfo_DDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInfo_DDA.Location = new System.Drawing.Point(1040, 59);
            this.buttonInfo_DDA.Name = "buttonInfo_DDA";
            this.buttonInfo_DDA.Size = new System.Drawing.Size(139, 74);
            this.buttonInfo_DDA.TabIndex = 4;
            this.buttonInfo_DDA.Text = "Справка";
            this.buttonInfo_DDA.UseVisualStyleBackColor = false;
            this.buttonInfo_DDA.Click += new System.EventHandler(this.buttonInfo_DDA_Click);
            // 
            // buttonOpenFile_DDA
            // 
            this.buttonOpenFile_DDA.BackColor = System.Drawing.Color.Yellow;
            this.buttonOpenFile_DDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenFile_DDA.Location = new System.Drawing.Point(906, 59);
            this.buttonOpenFile_DDA.Name = "buttonOpenFile_DDA";
            this.buttonOpenFile_DDA.Size = new System.Drawing.Size(128, 75);
            this.buttonOpenFile_DDA.TabIndex = 2;
            this.buttonOpenFile_DDA.Text = "Открыть файл";
            this.buttonOpenFile_DDA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_DDA.Click += new System.EventHandler(this.buttonOpenFile_DDA_Click);
            // 
            // buttonDone_DDA
            // 
            this.buttonDone_DDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_DDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone_DDA.Location = new System.Drawing.Point(781, 60);
            this.buttonDone_DDA.Name = "buttonDone_DDA";
            this.buttonDone_DDA.Size = new System.Drawing.Size(119, 74);
            this.buttonDone_DDA.TabIndex = 1;
            this.buttonDone_DDA.Text = "Выполнить";
            this.buttonDone_DDA.UseVisualStyleBackColor = false;
            this.buttonDone_DDA.Click += new System.EventHandler(this.buttonDone_DDA_Click);
            // 
            // panelOutPut_DDA
            // 
            this.panelOutPut_DDA.Controls.Add(this.groupBox1);
            this.panelOutPut_DDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPut_DDA.Location = new System.Drawing.Point(0, 139);
            this.panelOutPut_DDA.Name = "panelOutPut_DDA";
            this.panelOutPut_DDA.Size = new System.Drawing.Size(249, 687);
            this.panelOutPut_DDA.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewResult_DDA);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 687);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод данных:";
            // 
            // dataGridViewResult_DDA
            // 
            this.dataGridViewResult_DDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_DDA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewResult_DDA.Name = "dataGridViewResult_DDA";
            this.dataGridViewResult_DDA.RowHeadersVisible = false;
            this.dataGridViewResult_DDA.RowHeadersWidth = 51;
            this.dataGridViewResult_DDA.RowTemplate.Height = 24;
            this.dataGridViewResult_DDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult_DDA.Size = new System.Drawing.Size(243, 666);
            this.dataGridViewResult_DDA.TabIndex = 0;
            this.dataGridViewResult_DDA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResult_DDA_CellContentClick);
            // 
            // panelChart_DDA
            // 
            this.panelChart_DDA.Controls.Add(this.chartResult_DDA);
            this.panelChart_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart_DDA.Location = new System.Drawing.Point(249, 139);
            this.panelChart_DDA.Name = "panelChart_DDA";
            this.panelChart_DDA.Size = new System.Drawing.Size(1223, 687);
            this.panelChart_DDA.TabIndex = 2;
            // 
            // chartResult_DDA
            // 
            this.chartResult_DDA.BackColor = System.Drawing.Color.Snow;
            chartArea3.Name = "ChartArea1";
            this.chartResult_DDA.ChartAreas.Add(chartArea3);
            this.chartResult_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartResult_DDA.Legends.Add(legend3);
            this.chartResult_DDA.Location = new System.Drawing.Point(0, 0);
            this.chartResult_DDA.Name = "chartResult_DDA";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartResult_DDA.Series.Add(series3);
            this.chartResult_DDA.Size = new System.Drawing.Size(1223, 687);
            this.chartResult_DDA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 826);
            this.Controls.Add(this.panelChart_DDA);
            this.Controls.Add(this.panelOutPut_DDA);
            this.Controls.Add(this.panelTask_DDA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 6 | Дёмин Д. А.";
            this.panelTask_DDA.ResumeLayout(false);
            this.groupBoxCondition_DDA.ResumeLayout(false);
            this.groupBoxCondition_DDA.PerformLayout();
            this.panelOutPut_DDA.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_DDA)).EndInit();
            this.panelChart_DDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_DDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_DDA;
        private System.Windows.Forms.Button buttonOpenFile_DDA;
        private System.Windows.Forms.Button buttonDone_DDA;
        private System.Windows.Forms.TextBox textBoxCondition_DDA;
        private System.Windows.Forms.Panel panelOutPut_DDA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewResult_DDA;
        private System.Windows.Forms.Panel panelChart_DDA;
        private System.Windows.Forms.Button buttonInfo_DDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_DDA;
        private System.Windows.Forms.GroupBox groupBoxCondition_DDA;
    }
}

