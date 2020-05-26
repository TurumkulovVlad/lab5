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
    public partial class Пристрої : Form
    {
        public Пристрої()
        {
            InitializeComponent();
        }

        private void технічні_характеристикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        
            this.tableAdapterManager.UpdateAll(this.kursovaDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovaDataSet.Пристрої". При необходимости она может быть перемещена или удалена.
            this.пристроїTableAdapter.Fill(this.kursovaDataSet.Пристрої);
           
         
          
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovaDataSet.Пристрої". При необходимости она может быть перемещена или удалена.
            this.пристроїTableAdapter.Fill(this.kursovaDataSet.Пристрої);
        

        }

        private void пристроїBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пристроїBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovaDataSet);

        }

        private void пристроїBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.пристроїBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovaDataSet);

        }
    }
}
