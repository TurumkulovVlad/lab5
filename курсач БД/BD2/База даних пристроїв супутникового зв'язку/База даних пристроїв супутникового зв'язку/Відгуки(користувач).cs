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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void відгукиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.відгукиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovaDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovaDataSet.Відгуки". При необходимости она может быть перемещена или удалена.
            this.відгукиTableAdapter.Fill(this.kursovaDataSet.Відгуки);

        }
    }
}
