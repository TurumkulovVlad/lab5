namespace WindowsFormsApp1
{
    partial class Form22
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
            this.button6 = new System.Windows.Forms.Button();
            this.працівники_ЗапросBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._123DataSet = new WindowsFormsApp1._123DataSet();
            this.tableAdapterManager = new WindowsFormsApp1._123DataSetTableAdapters.TableAdapterManager();
            this.працівники_ЗапросTableAdapter = new WindowsFormsApp1._123DataSetTableAdapters.Працівники_ЗапросTableAdapter();
            this.працівники_ЗапросDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.працівники_ЗапросBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._123DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.працівники_ЗапросDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(25, 323);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "назад";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(500, 323);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "вихід";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // працівники_ЗапросBindingSource
            // 
            this.працівники_ЗапросBindingSource.DataMember = "Працівники Запрос";
            this.працівники_ЗапросBindingSource.DataSource = this._123DataSet;
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
            // працівники_ЗапросTableAdapter
            // 
            this.працівники_ЗапросTableAdapter.ClearBeforeFill = true;
            // 
            // працівники_ЗапросDataGridView
            // 
            this.працівники_ЗапросDataGridView.AutoGenerateColumns = false;
            this.працівники_ЗапросDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.працівники_ЗапросDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.працівники_ЗапросDataGridView.DataSource = this.працівники_ЗапросBindingSource;
            this.працівники_ЗапросDataGridView.Location = new System.Drawing.Point(22, 12);
            this.працівники_ЗапросDataGridView.Name = "працівники_ЗапросDataGridView";
            this.працівники_ЗапросDataGridView.Size = new System.Drawing.Size(553, 220);
            this.працівники_ЗапросDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Прізвище та ініціали";
            this.dataGridViewTextBoxColumn2.HeaderText = "Прізвище та ініціали";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Посада";
            this.dataGridViewTextBoxColumn3.HeaderText = "Посада";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата прийняття на роботу";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата прийняття на роботу";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 417);
            this.Controls.Add(this.працівники_ЗапросDataGridView);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Name = "Form22";
            this.Text = "запит працівники(прийняття2019+)";
            ((System.ComponentModel.ISupportInitialize)(this.працівники_ЗапросBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._123DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.працівники_ЗапросDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource працівники_ЗапросBindingSource;
        private _123DataSet _123DataSet;
        private _123DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _123DataSetTableAdapters.Працівники_ЗапросTableAdapter працівники_ЗапросTableAdapter;
        private System.Windows.Forms.DataGridView працівники_ЗапросDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}