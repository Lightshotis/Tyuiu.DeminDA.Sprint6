using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DeminDA.Sprint6.Task1.V14.Lib;

namespace Tyuiu.DeminDA.Sprint6.Task1.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_DDA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_DDA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;


                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_DDA.Text = "";
                textBoxResult_DDA.AppendText("+-------------+------------+" + Environment.NewLine);
                textBoxResult_DDA.AppendText("|      X      |    f(x)    |" + Environment.NewLine);
                textBoxResult_DDA.AppendText("+-------------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,7:d}      |   {1, 7:f2}  |", startStep, valueArray[i]);
                    textBoxResult_DDA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_DDA.AppendText("+-------------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxCondition_DDA_Click(object sender, EventArgs e)
        {

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПБ-23-2 Дёмин Денис Александрович", "Сообщение");
        }

        private void textBoxStartStep_DDA_Text(object sender, EventArgs e)
        {

        }

        private void textBoxStopStep_DDA__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

        }

    }
}
