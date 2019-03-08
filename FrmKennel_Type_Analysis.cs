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
    public partial class FrmKennel_Type_Analysis : Form
    {
        FrmHome home;
        public FrmKennel_Type_Analysis()
        {
            InitializeComponent();
        }
        public FrmKennel_Type_Analysis(FrmHome Home)
        {
            InitializeComponent();
            home = Home;
        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void FrmKennel_Type_Analysis_Load(object sender, EventArgs e)
        {
            chtData.Visible = false;

            DataSet ds = new DataSet();
            ds = Booking.getYears(ds);

            for (int i = 0; i < ds.Tables["year"].Rows.Count; i++)

                cboYear.Items.Add(ds.Tables[0].Rows[i][0].ToString());
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String strSQL = "SELECT SUM(Cost), Kennel_type FROM Bookings,KENNELS WHERE to_Char(DEPARTURE_DATE,'yy') = '"+cboYear.Text+"' AND BOOKINGS.KENNEL_ID = Kennels.KENNEL_ID GROUP BY KENNELS.KENNEL_TYPE ORDER BY KENNELS.KENNEL_TYPE";
            DataTable dt = new DataTable();

            OracleConnection myConn = new OracleConnection(dbConnection.oradb);

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(dt);
            myConn.Close();

            string[] N = new string[dt.Rows.Count];
            decimal[] M = new decimal[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                N[i] = (dt.Rows[i][1]).ToString();
                M[i] = Convert.ToDecimal(dt.Rows[i][0]);
            }

            //order the arrays N and M

            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series[0].LegendText = "Income in €";

            chtData.Series["Series1"]["PointWidth"] = ".5";

            chtData.Series["Series1"]["PixelPointWidth"] = "20";
            chtData.Series[0].Points.DataBindXY(N, M);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            //chtSales.Series[0].Points[0] = "XXX";
            //chtData.Series[0].Label = "#VALY";


            //chtData.ChartAreas[0].AxisX.LabelStyle.si = 5;
            chtData.ChartAreas[0].AxisX.Title = "Kennel Type";
            chtData.ChartAreas[0].AxisY.Title = "€'s";
            chtData.Series[0].IsVisibleInLegend = false;
            chtData.Titles.Clear();
            chtData.Titles.Add("Kennel Type Revenue");
            chtData.Visible = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = this.chtData.Printing.PrintDocument;
            ppd.ShowDialog();
        }

 
    }
}


