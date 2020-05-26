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
    public partial class Користувач : Form
    {
        public Користувач()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 p = new Form8();
            p.Show();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 n = new Form7();
            n.Show();
        }

        private void Користувач_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovaDataSet.Відгуки". При необходимости она может быть перемещена или удалена.
            this.відгукиTableAdapter.Fill(this.kursovaDataSet.Відгуки);

        }
    }
}
