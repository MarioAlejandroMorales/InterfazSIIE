using System;
using System.Collections.Generic;
using AccesoDatos;
using Common.Cache;

namespace Dominio
{
    public class AdminModel:ConexionSQL
    {
        public List<List<string>> getReg()
        {
            RegistroSql registroSql = new RegistroSql();
            return registroSql.getRegistros();
        }
        public void addU(int rol, List<string> dtU)
        {
            AdminSql admSql = new AdminSql();
            if (admSql.addUser(rol, dtU))
            {
                RegistroSql registroSql = new RegistroSql();
                string query = "SELECT * FROM ";
                if (rol == 1)
                    query += "Coordinadores WHERE idCoordinador='";
                else if (rol == 2)
                    query += "Docentes WHERE idDocente='";
                else 
                    query += "Alumnos WHERE idAlumno='";

                query += UserLoginCache.IdUser + "'";
                //userDao.onLogon(query);
                registroSql.addRegistro(Common.Cache.UserLoginCache.IdUser, "Creacion de usuario" + admSql.getIdGlobal() + " Con rol " + rol.ToString(), "" );
            }
        }
        public List<string> searchUser(string arg, int tipo, string arg2 = "")
        {
            AdminSql admSql = new AdminSql();
            if (tipo==1)
                return admSql.searchUserId(arg);
            return new List<string>();
        }
        public bool delU(string id, string rol)
        {
            RegistroSql registroSql = new RegistroSql();
            AdminSql admSql = new AdminSql();
            bool resultado = admSql.deleteUser(id, rol);
            if (resultado)
                registroSql.addRegistro(Common.Cache.UserLoginCache.IdUser, "Eliminacion de usuario " + id + " Con rol " + rol.ToString(), "");
            return resultado;

        }
    }
}
