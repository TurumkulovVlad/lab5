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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void постачальникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.постачальникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovaDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovaDataSet.Постачальники". При необходимости она может быть перемещена или удалена.
            this.постачальникиTableAdapter.Fill(this.kursovaDataSet.Постачальники);

        }
    }
}
