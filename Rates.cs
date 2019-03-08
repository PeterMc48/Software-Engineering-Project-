using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace KennelSys
{
    class Rates
    {
        //instance variables
        private String kennelType;
        private String description;
        private decimal rate;

        //no argument constuctor
        public Rates()
        {
            kennelType = "";
            description = "";
            rate = 0;
        }
        //single argument constuctor
        public Rates(String kType)
        {
            kennelType = kType;
        }

        //3 argument constuctor
        public Rates(String kType, String Desc, decimal Rates)
        {
            kennelType = kType;
            description = Desc;
            rate = Rates;
        }
        //define the setters
        public void setKennelType(String Kennel_Type)
        {
            this.kennelType = Kennel_Type;
        }
        public void setDescription(String desc)
        {
            this.description = desc;
        }
        public void setRate(decimal Rate)
        {
            this.rate = Rate;
        }
        //define the getters
        public String getKennelType()
        {
            return kennelType;
        }
        public string getDesc()
        {
            return description;
        }
        public decimal getRate()
        {
            return rate;
        }


        //Add kennel type method
        public void addKennelType()
        {
            //connect to database
            OracleConnection conn = new OracleConnection(dbConnection.oradb);
            conn.Open();

            //define the sql query
            String strSQL = "INSERT INTO Rates VALUES('" + this.kennelType + "','" + this.description + "'," +
                this.rate + ")";

            //create oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteReader();

            //close database
            conn.Close();
        }
        public Boolean kennelExists()
        {
            Boolean valid = false;
            //connect to database
            OracleConnection conn = new OracleConnection(dbConnection.oradb);
            conn.Open();

            //define the sql query
            String strsql = "SELECT kennel_Type FROM Rates where kennel_Type = '" + this.kennelType + "'";

            //create the oracle command
            OracleCommand cmd = new OracleCommand(strsql, conn);
            cmd.ExecuteReader();

            //execute command (data reader)
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            //check to see if the dataReader has rows
            if (dr.HasRows)
            {
                //close database connection
                conn.Close();
            }
            else
            {
                valid = true;
                //close database connection
                conn.Close();
            }

            //return boolean
            return valid;
        }
        public static DataSet getktype(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(dbConnection.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT kennel_type From Rates";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "kt");

            conn.Close();

            return DS;
        }
        public void getkennelDetails(String Kennel_Type)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(dbConnection.oradb);
            myConn.Open();

            //Define SQL query to get kennel details
            String strSQL = "SELECT * FROM Rates WHERE Kennel_type = '" + Kennel_Type + "'";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            
            if (dr.Read())
            { 
                setDescription(dr.GetString(1));
                setRate(dr.GetDecimal(2));

            }
            //close DB connection
            myConn.Close();
        }

        public void updKennelType()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(dbConnection.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Rates SET Description = '" + this.description.ToUpper() + "', Rate = " + this.rate + " WHERE kennel_Type = '" + this.kennelType.ToUpper() + "'"; 

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }


    }
}
