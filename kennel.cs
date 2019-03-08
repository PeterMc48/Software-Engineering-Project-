using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace KennelSys
{
    class kennel
    {
        private int Kennel_ID;
        private String Kennel_Type;
        private char Status;

        //no arugment 
        public kennel()
        {
            Kennel_ID = 0;
            Kennel_Type = "";
            Status = ' ';
        }
        // 3 arugment
        public kennel(int KennelID, String KennelType, char Stat)
        {
            Kennel_ID = KennelID;
            Kennel_Type = KennelType;
            Status = Stat;
        }
        //2 arugment
        public kennel(int KennelID,char Stat)
        {
            Kennel_ID = KennelID;
            Status = Stat;
        }
        //defining setters
        public void setKennelID(int KennelID)
        {
            this.Kennel_ID = KennelID;
        }
        public void setKennelType(String KennelType)
        {
            this.Kennel_Type = KennelType;
        }
        public void setStatus(char Stat)
        {
            this.Status = Stat;
        }
        //define getters
        public int getKennelID()
        {
            return Kennel_ID;
        }
        public String getKennelType()
        {
            return Kennel_Type;
        }
        public char getStatus()
        {
            return Status;
        }



        public static int nextkennelID()
        {
            //declare working variable
            int intNextKennelID;

            //connect to database
            OracleConnection conn = new OracleConnection(dbConnection.oradb);
            conn.Open();

            //define the sql query
            String strSQL = "SELECT MAX(kennel_ID) FROM Kennels";

            //create oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute command (data reader)
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
            {
                intNextKennelID = 1;
            }
            else
                intNextKennelID = Convert.ToInt32(dr.GetValue(0)) + 1;

            //close database
            conn.Close();

            //return nextStockNo
            return intNextKennelID;

        }

        internal static void updateKennelStatus(int kennelID,char KennelStatus)
        {
            //connect to DB
            OracleConnection myConn = new OracleConnection(dbConnection.oradb);
            myConn.Open();

            //define SQL query to decommission the kennel status
            String strSQL = "UPDATE Kennels SET Status = '"+KennelStatus+"' WHERE kennel_ID = " + kennelID;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public void addKennel()
        {

            //connect to database
            OracleConnection conn = new OracleConnection(dbConnection.oradb);
            conn.Open();

            //define the sql query
            String strSQL = "INSERT INTO Kennels VALUES(" + this.Kennel_ID + ",'" + this.Kennel_Type + "','"  + this.Status + "')";

            //create oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteReader();

            //close database
            conn.Close();
        }
        //geting kennel details for conformation.
        public void getkennelDetails(int KennelID)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(dbConnection.oradb);
            myConn.Open();

            //Define SQL query to get kennel details
            String strSQL = "SELECT * FROM Kennels WHERE Kennel_ID = " + KennelID;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                setKennelID(dr.GetInt32(0));
                setKennelType(dr.GetString(1));
                setStatus(Convert.ToChar(dr.GetValue(2)));

            }
            //close DB connection
            myConn.Close();
        }
        public void decommisionKennel()
        {
            //connect to DB
            OracleConnection myConn = new OracleConnection(dbConnection.oradb);
            myConn.Open();

            //define SQL query to decommission the kennel status
            String strSQL = "UPDATE Kennels SET Status = '" + this.Status + "' WHERE kennel_ID = " + this.Kennel_ID;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
        public static DataSet getktype(DataSet DS, String Status)
        {
            OracleConnection conn = new OracleConnection(dbConnection.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT * From Kennels";

            if(!Status.Equals(""))
            {
                strSQL = strSQL + " WHERE Status = '" + Status +"'";
            }

            strSQL = strSQL + " ORDER By Kennel_ID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "kt");

            conn.Close();

            return DS;
        }

    }
  
}
