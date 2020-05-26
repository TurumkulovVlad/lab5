namespace WindowsFormsApp1
{
    partial class Form19
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
            this.button5 = new System.Windows.Forms.Button();
            this.замовлення_запит_300_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._123DataSet = new WindowsFormsApp1._123DataSet();
            this.tableAdapterManager = new WindowsFormsApp1._123DataSetTableAdapters.TableAdapterManager();
            this.замовлення_запит_300_TableAdapter = new WindowsFormsApp1._123DataSetTableAdapters.Замовлення_запит_300_TableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.замовлення_запит_300_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.замовлення_запит_300_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._123DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовлення_запит_300_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 312);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "назад";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // замовлення_запит_300_BindingSource
            // 
            this.замовлення_запит_300_BindingSource.DataMember = "Замовлення запит 300+";
            this.замовлення_запит_300_BindingSource.DataSource = this._123DataSet;
            // 
            // _123DataSet
            // 
            this._123DataSet.DataSetName = "_123DataSet";
            this._123DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // замовлення_запит_300_TableAdapter
            // 
            this.замовлення_запит_300_TableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(576, 312);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "вихід";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // замовлення_запит_300_DataGridView
            // 
            this.замовлення_запит_300_DataGridView.AutoGenerateColumns = false;
            this.замовлення_запит_300_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.замовлення_запит_300_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.замовлення_запит_300_DataGridView.DataSource = this.замовлення_запит_300_BindingSource;
            this.замовлення_запит_300_DataGridView.Location = new System.Drawing.Point(4, 12);
            this.замовлення_запит_300_DataGridView.Name = "замовлення_запит_300_DataGridView";
            this.замовлення_запит_300_DataGridView.Size = new System.Drawing.Size(655, 220);
            this.замовлення_запит_300_DataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Вид послуги";
            this.dataGridViewTextBoxColumn2.HeaderText = "Вид послуги";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Вартість замовлення";
            this.dataGridViewTextBoxColumn3.HeaderText = "Вартість замовлення";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата замовлення";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата замовлення";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Працівник";
            this.dataGridViewTextBoxColumn5.HeaderText = "Працівник";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Клієнт";
            this.dataGridViewTextBoxColumn6.HeaderText = "Клієнт";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 355);
            this.Controls.Add(this.замовлення_запит_300_DataGridView);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Name = "Form19";
            this.Text = "запит вартість >300";
            ((System.ComponentModel.ISupportInitialize)(this.замовлення_запит_300_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._123DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.замовлення_запит_300_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource замовлення_запит_300_BindingSource;
        private _123DataSet _123DataSet;
        private _123DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _123DataSetTableAdapters.Замовлення_запит_300_TableAdapter замовлення_запит_300_TableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView замовлення_запит_300_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}