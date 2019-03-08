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
    public partial class FrmRecord_Departure : Form
    {
        FrmHome home;
        public FrmRecord_Departure()
        {
            InitializeComponent();
        }
        public FrmRecord_Departure(FrmHome Home)
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
            //validate surname entered
            if (txtSearchLastName.Text.Equals(""))
            {
                MessageBox.Show("must be entered");
                txtSearchLastName.Focus();
                return;

            }
            else
            {


                //get the booking and customer details for todays arrivals using surname
                DataSet ds = new DataSet();
                grdCustDetails.DataSource = Booking.getArrivals(ds, txtSearchLastName.Text.ToUpper()).Tables["custSearch"];
                if (grdCustDetails.Rows.Count == 1)
                {
                    MessageBox.Show("No Customers in the system with that last name arriving today", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //display bookings
                grpBookingsDetails.Visible = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String kennelID = grdCustDetails.Rows[grdCustDetails.CurrentCell.RowIndex].Cells[5].Value.ToString();
            String BookingID = grdCustDetails.Rows[grdCustDetails.CurrentCell.RowIndex].Cells[0].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("ARe you sure you want to cancel this booking", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                char kennelStatus = 'A';
                char BookingStatus = 'D';
                //update kennel file
                kennel.updateKennelStatus(Convert.ToInt32(kennelID),kennelStatus);
                //update booking file
                Booking.updateBookingStatus(Convert.ToInt32(BookingID),BookingStatus);

                //display conf message
                MessageBox.Show("Customer Departed, Kennel ready to use again","Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);

                //reset UI
                grpBookingsDetails.Visible = false;
                txtSearchLastName.Clear();
                txtSearchLastName.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Departure canceled", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpBookingsDetails.Visible = false;
                txtSearchLastName.Clear();
                txtSearchLastName.Focus();
                return;
            }
        }

   
    }
}
