﻿namespace База_даних_пристроїв_супутникового_зв_язку
{
    partial class Form8
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
            System.Windows.Forms.Label ім_я_користувачаLabel;
            System.Windows.Forms.Label відгукLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.kursovaDataSet = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSet();
            this.відгукиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.відгукиTableAdapter = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.ВідгукиTableAdapter();
            this.tableAdapterManager = new База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.TableAdapterManager();
            this.відгукиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.відгукиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_pTextBox = new System.Windows.Forms.TextBox();
            this.ім_я_користувачаTextBox = new System.Windows.Forms.TextBox();
            this.відгукTextBox = new System.Windows.Forms.TextBox();
            id_pLabel = new System.Windows.Forms.Label();
            ім_я_користувачаLabel = new System.Windows.Forms.Label();
            відгукLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.відгукиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.відгукиBindingNavigator)).BeginInit();
            this.відгукиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_pLabel
            // 
            id_pLabel.AutoSize = true;
            id_pLabel.Location = new System.Drawing.Point(12, 31);
            id_pLabel.Name = "id_pLabel";
            id_pLabel.Size = new System.Drawing.Size(81, 13);
            id_pLabel.TabIndex = 1;
            id_pLabel.Text = "Код пристрою:";
            // 
            // ім_я_користувачаLabel
            // 
            ім_я_користувачаLabel.AutoSize = true;
            ім_я_користувачаLabel.Location = new System.Drawing.Point(12, 85);
            ім_я_користувачаLabel.Name = "ім_я_користувачаLabel";
            ім_я_користувачаLabel.Size = new System.Drawing.Size(95, 13);
            ім_я_користувачаLabel.TabIndex = 3;
            ім_я_користувачаLabel.Text = "Ім\'я користувача:";
            // 
            // відгукLabel
            // 
            відгукLabel.AutoSize = true;
            відгукLabel.Location = new System.Drawing.Point(219, 52);
            відгукLabel.Name = "відгукLabel";
            відгукLabel.Size = new System.Drawing.Size(41, 13);
            відгукLabel.TabIndex = 5;
            відгукLabel.Text = "Відгук:";
            // 
            // kursovaDataSet
            // 
            this.kursovaDataSet.DataSetName = "KursovaDataSet";
            this.kursovaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // відгукиBindingSource
            // 
            this.відгукиBindingSource.DataMember = "Відгуки";
            this.відгукиBindingSource.DataSource = this.kursovaDataSet;
            // 
            // відгукиTableAdapter
            // 
            this.відгукиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = База_даних_пристроїв_супутникового_зв_язку.KursovaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВідгукиTableAdapter = this.відгукиTableAdapter;
            this.tableAdapterManager.МагазиниTableAdapter = null;
            this.tableAdapterManager.ПостачальникиTableAdapter = null;
            this.tableAdapterManager.ПристроїTableAdapter = null;
            this.tableAdapterManager.Технічні_характеристикиTableAdapter = null;
            // 
            // відгукиBindingNavigator
            // 
            this.відгукиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.відгукиBindingNavigator.BindingSource = this.відгукиBindingSource;
            this.відгукиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.відгукиBindingNavigator.DeleteItem = null;
            this.відгукиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.відгукиBindingNavigatorSaveItem});
            this.відгукиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.відгукиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.відгукиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.відгукиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.відгукиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.відгукиBindingNavigator.Name = "відгукиBindingNavigator";
            this.відгукиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.відгукиBindingNavigator.Size = new System.Drawing.Size(451, 25);
            this.відгукиBindingNavigator.TabIndex = 0;
            this.відгукиBindingNavigator.Text = "bindingNavigator1";
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
            // відгукиBindingNavigatorSaveItem
            // 
            this.відгукиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.відгукиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("відгукиBindingNavigatorSaveItem.Image")));
            this.відгукиBindingNavigatorSaveItem.Name = "відгукиBindingNavigatorSaveItem";
            this.відгукиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.відгукиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.відгукиBindingNavigatorSaveItem.Click += new System.EventHandler(this.відгукиBindingNavigatorSaveItem_Click);
            // 
            // id_pTextBox
            // 
            this.id_pTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.відгукиBindingSource, "Id_p", true));
            this.id_pTextBox.Location = new System.Drawing.Point(113, 31);
            this.id_pTextBox.Name = "id_pTextBox";
            this.id_pTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_pTextBox.TabIndex = 2;
            // 
            // ім_я_користувачаTextBox
            // 
            this.ім_я_користувачаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.відгукиBindingSource, "Ім\'я користувача", true));
            this.ім_я_користувачаTextBox.Location = new System.Drawing.Point(113, 82);
            this.ім_я_користувачаTextBox.Name = "ім_я_користувачаTextBox";
            this.ім_я_користувачаTextBox.Size = new System.Drawing.Size(100, 20);
            this.ім_я_користувачаTextBox.TabIndex = 4;
            // 
            // відгукTextBox
            // 
            this.відгукTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.відгукиBindingSource, "Відгук", true));
            this.відгукTextBox.Location = new System.Drawing.Point(266, 28);
            this.відгукTextBox.Multiline = true;
            this.відгукTextBox.Name = "відгукTextBox";
            this.відгукTextBox.Size = new System.Drawing.Size(173, 74);
            this.відгукTextBox.TabIndex = 6;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 121);
            this.Controls.Add(id_pLabel);
            this.Controls.Add(this.id_pTextBox);
            this.Controls.Add(ім_я_користувачаLabel);
            this.Controls.Add(this.ім_я_користувачаTextBox);
            this.Controls.Add(відгукLabel);
            this.Controls.Add(this.відгукTextBox);
            this.Controls.Add(this.відгукиBindingNavigator);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Відгуки";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.відгукиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.відгукиBindingNavigator)).EndInit();
            this.відгукиBindingNavigator.ResumeLayout(false);
            this.відгукиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KursovaDataSet kursovaDataSet;
        private System.Windows.Forms.BindingSource відгукиBindingSource;
        private KursovaDataSetTableAdapters.ВідгукиTableAdapter відгукиTableAdapter;
        private KursovaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator відгукиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton відгукиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_pTextBox;
        private System.Windows.Forms.TextBox ім_я_користувачаTextBox;
        private System.Windows.Forms.TextBox відгукTextBox;
    }
}