using System;
using System.Collections.Generic;
using AccesoDatos;
using Common.Cache;

namespace Dominio
{
    public class AdminModel:ConexionSQL
    {
        AdminSql admSql = new AdminSql();
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
            return admSql.deleteUser(id, rol);
        }
    }
}
