using System;
using System.Collections.Generic;
using AccesoDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace Dominio
{
    public class AlumnModel:ConexionSQL
    {
        GpAlumnSql gpAlumnSql = new GpAlumnSql();

        MateriaSql matSql = new MateriaSql();
        GrupoSql grupoSql = new GrupoSql();

        public List<List<string>> horarioAlumno(string arg)
        {
            List<List<string>> dtG = gpAlumnSql.horarioDocente(arg);

            if (dtG.Count() > 0)
                foreach (List<string> grupo in dtG)
                    grupo[2] = matSql.getNombreId(grupo[2]);
            return dtG;
        }
        public List<List<string>> getGrupos(string arg)
        {
            List<List<string>> dtG = grupoSql.gruposMateria(arg);

            if (dtG.Count() > 0)
                foreach (List<string> grupo in dtG)
                    grupo[4] = matSql.getNombreId(grupo[4]);
            return dtG;
        }
        public string addMateria(string arg)
        {
            return gpAlumnSql.registrarMateria(arg, Common.Cache.UserLoginCache.IdUser);             
        }
    }
}
