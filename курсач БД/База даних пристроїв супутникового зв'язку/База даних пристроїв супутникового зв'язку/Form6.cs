﻿using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void магазиниBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.магазиниBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovaDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovaDataSet.Магазини". При необходимости она может быть перемещена или удалена.
            this.магазиниTableAdapter.Fill(this.kursovaDataSet.Магазини);

        }
    }
}
