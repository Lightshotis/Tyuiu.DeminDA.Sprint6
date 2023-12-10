
namespace Tyuiu.DeminDA.Sprint6.Task6.V6
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
            this.buttonHelp_DDA = new System.Windows.Forms.Button();
            this.buttonDone_DDA = new System.Windows.Forms.Button();
            this.buttonOpenFileTask_DDA = new System.Windows.Forms.Button();
            this.panelTask_DDA = new System.Windows.Forms.Panel();
            this.textBoxTask_DDA = new System.Windows.Forms.TextBox();
            this.panelInPut_DDA = new System.Windows.Forms.Panel();
            this.textBoxInPut_DDA = new System.Windows.Forms.TextBox();
            this.panelOut_DDA = new System.Windows.Forms.Panel();
            this.textBoxOut_DDA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_DDA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_DDA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxInPut_DDA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_DDA = new System.Windows.Forms.GroupBox();
            this.panelButtons_DDA.SuspendLayout();
            this.panelTask_DDA.SuspendLayout();
            this.panelInPut_DDA.SuspendLayout();
            this.panelOut_DDA.SuspendLayout();
            this.groupBoxInPut_DDA.SuspendLayout();
            this.groupBoxOutPut_DDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_DDA
            // 
            this.panelButtons_DDA.Controls.Add(this.buttonHelp_DDA);
            this.panelButtons_DDA.Controls.Add(this.buttonDone_DDA);
            this.panelButtons_DDA.Controls.Add(this.buttonOpenFileTask_DDA);
            this.panelButtons_DDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_DDA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_DDA.Name = "panelButtons_DDA";
            this.panelButtons_DDA.Size = new System.Drawing.Size(1520, 100);
            this.panelButtons_DDA.TabIndex = 0;
            // 
            // buttonHelp_DDA
            // 
            this.buttonHelp_DDA.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp_DDA.Location = new System.Drawing.Point(1407, 0);
            this.buttonHelp_DDA.Name = "buttonHelp_DDA";
            this.buttonHelp_DDA.Size = new System.Drawing.Size(113, 100);
            this.buttonHelp_DDA.TabIndex = 2;
            this.buttonHelp_DDA.Text = "Информация";
            this.toolTip_DDA.SetToolTip(this.buttonHelp_DDA, "Сведения о программе\r\n");
            this.buttonHelp_DDA.UseVisualStyleBackColor = true;
            this.buttonHelp_DDA.Click += new System.EventHandler(this.buttonHelp_DDA_Click);
            // 
            // buttonDone_DDA
            // 
            this.buttonDone_DDA.Location = new System.Drawing.Point(151, 14);
            this.buttonDone_DDA.Name = "buttonDone_DDA";
            this.buttonDone_DDA.Size = new System.Drawing.Size(143, 83);
            this.buttonDone_DDA.TabIndex = 1;
            this.buttonDone_DDA.Text = "Выполнить";
            this.toolTip_DDA.SetToolTip(this.buttonDone_DDA, "Производит поиск в  файле слов содержащих b и выводит их textBoxOut_DDA");
            this.buttonDone_DDA.UseVisualStyleBackColor = true;
            this.buttonDone_DDA.Click += new System.EventHandler(this.buttonDone_DDA_Click);
            // 
            // buttonOpenFileTask_DDA
            // 
            this.buttonOpenFileTask_DDA.Location = new System.Drawing.Point(3, 14);
            this.buttonOpenFileTask_DDA.Name = "buttonOpenFileTask_DDA";
            this.buttonOpenFileTask_DDA.Size = new System.Drawing.Size(142, 83);
            this.buttonOpenFileTask_DDA.TabIndex = 0;
            this.buttonOpenFileTask_DDA.Text = "Открыть файл";
            this.toolTip_DDA.SetToolTip(this.buttonOpenFileTask_DDA, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFileTask_DDA.UseVisualStyleBackColor = true;
            this.buttonOpenFileTask_DDA.Click += new System.EventHandler(this.buttonOpenFile_DDA_Click);
            // 
            // panelTask_DDA
            // 
            this.panelTask_DDA.Controls.Add(this.textBoxTask_DDA);
            this.panelTask_DDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_DDA.Location = new System.Drawing.Point(0, 100);
            this.panelTask_DDA.Name = "panelTask_DDA";
            this.panelTask_DDA.Size = new System.Drawing.Size(1520, 100);
            this.panelTask_DDA.TabIndex = 1;
            // 
            // textBoxTask_DDA
            // 
            this.textBoxTask_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_DDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_DDA.Location = new System.Drawing.Point(0, 0);
            this.textBoxTask_DDA.Multiline = true;
            this.textBoxTask_DDA.Name = "textBoxTask_DDA";
            this.textBoxTask_DDA.ReadOnly = true;
            this.textBoxTask_DDA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTask_DDA.Size = new System.Drawing.Size(1520, 100);
            this.textBoxTask_DDA.TabIndex = 0;
            this.textBoxTask_DDA.Text = resources.GetString("textBoxTask_DDA.Text");
            // 
            // panelInPut_DDA
            // 
            this.panelInPut_DDA.Controls.Add(this.groupBoxInPut_DDA);
            this.panelInPut_DDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_DDA.Location = new System.Drawing.Point(0, 200);
            this.panelInPut_DDA.Name = "panelInPut_DDA";
            this.panelInPut_DDA.Size = new System.Drawing.Size(773, 624);
            this.panelInPut_DDA.TabIndex = 2;
            // 
            // textBoxInPut_DDA
            // 
            this.textBoxInPut_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInPut_DDA.Location = new System.Drawing.Point(3, 18);
            this.textBoxInPut_DDA.Multiline = true;
            this.textBoxInPut_DDA.Name = "textBoxInPut_DDA";
            this.textBoxInPut_DDA.ReadOnly = true;
            this.textBoxInPut_DDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut_DDA.Size = new System.Drawing.Size(767, 603);
            this.textBoxInPut_DDA.TabIndex = 0;
            // 
            // panelOut_DDA
            // 
            this.panelOut_DDA.Controls.Add(this.groupBoxOutPut_DDA);
            this.panelOut_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOut_DDA.Location = new System.Drawing.Point(773, 200);
            this.panelOut_DDA.Name = "panelOut_DDA";
            this.panelOut_DDA.Size = new System.Drawing.Size(747, 624);
            this.panelOut_DDA.TabIndex = 3;
            // 
            // textBoxOut_DDA
            // 
            this.textBoxOut_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_DDA.Location = new System.Drawing.Point(3, 18);
            this.textBoxOut_DDA.Multiline = true;
            this.textBoxOut_DDA.Name = "textBoxOut_DDA";
            this.textBoxOut_DDA.ReadOnly = true;
            this.textBoxOut_DDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_DDA.Size = new System.Drawing.Size(741, 603);
            this.textBoxOut_DDA.TabIndex = 0;
            this.textBoxOut_DDA.TextChanged += new System.EventHandler(this.textBoxOut_DDA_TextChanged);
            // 
            // openFileDialogTask_DDA
            // 
            this.openFileDialogTask_DDA.FileName = "openFileDialog1";
            // 
            // toolTip_DDA
            // 
            this.toolTip_DDA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_DDA.ToolTipTitle = "Подсказка";
            this.toolTip_DDA.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // groupBoxInPut_DDA
            // 
            this.groupBoxInPut_DDA.Controls.Add(this.textBoxInPut_DDA);
            this.groupBoxInPut_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_DDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_DDA.Name = "groupBoxInPut_DDA";
            this.groupBoxInPut_DDA.Size = new System.Drawing.Size(773, 624);
            this.groupBoxInPut_DDA.TabIndex = 0;
            this.groupBoxInPut_DDA.TabStop = false;
            this.groupBoxInPut_DDA.Text = "Ввод";
            // 
            // groupBoxOutPut_DDA
            // 
            this.groupBoxOutPut_DDA.Controls.Add(this.textBoxOut_DDA);
            this.groupBoxOutPut_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_DDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_DDA.Name = "groupBoxOutPut_DDA";
            this.groupBoxOutPut_DDA.Size = new System.Drawing.Size(747, 624);
            this.groupBoxOutPut_DDA.TabIndex = 0;
            this.groupBoxOutPut_DDA.TabStop = false;
            this.groupBoxOutPut_DDA.Text = "Вывод:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 824);
            this.Controls.Add(this.panelOut_DDA);
            this.Controls.Add(this.panelInPut_DDA);
            this.Controls.Add(this.panelTask_DDA);
            this.Controls.Add(this.panelButtons_DDA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 6 | Дёмин Д. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons_DDA.ResumeLayout(false);
            this.panelTask_DDA.ResumeLayout(false);
            this.panelTask_DDA.PerformLayout();
            this.panelInPut_DDA.ResumeLayout(false);
            this.panelOut_DDA.ResumeLayout(false);
            this.groupBoxInPut_DDA.ResumeLayout(false);
            this.groupBoxInPut_DDA.PerformLayout();
            this.groupBoxOutPut_DDA.ResumeLayout(false);
            this.groupBoxOutPut_DDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_DDA;
        private System.Windows.Forms.Panel panelTask_DDA;
        private System.Windows.Forms.Panel panelInPut_DDA;
        private System.Windows.Forms.Panel panelOut_DDA;
        private System.Windows.Forms.TextBox textBoxTask_DDA;
        private System.Windows.Forms.TextBox textBoxInPut_DDA;
        private System.Windows.Forms.TextBox textBoxOut_DDA;
        private System.Windows.Forms.Button buttonOpenFileTask_DDA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_DDA;
        private System.Windows.Forms.Button buttonHelp_DDA;
        private System.Windows.Forms.Button buttonDone_DDA;
        private System.Windows.Forms.ToolTip toolTip_DDA;
        private System.Windows.Forms.GroupBox groupBoxInPut_DDA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_DDA;
    }
}

