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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Пристрої p = new Пристрої();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 p = new Form4();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 p = new Form5();
            p.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 p = new Form6();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 p = new Form7();
            p.Show();
        }
    }
}
