using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace KennelSys
{
    public partial class FrmAdd_Kennel_Type : Form
    {
        
        FrmHome home;
        public FrmAdd_Kennel_Type()
        {
            InitializeComponent();
        }

        public FrmAdd_Kennel_Type(FrmHome Home)
        {
            InitializeComponent();

            home = Home;
        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //validate the input data
            if (txtType.Text.Equals(""))
            {
                MessageBox.Show("A kennel type must be entered!!(s,m,l,xl,xxl)");
                txtType.Focus();
                return;
            }

            if (txtDesc.Text.Equals(""))
            {
                MessageBox.Show("Please give desciption of kennel");
                txtDesc.Focus();
                return;
            }

            decimal parsedValue;
            if (!Decimal.TryParse(txtRate.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                txtRate.Focus();
                return;
            }
            else if (parsedValue < 0)
            {
                MessageBox.Show("The value must be above 0");
                txtRate.Focus();
                return;
            }

            //type already exists in database
            Rates myType = new Rates(txtType.Text);
            
            if (myType.kennelExists())
            {
                Rates myRate = new Rates(txtType.Text.ToUpper(), txtDesc.Text.ToUpper(), Convert.ToDecimal(txtRate.Text));
                //save data in Rates Table
                myRate.addKennelType();
                //display conf message
                MessageBox.Show("Kennel type " + txtType.Text + "  added");

                //reset UI
                txtType.Clear();
                txtDesc.Clear();
                txtRate.Clear();
                txtType.Focus();
                return;
            }
            else
                MessageBox.Show("Kennel type "+txtType.Text + " already exists");
                txtType.Focus();
                return;

            

        }
    }
}
