using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class GrupoSql : ConexionSQL
    {
        public string docenteImparte(string grupo, string docen)
        {
            string query = "";
            var connection = GetConnection();
            string materia = "";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;

            query = "SELECT * FROM Grupos WHERE idGrupo='" + grupo + "' AND idDocente='"+docen+"' ";
            commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    materia = reader["idMateria"].ToString();
                }
                connection.Close();
            }
            catch (Exception ex) { }
            connection.Close();

            return materia;
        }
        public string addGrupo(List<string> dtG)
        {
            string query = "INSERT INTO Grupos(idMateria, idDocente, aula, horaEntrada, horaSalida, dia, integrantes, cupos)";
            query += " VALUES('" + dtG[0] + "','" + dtG[1] + "','" + dtG[2] + "','" + dtG[3] + "','" + dtG[4] + "','" + dtG[5] + "','0','0')";
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
            if (flag != "-1")
            {
                query = "SELECT idGrupo FROM Grupos ORDER BY idGrupo DESC LIMIT 1";
                commandDatabase = new MySqlCommand(query, connection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    connection.Open();
                    MySqlDataReader reader = commandDatabase.ExecuteReader();
                    if (reader.Read())
                        flag = reader["idGrupo"].ToString();
                    connection.Close();
                }
                catch (Exception ex) { flag = "-1"; }
                connection.Close();
            }
            return flag;
        }
        public bool delGrupo(string id)
        {
            string query = "DELETE FROM GrupoAlumnos WHERE idGrupo='"+id+"'";
            var connection = GetConnection();
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                commandDatabase.ExecuteNonQuery();
            }
            catch (Exception ex) { return false; }
            connection.Close();
            query = "DELETE FROM Grupos WHERE idGrupo='" + id + "'";
            commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                commandDatabase.ExecuteNonQuery();
            }
            catch (Exception ex) { return false; }
            connection.Close();

            return true;
        }

        public List<string> findGrupo(string id)
        {
            List<string> dtG = new List<string>();
            string query = "";
            var connection = GetConnection();

            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;

            query = "SELECT * FROM Grupos WHERE idGrupo='" + id + "'";
            commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    dtG.Add(reader["idDocente"].ToString());
                    dtG.Add(reader["horaEntrada"].ToString());
                    dtG.Add(reader["horaSalida"].ToString());
                    dtG.Add(reader["idMateria"].ToString());
                    dtG.Add(reader["dia"].ToString());
                    dtG.Add(reader["aula"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex) { }
            connection.Close();

            return dtG;
        }
        public List<List<string>> horarioDocente(string id)
        {
            List<List<string>> dtG = new List<List<string>>();
            List<string> dtG1 = new List<string>();
            string query = "";
            var connection = GetConnection();

            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;

            query = "SELECT * FROM Grupos WHERE idDocente='" + id + "'";
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
                    dtG1.Add(reader["idgrupo"].ToString());
                    dtG.Add(new List<string> { dtG1[0], dtG1[1], dtG1[2], dtG1[3], dtG1[4], dtG1[5] });
                    dtG1.Clear();
                }
            }
            catch (Exception ex) { }
            connection.Close();

            return dtG;
        }

        public List<List<string>> gruposMateria(string id)
        {
            List<List<string>> dtG = new List<List<string>>();
            List<string> dtG1 = new List<string>();
            string query = "";
            var connection = GetConnection();

            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;

            query = "SELECT * FROM Grupos WHERE idMateria='" + id + "'";
            commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    dtG1.Add(reader["idgrupo"].ToString());
                    dtG1.Add(reader["idDocente"].ToString());
                    dtG1.Add(reader["horaEntrada"].ToString());
                    dtG1.Add(reader["horaSalida"].ToString());
                    dtG1.Add(reader["idMateria"].ToString());
                    dtG1.Add(reader["dia"].ToString());
                    dtG1.Add(reader["aula"].ToString());
                    dtG1.Add(reader["integrantes"].ToString());
                    dtG1.Add(reader["cupos"].ToString());
                    dtG.Add(new List<string> { dtG1[0], dtG1[1], dtG1[2], dtG1[3], dtG1[4], dtG1[5], dtG1[6], dtG1[7], dtG1[8] });
                    dtG1.Clear();
                }
            }
            catch (Exception ex) { }
            connection.Close();

            return dtG;
        }
    }
}
