namespace База_даних_пристроїв_супутникового_зв_язку
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            System.Windows.Forms.Label id_pLabel;
            System.Windows.Forms.Label назва_пристроюLabel;
            System.Windows.Forms.Label особливостіLabel;
            System.Windows.Forms.Label габаритиLabel;
            System.Windows.Forms.Label масаLabel;
            System.Windows.Forms.Label час_розмовиLabel;
            System.Windows.Forms.Label клас_захисту_корпусаLabel;
            System.Windows.Forms.Label описLabel;
            this.kursovaDataSet = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSet();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.TableAdapterManager();
            this.dataTable1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_pTextBox = new System.Windows.Forms.TextBox();
            this.назва_пристроюTextBox = new System.Windows.Forms.TextBox();
            this.особливостіTextBox = new System.Windows.Forms.TextBox();
            this.габаритиTextBox = new System.Windows.Forms.TextBox();
            this.масаTextBox = new System.Windows.Forms.TextBox();
            this.час_розмовиTextBox = new System.Windows.Forms.TextBox();
            this.клас_захисту_корпусаTextBox = new System.Windows.Forms.TextBox();
            this.описTextBox = new System.Windows.Forms.TextBox();
            id_pLabel = new System.Windows.Forms.Label();
            назва_пристроюLabel = new System.Windows.Forms.Label();
            особливостіLabel = new System.Windows.Forms.Label();
            габаритиLabel = new System.Windows.Forms.Label();
            масаLabel = new System.Windows.Forms.Label();
            час_розмовиLabel = new System.Windows.Forms.Label();
            клас_захисту_корпусаLabel = new System.Windows.Forms.Label();
            описLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingNavigator)).BeginInit();
            this.dataTable1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // kursovaDataSet
            // 
            this.kursovaDataSet.DataSetName = "KursovaDataSet";
            this.kursovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.kursovaDataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВідгукиTableAdapter = null;
            this.tableAdapterManager.МагазиниTableAdapter = null;
            this.tableAdapterManager.ПостачальникиTableAdapter = null;
            this.tableAdapterManager.ПристроїTableAdapter = null;
            this.tableAdapterManager.Технічні_характеристикиTableAdapter = null;
            // 
            // dataTable1BindingNavigator
            // 
            this.dataTable1BindingNavigator.AddNewItem = null;
            this.dataTable1BindingNavigator.BindingSource = this.dataTable1BindingSource;
            this.dataTable1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataTable1BindingNavigator.DeleteItem = null;
            this.dataTable1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.dataTable1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataTable1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataTable1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataTable1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataTable1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataTable1BindingNavigator.Name = "dataTable1BindingNavigator";
            this.dataTable1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataTable1BindingNavigator.Size = new System.Drawing.Size(720, 25);
            this.dataTable1BindingNavigator.TabIndex = 0;
            this.dataTable1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // id_pLabel
            // 
            id_pLabel.AutoSize = true;
            id_pLabel.Location = new System.Drawing.Point(12, 38);
            id_pLabel.Name = "id_pLabel";
            id_pLabel.Size = new System.Drawing.Size(28, 13);
            id_pLabel.TabIndex = 1;
            id_pLabel.Text = "Id p:";
            // 
            // id_pTextBox
            // 
            this.id_pTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Id_p", true));
            this.id_pTextBox.Location = new System.Drawing.Point(139, 35);
            this.id_pTextBox.Name = "id_pTextBox";
            this.id_pTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_pTextBox.TabIndex = 2;
            // 
            // назва_пристроюLabel
            // 
            назва_пристроюLabel.AutoSize = true;
            назва_пристроюLabel.Location = new System.Drawing.Point(12, 64);
            назва_пристроюLabel.Name = "назва_пристроюLabel";
            назва_пристроюLabel.Size = new System.Drawing.Size(94, 13);
            назва_пристроюLabel.TabIndex = 3;
            назва_пристроюLabel.Text = "Назва пристрою:";
            // 
            // назва_пристроюTextBox
            // 
            this.назва_пристроюTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Назва пристрою", true));
            this.назва_пристроюTextBox.Location = new System.Drawing.Point(139, 61);
            this.назва_пристроюTextBox.Name = "назва_пристроюTextBox";
            this.назва_пристроюTextBox.Size = new System.Drawing.Size(154, 20);
            this.назва_пристроюTextBox.TabIndex = 4;
            // 
            // особливостіLabel
            // 
            особливостіLabel.AutoSize = true;
            особливостіLabel.Location = new System.Drawing.Point(316, 117);
            особливостіLabel.Name = "особливостіLabel";
            особливостіLabel.Size = new System.Drawing.Size(73, 13);
            особливостіLabel.TabIndex = 5;
            особливостіLabel.Text = "Особливості:";
            // 
            // особливостіTextBox
            // 
            this.особливостіTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Особливості", true));
            this.особливостіTextBox.Location = new System.Drawing.Point(395, 64);
            this.особливостіTextBox.Multiline = true;
            this.особливостіTextBox.Name = "особливостіTextBox";
            this.особливостіTextBox.Size = new System.Drawing.Size(314, 125);
            this.особливостіTextBox.TabIndex = 6;
            // 
            // габаритиLabel
            // 
            габаритиLabel.AutoSize = true;
            габаритиLabel.Location = new System.Drawing.Point(12, 91);
            габаритиLabel.Name = "габаритиLabel";
            габаритиLabel.Size = new System.Drawing.Size(57, 13);
            габаритиLabel.TabIndex = 7;
            габаритиLabel.Text = "Габарити:";
            // 
            // габаритиTextBox
            // 
            this.габаритиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Габарити", true));
            this.габаритиTextBox.Location = new System.Drawing.Point(139, 88);
            this.габаритиTextBox.Name = "габаритиTextBox";
            this.габаритиTextBox.Size = new System.Drawing.Size(154, 20);
            this.габаритиTextBox.TabIndex = 8;
            // 
            // масаLabel
            // 
            масаLabel.AutoSize = true;
            масаLabel.Location = new System.Drawing.Point(12, 117);
            масаLabel.Name = "масаLabel";
            масаLabel.Size = new System.Drawing.Size(37, 13);
            масаLabel.TabIndex = 9;
            масаLabel.Text = "Маса:";
            // 
            // масаTextBox
            // 
            this.масаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Маса", true));
            this.масаTextBox.Location = new System.Drawing.Point(139, 114);
            this.масаTextBox.Name = "масаTextBox";
            this.масаTextBox.Size = new System.Drawing.Size(154, 20);
            this.масаTextBox.TabIndex = 10;
            // 
            // час_розмовиLabel
            // 
            час_розмовиLabel.AutoSize = true;
            час_розмовиLabel.Location = new System.Drawing.Point(12, 143);
            час_розмовиLabel.Name = "час_розмовиLabel";
            час_розмовиLabel.Size = new System.Drawing.Size(77, 13);
            час_розмовиLabel.TabIndex = 11;
            час_розмовиLabel.Text = "Час розмови:";
            // 
            // час_розмовиTextBox
            // 
            this.час_розмовиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Час розмови", true));
            this.час_розмовиTextBox.Location = new System.Drawing.Point(139, 140);
            this.час_розмовиTextBox.Name = "час_розмовиTextBox";
            this.час_розмовиTextBox.Size = new System.Drawing.Size(154, 20);
            this.час_розмовиTextBox.TabIndex = 12;
            // 
            // клас_захисту_корпусаLabel
            // 
            клас_захисту_корпусаLabel.AutoSize = true;
            клас_захисту_корпусаLabel.Location = new System.Drawing.Point(12, 169);
            клас_захисту_корпусаLabel.Name = "клас_захисту_корпусаLabel";
            клас_захисту_корпусаLabel.Size = new System.Drawing.Size(121, 13);
            клас_захисту_корпусаLabel.TabIndex = 13;
            клас_захисту_корпусаLabel.Text = "Клас захисту корпуса:";
            // 
            // клас_захисту_корпусаTextBox
            // 
            this.клас_захисту_корпусаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Клас захисту корпуса", true));
            this.клас_захисту_корпусаTextBox.Location = new System.Drawing.Point(139, 166);
            this.клас_захисту_корпусаTextBox.Name = "клас_захисту_корпусаTextBox";
            this.клас_захисту_корпусаTextBox.Size = new System.Drawing.Size(154, 20);
            this.клас_захисту_корпусаTextBox.TabIndex = 14;
            // 
            // описLabel
            // 
            описLabel.AutoSize = true;
            описLabel.Location = new System.Drawing.Point(12, 315);
            описLabel.Name = "описLabel";
            описLabel.Size = new System.Drawing.Size(36, 13);
            описLabel.TabIndex = 15;
            описLabel.Text = "Опис:";
            // 
            // описTextBox
            // 
            this.описTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTable1BindingSource, "Опис", true));
            this.описTextBox.Location = new System.Drawing.Point(139, 217);
            this.описTextBox.Multiline = true;
            this.описTextBox.Name = "описTextBox";
            this.описTextBox.Size = new System.Drawing.Size(570, 221);
            this.описTextBox.TabIndex = 16;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(id_pLabel);
            this.Controls.Add(this.id_pTextBox);
            this.Controls.Add(назва_пристроюLabel);
            this.Controls.Add(this.назва_пристроюTextBox);
            this.Controls.Add(особливостіLabel);
            this.Controls.Add(this.особливостіTextBox);
            this.Controls.Add(габаритиLabel);
            this.Controls.Add(this.габаритиTextBox);
            this.Controls.Add(масаLabel);
            this.Controls.Add(this.масаTextBox);
            this.Controls.Add(час_розмовиLabel);
            this.Controls.Add(this.час_розмовиTextBox);
            this.Controls.Add(клас_захисту_корпусаLabel);
            this.Controls.Add(this.клас_захисту_корпусаTextBox);
            this.Controls.Add(описLabel);
            this.Controls.Add(this.описTextBox);
            this.Controls.Add(this.dataTable1BindingNavigator);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пристрої";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingNavigator)).EndInit();
            this.dataTable1BindingNavigator.ResumeLayout(false);
            this.dataTable1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KursovaDataSet kursovaDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private KursovaDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private KursovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dataTable1BindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox id_pTextBox;
        private System.Windows.Forms.TextBox назва_пристроюTextBox;
        private System.Windows.Forms.TextBox особливостіTextBox;
        private System.Windows.Forms.TextBox габаритиTextBox;
        private System.Windows.Forms.TextBox масаTextBox;
        private System.Windows.Forms.TextBox час_розмовиTextBox;
        private System.Windows.Forms.TextBox клас_захисту_корпусаTextBox;
        private System.Windows.Forms.TextBox описTextBox;
    }
}