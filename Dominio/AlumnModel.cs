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
        public List<List<string>> horarioAlumno(string arg)
        {
            GpAlumnSql gpAlumnSql = new GpAlumnSql();
            MateriaSql matSql = new MateriaSql();
            List<List<string>> dtG = gpAlumnSql.horarioDocente(arg);

            if (dtG.Count() > 0)
                foreach (List<string> grupo in dtG)
                    grupo[2] = matSql.getNombreId(grupo[2]);
            return dtG;
        }
        public List<List<string>> getGrupos(string arg)
        {
            GrupoSql grupoSql = new GrupoSql();
            MateriaSql matSql = new MateriaSql();
            List<List<string>> dtG = grupoSql.gruposMateria(arg);

            if (dtG.Count() > 0)
                foreach (List<string> grupo in dtG)
                    grupo[4] = matSql.getNombreId(grupo[4]);
            return dtG;
        }
        public bool addMateria(string arg)
        {
            GpAlumnSql gpAlumnSql = new GpAlumnSql();
            return gpAlumnSql.registrarMateria(arg, Common.Cache.UserLoginCache.IdUser);             
        }
        public List<List<string>> getKardex(string arg)
        {
            MateriaSql matSql = new MateriaSql();
            CalificacionesSql calificacionesSql= new CalificacionesSql();
            DocenteSql docenteSql = new DocenteSql();
            List<List<string>> dtC= calificacionesSql.getKardex(arg);
            if (dtC.Count() > 0)
                foreach (List<string> cali in dtC)
                    cali[1] = matSql.getNombreId(cali[1]);

            if (dtC.Count() > 0)
                foreach (List<string> cali in dtC)
                    cali[0] = docenteSql.getNombre(cali[0]);
            return dtC;

        }
    }
}
