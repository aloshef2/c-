namespace test
{
    partial class AddProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContentAdd = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backerDataSet = new test.backerDataSet();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTableProduct = new System.Data.DataTable();
            this.nameProduct = new System.Data.DataColumn();
            this.unitProduct = new System.Data.DataColumn();
            this.productTableAdapter = new test.backerDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new test.backerDataSetTableAdapters.TableAdapterManager();
            this.idproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panelContentAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContentAdd
            // 
            this.panelContentAdd.Controls.Add(this.button1);
            this.panelContentAdd.Controls.Add(this.dataGridView1);
            this.panelContentAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentAdd.Location = new System.Drawing.Point(0, 0);
            this.panelContentAdd.Name = "panelContentAdd";
            this.panelContentAdd.Size = new System.Drawing.Size(800, 454);
            this.panelContentAdd.TabIndex = 1;
            this.panelContentAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContentAdd_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduct,
            this.nameProductDataGridViewTextBoxColumn,
            this.unitProductDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(563, 147);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productBindingSource
            // 
            this.productBindingSource.AllowNew = true;
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.backerDataSet;
            this.productBindingSource.CurrentItemChanged += new System.EventHandler(this.productBindingSource_CurrentItemChanged);
            // 
            // backerDataSet
            // 
            this.backerDataSet.DataSetName = "backerDataSet";
            this.backerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableProduct});
            // 
            // dataTableProduct
            // 
            this.dataTableProduct.Columns.AddRange(new System.Data.DataColumn[] {
            this.nameProduct,
            this.unitProduct});
            this.dataTableProduct.TableName = "product";
            // 
            // nameProduct
            // 
            this.nameProduct.ColumnName = "Название";
            // 
            // unitProduct
            // 
            this.unitProduct.ColumnName = "Еденици измерения";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = true;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = test.backerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete;
            // 
            // idproduct
            // 
            this.idproduct.DataPropertyName = "idproduct";
            dataGridViewCellStyle1.NullValue = "int";
            this.idproduct.DefaultCellStyle = dataGridViewCellStyle1;
            this.idproduct.HeaderText = "idproduct";
            this.idproduct.Name = "idproduct";
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            this.nameProductDataGridViewTextBoxColumn.DataPropertyName = "nameProduct";
            this.nameProductDataGridViewTextBoxColumn.HeaderText = "nameProduct";
            this.nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            // 
            // unitProductDataGridViewTextBoxColumn
            // 
            this.unitProductDataGridViewTextBoxColumn.DataPropertyName = "unitProduct";
            this.unitProductDataGridViewTextBoxColumn.HeaderText = "unitProduct";
            this.unitProductDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "кг",
            "грамм",
            "шт"});
            this.unitProductDataGridViewTextBoxColumn.Name = "unitProductDataGridViewTextBoxColumn";
            this.unitProductDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitProductDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.panelContentAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProduct_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddProduct_FormClosed);
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.panelContentAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContentAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTableProduct;
        private System.Data.DataColumn nameProduct;
        private System.Data.DataColumn unitProduct;
        private backerDataSet backerDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private backerDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private backerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitProductDataGridViewTextBoxColumn;
    }
}