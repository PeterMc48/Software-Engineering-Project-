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
    public partial class FrmHome : Form
    {
        
        public FrmHome()
        {
            InitializeComponent();
        }

        private void mnuTypeAdd_Click(object sender, EventArgs e)
        {
           
            FrmAdd_Kennel_Type addKennelType = new FrmAdd_Kennel_Type(this);
            addKennelType.Show();
            this.Hide();
        }

        private void mnubookings_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateKennelType updateKennelType = new FrmUpdateKennelType(this);
            updateKennelType.Show();
            this.Hide();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void mnuKennels_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuAddKennel_Click(object sender, EventArgs e)
        {
            FrmAdd_Kennel Add_Kennel = new FrmAdd_Kennel(this);
            Add_Kennel.Show();
            this.Hide();
        }

        private void mnuremoveKennel_Click(object sender, EventArgs e)
        {
            FrmRemove_Kennel remove_Kennel = new FrmRemove_Kennel(this);
            remove_Kennel.Show();
            this.Hide();

        }

        private void mnukennelEnquiry_Click(object sender, EventArgs e)
        {
            FrmKennelEnquiry kennelEnquiry = new FrmKennelEnquiry(this);
            kennelEnquiry.Show();
            this.Hide();

        }

        private void mnumakeBooking_Click(object sender, EventArgs e)
        {
            FrmMake_Booking make_Booking = new FrmMake_Booking(this);
            make_Booking.Show();
            this.Hide();
        }

        private void mnucancelBooking_Click(object sender, EventArgs e)
        {
            FrmCancel_Booking cancel_Booking = new FrmCancel_Booking(this);
            cancel_Booking.Show();
            this.Hide();
        }

        private void mnurecordArrival_Click(object sender, EventArgs e)
        {
            FrmRecord_Arrival record_Arrival = new FrmRecord_Arrival(this);
            record_Arrival.Show();
            this.Hide();
        }

        private void mnurecordDeparture_Click(object sender, EventArgs e)
        {
            FrmRecord_Departure record_Departure = new FrmRecord_Departure(this);
            record_Departure.Show();
            this.Hide();
        }

        private void mnurevenueAnalysis_Click(object sender, EventArgs e)
        {
            Revenue_Analysis revenue_Analysis = new Revenue_Analysis(this);
            revenue_Analysis.Show();
            this.Hide();
        }

        private void mnukennelType_Click(object sender, EventArgs e)
        {
            FrmKennel_Type_Analysis kennel_Type_Analysis = new FrmKennel_Type_Analysis(this);
            kennel_Type_Analysis.Show();
            this.Hide();
        }
    }
}
