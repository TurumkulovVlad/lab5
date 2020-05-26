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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void замовленняBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.замовленняBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._123DataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Замовлення". При необходимости она может быть перемещена или удалена.
            this.замовленняTableAdapter.Fill(this._123DataSet.Замовлення);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Замовлення". При необходимости она может быть перемещена или удалена.
            this.замовленняTableAdapter.Fill(this._123DataSet.Замовлення);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 p = new Form2();
            {
                p.Show();
                Hide();
            }
        }

        private void замовленняBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.замовленняBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._123DataSet);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 p = new Form2();
            {
                p.Show();
                Hide();
            }
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
