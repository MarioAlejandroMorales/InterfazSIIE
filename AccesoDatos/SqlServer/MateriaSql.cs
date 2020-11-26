using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class MateriaSql:ConexionSQL
    {
        public List<string> buscarMateriaNom(string materia)
        {
            List<string> dtM = new List<string>();
            string query= "SELECT * FROM Materias WHERE nombre='" + materia+"'";
            Console.WriteLine(query);
            var connection = GetConnection();
            string flag = "0";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    flag = "1";
                    dtM.Add(reader["idMateria"].ToString());
                    dtM.Add(materia);
                }
                dtM.Add(flag);

            }
            catch (Exception ex){ Console.WriteLine(ex);}
            connection.Close();
            return dtM;
        }
        public List<string> buscarMateriaId(string id)
        {
            List<string> dtM = new List<string>();
            string query = "SELECT * FROM Materias WHERE idMateria='" + id + "'";
            var connection = GetConnection();
            string flag = "0";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    flag = "1";
                    dtM.Add(id);
                    dtM.Add(reader["nombre"].ToString());
                }
                dtM.Add(flag);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            connection.Close();
            return dtM;
        }
        public string addMateria(string materia)
        {
            string query = "INSERT INTO Materias(nombre) VALUES ('"+materia+"')";
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
            catch (Exception ex) { 
                flag = "-1"; 
                Console.WriteLine(ex); 
            }
            connection.Close();
            if (flag != "-1")
            {
                query = "SELECT idMateria FROM Materias ORDER BY idMateria DESC LIMIT 1";
                commandDatabase = new MySqlCommand(query, connection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    connection.Open();
                    MySqlDataReader reader = commandDatabase.ExecuteReader();
                    if (reader.Read())
                        flag = reader["idMateria"].ToString();
                    Console.WriteLine(query);
                    connection.Close();
                }
                catch (Exception ex) { flag = "-1"; }
                connection.Close();
            }
            return flag;
        }
        public string getNombreId(string id)
        {
            string query = "SELECT nombre FROM Materias WHERE idMateria='" + id + "'";
            var connection = GetConnection();
            string res = "-1";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                    res=reader["nombre"].ToString();
            }
            catch (Exception ex) {}
            
            connection.Close();
            return res;
        }

        public bool deletMateria(string materia)
        {
            string query = "DELETE FROM Materias WHERE idMateria='" + materia + "'";
            var connection = GetConnection();
            bool flag = true;
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                commandDatabase.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                flag = false;
            }
            connection.Close();
            return flag;
        }
    }
}
