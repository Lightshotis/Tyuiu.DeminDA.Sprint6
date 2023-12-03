using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.DeminDA.Sprint6.Task2.V7.Lib;

namespace Tyuiu.DeminDA.Sprint6.Task2.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
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
                this.chartFunction_DDA.Titles.Add("График функции");

                this.chartFunction_DDA.ChartAreas[0].AxisX.Title = "Ось X";

                this.chartFunction_DDA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_DDA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_DDA.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonInfo_DDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПБ-23-2 Дёмин Денис Александрович", "Сообщение");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_DDA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_DDA.BackColor = Color.Red;
        }


        private void buttonDone_DDA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_DDA.BackColor = Color.Blue;
        }

        private void chartFunction_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_DDA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_DDA.BackColor = Color.Green;
        }

        private void textBoxStartStep_DDA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
