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
    public partial class Вхід : Form
    {
        public Вхід()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 p = new Form1();
            Користувач p1 = new Користувач();
            ERROR p2 = new ERROR();
            Form11 p3 = new Form11();
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            if ((t1 == "admin") && (t2 == "admin"))
            {
                p.Show();
                Hide();
            }
            else if ((t1 == "manager") && (t2 == "1234"))
            {
                p3.Show();
                Hide();
            }
            else if ((t1 == "user") && (t2 == "user1"))
            {
                p1.Show();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Допомога p = new Допомога();
            p.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
