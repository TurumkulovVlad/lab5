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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovaDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.kursovaDataSet.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovaDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.kursovaDataSet.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovaDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.kursovaDataSet.DataTable1);

        }
    }
}
