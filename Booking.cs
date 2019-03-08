using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace KennelSys
{
    class Booking
    {
        private int BOOKINGID;
        private int KennelID;
        private DateTime ArrivalDate;
        private DateTime DepartureDate;
        private String CustFirstName;
        private String CustLastName;
        private String PhoneNo;
        private String CustEmail;
        private String DogBreed;
        private String DogName;
        private String Info;
        private Decimal Cost;
        private char Status;
        public Booking(int BookingID, int kennelID, DateTime A_Date, DateTime D_Date, String FirstName, String LastName, String Phone, String Email, String DBreed, String DName, String info, Decimal cost, char Stat)
        {
            BOOKINGID = BookingID;
            KennelID = kennelID;
            ArrivalDate = A_Date;
            DepartureDate = D_Date;
            CustFirstName = FirstName;
            CustLastName = LastName;
            PhoneNo = Phone;
            CustEmail = Email;
            DogBreed = DBreed;
            DogName = DName;
            Info = info;
            Cost = cost;
            Status = Stat;

        }
        public Booking(int BookingID, DateTime A_Date, DateTime D_Date, int kennelID)
        {
            BOOKINGID = BookingID;
            ArrivalDate = A_Date;
            DepartureDate = D_Date;
            KennelID = kennelID;
        }
        public Booking(DateTime A_Date, DateTime D_Date, int kennelID)
        {
           
            ArrivalDate = A_Date;
            DepartureDate = D_Date;
            KennelID = kennelID;
        }
        //defining setters
        public void setBookinglID(int BookingID)
        {
            this.BOOKINGID = BookingID;
        }
        public void setKennelID(int kID)
        {
            this.KennelID = kID;
        }
        public void setArrivalDate(DateTime A_Date)
        {
            this.ArrivalDate = A_Date;
        }
        public void setDepartureDate(DateTime     D_Date)
        {
            this.DepartureDate = D_Date;
        }
        public void setCustFirstName(String FirstName)
        {
            this.CustFirstName = FirstName;
        }
        public void setCustLastName(String lastName)
        {
            this.CustLastName = lastName;
        }
        public void setPhoneNo(String phone)
        {
            this.PhoneNo = phone;
        }
        public void setCustEmail(String email)
        {
            this.CustEmail = email;
        }
        public void setDogBreed(String Dog)
        {
            this.DogBreed = Dog;
        }
        public void setDogName(String DogName)
        {
            this.DogName = DogName;
        }
        public void setInfo(String info)
        {
            this.Info = info;
        }
        public void setCost(decimal cost)
        {
            this.Cost = cost;
        }
        public void setStatus(char stat)
        {
            this.Status = stat;
        }
        //define getters
        public int getBOOKINGID()
        {
            return BOOKINGID;
        }
        public int getkID()
        {
            return KennelID;
        }
        public DateTime getArrival()
        {
            return ArrivalDate;
        }
        public DateTime getDeparture()
        {
            return DepartureDate;
        }
        public String getCustFirstName()
        {
            return CustFirstName;
        }
        public String getCustLastName()
        {
            return CustLastName;
        }
        public String getPhoneNo()
        {
            return PhoneNo;
        }
        public String getCustEmail()
        {
            return CustEmail;
        }
        public String getDogBreed()
        {
            return DogBreed;
        }
        public String getDogName()
        {
            return DogName;
        }
        public String getInfo()
        {
            return Info;
        }
        public decimal getCost()
        {
            return Cost;
        }
        public char getStat()
        {
            return Status;
        }
        //Get next booking id
        public static int nextBookingID()
        {
            //declare working variable
            int intNextBookingID;

            //connect to database
            OracleConnection conn = new OracleConnection(dbConnection.oradb);
            conn.Open();

            //define the sql query
            String strSQL = "SELECT MAX(BookingID) FROM Bookings";

            //create oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute command (data reader)
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
            {
                intNextBookingID = 1;
            }
            else
                intNextBookingID = Convert.ToInt32(dr.GetValue(0)) + 1;

            //close database
            conn.Close();

            //return nextStockNo
            return intNextBookingID;
        }
        //get kennel type
        public static DataSet getktype(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(dbConnection.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT KENNEL_TYPE, Rate From Rates WHERE Kennel_Type Not IN (Select Kennel_type From Kennels Where Status = 'D')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "kt");

            conn.Close();

            return DS;
        }
        //get dataset for grid
        public static DataSet getKennelDetails(DataSet ds,String KennelType, String ArrivalDate, String DepartureDate)
        {

            //connect to database
            OracleConnection conn = new OracleConnection(dbConnection.oradb);
            conn.Open();


            //define the sql query
            String strsql = "SELECT * FROM Kennels WHERE Kennel_ID NOT IN(SELECT Kennel_ID FROM Bookings" +
                            " WHERE"+ 
                             "(ARRIVAL_DATE >= '" + ArrivalDate + "' AND DEPARTURE_DATE <= '" + DepartureDate + "') OR " +
                             "(ARRIVAL_DATE <='" + ArrivalDate + "' AND DEPARTURE_DATE >= '" + DepartureDate + "') OR" +
                             "((ARRIVAL_DATE BETWEEN '" + ArrivalDate + "' AND '" + DepartureDate + "') AND (DEPARTURE_DATE >= '" + DepartureDate + "')) OR" +
                             "((Arrival_Date <= '" + ArrivalDate + "') AND (Departure_Date BETWEEN '" + ArrivalDate + "'  AND '" + DepartureDate + "')))" +
                             "AND Kennel_Type = '" + KennelType + 
                             "' ORDER BY Kennel_ID";

            //create the oracle command
            OracleCommand cmd = new OracleCommand(strsql, conn);
            cmd.ExecuteReader();

            //execute the SQL query
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "AvailiableKennels");


            //close DB connection
            conn.Close();

            return ds;
        }
        //get price of the selected kennel type
        public static double getPrice(String KennelType)
        {
            //variable to return rate
            double Price =0;

            //connect to database
            OracleConnection conn = new OracleConnection(dbConnection.oradb);
            conn.Open();

            //define sql to get rate
            String strsql = "SELECT Rate FROM Rates WHERE KENNEL_Type = '" + KennelType + "'";

            //create the oracle command
            OracleCommand cmd = new OracleCommand(strsql, conn);
            cmd.ExecuteReader();

            //execute command (data reader)
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Price = dr.GetDouble(0);
            }

            return Price;
        }
        //add booking to booking file
        public void addBooking()
        {

            //connect to database
            OracleConnection conn = new OracleConnection(dbConnection.oradb);
            conn.Open();
            String arrival = String.Format("{0:dd-MMM-yy}", this.ArrivalDate);
            String departure = String.Format("{0:dd-MMM-yy}", this.DepartureDate);
            //define the sql query
            String strSQL = "INSERT INTO Bookings VALUES(" + this.BOOKINGID + ","+ this.KennelID + ",'" + arrival + "','"+departure+"','"+
                             this.CustFirstName+"','"+this.CustLastName+"','"+this.PhoneNo+"','"+this.CustEmail+"','"+this.DogBreed+
                             "','"+this.DogName+"','"+this.Info+"',"+this.Cost+",'"+this.Status+"')";

            //create oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteReader();

            //close database
            conn.Close();
        }
        //getting customers details for cancelling a booking
        public static DataSet getCustsByname(DataSet DS, String Search)
        {
            OracleConnection myConn = new OracleConnection(dbConnection.oradb);
            myConn.Open();

            String strSQL = "SELECT BookingId, CustFirstName, CustLastName, CustEmail, Arrival_Date, Departure_Date FROM Bookings WHERE CustLastName LIKE '" + Search + "%' ORDER BY CustLastName, CustFirstName";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "custSearch");

            myConn.Close();

            return DS;
        }
        public static void cancelBooking(int BookingID)
        {
            OracleConnection myConn = new OracleConnection(dbConnection.oradb);
            myConn.Open();

            String strSQL = "DELETE FROM Bookings WHERE BOOKINGID = " + BookingID;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
        public static DataSet getArrivals(DataSet DS, String lastname)
        {
            OracleConnection myConn = new OracleConnection(dbConnection.oradb);
            myConn.Open();
            String today = String.Format("{0:dd-MMM-yy}", System.DateTime.Now);
            String strSQL = "SELECT BookingId, CustFirstName, CustLastName, CustEmail, Arrival_Date, Kennel_ID FROM Bookings WHERE CustLastName LIKE '" + lastname + "%' AND Arrival_Date = '" + today + "' ORDER BY CustLastName, CustFirstName";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "custSearch");

            myConn.Close();

            return DS;

        }
        public static void updateBookingStatus(int BookingID, char bookingStatus)
        {
            //connect to DB
            OracleConnection myConn = new OracleConnection(dbConnection.oradb);
            myConn.Open();

            //define SQL query to decommission the kennel status
            String strSQL = "UPDATE Bookings SET Status = '"+bookingStatus+"' WHERE BookingID = " + BookingID;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
        public static DataSet getYears(DataSet ds)
        {
            OracleConnection conn = new OracleConnection(dbConnection.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT to_Char(DEPARTURE_DATE,'yy') FROM Bookings Group by to_Char(DEPARTURE_DATE,'yy')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "year");

            conn.Close();

            return ds;
        }
    }
}
