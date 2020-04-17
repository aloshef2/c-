namespace test
{
    partial class AddRecipt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ReciptXml = new System.Windows.Forms.DataGridView();
            this.idriceptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riceptarrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riceptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backerDataSet2 = new test.backerDataSet2();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titlericept = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createRicept = new System.Windows.Forms.Button();
            this.backerDataSet1 = new test.backerDataSet1();
            this.reciptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reciptTableAdapter = new test.backerDataSet1TableAdapters.reciptTableAdapter();
            this.riceptTableAdapter = new test.backerDataSet2TableAdapters.riceptTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReciptXml)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reciptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReciptXml
            // 
            this.ReciptXml.AllowUserToOrderColumns = true;
            this.ReciptXml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReciptXml.AutoGenerateColumns = false;
            this.ReciptXml.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReciptXml.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.ReciptXml.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.ReciptXml.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReciptXml.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReciptXml.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReciptXml.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ReciptXml.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReciptXml.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idriceptDataGridViewTextBoxColumn,
            this.titlenameDataGridViewTextBoxColumn,
            this.riceptarrDataGridViewTextBoxColumn});
            this.ReciptXml.DataSource = this.riceptBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReciptXml.DefaultCellStyle = dataGridViewCellStyle2;
            this.ReciptXml.EnableHeadersVisualStyles = false;
            this.ReciptXml.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.ReciptXml.Location = new System.Drawing.Point(53, 192);
            this.ReciptXml.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.ReciptXml.Name = "ReciptXml";
            this.ReciptXml.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReciptXml.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReciptXml.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReciptXml.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ReciptXml.Size = new System.Drawing.Size(604, 267);
            this.ReciptXml.TabIndex = 0;
            // 
            // idriceptDataGridViewTextBoxColumn
            // 
            this.idriceptDataGridViewTextBoxColumn.DataPropertyName = "idricept";
            this.idriceptDataGridViewTextBoxColumn.HeaderText = "idricept";
            this.idriceptDataGridViewTextBoxColumn.Name = "idriceptDataGridViewTextBoxColumn";
            // 
            // titlenameDataGridViewTextBoxColumn
            // 
            this.titlenameDataGridViewTextBoxColumn.DataPropertyName = "titlename";
            this.titlenameDataGridViewTextBoxColumn.HeaderText = "titlename";
            this.titlenameDataGridViewTextBoxColumn.Name = "titlenameDataGridViewTextBoxColumn";
            // 
            // riceptarrDataGridViewTextBoxColumn
            // 
            this.riceptarrDataGridViewTextBoxColumn.DataPropertyName = "riceptarr";
            this.riceptarrDataGridViewTextBoxColumn.HeaderText = "riceptarr";
            this.riceptarrDataGridViewTextBoxColumn.Name = "riceptarrDataGridViewTextBoxColumn";
            // 
            // riceptBindingSource
            // 
            this.riceptBindingSource.DataMember = "ricept";
            this.riceptBindingSource.DataSource = this.backerDataSet2;
            // 
            // backerDataSet2
            // 
            this.backerDataSet2.DataSetName = "backerDataSet2";
            this.backerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTable1.TableName = "ricept";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "riceptProductName";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "riceptValue";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "unit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.titlericept);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 150);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Location = new System.Drawing.Point(57, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(27, 0, 0, 37);
            this.panel2.Size = new System.Drawing.Size(600, 4);
            this.panel2.TabIndex = 3;
            // 
            // titlericept
            // 
            this.titlericept.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.titlericept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titlericept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.titlericept.ForeColor = System.Drawing.Color.White;
            this.titlericept.Location = new System.Drawing.Point(57, 89);
            this.titlericept.Margin = new System.Windows.Forms.Padding(4);
            this.titlericept.Name = "titlericept";
            this.titlericept.Size = new System.Drawing.Size(600, 29);
            this.titlericept.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название рецепта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание рецепта";
            // 
            // createRicept
            // 
            this.createRicept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createRicept.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.createRicept.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.createRicept.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.createRicept.FlatAppearance.BorderSize = 0;
            this.createRicept.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.createRicept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createRicept.ForeColor = System.Drawing.Color.White;
            this.createRicept.Location = new System.Drawing.Point(576, 481);
            this.createRicept.Margin = new System.Windows.Forms.Padding(4);
            this.createRicept.Name = "createRicept";
            this.createRicept.Size = new System.Drawing.Size(100, 28);
            this.createRicept.TabIndex = 4;
            this.createRicept.Text = "Создать";
            this.createRicept.UseVisualStyleBackColor = false;
            this.createRicept.UseWaitCursor = true;
            this.createRicept.Click += new System.EventHandler(this.createRicept_Click);
            // 
            // backerDataSet1
            // 
            this.backerDataSet1.DataSetName = "backerDataSet1";
            this.backerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reciptBindingSource
            // 
            this.reciptBindingSource.DataMember = "recipt";
            this.reciptBindingSource.DataSource = this.backerDataSet1;
            // 
            // reciptTableAdapter
            // 
            this.reciptTableAdapter.ClearBeforeFill = true;
            // 
            // riceptTableAdapter
            // 
            this.riceptTableAdapter.ClearBeforeFill = true;
            // 
            // AddRecipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(725, 522);
            this.Controls.Add(this.createRicept);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReciptXml);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddRecipt";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReciptXml)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reciptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReciptXml;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox titlericept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createRicept;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private backerDataSet1 backerDataSet1;
        private System.Windows.Forms.BindingSource reciptBindingSource;
        private backerDataSet1TableAdapters.reciptTableAdapter reciptTableAdapter;
        private backerDataSet2 backerDataSet2;
        private System.Windows.Forms.BindingSource riceptBindingSource;
        private backerDataSet2TableAdapters.riceptTableAdapter riceptTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idriceptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn riceptarrDataGridViewTextBoxColumn;
    }
}