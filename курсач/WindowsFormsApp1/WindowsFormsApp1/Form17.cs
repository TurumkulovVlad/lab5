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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_123DataSet.Працівники_Запрос". При необходимости она может быть перемещена или удалена.
            this.працівники_ЗапросTableAdapter.Fill(this._123DataSet.Працівники_Запрос);

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
