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
    public partial class FrmUpdateKennelType : Form
    {
        FrmHome home;
        public FrmUpdateKennelType()
        {
            InitializeComponent();
            

        }
        public FrmUpdateKennelType(FrmHome Home)
        {
            InitializeComponent();
            home = Home;
        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }


        private void FrmUpdateKennelType_Load(object sender, EventArgs e)
        {
           

            //load combo with kennel type from rates table
            DataSet ds = new DataSet();
            ds = Rates.getktype(ds);

            for (int i = 0; i < ds.Tables["kt"].Rows.Count;i++)
            
                cboKennel_Type.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            
        }

        private void grpUpdateKennelType_Enter(object sender, EventArgs e)
        {
        }

        private void cboKennel_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKennel_Type.SelectedIndex == -1)
            {
                return;
            }
            Rates updateKennel = new Rates();
            updateKennel.getkennelDetails(cboKennel_Type.Text);


            txtDesc.Text = updateKennel.getDesc();
            txtRate.Text = updateKennel.getRate().ToString();

            grpUpdateKennelType.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //validation
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


            //update kennel type

            Rates UpdatekennelType = new Rates(cboKennel_Type.Text.ToUpper(), txtDesc.Text.ToUpper(), Convert.ToDecimal(txtRate.Text));
            //save data in Rates Table
            UpdatekennelType.updKennelType();

            //confirmation message
            MessageBox.Show("Kennel type " + cboKennel_Type.Text.ToUpper() + " has been updated","Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI

            grpUpdateKennelType.Visible = false;
            
            cboKennel_Type.SelectedIndex = -1;
         
        }

   
    }
}
