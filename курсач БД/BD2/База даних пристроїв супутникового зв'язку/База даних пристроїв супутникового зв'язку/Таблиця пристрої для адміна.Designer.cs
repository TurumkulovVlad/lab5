namespace База_даних_пристроїв_супутникового_зв_язку
{
    partial class Form2
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
            System.Windows.Forms.Label id_posLabel;
            System.Windows.Forms.Label id_mLabel;
            System.Windows.Forms.Label назва_пристроюLabel;
            System.Windows.Forms.Label особливостіLabel;
            System.Windows.Forms.Label описLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.kursovaDataSet = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSet();
            this.пристроїBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пристроїTableAdapter = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.ПристроїTableAdapter();
            this.tableAdapterManager = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.TableAdapterManager();
            this.пристроїBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.пристроїBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_pTextBox = new System.Windows.Forms.TextBox();
            this.id_posTextBox = new System.Windows.Forms.TextBox();
            this.id_mTextBox = new System.Windows.Forms.TextBox();
            this.назва_пристроюTextBox = new System.Windows.Forms.TextBox();
            this.особливостіTextBox = new System.Windows.Forms.TextBox();
            this.описTextBox = new System.Windows.Forms.TextBox();
            id_pLabel = new System.Windows.Forms.Label();
            id_posLabel = new System.Windows.Forms.Label();
            id_mLabel = new System.Windows.Forms.Label();
            назва_пристроюLabel = new System.Windows.Forms.Label();
            особливостіLabel = new System.Windows.Forms.Label();
            описLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пристроїBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пристроїBindingNavigator)).BeginInit();
            this.пристроїBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_pLabel
            // 
            id_pLabel.AutoSize = true;
            id_pLabel.Location = new System.Drawing.Point(12, 25);
            id_pLabel.Name = "id_pLabel";
            id_pLabel.Size = new System.Drawing.Size(81, 13);
            id_pLabel.TabIndex = 1;
            id_pLabel.Text = "Код пристрою:";
            // 
            // id_posLabel
            // 
            id_posLabel.AutoSize = true;
            id_posLabel.Location = new System.Drawing.Point(12, 51);
            id_posLabel.Name = "id_posLabel";
            id_posLabel.Size = new System.Drawing.Size(108, 13);
            id_posLabel.TabIndex = 3;
            id_posLabel.Text = "Код постачальника:";
            // 
            // id_mLabel
            // 
            id_mLabel.AutoSize = true;
            id_mLabel.Location = new System.Drawing.Point(12, 77);
            id_mLabel.Name = "id_mLabel";
            id_mLabel.Size = new System.Drawing.Size(80, 13);
            id_mLabel.TabIndex = 5;
            id_mLabel.Text = "Код магазину:";
            // 
            // назва_пристроюLabel
            // 
            назва_пристроюLabel.AutoSize = true;
            назва_пристроюLabel.Location = new System.Drawing.Point(12, 103);
            назва_пристроюLabel.Name = "назва_пристроюLabel";
            назва_пристроюLabel.Size = new System.Drawing.Size(94, 13);
            назва_пристроюLabel.TabIndex = 7;
            назва_пристроюLabel.Text = "Назва пристрою:";
            // 
            // особливостіLabel
            // 
            особливостіLabel.AutoSize = true;
            особливостіLabel.Location = new System.Drawing.Point(274, 77);
            особливостіLabel.Name = "особливостіLabel";
            особливостіLabel.Size = new System.Drawing.Size(73, 13);
            особливостіLabel.TabIndex = 9;
            особливостіLabel.Text = "Особливості:";
            // 
            // описLabel
            // 
            описLabel.AutoSize = true;
            описLabel.Location = new System.Drawing.Point(12, 293);
            описLabel.Name = "описLabel";
            описLabel.Size = new System.Drawing.Size(36, 13);
            описLabel.TabIndex = 11;
            описLabel.Text = "Опис:";
            // 
            // kursovaDataSet
            // 
            this.kursovaDataSet.DataSetName = "KursovaDataSet";
            this.kursovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пристроїBindingSource
            // 
            this.пристроїBindingSource.DataMember = "Пристрої";
            this.пристроїBindingSource.DataSource = this.kursovaDataSet;
            // 
            // пристроїTableAdapter
            // 
            this.пристроїTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВідгукиTableAdapter = null;
            this.tableAdapterManager.МагазиниTableAdapter = null;
            this.tableAdapterManager.ПостачальникиTableAdapter = null;
            this.tableAdapterManager.ПристроїTableAdapter = this.пристроїTableAdapter;
            this.tableAdapterManager.Технічні_характеристикиTableAdapter = null;
            // 
            // пристроїBindingNavigator
            // 
            this.пристроїBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.пристроїBindingNavigator.BindingSource = this.пристроїBindingSource;
            this.пристроїBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.пристроїBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.пристроїBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.пристроїBindingNavigatorSaveItem});
            this.пристроїBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.пристроїBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.пристроїBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.пристроїBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.пристроїBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.пристроїBindingNavigator.Name = "пристроїBindingNavigator";
            this.пристроїBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.пристроїBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.пристроїBindingNavigator.TabIndex = 0;
            this.пристроїBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
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
            // пристроїBindingNavigatorSaveItem
            // 
            this.пристроїBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.пристроїBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("пристроїBindingNavigatorSaveItem.Image")));
            this.пристроїBindingNavigatorSaveItem.Name = "пристроїBindingNavigatorSaveItem";
            this.пристроїBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.пристроїBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.пристроїBindingNavigatorSaveItem.Click += new System.EventHandler(this.пристроїBindingNavigatorSaveItem_Click);
            // 
            // id_pTextBox
            // 
            this.id_pTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пристроїBindingSource, "Id_p", true));
            this.id_pTextBox.Location = new System.Drawing.Point(128, 22);
            this.id_pTextBox.Name = "id_pTextBox";
            this.id_pTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_pTextBox.TabIndex = 2;
            // 
            // id_posTextBox
            // 
            this.id_posTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пристроїBindingSource, "Id_pos", true));
            this.id_posTextBox.Location = new System.Drawing.Point(128, 48);
            this.id_posTextBox.Name = "id_posTextBox";
            this.id_posTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_posTextBox.TabIndex = 4;
            // 
            // id_mTextBox
            // 
            this.id_mTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пристроїBindingSource, "Id_m", true));
            this.id_mTextBox.Location = new System.Drawing.Point(128, 74);
            this.id_mTextBox.Name = "id_mTextBox";
            this.id_mTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_mTextBox.TabIndex = 6;
            // 
            // назва_пристроюTextBox
            // 
            this.назва_пристроюTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пристроїBindingSource, "Назва пристрою", true));
            this.назва_пристроюTextBox.Location = new System.Drawing.Point(128, 100);
            this.назва_пристроюTextBox.Name = "назва_пристроюTextBox";
            this.назва_пристроюTextBox.Size = new System.Drawing.Size(129, 20);
            this.назва_пристроюTextBox.TabIndex = 8;
            // 
            // особливостіTextBox
            // 
            this.особливостіTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пристроїBindingSource, "Особливості", true));
            this.особливостіTextBox.Location = new System.Drawing.Point(353, 26);
            this.особливостіTextBox.Multiline = true;
            this.особливостіTextBox.Name = "особливостіTextBox";
            this.особливостіTextBox.Size = new System.Drawing.Size(435, 116);
            this.особливостіTextBox.TabIndex = 10;
            this.особливостіTextBox.TextChanged += new System.EventHandler(this.особливостіTextBox_TextChanged);
            // 
            // описTextBox
            // 
            this.описTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пристроїBindingSource, "Опис", true));
            this.описTextBox.Location = new System.Drawing.Point(54, 148);
            this.описTextBox.Multiline = true;
            this.описTextBox.Name = "описTextBox";
            this.описTextBox.Size = new System.Drawing.Size(734, 290);
            this.описTextBox.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(id_pLabel);
            this.Controls.Add(this.id_pTextBox);
            this.Controls.Add(id_posLabel);
            this.Controls.Add(this.id_posTextBox);
            this.Controls.Add(id_mLabel);
            this.Controls.Add(this.id_mTextBox);
            this.Controls.Add(назва_пристроюLabel);
            this.Controls.Add(this.назва_пристроюTextBox);
            this.Controls.Add(особливостіLabel);
            this.Controls.Add(this.особливостіTextBox);
            this.Controls.Add(описLabel);
            this.Controls.Add(this.описTextBox);
            this.Controls.Add(this.пристроїBindingNavigator);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пристрої";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пристроїBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пристроїBindingNavigator)).EndInit();
            this.пристроїBindingNavigator.ResumeLayout(false);
            this.пристроїBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KursovaDataSet kursovaDataSet;
        private System.Windows.Forms.BindingSource пристроїBindingSource;
        private KursovaDataSetTableAdapters.ПристроїTableAdapter пристроїTableAdapter;
        private KursovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator пристроїBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton пристроїBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_pTextBox;
        private System.Windows.Forms.TextBox id_posTextBox;
        private System.Windows.Forms.TextBox id_mTextBox;
        private System.Windows.Forms.TextBox назва_пристроюTextBox;
        private System.Windows.Forms.TextBox особливостіTextBox;
        private System.Windows.Forms.TextBox описTextBox;
    }
}