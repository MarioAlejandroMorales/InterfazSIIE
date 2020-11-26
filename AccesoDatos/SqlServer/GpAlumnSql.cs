using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;





//----------------------------------------------------------------------------------------------------------------------------------

namespace AccesoDatos
{
    public class AlumnosSql : ConexionSQL
    {
        public List<string> getAlumnoDatos(string id)
        {
            List<string> dtG = new List<string>();
            string query = "";
            var connection = GetConnection();

            query = "SELECT * FROM Alumnos WHERE idAlumno='" + id + "'";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            string nombre = "";
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    dtG.Add(reader["idAlumno"].ToString());
                    nombre += reader["nombre"].ToString()+" ";
                    nombre += reader["apellido1"].ToString() + " ";
                    nombre += reader["apellido2"].ToString();
                    dtG.Add(nombre);
                }
                connection.Close();
            }
            catch (Exception ex) { }
            connection.Close();

            return dtG;
        }
    }
}

//----------------------------------------------------------------------------------------------------------------------------------


namespace AccesoDatos
{
    public class GpAlumnSql : ConexionSQL
    {
        public bool alumnoCursa(string grupo, string codigo)
        {
            bool flag=false;
            string query = "";
            var connection = GetConnection();

            query = "SELECT * FROM GrupoAlumnos WHERE idGrupo='" + grupo + "' AND idAlumno='"+codigo+"'";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    flag = true;
                }
                connection.Close();
            }
            catch (Exception ex) { }
            connection.Close();

            return flag;
        }

        public List<string> findAlumnosGrupos(string id)
        {
            List<string> dtG = new List<string>();
            string query = "";
            var connection = GetConnection();

            query = "SELECT idAlumno FROM GrupoAlumnos WHERE idGrupo='" + id + "'";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    dtG.Add(reader["idAlumno"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex) { }
            connection.Close();

            return dtG;
        }
        public List<string> findGruposAlumnos(string id)
        {
            List<string> dtG = new List<string>();
            string query = "";
            var connection = GetConnection();

            query = "SELECT idGrupo FROM GrupoAlumnos WHERE idAlumno='" + id + "'";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    dtG.Add(reader["idGrupo"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex) { }
            connection.Close();

            return dtG;
        }
        public string registrarMateria(string idGrupo, string idAlumno)
        {
            string query = "INSERT INTO GrupoAlumnos(idGrupo, idAlumno)";
            query += " VALUES('" + idGrupo + "','" + idAlumno + "')";
            var connection = GetConnection();
            string flag = "0";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                commandDatabase.ExecuteNonQuery();
            }
            catch (Exception ex) { flag = "-1"; }
            connection.Close();
            
            return flag;
        }
        
        public List<List<string>> horarioDocente(string id)
        {
            List<List<string>> dtG = new List<List<string>>();
            List<string> dtG1 = new List<string>();
            List<string> dtGA = findGruposAlumnos(id);
            if (dtGA.Count() != 0)
            {
                foreach (string grupo in dtGA)
                {
                    string query = "";
                    var connection = GetConnection();

                    MySqlCommand commandDatabase = new MySqlCommand(query, connection);
                    commandDatabase.CommandTimeout = 60;

                    query = "SELECT * FROM Grupos WHERE idGrupo='" + grupo +"'";
                    commandDatabase = new MySqlCommand(query, connection);
                    commandDatabase.CommandTimeout = 60;
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = commandDatabase.ExecuteReader();
                        while (reader.Read())
                        {
                            dtG1.Add(reader["horaEntrada"].ToString());
                            dtG1.Add(reader["horaSalida"].ToString());
                            dtG1.Add(reader["idMateria"].ToString());
                            dtG1.Add(reader["dia"].ToString());
                            dtG1.Add(reader["aula"].ToString());
                            dtG.Add(new List<string> { dtG1[0], dtG1[1], dtG1[2], dtG1[3], dtG1[4] });
                            dtG1.Clear();
                        }
                    }
                    catch (Exception ex) { }
                    connection.Close();
                }
            }
            return dtG;
        }
    }
}
