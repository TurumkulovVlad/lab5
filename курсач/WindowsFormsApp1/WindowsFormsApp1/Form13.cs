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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Замовлення_запит". При необходимости она может быть перемещена или удалена.
            this.замовлення_запитTableAdapter.Fill(this._123DataSet.Замовлення_запит);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet._Замовлення_запит_300_". При необходимости она может быть перемещена или удалена.
            this.замовлення_запит_300_TableAdapter.Fill(this._123DataSet._Замовлення_запит_300_);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 p = new Form2();
            {
                p.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void замовлення_запит_300_BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void замовлення_запитBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void замовлення_запитDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
