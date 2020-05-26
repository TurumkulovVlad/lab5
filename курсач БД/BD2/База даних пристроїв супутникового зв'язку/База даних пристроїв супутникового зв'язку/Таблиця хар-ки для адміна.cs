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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void технічні_характеристикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.технічні_характеристикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovaDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovaDataSet.Технічні_характеристики". При необходимости она может быть перемещена или удалена.
            this.технічні_характеристикиTableAdapter.Fill(this.kursovaDataSet.Технічні_характеристики);

        }

        private void id_pTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
