using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Tyuiu.DeminDA.Sprint6.Task5.V6.Lib;
using System.IO;

namespace Tyuiu.DeminDA.Sprint6.Task5.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds= new DataService();

        private string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V6.txt";
        private void buttonDone_DDA_Click(object sender, EventArgs e)
        {
            dataGridViewResult_DDA.ColumnCount = 2;
            dataGridViewResult_DDA.Columns[0].Width = 20;
            dataGridViewResult_DDA.Columns[1].Width = 50;

            this.chartResult_DDA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_DDA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_DDA.Series[0].Points.Clear();

            double[] numMass =  new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult_DDA.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartResult_DDA.Series[0].Points.AddXY(i, numMass[i]);
            }
            

        }

        private void buttonInfo_DDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПБ-23-2 Дёмин Денис Александрович", "Сообщение");
        }

        private void buttonOpenFile_DDA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void dataGridViewResult_DDA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
