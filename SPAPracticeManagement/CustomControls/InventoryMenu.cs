using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPAPracticeManagement.InventoryMaster;
using SPAPracticeManagement.Settings;
namespace SPAPracticeManagement.CustomControls
{
    public partial class InventoryMenu : UserControl
    {
        public InventoryMenu()
        {
            InitializeComponent();
        }

        private void godownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGodown objGodown = new frmGodown();
            objGodown.Show();
            this.Parent.FindForm().Hide();
        }

        private void itemMainGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemMainGroup objItemMainGroup = new frmItemMainGroup();
            objItemMainGroup.Show();
            this.Parent.FindForm().Hide();
        }
    }
}
