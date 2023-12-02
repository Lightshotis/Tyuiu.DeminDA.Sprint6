using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.DeminDA.Sprint6.Task0.V18.Lib;

namespace Tyuiu.DeminDA.Sprint6.Task0.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void groupBoxDataInPut_DDA_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_DDA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOutPutResult_DDA.Text =
                    Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_DDA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarXInPut_DDA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_DDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПБ-23-2 Дёмин Денис Александрович", "Сообщение");
        }

        private void textBoxOutPutResult_DDA_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxOutPutResult_DDA_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxTaskDDA_Enter(object sender, EventArgs e)
        {

        }
    }
}
