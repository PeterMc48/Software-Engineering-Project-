using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KennelSys
{
    public partial class FrmMake_Booking : Form
    {
        FrmHome home;
        public FrmMake_Booking()
        {
            InitializeComponent();
        }
        public FrmMake_Booking(FrmHome Home)
        {
            InitializeComponent();
            home = Home;
        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            grpAvailableKennels.Visible = false;


            DataSet ds = new DataSet();
            grdAvailableKennels.DataSource = Booking.getKennelDetails(ds, cboKennelTypes.Text, String.Format("{0:dd-MMM-yy}", dtpArrival.Value), String.Format("{0:dd-MMM-yy}", dtpDeparture.Value)).Tables["AvailiableKennels"];
            if (grdAvailableKennels.Rows.Count == 1)
            {
                MessageBox.Show("No kennels available", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            grpAvailableKennels.Visible = true;

            
        }

    

        private void txtBookingID_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMake_Booking_Load(object sender, EventArgs e)
        {
            txtBookingID.Text = Booking.nextBookingID().ToString("00000");
            loadCombo();
            
        }
        public void loadCombo()
        {
            //load combo with kennel type from rates table
            DataSet ds = new DataSet();
            ds = Booking.getktype(ds);

            cboKennelTypes.Items.Clear();
            cboKennelTypes.SelectedIndex = -1;

            for (int i = 0; i < ds.Tables["kt"].Rows.Count; i++)

                cboKennelTypes.Items.Add(ds.Tables[0].Rows[i][0].ToString());
        }

        private void cboKennelTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPickedKennel_Click(object sender, EventArgs e)
        {
            //get kennel type
            String kennelType = cboKennelTypes.Text;

           

            double difference = (dtpDeparture.Value - dtpArrival.Value).TotalDays;
            double cost = difference * Booking.getPrice(kennelType);
            txtCost.Text = cost.ToString("000.00");
            //display the info part
            grpInfo.Visible = true;

        }

        private void grpmake_Enter(object sender, EventArgs e)
        {

        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Equals(""))
            {
                MessageBox.Show("Error!! Please enter First Name", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if(txtLastName.Equals(""))
            {
                MessageBox.Show("Error!! Please enter Last Name", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return;
            }
            if(txtPhoneNo.Equals(""))
            {
                MessageBox.Show("Error!! Please enter Phone Number", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Focus();
                return;
            }
            else
            {
                //Convert.ToInt32(txtPhoneNo);
                foreach (char c in txtPhoneNo.Text)
                {
                    if(c < '0' || c > '9')
                    {
                        MessageBox.Show("Only digits allowed in the phone number field!! Please re enter the number","Error!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txtPhoneNo.Focus();
                        return;
                    }
                }
               
            }
            if(txtEmail.Equals(""))
            {
                MessageBox.Show("Error!! Please enter your email", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else
            {
                if (!Regex.IsMatch(txtEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("Email Invaild!! Please try again", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;

                }
            }
            if(txtBreed.Equals(""))
            {
                MessageBox.Show("Error!! Please enter the dogs breed", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBreed.Focus();
                return;
            }
            if (txtDogName.Equals(""))
            {
                MessageBox.Show("Error!! Please enter dogs name", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDogName.Focus();
                return;
            }

            //getting kennel id from grid
            String kennelID = grdAvailableKennels.Rows[grdAvailableKennels.CurrentCell.RowIndex].Cells[0].Value.ToString();

            Booking booking = new Booking(Convert.ToInt32(txtBookingID.Text),Convert.ToInt32(kennelID),  dtpArrival.Value, dtpDeparture.Value, txtFirstName.Text.ToUpper(), txtLastName.Text.ToUpper(), txtPhoneNo.Text, txtEmail.Text, txtBreed.Text, txtDogName.Text, txtInfo.Text, Convert.ToDecimal(txtCost.Text), 'B');
            booking.addBooking();

            MessageBox.Show("Booking Added", "Conformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //sent confirmation email


            //reload the booking id field with the next booking id
            txtBookingID.Text = Booking.nextBookingID().ToString("00000");
            //load combo box again
            loadCombo();

            //turn group boxes invisibe and clear all existing data
            grpAvailableKennels.Visible = false;
            txtFirstName.Clear();
            dtpArrival.ResetText();
            dtpDeparture.ResetText();
            txtLastName.Clear();
            txtBreed.Clear();
            txtDogName.Clear();
            txtEmail.Clear();
            txtInfo.Clear();
            txtPhoneNo.Clear();
            txtCost.Clear();
            grpInfo.Visible = false;

        }

    
    }
}
