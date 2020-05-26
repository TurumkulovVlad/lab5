namespace База_даних_пристроїв_супутникового_зв_язку
{
    partial class Form4
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
            System.Windows.Forms.Label id_pLabel;
            System.Windows.Forms.Label габаритиLabel;
            System.Windows.Forms.Label масаLabel;
            System.Windows.Forms.Label час_розмовиLabel;
            System.Windows.Forms.Label клас_захисту_корпусаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.kursovaDataSet = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSet();
            this.технічні_характеристикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.технічні_характеристикиTableAdapter = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.Технічні_характеристикиTableAdapter();
            this.tableAdapterManager = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.TableAdapterManager();
            this.технічні_характеристикиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_pTextBox = new System.Windows.Forms.TextBox();
            this.габаритиTextBox = new System.Windows.Forms.TextBox();
            this.масаTextBox = new System.Windows.Forms.TextBox();
            this.час_розмовиTextBox = new System.Windows.Forms.TextBox();
            this.клас_захисту_корпусаTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.технічні_характеристикиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            id_pLabel = new System.Windows.Forms.Label();
            габаритиLabel = new System.Windows.Forms.Label();
            масаLabel = new System.Windows.Forms.Label();
            час_розмовиLabel = new System.Windows.Forms.Label();
            клас_захисту_корпусаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.технічні_характеристикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.технічні_характеристикиBindingNavigator)).BeginInit();
            this.технічні_характеристикиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // kursovaDataSet
            // 
            this.kursovaDataSet.DataSetName = "KursovaDataSet";
            this.kursovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // технічні_характеристикиBindingSource
            // 
            this.технічні_характеристикиBindingSource.DataMember = "Технічні характеристики";
            this.технічні_характеристикиBindingSource.DataSource = this.kursovaDataSet;
            // 
            // технічні_характеристикиTableAdapter
            // 
            this.технічні_характеристикиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВідгукиTableAdapter = null;
            this.tableAdapterManager.МагазиниTableAdapter = null;
            this.tableAdapterManager.ПостачальникиTableAdapter = null;
            this.tableAdapterManager.ПристроїTableAdapter = null;
            this.tableAdapterManager.Технічні_характеристикиTableAdapter = this.технічні_характеристикиTableAdapter;
            // 
            // технічні_характеристикиBindingNavigator
            // 
            this.технічні_характеристикиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.технічні_характеристикиBindingNavigator.BindingSource = this.технічні_характеристикиBindingSource;
            this.технічні_характеристикиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.технічні_характеристикиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.технічні_характеристикиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.технічні_характеристикиBindingNavigatorSaveItem});
            this.технічні_характеристикиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.технічні_характеристикиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.технічні_характеристикиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.технічні_характеристикиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.технічні_характеристикиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.технічні_характеристикиBindingNavigator.Name = "технічні_характеристикиBindingNavigator";
            this.технічні_характеристикиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.технічні_характеристикиBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.технічні_характеристикиBindingNavigator.TabIndex = 0;
            this.технічні_характеристикиBindingNavigator.Text = "bindingNavigator1";
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
            this.id_pTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.технічні_характеристикиBindingSource, "Id_p", true));
            this.id_pTextBox.Location = new System.Drawing.Point(139, 35);
            this.id_pTextBox.Name = "id_pTextBox";
            this.id_pTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_pTextBox.TabIndex = 2;
            // 
            // габаритиLabel
            // 
            габаритиLabel.AutoSize = true;
            габаритиLabel.Location = new System.Drawing.Point(12, 64);
            габаритиLabel.Name = "габаритиLabel";
            габаритиLabel.Size = new System.Drawing.Size(57, 13);
            габаритиLabel.TabIndex = 3;
            габаритиLabel.Text = "Габарити:";
            // 
            // габаритиTextBox
            // 
            this.габаритиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.технічні_характеристикиBindingSource, "Габарити", true));
            this.габаритиTextBox.Location = new System.Drawing.Point(139, 61);
            this.габаритиTextBox.Name = "габаритиTextBox";
            this.габаритиTextBox.Size = new System.Drawing.Size(100, 20);
            this.габаритиTextBox.TabIndex = 4;
            // 
            // масаLabel
            // 
            масаLabel.AutoSize = true;
            масаLabel.Location = new System.Drawing.Point(12, 90);
            масаLabel.Name = "масаLabel";
            масаLabel.Size = new System.Drawing.Size(37, 13);
            масаLabel.TabIndex = 5;
            масаLabel.Text = "Маса:";
            // 
            // масаTextBox
            // 
            this.масаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.технічні_характеристикиBindingSource, "Маса", true));
            this.масаTextBox.Location = new System.Drawing.Point(139, 87);
            this.масаTextBox.Name = "масаTextBox";
            this.масаTextBox.Size = new System.Drawing.Size(100, 20);
            this.масаTextBox.TabIndex = 6;
            // 
            // час_розмовиLabel
            // 
            час_розмовиLabel.AutoSize = true;
            час_розмовиLabel.Location = new System.Drawing.Point(12, 116);
            час_розмовиLabel.Name = "час_розмовиLabel";
            час_розмовиLabel.Size = new System.Drawing.Size(77, 13);
            час_розмовиLabel.TabIndex = 7;
            час_розмовиLabel.Text = "Час розмови:";
            // 
            // час_розмовиTextBox
            // 
            this.час_розмовиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.технічні_характеристикиBindingSource, "Час розмови", true));
            this.час_розмовиTextBox.Location = new System.Drawing.Point(139, 113);
            this.час_розмовиTextBox.Name = "час_розмовиTextBox";
            this.час_розмовиTextBox.Size = new System.Drawing.Size(100, 20);
            this.час_розмовиTextBox.TabIndex = 8;
            // 
            // клас_захисту_корпусаLabel
            // 
            клас_захисту_корпусаLabel.AutoSize = true;
            клас_захисту_корпусаLabel.Location = new System.Drawing.Point(12, 142);
            клас_захисту_корпусаLabel.Name = "клас_захисту_корпусаLabel";
            клас_захисту_корпусаLabel.Size = new System.Drawing.Size(121, 13);
            клас_захисту_корпусаLabel.TabIndex = 9;
            клас_захисту_корпусаLabel.Text = "Клас захисту корпуса:";
            // 
            // клас_захисту_корпусаTextBox
            // 
            this.клас_захисту_корпусаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.технічні_характеристикиBindingSource, "Клас захисту корпуса", true));
            this.клас_захисту_корпусаTextBox.Location = new System.Drawing.Point(139, 139);
            this.клас_захисту_корпусаTextBox.Name = "клас_захисту_корпусаTextBox";
            this.клас_захисту_корпусаTextBox.Size = new System.Drawing.Size(100, 20);
            this.клас_захисту_корпусаTextBox.TabIndex = 10;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // технічні_характеристикиBindingNavigatorSaveItem
            // 
            this.технічні_характеристикиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.технічні_характеристикиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("технічні_характеристикиBindingNavigatorSaveItem.Image")));
            this.технічні_характеристикиBindingNavigatorSaveItem.Name = "технічні_характеристикиBindingNavigatorSaveItem";
            this.технічні_характеристикиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.технічні_характеристикиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.технічні_характеристикиBindingNavigatorSaveItem.Click += new System.EventHandler(this.технічні_характеристикиBindingNavigatorSaveItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 172);
            this.Controls.Add(id_pLabel);
            this.Controls.Add(this.id_pTextBox);
            this.Controls.Add(габаритиLabel);
            this.Controls.Add(this.габаритиTextBox);
            this.Controls.Add(масаLabel);
            this.Controls.Add(this.масаTextBox);
            this.Controls.Add(час_розмовиLabel);
            this.Controls.Add(this.час_розмовиTextBox);
            this.Controls.Add(клас_захисту_корпусаLabel);
            this.Controls.Add(this.клас_захисту_корпусаTextBox);
            this.Controls.Add(this.технічні_характеристикиBindingNavigator);
            this.Name = "Form4";
            this.Text = "Технічні характеристики";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.технічні_характеристикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.технічні_характеристикиBindingNavigator)).EndInit();
            this.технічні_характеристикиBindingNavigator.ResumeLayout(false);
            this.технічні_характеристикиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KursovaDataSet kursovaDataSet;
        private System.Windows.Forms.BindingSource технічні_характеристикиBindingSource;
        private KursovaDataSetTableAdapters.Технічні_характеристикиTableAdapter технічні_характеристикиTableAdapter;
        private KursovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator технічні_характеристикиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton технічні_характеристикиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_pTextBox;
        private System.Windows.Forms.TextBox габаритиTextBox;
        private System.Windows.Forms.TextBox масаTextBox;
        private System.Windows.Forms.TextBox час_розмовиTextBox;
        private System.Windows.Forms.TextBox клас_захисту_корпусаTextBox;
    }
}