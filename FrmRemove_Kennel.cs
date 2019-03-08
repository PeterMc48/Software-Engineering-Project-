using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KennelSys
{
    public partial class FrmRemove_Kennel : Form
    {
        FrmHome home;
        public FrmRemove_Kennel()
        {
            InitializeComponent();
        }
        public FrmRemove_Kennel(FrmHome Home)
        {
            InitializeComponent();
            home = Home;
        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            kennel kenneldetails = new kennel();
            kenneldetails.getkennelDetails(Convert.ToInt32(txtID.Text));


            txtKennelDetails.Text = kenneldetails.getKennelID().ToString() + " " + kenneldetails.getKennelType() + " " + kenneldetails.getStatus().ToString();

            grpKennelDetails.Visible = true;

        }

        private void txtKennelDetails_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            kennel updateStatus = new kennel(Convert.ToInt32(txtID.Text),'D');
            updateStatus.decommisionKennel();

            MessageBox.Show("Kennel NO: " +txtID.Text+ " now decommission","Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);

            txtID.Clear();
            txtID.Focus();
            grpKennelDetails.Visible = false;

        }

        private void FrmRemove_Kennel_Load(object sender, EventArgs e)
        {
            grpKennelDetails.Visible = false;
        }

      
    }
}
