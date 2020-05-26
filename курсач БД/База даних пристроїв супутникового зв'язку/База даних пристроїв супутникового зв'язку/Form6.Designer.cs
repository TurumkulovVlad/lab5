namespace База_даних_пристроїв_супутникового_зв_язку
{
    partial class Form6
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
            System.Windows.Forms.Label id_mLabel;
            System.Windows.Forms.Label магазиниLabel;
            System.Windows.Forms.Label містоLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.kursovaDataSet = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSet();
            this.магазиниBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.магазиниTableAdapter = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.МагазиниTableAdapter();
            this.tableAdapterManager = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.TableAdapterManager();
            this.магазиниBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_mTextBox = new System.Windows.Forms.TextBox();
            this.магазиниTextBox = new System.Windows.Forms.TextBox();
            this.містоTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.магазиниBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            id_mLabel = new System.Windows.Forms.Label();
            магазиниLabel = new System.Windows.Forms.Label();
            містоLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазиниBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазиниBindingNavigator)).BeginInit();
            this.магазиниBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // kursovaDataSet
            // 
            this.kursovaDataSet.DataSetName = "KursovaDataSet";
            this.kursovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // магазиниBindingSource
            // 
            this.магазиниBindingSource.DataMember = "Магазини";
            this.магазиниBindingSource.DataSource = this.kursovaDataSet;
            // 
            // магазиниTableAdapter
            // 
            this.магазиниTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВідгукиTableAdapter = null;
            this.tableAdapterManager.МагазиниTableAdapter = this.магазиниTableAdapter;
            this.tableAdapterManager.ПостачальникиTableAdapter = null;
            this.tableAdapterManager.ПристроїTableAdapter = null;
            this.tableAdapterManager.Технічні_характеристикиTableAdapter = null;
            // 
            // магазиниBindingNavigator
            // 
            this.магазиниBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.магазиниBindingNavigator.BindingSource = this.магазиниBindingSource;
            this.магазиниBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.магазиниBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.магазиниBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.магазиниBindingNavigatorSaveItem});
            this.магазиниBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.магазиниBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.магазиниBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.магазиниBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.магазиниBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.магазиниBindingNavigator.Name = "магазиниBindingNavigator";
            this.магазиниBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.магазиниBindingNavigator.Size = new System.Drawing.Size(282, 25);
            this.магазиниBindingNavigator.TabIndex = 0;
            this.магазиниBindingNavigator.Text = "bindingNavigator1";
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
            // id_mLabel
            // 
            id_mLabel.AutoSize = true;
            id_mLabel.Location = new System.Drawing.Point(6, 31);
            id_mLabel.Name = "id_mLabel";
            id_mLabel.Size = new System.Drawing.Size(30, 13);
            id_mLabel.TabIndex = 1;
            id_mLabel.Text = "Id m:";
            // 
            // id_mTextBox
            // 
            this.id_mTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.магазиниBindingSource, "Id_m", true));
            this.id_mTextBox.Location = new System.Drawing.Point(72, 28);
            this.id_mTextBox.Name = "id_mTextBox";
            this.id_mTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_mTextBox.TabIndex = 2;
            // 
            // магазиниLabel
            // 
            магазиниLabel.AutoSize = true;
            магазиниLabel.Location = new System.Drawing.Point(6, 57);
            магазиниLabel.Name = "магазиниLabel";
            магазиниLabel.Size = new System.Drawing.Size(60, 13);
            магазиниLabel.TabIndex = 3;
            магазиниLabel.Text = "Магазини:";
            // 
            // магазиниTextBox
            // 
            this.магазиниTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.магазиниBindingSource, "Магазини", true));
            this.магазиниTextBox.Location = new System.Drawing.Point(72, 54);
            this.магазиниTextBox.Name = "магазиниTextBox";
            this.магазиниTextBox.Size = new System.Drawing.Size(100, 20);
            this.магазиниTextBox.TabIndex = 4;
            // 
            // містоLabel
            // 
            містоLabel.AutoSize = true;
            містоLabel.Location = new System.Drawing.Point(6, 83);
            містоLabel.Name = "містоLabel";
            містоLabel.Size = new System.Drawing.Size(38, 13);
            містоLabel.TabIndex = 5;
            містоLabel.Text = "Місто:";
            // 
            // містоTextBox
            // 
            this.містоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.магазиниBindingSource, "Місто", true));
            this.містоTextBox.Location = new System.Drawing.Point(72, 80);
            this.містоTextBox.Name = "містоTextBox";
            this.містоTextBox.Size = new System.Drawing.Size(100, 20);
            this.містоTextBox.TabIndex = 6;
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
            // магазиниBindingNavigatorSaveItem
            // 
            this.магазиниBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.магазиниBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("магазиниBindingNavigatorSaveItem.Image")));
            this.магазиниBindingNavigatorSaveItem.Name = "магазиниBindingNavigatorSaveItem";
            this.магазиниBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.магазиниBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.магазиниBindingNavigatorSaveItem.Click += new System.EventHandler(this.магазиниBindingNavigatorSaveItem_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 111);
            this.Controls.Add(id_mLabel);
            this.Controls.Add(this.id_mTextBox);
            this.Controls.Add(магазиниLabel);
            this.Controls.Add(this.магазиниTextBox);
            this.Controls.Add(містоLabel);
            this.Controls.Add(this.містоTextBox);
            this.Controls.Add(this.магазиниBindingNavigator);
            this.Name = "Form6";
            this.Text = "Магазини";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазиниBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.магазиниBindingNavigator)).EndInit();
            this.магазиниBindingNavigator.ResumeLayout(false);
            this.магазиниBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KursovaDataSet kursovaDataSet;
        private System.Windows.Forms.BindingSource магазиниBindingSource;
        private KursovaDataSetTableAdapters.МагазиниTableAdapter магазиниTableAdapter;
        private KursovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator магазиниBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton магазиниBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_mTextBox;
        private System.Windows.Forms.TextBox магазиниTextBox;
        private System.Windows.Forms.TextBox містоTextBox;
    }
}