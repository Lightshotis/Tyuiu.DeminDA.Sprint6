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
using Tyuiu.DeminDA.Sprint6.Task6.V6.Lib;

namespace Tyuiu.DeminDA.Sprint6.Task6.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private string openFilePath;
        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_DDA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_DDA.ShowDialog();
            openFilePath = openFileDialogTask_DDA.FileName;
            textBoxInPut_DDA.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_DDA.Text = groupBoxInPut_DDA.Text+ " " + openFileDialogTask_DDA.FileName;
            buttonDone_DDA.Enabled = true;
        }

        private void buttonDone_DDA_Click(object sender, EventArgs e)
        {
            textBoxOut_DDA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void buttonHelp_DDA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void textBoxOut_DDA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
