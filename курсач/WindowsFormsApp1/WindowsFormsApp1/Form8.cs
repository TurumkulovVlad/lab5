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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Клієнти". При необходимости она может быть перемещена или удалена.
            this.клієнтиTableAdapter.Fill(this._123DataSet.Клієнти);

        }

        private void клієнтиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клієнтиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._123DataSet);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 p = new Form2();
            {
                p.Show();
                Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
