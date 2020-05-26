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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet._Замовлення_запит_300_". При необходимости она может быть перемещена или удалена.
            this.замовлення_запит_300_TableAdapter.Fill(this._123DataSet._Замовлення_запит_300_);

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
