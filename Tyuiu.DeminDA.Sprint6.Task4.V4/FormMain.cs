using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DeminDA.Sprint6.Task4.V4.Lib;


namespace Tyuiu.DeminDA.Sprint6.Task4.V4
{
    public partial class FormMain_DDA : Form
    {
        public FormMain_DDA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_DDA_Click(object sender, EventArgs e)
        {

            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_DDA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_DDA.Text);


                int len = ds.GetMassFunction(startStep, stopStep).Length;


                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                //this.chartFunction_DDA.Titles.Add("График функции");

                this.chartFunction_DDA.ChartAreas[0].AxisX.Title = "Ось X";

                this.chartFunction_DDA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_DDA.Text = "";

                chartFunction_DDA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_DDA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_DDA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonSaveFile_DDA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V8.txt";
                File.WriteAllText(path, textBoxResult_DDA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }

            }
            catch
            {
                MessageBox.Show("Сбой сохранения файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_DDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПБ-23-2 Дёмин Денис Александрович", "Сообщение");
        }
    }
}
