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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void пристроїBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пристроїBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovaDataSet.Пристрої". При необходимости она может быть перемещена или удалена.
            this.пристроїTableAdapter.Fill(this.kursovaDataSet.Пристрої);

        }

        private void особливостіTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
