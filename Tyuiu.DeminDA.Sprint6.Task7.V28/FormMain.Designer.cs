
namespace Tyuiu.DeminDA.Sprint6.Task7.V28
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_DDA = new System.Windows.Forms.Panel();
            this.groupBoxCondition_DDA = new System.Windows.Forms.GroupBox();
            this.labelCondition_DDA = new System.Windows.Forms.Label();
            this.panelTask_DDA = new System.Windows.Forms.Panel();
            this.buttonInfo_DDA = new System.Windows.Forms.Button();
            this.buttonSaveFile_DDA = new System.Windows.Forms.Button();
            this.buttonDone_DDA = new System.Windows.Forms.Button();
            this.buttonOpenFile_DDA = new System.Windows.Forms.Button();
            this.panelOutPut_DDA = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_DDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_DDA = new System.Windows.Forms.DataGridView();
            this.panelInPut_DDA = new System.Windows.Forms.Panel();
            this.groupBoxInPut_DDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_DDA = new System.Windows.Forms.DataGridView();
            this.openFileDialog_DDA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_DDA = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_DDA = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtons_DDA.SuspendLayout();
            this.groupBoxCondition_DDA.SuspendLayout();
            this.panelTask_DDA.SuspendLayout();
            this.panelOutPut_DDA.SuspendLayout();
            this.groupBoxOutPut_DDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_DDA)).BeginInit();
            this.panelInPut_DDA.SuspendLayout();
            this.groupBoxInPut_DDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_DDA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_DDA
            // 
            this.panelButtons_DDA.Controls.Add(this.groupBoxCondition_DDA);
            this.panelButtons_DDA.Controls.Add(this.panelTask_DDA);
            this.panelButtons_DDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_DDA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_DDA.Name = "panelButtons_DDA";
            this.panelButtons_DDA.Size = new System.Drawing.Size(1340, 252);
            this.panelButtons_DDA.TabIndex = 0;
            // 
            // groupBoxCondition_DDA
            // 
            this.groupBoxCondition_DDA.Controls.Add(this.labelCondition_DDA);
            this.groupBoxCondition_DDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCondition_DDA.Location = new System.Drawing.Point(0, 138);
            this.groupBoxCondition_DDA.Name = "groupBoxCondition_DDA";
            this.groupBoxCondition_DDA.Size = new System.Drawing.Size(1340, 106);
            this.groupBoxCondition_DDA.TabIndex = 1;
            this.groupBoxCondition_DDA.TabStop = false;
            this.groupBoxCondition_DDA.Text = "Условие:";
            this.groupBoxCondition_DDA.Enter += new System.EventHandler(this.groupBoxCondition_DDA_Enter);
            // 
            // labelCondition_DDA
            // 
            this.labelCondition_DDA.AutoSize = true;
            this.labelCondition_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCondition_DDA.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCondition_DDA.Location = new System.Drawing.Point(3, 18);
            this.labelCondition_DDA.Name = "labelCondition_DDA";
            this.labelCondition_DDA.Size = new System.Drawing.Size(1242, 69);
            this.labelCondition_DDA.TabIndex = 0;
            this.labelCondition_DDA.Text = resources.GetString("labelCondition_DDA.Text");
            // 
            // panelTask_DDA
            // 
            this.panelTask_DDA.Controls.Add(this.buttonInfo_DDA);
            this.panelTask_DDA.Controls.Add(this.buttonSaveFile_DDA);
            this.panelTask_DDA.Controls.Add(this.buttonDone_DDA);
            this.panelTask_DDA.Controls.Add(this.buttonOpenFile_DDA);
            this.panelTask_DDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_DDA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_DDA.Name = "panelTask_DDA";
            this.panelTask_DDA.Size = new System.Drawing.Size(1340, 138);
            this.panelTask_DDA.TabIndex = 0;
            // 
            // buttonInfo_DDA
            // 
            this.buttonInfo_DDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_DDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_DDA.Image")));
            this.buttonInfo_DDA.Location = new System.Drawing.Point(1215, 33);
            this.buttonInfo_DDA.Name = "buttonInfo_DDA";
            this.buttonInfo_DDA.Size = new System.Drawing.Size(115, 83);
            this.buttonInfo_DDA.TabIndex = 3;
            this.buttonInfo_DDA.UseVisualStyleBackColor = true;
            this.buttonInfo_DDA.Click += new System.EventHandler(this.buttonInfo_DDA_Click);
            // 
            // buttonSaveFile_DDA
            // 
            this.buttonSaveFile_DDA.Enabled = false;
            this.buttonSaveFile_DDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_DDA.Image")));
            this.buttonSaveFile_DDA.Location = new System.Drawing.Point(289, 33);
            this.buttonSaveFile_DDA.Name = "buttonSaveFile_DDA";
            this.buttonSaveFile_DDA.Size = new System.Drawing.Size(124, 83);
            this.buttonSaveFile_DDA.TabIndex = 2;
            this.toolTipButton_DDA.SetToolTip(this.buttonSaveFile_DDA, " Сохранить результат в файл OutPutFileTask7.csv через saveFileDialog.\r\n\r\n\r\n");
            this.buttonSaveFile_DDA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_DDA.Click += new System.EventHandler(this.buttonSaveFile_DDA_Click);
            // 
            // buttonDone_DDA
            // 
            this.buttonDone_DDA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDone_DDA.Enabled = false;
            this.buttonDone_DDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_DDA.Image")));
            this.buttonDone_DDA.Location = new System.Drawing.Point(156, 33);
            this.buttonDone_DDA.Name = "buttonDone_DDA";
            this.buttonDone_DDA.Size = new System.Drawing.Size(111, 83);
            this.buttonDone_DDA.TabIndex = 1;
            this.toolTipButton_DDA.SetToolTip(this.buttonDone_DDA, "Изменить в седьмой строке числа не равные 13 на 0. Результат вывести в объект dat" +
        "aGridViewOut.");
            this.buttonDone_DDA.UseVisualStyleBackColor = true;
            this.buttonDone_DDA.Click += new System.EventHandler(this.buttonDone_DDA_Click);
            // 
            // buttonOpenFile_DDA
            // 
            this.buttonOpenFile_DDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_DDA.Image")));
            this.buttonOpenFile_DDA.Location = new System.Drawing.Point(29, 33);
            this.buttonOpenFile_DDA.Name = "buttonOpenFile_DDA";
            this.buttonOpenFile_DDA.Size = new System.Drawing.Size(107, 83);
            this.buttonOpenFile_DDA.TabIndex = 0;
            this.toolTipButton_DDA.SetToolTip(this.buttonOpenFile_DDA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_DDA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_DDA.Click += new System.EventHandler(this.buttonOpenFile_DDA_Click);
            // 
            // panelOutPut_DDA
            // 
            this.panelOutPut_DDA.Controls.Add(this.groupBoxOutPut_DDA);
            this.panelOutPut_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_DDA.Location = new System.Drawing.Point(677, 252);
            this.panelOutPut_DDA.Name = "panelOutPut_DDA";
            this.panelOutPut_DDA.Size = new System.Drawing.Size(663, 536);
            this.panelOutPut_DDA.TabIndex = 2;
            this.panelOutPut_DDA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOutPut_DDA_Paint);
            // 
            // groupBoxOutPut_DDA
            // 
            this.groupBoxOutPut_DDA.Controls.Add(this.dataGridViewOut_DDA);
            this.groupBoxOutPut_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_DDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_DDA.Name = "groupBoxOutPut_DDA";
            this.groupBoxOutPut_DDA.Size = new System.Drawing.Size(663, 536);
            this.groupBoxOutPut_DDA.TabIndex = 0;
            this.groupBoxOutPut_DDA.TabStop = false;
            this.groupBoxOutPut_DDA.Text = "Вывод:";
            // 
            // dataGridViewOut_DDA
            // 
            this.dataGridViewOut_DDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_DDA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOut_DDA.Name = "dataGridViewOut_DDA";
            this.dataGridViewOut_DDA.RowHeadersVisible = false;
            this.dataGridViewOut_DDA.RowHeadersWidth = 51;
            this.dataGridViewOut_DDA.RowTemplate.Height = 24;
            this.dataGridViewOut_DDA.Size = new System.Drawing.Size(657, 515);
            this.dataGridViewOut_DDA.TabIndex = 0;
            // 
            // panelInPut_DDA
            // 
            this.panelInPut_DDA.Controls.Add(this.groupBoxInPut_DDA);
            this.panelInPut_DDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_DDA.Location = new System.Drawing.Point(0, 252);
            this.panelInPut_DDA.Name = "panelInPut_DDA";
            this.panelInPut_DDA.Size = new System.Drawing.Size(677, 536);
            this.panelInPut_DDA.TabIndex = 3;
            // 
            // groupBoxInPut_DDA
            // 
            this.groupBoxInPut_DDA.Controls.Add(this.dataGridViewIn_DDA);
            this.groupBoxInPut_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_DDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_DDA.Name = "groupBoxInPut_DDA";
            this.groupBoxInPut_DDA.Size = new System.Drawing.Size(677, 536);
            this.groupBoxInPut_DDA.TabIndex = 0;
            this.groupBoxInPut_DDA.TabStop = false;
            this.groupBoxInPut_DDA.Text = "Ввод:";
            // 
            // dataGridViewIn_DDA
            // 
            this.dataGridViewIn_DDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_DDA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewIn_DDA.Name = "dataGridViewIn_DDA";
            this.dataGridViewIn_DDA.RowHeadersVisible = false;
            this.dataGridViewIn_DDA.RowHeadersWidth = 51;
            this.dataGridViewIn_DDA.RowTemplate.Height = 24;
            this.dataGridViewIn_DDA.Size = new System.Drawing.Size(671, 515);
            this.dataGridViewIn_DDA.TabIndex = 0;
            // 
            // openFileDialog_DDA
            // 
            this.openFileDialog_DDA.FileName = "openFileDialog1";
            this.openFileDialog_DDA.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_DDA_FileOk);
            // 
            // toolTipButton_DDA
            // 
            this.toolTipButton_DDA.IsBalloon = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 788);
            this.Controls.Add(this.panelOutPut_DDA);
            this.Controls.Add(this.panelInPut_DDA);
            this.Controls.Add(this.panelButtons_DDA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 28 | Дёмин Д. А.";
            this.panelButtons_DDA.ResumeLayout(false);
            this.groupBoxCondition_DDA.ResumeLayout(false);
            this.groupBoxCondition_DDA.PerformLayout();
            this.panelTask_DDA.ResumeLayout(false);
            this.panelOutPut_DDA.ResumeLayout(false);
            this.groupBoxOutPut_DDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_DDA)).EndInit();
            this.panelInPut_DDA.ResumeLayout(false);
            this.groupBoxInPut_DDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_DDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_DDA;
        private System.Windows.Forms.GroupBox groupBoxCondition_DDA;
        private System.Windows.Forms.Label labelCondition_DDA;
        private System.Windows.Forms.Panel panelTask_DDA;
        private System.Windows.Forms.Panel panelOutPut_DDA;
        private System.Windows.Forms.Panel panelInPut_DDA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_DDA;
        private System.Windows.Forms.DataGridView dataGridViewOut_DDA;
        private System.Windows.Forms.GroupBox groupBoxInPut_DDA;
        private System.Windows.Forms.DataGridView dataGridViewIn_DDA;
        private System.Windows.Forms.Button buttonDone_DDA;
        private System.Windows.Forms.Button buttonOpenFile_DDA;
        private System.Windows.Forms.Button buttonInfo_DDA;
        private System.Windows.Forms.Button buttonSaveFile_DDA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_DDA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_DDA;
        private System.Windows.Forms.ToolTip toolTipButton_DDA;
    }
}

