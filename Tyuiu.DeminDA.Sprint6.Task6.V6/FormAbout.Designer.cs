
namespace Tyuiu.DeminDA.Sprint6.Task6.V6
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_DDA = new System.Windows.Forms.PictureBox();
            this.labelInfo_DDA = new System.Windows.Forms.Label();
            this.buttonOk_DDA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_DDA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_DDA
            // 
            this.pictureBoxAvatar_DDA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_DDA.Image")));
            this.pictureBoxAvatar_DDA.Location = new System.Drawing.Point(0, 12);
            this.pictureBoxAvatar_DDA.Name = "pictureBoxAvatar_DDA";
            this.pictureBoxAvatar_DDA.Size = new System.Drawing.Size(286, 249);
            this.pictureBoxAvatar_DDA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_DDA.TabIndex = 0;
            this.pictureBoxAvatar_DDA.TabStop = false;
            // 
            // labelInfo_DDA
            // 
            this.labelInfo_DDA.AutoSize = true;
            this.labelInfo_DDA.Location = new System.Drawing.Point(292, 21);
            this.labelInfo_DDA.Name = "labelInfo_DDA";
            this.labelInfo_DDA.Size = new System.Drawing.Size(363, 153);
            this.labelInfo_DDA.TabIndex = 1;
            this.labelInfo_DDA.Text = resources.GetString("labelInfo_DDA.Text");
            // 
            // buttonOk_DDA
            // 
            this.buttonOk_DDA.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonOk_DDA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOk_DDA.Location = new System.Drawing.Point(546, 204);
            this.buttonOk_DDA.Name = "buttonOk_DDA";
            this.buttonOk_DDA.Size = new System.Drawing.Size(103, 48);
            this.buttonOk_DDA.TabIndex = 2;
            this.buttonOk_DDA.Text = "OK";
            this.buttonOk_DDA.UseVisualStyleBackColor = true;
            this.buttonOk_DDA.Click += new System.EventHandler(this.buttonOk_DDA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 264);
            this.Controls.Add(this.buttonOk_DDA);
            this.Controls.Add(this.labelInfo_DDA);
            this.Controls.Add(this.pictureBoxAvatar_DDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_DDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_DDA;
        private System.Windows.Forms.Label labelInfo_DDA;
        private System.Windows.Forms.Button buttonOk_DDA;
    }
}