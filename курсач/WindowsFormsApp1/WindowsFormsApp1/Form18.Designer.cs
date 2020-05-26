namespace WindowsFormsApp1
{
    partial class Form18
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
            this._123DataSet = new WindowsFormsApp1._123DataSet();
            this.замовлення_запит_300_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.замовлення_запит_300_TableAdapter = new WindowsFormsApp1._123DataSetTableAdapters.Замовлення_запит_300_TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1._123DataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.замовлення_запитBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.замовлення_запитTableAdapter = new WindowsFormsApp1._123DataSetTableAdapters.Замовлення_запитTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.замовлення_запитDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._123DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовлення_запит_300_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовлення_запитBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовлення_запитDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _123DataSet
            // 
            this._123DataSet.DataSetName = "_123DataSet";
            this._123DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // замовлення_запит_300_BindingSource
            // 
            this.замовлення_запит_300_BindingSource.DataMember = "Замовлення запит 300+";
            this.замовлення_запит_300_BindingSource.DataSource = this._123DataSet;
            // 
            // замовлення_запит_300_TableAdapter
            // 
            this.замовлення_запит_300_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1._123DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗамовленняTableAdapter = null;
            this.tableAdapterManager.КлієнтиTableAdapter = null;
            this.tableAdapterManager.ПослугиTableAdapter = null;
            this.tableAdapterManager.ПрацівникиTableAdapter = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // замовлення_запитBindingSource
            // 
            this.замовлення_запитBindingSource.DataMember = "Замовлення запит";
            this.замовлення_запитBindingSource.DataSource = this._123DataSet;
            // 
            // замовлення_запитTableAdapter
            // 
            this.замовлення_запитTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(567, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "вихід";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Адреса";
            this.dataGridViewTextBoxColumn6.HeaderText = "Адреса";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Клієнт";
            this.dataGridViewTextBoxColumn4.HeaderText = "Клієнт";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Вартість замовлення";
            this.dataGridViewTextBoxColumn3.HeaderText = "Вартість замовлення";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Вид послуги";
            this.dataGridViewTextBoxColumn2.HeaderText = "Вид послуги";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // замовлення_запитDataGridView
            // 
            this.замовлення_запитDataGridView.AutoGenerateColumns = false;
            this.замовлення_запитDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.замовлення_запитDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.замовлення_запитDataGridView.DataSource = this.замовлення_запитBindingSource;
            this.замовлення_запитDataGridView.Location = new System.Drawing.Point(3, 1);
            this.замовлення_запитDataGridView.Name = "замовлення_запитDataGridView";
            this.замовлення_запитDataGridView.Size = new System.Drawing.Size(669, 220);
            this.замовлення_запитDataGridView.TabIndex = 6;
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 336);
            this.Controls.Add(this.замовлення_запитDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Form18";
            this.Text = "Запит замовлення+клієнт";
            ((System.ComponentModel.ISupportInitialize)(this._123DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовлення_запит_300_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовлення_запитBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовлення_запитDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _123DataSet _123DataSet;
        private System.Windows.Forms.BindingSource замовлення_запит_300_BindingSource;
        private _123DataSetTableAdapters.Замовлення_запит_300_TableAdapter замовлення_запит_300_TableAdapter;
        private _123DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource замовлення_запитBindingSource;
        private _123DataSetTableAdapters.Замовлення_запитTableAdapter замовлення_запитTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView замовлення_запитDataGridView;
    }
}