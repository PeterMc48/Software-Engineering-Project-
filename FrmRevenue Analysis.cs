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
    public partial class Revenue_Analysis : Form
    {
        FrmHome home;
        public Revenue_Analysis()
        {
            InitializeComponent();
        }
        public Revenue_Analysis(FrmHome Home)
        {
            InitializeComponent();
            home = Home;
        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void Revenue_Analysis_Load(object sender, EventArgs e)
        {
            chtData.Visible = false;

            DataSet ds = new DataSet();
            ds = Booking.getYears(ds);

            for (int i = 0; i < ds.Tables["year"].Rows.Count; i++)

                cboYear.Items.Add(ds.Tables[0].Rows[i][0].ToString());

        }


        public String getMonth(int month)
        {
            switch (month)
            {
                case 1:
                    {
                        return "JAN";

                    }
                case 2:
                    {
                        return "FEB";

                    }
                case 3:
                    {
                        return "MAR";

                    }
                case 4:
                    {
                        return "APR";

                    }
                case 5:
                    {
                        return "MAY";

                    }
                case 6:
                    {
                        return "JUN";

                    }
                case 7:
                    {
                        return "JUL";

                    }
                case 8:
                    {
                        return "AUG";

                    }
                case 9:
                    {
                        return "SEP";

                    }
                case 10:
                    {
                        return "OCT";

                    }
                case 11:
                    {
                        return "NOV";

                    }
                case 12:
                    {
                        return "DEC";

                    }
                default: return "OTH";

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
        

            String strSQL = "SELECT SUM(Cost), to_Char(departure_date,'MM') FROM Bookings WHERE to_Char(DEPARTURE_DATE,'yy') = '"+Convert.ToInt32(cboYear.Text)+"' AND Status = 'D' GROUP BY to_Char(departure_date,'MM') ORDER BY to_char(departure_date,'MM')";
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

                N[i] = getMonth(Convert.ToInt32(dt.Rows[i][1]));
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
            chtData.ChartAreas[0].AxisX.Title = "MONTH";
            chtData.ChartAreas[0].AxisY.Title = "€'s";
            chtData.Series[0].IsVisibleInLegend = false;
            chtData.Titles.Clear();
            chtData.Titles.Add("Yearly Revenue");
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

