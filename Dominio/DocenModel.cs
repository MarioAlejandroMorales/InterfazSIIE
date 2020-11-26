using System;
using System.Collections.Generic;
using AccesoDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.Windows;

namespace Dominio
{
    public class DocenModel : ConexionSQL
    {
        MateriaSql matSql = new MateriaSql();
        GrupoSql grupoSql = new GrupoSql();
        GpAlumnSql gpAlumnSql = new GpAlumnSql();
        AlumnosSql alumnosSql = new AlumnosSql();
        CalificacionesSql calificacionesSql = new CalificacionesSql();
        public List<List<string>> horarioDocente(string arg)
        {
            List<List<string>> dtG = grupoSql.horarioDocente(arg);

            if (dtG.Count() > 0)
                foreach (List<string> grupo in dtG)
                    grupo[2] = matSql.getNombreId(grupo[2]);
            return dtG;
        }
        public List<List<string>> listaGrupos(string arg)
        {

            List<string> dtG1 = gpAlumnSql.findAlumnosGrupos(arg);
            List<List<string>> dtG = new List<List<string>>();
            foreach(string id in dtG1)
            {
                dtG.Add(alumnosSql.getAlumnoDatos(id));
            }
            return dtG;
        }
        public bool subirCalificacion(string arg1, string arg2, string arg3)
        {
            
            string materia= grupoSql.docenteImparte(arg1, Common.Cache.UserLoginCache.IdUser);
            if (materia != "")
            {
                if (gpAlumnSql.alumnoCursa(arg1, arg2))
                {
                    if (calificacionesSql.searchCalifi(arg2, materia))
                        calificacionesSql.updateCalifi(arg2, materia, Common.Cache.UserLoginCache.IdUser, arg3);
                    else
                        calificacionesSql.addCalifi(arg2, materia, Common.Cache.UserLoginCache.IdUser, arg3);
                    return true;
                }

                else
                    return false;

            }
            return false;
        }
        public string docenteImparte(string arg1, string arg2, string arg3)
        {
            string materia = grupoSql.docenteImparte(arg1, Common.Cache.UserLoginCache.IdUser);
            materia = matSql.buscarMateriaId(materia)[1];
            return materia;
        }

    }
}
