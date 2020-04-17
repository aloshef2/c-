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
    public partial class AllProduct : MetroFramework.Forms.MetroForm
    {
        public AllProduct()
        {
            InitializeComponent();
        }

        private void AllProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "backerDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.backerDataSet.Product);

        }
    }
}
