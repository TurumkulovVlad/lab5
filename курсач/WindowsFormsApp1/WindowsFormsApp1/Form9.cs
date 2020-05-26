using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void послугиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.послугиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._123DataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Послуги". При необходимости она может быть перемещена или удалена.
            this.послугиTableAdapter.Fill(this._123DataSet.Послуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Послуги". При необходимости она может быть перемещена или удалена.
            this.послугиTableAdapter.Fill(this._123DataSet.Послуги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 p = new Form4();
            {
                p.Show();
                Hide();
            }
        }

        private void послугиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.послугиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._123DataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
