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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void замовленняBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.замовленняBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._123DataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Замовлення". При необходимости она может быть перемещена или удалена.
            this.замовленняTableAdapter.Fill(this._123DataSet.Замовлення);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 p = new Form4();
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
