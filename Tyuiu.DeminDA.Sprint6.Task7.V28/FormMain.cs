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
using Tyuiu.DeminDA.Sprint6.Task7.V28.Lib;

namespace Tyuiu.DeminDA.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_DDA.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_DDA.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

         static int rows;
         static int columns;
         
         static string openFilePath;
        DataService ds = new DataService();

        public int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;


        }

        private void groupBoxCondition_DDA_Enter(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panelOutPut_DDA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOpenFile_DDA_Click(object sender, EventArgs e)
        {
            openFileDialog_DDA.ShowDialog();
            openFilePath = openFileDialog_DDA.FileName;

            int[,] arrayValues = new int[rows, columns];
                arrayValues= LoadFromFileData(openFilePath);
                dataGridViewIn_DDA.ColumnCount = columns;
                dataGridViewIn_DDA.RowCount = rows;
                dataGridViewOut_DDA.ColumnCount = columns;
                dataGridViewOut_DDA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_DDA.Columns[i].Width = 25;
                dataGridViewOut_DDA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_DDA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_DDA.Enabled=true;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_DDA.ColumnCount = 50;
            dataGridViewOut_DDA.ColumnCount = 50;

            dataGridViewIn_DDA.RowCount = 50;
            dataGridViewOut_DDA.RowCount = 50;

            panelInPut_DDA.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_DDA.Columns[i].Width = 25;
                dataGridViewOut_DDA.Columns[i].Width = 25;
            }
        }



        private void buttonDone_DDA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_DDA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_DDA.Enabled = true;
        }

        private void buttonSaveFile_DDA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_DDA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_DDA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_DDA.ShowDialog();

            string path = saveFileDialogMatrix_DDA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_DDA.RowCount;
            int columns = dataGridViewOut_DDA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_DDA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_DDA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void openFileDialog_DDA_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonInfo_DDA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
