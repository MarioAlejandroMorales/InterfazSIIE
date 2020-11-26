using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class ConexionSQL
    {
        private MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
        
        public ConexionSQL()
        {
            conn_string.Server = "remotemysql.com";
            conn_string.UserID = "6Dd9ogxEWH";
            conn_string.Port = 3306;
            conn_string.Password = "6uTrX298BU";
            conn_string.Database = "6Dd9ogxEWH";
        }

        protected MySqlConnection GetConnection()
        {
            MySqlConnection databaseConnection = new MySqlConnection(conn_string.ToString());
            return databaseConnection;
        }

    }
}