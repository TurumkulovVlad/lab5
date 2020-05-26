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
            System.Windows.Forms.Label id_posLabel;
            System.Windows.Forms.Label назва_компаніїLabel;
            System.Windows.Forms.Label ім_я_контактної_особиLabel;
            System.Windows.Forms.Label адресаLabel;
            System.Windows.Forms.Label місто__областьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.kursovaDataSet = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSet();
            this.постачальникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.постачальникиTableAdapter = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.ПостачальникиTableAdapter();
            this.tableAdapterManager = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.TableAdapterManager();
            this.постачальникиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.постачальникиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_posTextBox = new System.Windows.Forms.TextBox();
            this.назва_компаніїTextBox = new System.Windows.Forms.TextBox();
            this.ім_я_контактної_особиTextBox = new System.Windows.Forms.TextBox();
            this.адресаTextBox = new System.Windows.Forms.TextBox();
            this.місто__областьTextBox = new System.Windows.Forms.TextBox();
            id_posLabel = new System.Windows.Forms.Label();
            назва_компаніїLabel = new System.Windows.Forms.Label();
            ім_я_контактної_особиLabel = new System.Windows.Forms.Label();
            адресаLabel = new System.Windows.Forms.Label();
            місто__областьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачальникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачальникиBindingNavigator)).BeginInit();
            this.постачальникиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_posLabel
            // 
            id_posLabel.AutoSize = true;
            id_posLabel.Location = new System.Drawing.Point(12, 47);
            id_posLabel.Name = "id_posLabel";
            id_posLabel.Size = new System.Drawing.Size(108, 13);
            id_posLabel.TabIndex = 1;
            id_posLabel.Text = "Код постачальника:";
            // 
            // назва_компаніїLabel
            // 
            назва_компаніїLabel.AutoSize = true;
            назва_компаніїLabel.Location = new System.Drawing.Point(12, 80);
            назва_компаніїLabel.Name = "назва_компаніїLabel";
            назва_компаніїLabel.Size = new System.Drawing.Size(88, 13);
            назва_компаніїLabel.TabIndex = 3;
            назва_компаніїLabel.Text = "Назва компанії:";
            // 
            // ім_я_контактної_особиLabel
            // 
            ім_я_контактної_особиLabel.AutoSize = true;
            ім_я_контактної_особиLabel.Location = new System.Drawing.Point(264, 37);
            ім_я_контактної_особиLabel.Name = "ім_я_контактної_особиLabel";
            ім_я_контактної_особиLabel.Size = new System.Drawing.Size(120, 13);
            ім_я_контактної_особиLabel.TabIndex = 5;
            ім_я_контактної_особиLabel.Text = "Ім\'я контактної особи:";
            // 
            // адресаLabel
            // 
            адресаLabel.AutoSize = true;
            адресаLabel.Location = new System.Drawing.Point(264, 89);
            адресаLabel.Name = "адресаLabel";
            адресаLabel.Size = new System.Drawing.Size(47, 13);
            адресаLabel.TabIndex = 7;
            адресаLabel.Text = "Адреса:";
            // 
            // місто__областьLabel
            // 
            місто__областьLabel.AutoSize = true;
            місто__областьLabel.Location = new System.Drawing.Point(264, 63);
            місто__областьLabel.Name = "місто__областьLabel";
            місто__областьLabel.Size = new System.Drawing.Size(85, 13);
            місто__областьLabel.TabIndex = 9;
            місто__областьLabel.Text = "Місто, область:";
            // 
            // kursovaDataSet
            // 
            this.kursovaDataSet.DataSetName = "KursovaDataSet";
            this.kursovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // постачальникиBindingSource
            // 
            this.постачальникиBindingSource.DataMember = "Постачальники";
            this.постачальникиBindingSource.DataSource = this.kursovaDataSet;
            // 
            // постачальникиTableAdapter
            // 
            this.постачальникиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВідгукиTableAdapter = null;
            this.tableAdapterManager.МагазиниTableAdapter = null;
            this.tableAdapterManager.ПостачальникиTableAdapter = this.постачальникиTableAdapter;
            this.tableAdapterManager.ПристроїTableAdapter = null;
            this.tableAdapterManager.Технічні_характеристикиTableAdapter = null;
            // 
            // постачальникиBindingNavigator
            // 
            this.постачальникиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.постачальникиBindingNavigator.BindingSource = this.постачальникиBindingSource;
            this.постачальникиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.постачальникиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.постачальникиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.постачальникиBindingNavigatorSaveItem});
            this.постачальникиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.постачальникиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.постачальникиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.постачальникиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.постачальникиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.постачальникиBindingNavigator.Name = "постачальникиBindingNavigator";
            this.постачальникиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.постачальникиBindingNavigator.Size = new System.Drawing.Size(574, 25);
            this.постачальникиBindingNavigator.TabIndex = 0;
            this.постачальникиBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // постачальникиBindingNavigatorSaveItem
            // 
            this.постачальникиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.постачальникиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("постачальникиBindingNavigatorSaveItem.Image")));
            this.постачальникиBindingNavigatorSaveItem.Name = "постачальникиBindingNavigatorSaveItem";
            this.постачальникиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.постачальникиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.постачальникиBindingNavigatorSaveItem.Click += new System.EventHandler(this.постачальникиBindingNavigatorSaveItem_Click);
            // 
            // id_posTextBox
            // 
            this.id_posTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.постачальникиBindingSource, "Id_pos", true));
            this.id_posTextBox.Location = new System.Drawing.Point(138, 47);
            this.id_posTextBox.Name = "id_posTextBox";
            this.id_posTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_posTextBox.TabIndex = 2;
            // 
            // назва_компаніїTextBox
            // 
            this.назва_компаніїTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.постачальникиBindingSource, "Назва компанії", true));
            this.назва_компаніїTextBox.Location = new System.Drawing.Point(138, 73);
            this.назва_компаніїTextBox.Name = "назва_компаніїTextBox";
            this.назва_компаніїTextBox.Size = new System.Drawing.Size(100, 20);
            this.назва_компаніїTextBox.TabIndex = 4;
            // 
            // ім_я_контактної_особиTextBox
            // 
            this.ім_я_контактної_особиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.постачальникиBindingSource, "Ім\'я контактної особи", true));
            this.ім_я_контактної_особиTextBox.Location = new System.Drawing.Point(406, 34);
            this.ім_я_контактної_особиTextBox.Name = "ім_я_контактної_особиTextBox";
            this.ім_я_контактної_особиTextBox.Size = new System.Drawing.Size(165, 20);
            this.ім_я_контактної_особиTextBox.TabIndex = 6;
            // 
            // адресаTextBox
            // 
            this.адресаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.постачальникиBindingSource, "Адреса", true));
            this.адресаTextBox.Location = new System.Drawing.Point(406, 86);
            this.адресаTextBox.Name = "адресаTextBox";
            this.адресаTextBox.Size = new System.Drawing.Size(165, 20);
            this.адресаTextBox.TabIndex = 8;
            // 
            // місто__областьTextBox
            // 
            this.місто__областьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.постачальникиBindingSource, "Місто, область", true));
            this.місто__областьTextBox.Location = new System.Drawing.Point(406, 60);
            this.місто__областьTextBox.Name = "місто__областьTextBox";
            this.місто__областьTextBox.Size = new System.Drawing.Size(165, 20);
            this.місто__областьTextBox.TabIndex = 10;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 114);
            this.Controls.Add(id_posLabel);
            this.Controls.Add(this.id_posTextBox);
            this.Controls.Add(назва_компаніїLabel);
            this.Controls.Add(this.назва_компаніїTextBox);
            this.Controls.Add(ім_я_контактної_особиLabel);
            this.Controls.Add(this.ім_я_контактної_особиTextBox);
            this.Controls.Add(адресаLabel);
            this.Controls.Add(this.адресаTextBox);
            this.Controls.Add(місто__областьLabel);
            this.Controls.Add(this.місто__областьTextBox);
            this.Controls.Add(this.постачальникиBindingNavigator);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Постачальники";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачальникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постачальникиBindingNavigator)).EndInit();
            this.постачальникиBindingNavigator.ResumeLayout(false);
            this.постачальникиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KursovaDataSet kursovaDataSet;
        private System.Windows.Forms.BindingSource постачальникиBindingSource;
        private KursovaDataSetTableAdapters.ПостачальникиTableAdapter постачальникиTableAdapter;
        private KursovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator постачальникиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton постачальникиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_posTextBox;
        private System.Windows.Forms.TextBox назва_компаніїTextBox;
        private System.Windows.Forms.TextBox ім_я_контактної_особиTextBox;
        private System.Windows.Forms.TextBox адресаTextBox;
        private System.Windows.Forms.TextBox місто__областьTextBox;
    }
}