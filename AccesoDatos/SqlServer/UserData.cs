using System;
using System.Collections.Generic;
using Common.Cache;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class UserDao:ConexionSQL
    {
        public List<string> recoveryUserPass(string email) 
        {
            var connection = GetConnection();
            List<string> data = new List<string>();
            List<List<string>> op = new List<List<string>>();
            op.Add(new List<string>() { "Alumnos", "idAlumno" });
            op.Add(new List<string>() { "Coordinadores", "idCoordinador" });
            op.Add(new List<string>() { "Docentes", "idDocente" });
            
            string query = "", id="0";
            foreach (List<string> i in op)
            {
                query= "SELECT * FROM "+i[0]+" WHERE correo='" + email + "'";
                MySqlCommand commandDatabase = new MySqlCommand(query, connection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    connection.Open();
                    MySqlDataReader reader = commandDatabase.ExecuteReader();
                    if (reader.Read())
                    {
                        id = reader[i[1]].ToString();
                        connection.Close();
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex); }
                connection.Close();
            }

            if (id != "0")
            {
                query = "SELECT * FROM Usuarios WHERE idUsuario='" + id + "'";
                MySqlCommand commandDatabase = new MySqlCommand(query, connection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    connection.Open();
                    MySqlDataReader reader = commandDatabase.ExecuteReader();
                    if (reader.Read())
                    {
                        data.Add( reader["idUsuario"].ToString());
                        data.Add( reader["contrasenia"].ToString());
                        connection.Close();
                    }
                }
                catch (Exception ex) {  }
                connection.Close();
            }
            return data;
        }

        public bool login(string user, string pass)
        {
            var connection = GetConnection();
            string query = "SELECT * FROM Usuarios WHERE idUsuario='"+user+"' AND contrasenia='"+pass+"'";                
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
                
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    UserLoginCache.IdUser = reader["idUsuario"].ToString();
                    UserLoginCache.Rol = reader["rol"].ToString();
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    return false;
                }
            }
            catch (Exception ex){ Console.WriteLine(ex);}
            connection.Close();
            return false;
        }
        public bool onLogon(string query)
        {
            var connection = GetConnection();
            bool flag = false;
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    flag = true;
                    UserLoginCache.FirstName = reader["nombre"].ToString();
                    UserLoginCache.LastName = reader["apellido1"].ToString() + " " + reader["apellido2"].ToString(); ;
                    UserLoginCache.Email = reader["correo"].ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            connection.Close();
            return flag;
        }

        public string recoverPassword(string userRequesting)
        {
            Console.WriteLine("Hola");
            return "0";
        }
    }
}
