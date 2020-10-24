using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HappyTech
{
    class DatabaseConnection
    {

        //private object of the class itself
        private static DatabaseConnection _instance;

        //connection string
        private string connStr;

        //connection to the DB
        private SqlConnection connToDB;

        /// <summary>
        /// constructor
        /// </summary>
        private DatabaseConnection()
        {
            connStr = Properties.Settings.Default.databaseConnectionString;

        }

        ///
        ///methods
        ///
        /**
         * a static method that creates an unique object of the class itself
         */
        public static DatabaseConnection getInstanceOfDBConnection()
        {
            if (_instance == null)
                _instance = new DatabaseConnection();
            return _instance;
        }

        /**
         * Returns a data set built based on the query sent as parameter
         */
        public DataSet getDataSet(string sqlQuery)
        {
            //create an empty dataset
            DataSet dataSet = new DataSet();

            using (connToDB = new SqlConnection(connStr))
            {
                //open the connection
                connToDB.Open();

                //create the object dataAdapter to send a query to the DB
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connToDB);

                //fill in the dataset
                dataAdapter.Fill(dataSet);

            }

            return dataSet;
        }
    }
}
