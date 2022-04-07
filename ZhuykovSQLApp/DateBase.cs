using MySql.Data.MySqlClient;

namespace ZhuykovSQLApp
{
    internal class DateBase
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306; username = root; password = root; database = CandyStore");
        //SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-R7BKC4T\SQLEXPRESS; Initial Catalog = CandyStore; Integrated Security = True");

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

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}