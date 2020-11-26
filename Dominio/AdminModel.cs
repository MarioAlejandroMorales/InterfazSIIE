using System;
using System.Collections.Generic;
using AccesoDatos;
using Common.Cache;

namespace Dominio
{
    public class AdminModel:ConexionSQL
    {
        AdminSql admSql = new AdminSql();
        RegistroSql registroSql = new RegistroSql();
        public void addU(int rol, List<string> dtU)
        {
            if(admSql.addUser(rol, dtU))
            {
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
            if (tipo==1)
                return admSql.searchUserId(arg);
            return new List<string>();
        }
        public bool delU(string id, string rol)
        {
            bool resultado = admSql.deleteUser(id, rol);
            registroSql.addRegistro(Common.Cache.UserLoginCache.IdUser, "Eliminacion de usuario " + id + " Con rol " + rol.ToString(), "");
            return resultado;

        }
    }
}
