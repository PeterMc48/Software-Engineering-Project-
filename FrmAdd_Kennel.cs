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

    public partial class FrmAdd_Kennel : Form
    {
        FrmHome home;
        public FrmAdd_Kennel()
        {
            InitializeComponent();
        }
        public FrmAdd_Kennel(FrmHome Home)
        {
            InitializeComponent();

            home = Home;
        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void FrmAdd_Kennel_Load(object sender, EventArgs e)
        {
            txtKennelId.Text = kennel.nextkennelID().ToString("00000");
            loadCombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(cboKennelTypes.SelectedIndex == -1)
            {
                MessageBox.Show("No kennel type selected!! Please select a kennel type to add", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // validate data
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to asign "+ cboKennelTypes.Text  + " to " + txtKennelId.Text, "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //making a Kennel object

                kennel myKennel = new kennel(Convert.ToInt32(txtKennelId.Text), cboKennelTypes.Text, 'A');

                myKennel.addKennel();

                //display confirm message
                MessageBox.Show("Kennel " + txtKennelId.Text + "Registered", "Confirmation");


                //reset UI

                txtKennelId.Text = kennel.nextkennelID().ToString("00000");

                loadCombo();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Kennel not added");
            }
            
        }

        private void txtKennelId_TextChanged(object sender, EventArgs e)
        {

        }
        public void loadCombo()
        {
            //load combo with kennel type from rates table
            DataSet ds = new DataSet();
            ds = Rates.getktype(ds);

            cboKennelTypes.Items.Clear();
            cboKennelTypes.SelectedIndex = -1;
            cboKennelTypes.Items.Add("Select Kennel Type");

            for (int i = 0; i < ds.Tables["kt"].Rows.Count; i++)

                cboKennelTypes.Items.Add(ds.Tables[0].Rows[i][0].ToString());
        }

        private void grpAddKennel_Enter(object sender, EventArgs e)
        {

        }

    
    }
}
