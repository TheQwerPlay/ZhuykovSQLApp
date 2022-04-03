using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ZhuykovSQLApp
{
    internal class DB
    {
        SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-R7BKC4T\SQLEXPRESS; Initial Catalog = CandyStore; Integrated Security = True");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            { 
                connection.Open();
            }        
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
