using System;
using System.Collections.Generic;
using AccesoDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace Dominio
{
    public class CoordiModel:ConexionSQL
    {
        public List<string> buscarMateria(string arg, int tp)
        {
            MateriaSql matSql = new MateriaSql();
            List<string> dtM;
            if(tp==1)
                dtM=matSql.buscarMateriaNom(arg);
            else
                dtM = matSql.buscarMateriaId(arg);
            return dtM;
        }
        public string agregarMateria(string arg)
        {
            MateriaSql matSql = new MateriaSql();
            return matSql.addMateria(arg);
        }
        public string agregarGrupo(List<string> args)
        {
            GrupoSql grupoSql = new GrupoSql();
            return grupoSql.addGrupo(args);
        }
        public List<string> buscarGrupo(string arg)
        {
            GrupoSql grupoSql = new GrupoSql();
            List<string> dtG= grupoSql.findGrupo(arg);
            MateriaSql matSql = new MateriaSql();

            if (dtG.Count()>0)
                dtG[3] = matSql.getNombreId(dtG[3]);
            return dtG;
        }

        public bool eliminarMateria(string arg)
        {
            MateriaSql matSql = new MateriaSql();
            return matSql.deletMateria(arg);
        }
        public bool delGrupo(string arg)
        {
            GrupoSql grupoSql = new GrupoSql();
            return grupoSql.delGrupo(arg);
        }
        public bool bajaAlumno(string arg)
        {
            AlumnoSql alumnoSql = new AlumnoSql();
            return alumnoSql.bajaAlumno(arg);
        }
    }
}
