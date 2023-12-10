
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_DDA = new System.Windows.Forms.Panel();
            this.panelInPut_DDA = new System.Windows.Forms.Panel();
            this.panelOutPut_DDA = new System.Windows.Forms.Panel();
            this.panelTask_DDA = new System.Windows.Forms.Panel();
            this.groupBoxCondition_DDA = new System.Windows.Forms.GroupBox();
            this.labelCondition_DDA = new System.Windows.Forms.Label();
            this.panelButtons_DDA.SuspendLayout();
            this.groupBoxCondition_DDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_DDA
            // 
            this.panelButtons_DDA.Controls.Add(this.groupBoxCondition_DDA);
            this.panelButtons_DDA.Controls.Add(this.panelTask_DDA);
            this.panelButtons_DDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_DDA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_DDA.Name = "panelButtons_DDA";
            this.panelButtons_DDA.Size = new System.Drawing.Size(1340, 286);
            this.panelButtons_DDA.TabIndex = 0;
            // 
            // panelInPut_DDA
            // 
            this.panelInPut_DDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_DDA.Location = new System.Drawing.Point(0, 286);
            this.panelInPut_DDA.Name = "panelInPut_DDA";
            this.panelInPut_DDA.Size = new System.Drawing.Size(637, 571);
            this.panelInPut_DDA.TabIndex = 1;
            // 
            // panelOutPut_DDA
            // 
            this.panelOutPut_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_DDA.Location = new System.Drawing.Point(637, 286);
            this.panelOutPut_DDA.Name = "panelOutPut_DDA";
            this.panelOutPut_DDA.Size = new System.Drawing.Size(703, 571);
            this.panelOutPut_DDA.TabIndex = 2;
            // 
            // panelTask_DDA
            // 
            this.panelTask_DDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_DDA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_DDA.Name = "panelTask_DDA";
            this.panelTask_DDA.Size = new System.Drawing.Size(1340, 177);
            this.panelTask_DDA.TabIndex = 0;
            // 
            // groupBoxCondition_DDA
            // 
            this.groupBoxCondition_DDA.Controls.Add(this.labelCondition_DDA);
            this.groupBoxCondition_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCondition_DDA.Location = new System.Drawing.Point(0, 177);
            this.groupBoxCondition_DDA.Name = "groupBoxCondition_DDA";
            this.groupBoxCondition_DDA.Size = new System.Drawing.Size(1340, 109);
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 857);
            this.Controls.Add(this.panelOutPut_DDA);
            this.Controls.Add(this.panelInPut_DDA);
            this.Controls.Add(this.panelButtons_DDA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 28 | Дёмин Д. А.";
            this.panelButtons_DDA.ResumeLayout(false);
            this.groupBoxCondition_DDA.ResumeLayout(false);
            this.groupBoxCondition_DDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_DDA;
        private System.Windows.Forms.GroupBox groupBoxCondition_DDA;
        private System.Windows.Forms.Label labelCondition_DDA;
        private System.Windows.Forms.Panel panelTask_DDA;
        private System.Windows.Forms.Panel panelInPut_DDA;
        private System.Windows.Forms.Panel panelOutPut_DDA;
    }
}

