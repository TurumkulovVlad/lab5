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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 p = new Form2();
            Form3 p2 = new Form3();
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            if ((t1 == "admin") && (t2 == "admin"))
            {
                p.Show();
                Hide();
            }
            else
            {
                p2.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 p = new Form4();
            {
                p.Show();
                Hide();
            }        }
    }
}
