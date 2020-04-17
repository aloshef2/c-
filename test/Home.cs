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
    public partial class Form : MetroFramework.Forms.MetroForm
    {
        public Form()
        {
            InitializeComponent();
            customizeDDizign();
        }

        private void customizeDDizign()
        {
            panelapp.Visible = false;
            panelrecipt.Visible = false;
            panelproduct.Visible = false;
        }

        private void hideAppPanel()
        {
            if (panelapp.Visible == true)
            {
                panelrecipt.Visible = false;
                panelproduct.Visible = false;
            }
                
            if (panelrecipt.Visible == true)
            {
                panelproduct.Visible = false;
                panelapp.Visible = false;
            }
                
            if (panelproduct.Visible == true)
            {
                panelrecipt.Visible = false;
                panelapp.Visible = false;
            }
                
        }
        private void showPanel(Panel appMenu)
        {
            if(appMenu.Visible == false)
            {
                hideAppPanel();
                appMenu.Visible = true;
            }
            else
            {
                appMenu.Visible = false;
            }
        }

        private void allapp_Click(object sender, EventArgs e)
        {
            openChildForm(new AllApp());
        }

        private void logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void app_Click(object sender, EventArgs e)
        {
            showPanel(panelapp);
        }

        private void recipt_Click(object sender, EventArgs e)
        {
            showPanel(panelrecipt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private System.Windows.Forms.Form activeForm = null;
        private void openChildForm(System.Windows.Forms.Form childForm)
        {
            if(activeForm!=null)
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.Dock = DockStyle.Fill;

                homePanel.Controls.Add(childForm);
                homePanel.Tag = childForm;

                childForm.BringToFront();
                childForm.Show();
            
        }

        private void appcreate_Click(object sender, EventArgs e)
        {
            openChildForm(new AddApp());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new AllRecipt());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new AddRecipt());
        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void product_Click(object sender, EventArgs e)
        {
            showPanel(panelproduct);
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new AddProduct());
        }

        private void productAll_Click(object sender, EventArgs e)
        {
            openChildForm(new AllProduct());
        }
    }
}
