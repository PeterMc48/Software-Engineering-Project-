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
    public partial class FrmCancel_Booking : Form
    {
        FrmHome home;
        public FrmCancel_Booking()
        {
            InitializeComponent();
        }
        public FrmCancel_Booking(FrmHome Home)
        {
            InitializeComponent();
            home = Home;
        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            //find customer in database
            grdCustDetails.Visible = false;

            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Please enter surname to search", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            DataSet ds = new DataSet();
            grdCustDetails.DataSource = Booking.getCustsByname(ds, txtSearch.Text.ToUpper()).Tables["custSearch"];


            if (grdCustDetails.Rows.Count == 1)
            {
                MessageBox.Show("No Customers Found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            grdCustDetails.Visible = true;

            //make customer search visable
        }

     
        private void btnConfirmCancel_Click(object sender, EventArgs e)
        {
                //confirm the right customer
                DialogResult dialogResult = MessageBox.Show("ARe you sure you want to cancel this booking", "Conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    //remove booking from booking file
                    String BookingID = grdCustDetails.Rows[grdCustDetails.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    Booking.cancelBooking(Convert.ToInt32(BookingID));

                    //confirmation message
                    MessageBox.Show("Booking has been removed", "Conformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clear UI
                    grdCustDetails.Visible = false;
                    txtSearch.Focus();
                    txtSearch.Clear();
                }
            else
            {
                txtSearch.Focus();
                txtSearch.Clear();
                grdCustDetails.Visible = false;
                return;
            }
            
            
        }

     
    }
}
