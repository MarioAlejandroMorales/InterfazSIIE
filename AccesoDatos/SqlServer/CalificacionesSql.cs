using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class CalificacionesSql : ConexionSQL
    {
        public string addCalifi(string codigo, string materia, string docen, string cal)
        {
            string query = "INSERT INTO Calificaciones(idAlumno, idMateria, idDocente, calificacion,kardex)";
            query+=" VALUES ('"+codigo+ "','" + materia+ "','" + docen + "','" + cal + "','NO')";
            Console.WriteLine(query);
            var connection = GetConnection();
            string flag = "0";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                commandDatabase.ExecuteNonQuery();
                Console.WriteLine(query);
            }
            catch (Exception ex)
            {
                flag = "-1";
                Console.WriteLine(ex);
            }
            connection.Close();
            
            return flag;
        }
        public bool searchCalifi(string codigo, string materia)
        {
            bool flag = false;
            string query = "SELECT * FROM Calificaciones WHERE idAlumno='" + codigo + "' AND idMateria='" + materia + "'";
            var connection = GetConnection();
            
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                    flag = true;
                Console.WriteLine(query);
                connection.Close();
            }
            catch (Exception ex) { }
            connection.Close();
        
            return flag;
        }

        public string updateCalifi(string codigo, string materia, string docen, string cal)
        {
            string query = "UPDATE Calificaciones SET idDocente='" + docen + "', calificacion='" + cal + "'";
            query += " WHERE idAlumno='" + codigo + "' AND idMateria='" + materia + "' AND kardex='NO'";
            Console.WriteLine(query);
            var connection = GetConnection();
            string flag = "0";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                commandDatabase.ExecuteNonQuery();
                Console.WriteLine(query);
            }
            catch (Exception ex)
            {
                flag = "-1";
                Console.WriteLine(ex);
            }
            connection.Close();

            return flag;
        }

        public string kardex(string codigo, string materia)
        {
            string query = "UPDATE Calificaciones SET kardex=['SI']";
            query += " WHERE idAlumno='" + codigo + "' AND idMateria='" + materia + "'";
            Console.WriteLine(query);
            var connection = GetConnection();
            string flag = "0";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                commandDatabase.ExecuteNonQuery();
                Console.WriteLine(query);
            }
            catch (Exception ex)
            { flag = "-1"; }
            connection.Close();

            return flag;
        }
        public List<List<string>> getKardex(string id)
        {
            List<List<string>> kL= new List<List<string>>();
            List<string> kL1 = new List<string>();
            string query = "SELECT* FROM Calificaciones WHERE idAlumno ='" + id + "'";
            var connection = GetConnection();

            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    kL1 = new List<string>();
                    kL1.Add(reader["idDocente"].ToString());
                    kL1.Add(reader["idMateria"].ToString());
                    kL1.Add(reader["calificacion"].ToString());
                    kL.Add(kL1);
                }
                connection.Close();
            }
            catch (Exception ex) { }
            connection.Close();

            return kL;
        }

    }
}