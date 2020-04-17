using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class AddProduct : MetroFramework.Forms.MetroForm
    {
        public AddProduct()
        {
            InitializeComponent();
        }


        private void panelContentAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            productTableAdapter.Update(backerDataSet);
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows[i].Cells[0].Value = i;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void AddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void productBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            productTableAdapter.Update(backerDataSet);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.FillBy(this.backerDataSet.Product);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
