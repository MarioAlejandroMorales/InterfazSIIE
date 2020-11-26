using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class DocenteSql : ConexionSQL
    {

        public string getNombre(string idDocente)
        {
            var connection = GetConnection();
            string query = "SELECT * FROM Docentes WHERE idDocente='" + idDocente + "'";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            string res = "0";
            try
            {

                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    res = reader["nombre"].ToString();
                    res +=" "+ reader["apellido1"].ToString();
                    res += " " + reader["apellido2"].ToString();
                }
                connection.Close();
            }
            catch (Exception ex) { }
            connection.Close();
            return res;
        }
    }
}