using System;
using System.Collections.Generic;
using System.Text;
using Common.Cache;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class RegistroSql : ConexionSQL
    {
        public bool addRegistro(string user, string action, string prev)
        {
            string id = "";
            DateTime thisDay = DateTime.Today;
            var connection = GetConnection();
            string query;
            bool flag = false;
            GenerateRandomString gs = new GenerateRandomString();
            query = "INSERT INTO Registro(usuario, accion, previo, fecha) ";
            query += "VALUES ('"+user+"','"+action+"','"+prev+"','"+thisDay.ToString("yyyy/MM/dd HH:mm:ss") +"')";

            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                commandDatabase.ExecuteNonQuery();
                Console.WriteLine(query);
                flag = true;
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            connection.Close();

            return flag;
        }

        public List<List<string>> getRegistros()
        {
            List<List<string>> reg = new List<List<string>>();
            List<string> reg1 = new List<string>();
            string query = "";
            var connection = GetConnection();

            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;

            query = "SELECT * FROM Registro";
            commandDatabase = new MySqlCommand(query, connection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    reg1.Add(reader["usuario"].ToString());
                    reg1.Add(reader["accion"].ToString());
                    reg1.Add(reader["previo"].ToString());
                    reg1.Add(reader["fecha"].ToString());
                    reg.Add(new List<string> { reg1[0], reg1[1], reg1[2], reg1[3]});
                    reg1.Clear();
                }
            }
            catch (Exception ex) { }
            connection.Close();

            return reg;
        }


    }
}
