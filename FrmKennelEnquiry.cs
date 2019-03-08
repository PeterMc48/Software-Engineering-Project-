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
    public partial class FrmKennelEnquiry : Form
    {
        FrmHome home;
        public FrmKennelEnquiry()
        {
            InitializeComponent();
        }
        public FrmKennelEnquiry(FrmHome Home)
        {
            InitializeComponent();

            home = Home;
        }

        private void FrmKennelEnquiry_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            String Status = "";
            grdKennels.DataSource = kennel.getktype(ds, Status).Tables["kt"];
        }

        private void radAvailable_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            String Status = "";
            if (radAvailable.Checked)
            {
                Status = "A";
            }
            grdKennels.DataSource = kennel.getktype(ds, Status).Tables["kt"];
        }

        private void radDecommissioned_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            String Status = " ";
            if (radDecommissioned.Checked)
            {
                Status = "D";
            }
            grdKennels.DataSource = kennel.getktype(ds, Status).Tables["kt"];
        }

        private void rabAll_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            String Status = "";
            grdKennels.DataSource = kennel.getktype(ds, Status).Tables["kt"];
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }
    }
}
