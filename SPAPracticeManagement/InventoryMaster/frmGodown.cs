using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPAPracticeManagement.InventoryMaster
{
    public partial class frmGodown : Form
    {
        public frmGodown()
        {
            InitializeComponent();
        }

        private void varticalMenu1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {

        }

       

       

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home objHome = new Home();
            objHome.Show();
            this.Hide();
            //this.Parent.FindForm().Hide();
        }

        private void frmGodown_Load(object sender, EventArgs e)
        {
            ActiveControl = ddlBranch;
        }

        private void btnHomeIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
