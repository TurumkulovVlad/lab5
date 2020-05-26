using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace База_даних_пристроїв_супутникового_зв_язку
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 n = new Form10();
            n.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 n = new Form12();
            n.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 n = new Form9();
            n.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 n = new Form6();
            n.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovaDataSet.DataTable2". При необходимости она может быть перемещена или удалена.
            this.dataTable2TableAdapter.Fill(this.kursovaDataSet.DataTable2);

        }
    }
}
