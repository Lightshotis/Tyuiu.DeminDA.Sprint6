using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DeminDA.Sprint6.Task3.V17.Lib;

namespace Tyuiu.DeminDA.Sprint6.Task3.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private int[,] mtrx = new int[5, 5]
        {
            { 22, 32, -16, 24, 27 },
            { 3, -20, 24, -20, 26 },
            { 21, 17, -8, -19, 17 },
            { 8, 22, 28, 27, 19 },
            { 11, 20, 12, 27, 29 }
        };


        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;


            dataGridViewInPutMatrix_DDA.ColumnCount = columns;
            dataGridViewInPutMatrix_DDA.RowCount = rows;

            //Задаём ширину столбцов
            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutMatrix_DDA.Columns[i].Width = 35;
            }

            // заполняем сетку данными из массива
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewInPutMatrix_DDA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
        private void buttonDone_DDA_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(mtrx);

            int rows = result.GetLength(0);
            int columns = result.GetLength(1);

            dataGridViewOutPutMatrix_DDA.ColumnCount = columns;
            dataGridViewOutPutMatrix_DDA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {

                dataGridViewOutPutMatrix_DDA.Columns[i].Width = 35;

            }

            for (int i = 0; i < rows; i++)
            {
                dataGridViewOutPutMatrix_DDA.Rows[i].Height = 35;
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPutMatrix_DDA.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }
            }

        }


        private void buttonInfo_DDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПБ-23-2 Дёмин Денис Александрович", "Сообщение");
        }

        private void dataGridViewInPutMatrix_DDA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
