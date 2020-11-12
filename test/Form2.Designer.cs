namespace test
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.baseDataSet = new test.BaseDataSet();
            this.списокклиентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_клиентовTableAdapter = new test.BaseDataSetTableAdapters.Список_клиентовTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеФирмыклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОКонтактногоЛицаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокклиентовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.названиеФирмыклиентаDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.фИОКонтактногоЛицаDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.списокклиентовBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 85);
            this.dataGridView1.TabIndex = 0;
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "BaseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // списокклиентовBindingSource
            // 
            this.списокклиентовBindingSource.DataMember = "Список_клиентов";
            this.списокклиентовBindingSource.DataSource = this.baseDataSet;
            // 
            // список_клиентовTableAdapter
            // 
            this.список_клиентовTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // названиеФирмыклиентаDataGridViewTextBoxColumn
            // 
            this.названиеФирмыклиентаDataGridViewTextBoxColumn.DataPropertyName = "название фирмы-клиента";
            this.названиеФирмыклиентаDataGridViewTextBoxColumn.HeaderText = "название фирмы-клиента";
            this.названиеФирмыклиентаDataGridViewTextBoxColumn.Name = "названиеФирмыклиентаDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // фИОКонтактногоЛицаDataGridViewTextBoxColumn
            // 
            this.фИОКонтактногоЛицаDataGridViewTextBoxColumn.DataPropertyName = "ФИО контактного лица";
            this.фИОКонтактногоЛицаDataGridViewTextBoxColumn.HeaderText = "ФИО контактного лица";
            this.фИОКонтактногоЛицаDataGridViewTextBoxColumn.Name = "фИОКонтактногоЛицаDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "e-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "e-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокклиентовBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BaseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource списокклиентовBindingSource;
        private BaseDataSetTableAdapters.Список_клиентовTableAdapter список_клиентовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеФирмыклиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОКонтактногоЛицаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}