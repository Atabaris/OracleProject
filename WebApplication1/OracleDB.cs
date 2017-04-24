using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class OracleDB
    {
        private string user_name;
        private OracleConnection connection;

        public OracleDB(string user_name)
        {
            this.user_name = user_name;
        }


        public void openConnection()
        {
            string connection_string = null;
            if (user_name == "Ata")
            {
                connection_string = "Data Source=XE;User Id=e_reservation;Password=password;";
            }
            else if (user_name == "Berk")
            {
                connection_string = "Data Source=XE;User Id=SYSTEM;Password=129200Berk";
            }
            else
            {
                Console.WriteLine("Error! User name is false!");
            }
            if (connection_string != null)
            {
                connection = new OracleConnection(connection_string);
                connection.Open();
                checkConnection(connection);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Could not connected to database because of invalid user_name!");
            }


        }

        public void closeConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Connection could not closed. Connection is null !");
            }
        }

        public void disposeConnection()
        {
            if (connection != null)
            {
                connection.Dispose();              
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Connection could not disposed. Connection is null !");
            }
        }

        public OracleDataReader getDataFromDB(string SQL)
        {
            OracleDataReader data_reader=null;
            if (SQL != null)
            {
                OracleCommand command = new OracleCommand();
                command.CommandText =SQL;
                command.Connection = connection;
                data_reader= command.ExecuteReader();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("You can not get data. Empty SQL string!");
            }
            return data_reader;
        }

        public void updateDataFromDB(string SQL)
        {
            if(SQL != null)
            {
                OracleCommand command = new OracleCommand();
                command.CommandText = SQL;
                command.Connection = connection;
                int affected_row_number=command.ExecuteNonQuery();
                checkSQLSuccess(affected_row_number);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("You can not get data. Empty SQL string!");
            }
        }

        private void checkConnection(OracleConnection connection)
        {
            if (connection != null)
            {
                System.Diagnostics.Debug.WriteLine("You are connected to Oracle Database!");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("You are not connected to Oracle Database. Connection is null !");
            }
        }

        private void checkSQLSuccess(int affected_number_of_rows)
        {
            if (affected_number_of_rows == 0)
            {
                System.Diagnostics.Debug.WriteLine("Your SQL command did not affect anything !!!");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Your SQL command did affected "+affected_number_of_rows+" rows !");
            }
        }
    }
}