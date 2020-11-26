using System;
using System.Collections.Generic;
using System.Text;
using Common.Cache;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    class GenerateRandomString
    {

        public string generateString()
        {

            // creating a StringBuilder object()
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < 8; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return(str_build.ToString());
        }
    }
}

namespace AccesoDatos
{
    public class AdminSql : ConexionSQL
    {
        public bool addUser(int rol, List<string> dtU)
        {
            string id="";
            var connection = GetConnection();
            string query;
            GenerateRandomString gs= new GenerateRandomString();
            query = "INSERT INTO Usuarios(contrasenia, rol)";
            query += " VALUES ('" + gs.generateString() + "','"+rol+"')";

            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                commandDatabase.ExecuteNonQuery();
                Console.WriteLine(query);

            }
            catch (Exception ex) { Console.WriteLine(ex); }
            connection.Close();

            query = "SELECT idUsuario FROM Usuarios ORDER BY idUsuario DESC LIMIT 1"; 
            commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                    id = reader["idUsuario"].ToString();
                Console.WriteLine(query);
                connection.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            connection.Close();

            if (rol == 1)
            {
                query = "INSERT INTO Coordinadores(idCoordinador, nombre, apellido1, apellido2, carrera, correo)";
                query += " VALUES ('"+ id + "','" + dtU[0] + "','" + dtU[1] + "','" + dtU[2] + "','" + dtU[3] + "','" + dtU[4] + "')";
            }
            else if (rol == 2)
            {
                query = "INSERT INTO Docentes(idDocente, nombre, apellido1, apellido2, correo, academia)";
                query += " VALUES ('" + id + "','" + dtU[0] + "','" + dtU[1] + "','" + dtU[2] + "','" + dtU[4] + "','" + dtU[3] + "')";
            }
            else
            {
                query = "INSERT INTO Alumnos(idAlumno, nombre, apellido1, apellido2, correo, carrera, admision, ciclo, status)";
                query += " VALUES ('" + id + "','" + dtU[0] + "','" + dtU[1] + "','" + dtU[2] + "','" + dtU[4] + "','" + dtU[3] + "','" + dtU[5] + "','" + dtU[5] + "','ACTIVO')";
            }

            commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                commandDatabase.ExecuteNonQuery();
                Console.WriteLine(query);
                connection.Close();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            connection.Close();
            return false;
        }


        public List<string> searchUserId(string user)
        {
            string rol="";
            List<string> dtF = new List<string>();
            var connection = GetConnection();
            string query = "SELECT * FROM Usuarios WHERE idUsuario='" + user + "'";
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);

            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                    rol = reader["rol"].ToString();
            }
            catch (Exception ex){ Console.WriteLine(ex); }
            if (rol == "0")
            {
                dtF.Add("");
                return dtF;
            }

            dtF.Add(rol);
            connection.Close();
            query = "SELECT * FROM ";
            if (rol=="1")
                query+= "Coordinadores WHERE idCoordinador='" + user + "'";
            else if (rol == "2")
                query += "Docentes WHERE idDocente='" + user + "'";
            else if (rol == "3")
                query += "Alumnos WHERE idAlumno='" + user + "'";

            commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    dtF.Add(reader["nombre"].ToString());
                    dtF.Add(reader["apellido1"].ToString());
                    dtF.Add(reader["apellido2"].ToString());
                    dtF.Add(reader["correo"].ToString());
                    if (rol == "2")
                        dtF.Add(reader["academia"].ToString());
                    else {
                        dtF.Add(reader["carrera"].ToString());
                        if (rol == "3")
                        {
                            dtF.Add(reader["admision"].ToString());
                            dtF.Add(reader["ciclo"].ToString());
                            dtF.Add(reader["status"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            connection.Close();

            return dtF;
        }

        public bool deleteUser(string idUsuario, string rol)
        {
            string id = "";
            var connection = GetConnection();
            string query;
            MySqlCommand commandDatabase;
            if (rol == "1")
            {
                query = "DELETE FROM Coordinadores WHERE idCoordinador='"+idUsuario+"'";
            }
            else if (rol == "2")
            {
                query = "DELETE FROM Docentes WHERE idDocente='" + idUsuario + "'";
            }
            else
            {
                query = "DELETE FROM Alumnos WHERE idAlumno='" + idUsuario + "'";
            }

            commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                commandDatabase.ExecuteNonQuery();
                Console.WriteLine(query);
                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            connection.Close();
            query = "DELETE FROM Usuarios WHERE idUsuario='" + idUsuario + "' AND rol='"+rol+"'";

            commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                commandDatabase.ExecuteNonQuery();
                Console.WriteLine(query);
                return true;

            }
            catch (Exception ex) { Console.WriteLine(ex); }
            connection.Close();
            return false;
        }
    }
}