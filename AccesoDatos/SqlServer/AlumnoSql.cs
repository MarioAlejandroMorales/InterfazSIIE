using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class AlumnoSql : ConexionSQL
    {

        public bool bajaAlumno(string idAlumno)
        {
            string status=getStatus(idAlumno);
            string query = "UPDATE Alumnos SET status='";
            if (status == "0")
                return false;
            else if (status == "ACTIVO")
                query += "BAJA";
            else
                query += "ACTIVO";
            query += "' WHERE idAlumno='" + idAlumno + "'";

            var connection = GetConnection();
            bool res=false;
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                commandDatabase.ExecuteNonQuery();
                res = true;
            }
            catch (Exception ex) {}
            connection.Close();
            return res;
        }

        public string getStatus(string idAlumno)
        {
            var connection = GetConnection();
            string query = "SELECT * FROM Alumnos WHERE idAlumno='"+idAlumno+"'";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            string res="0";
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                    res = reader["status"].ToString();
                Console.WriteLine(query);
                connection.Close();
            }
            catch (Exception ex) { }
            connection.Close();
            return res;
        }
    }
}

