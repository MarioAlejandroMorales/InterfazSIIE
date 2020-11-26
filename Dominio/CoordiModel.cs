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
        RegistroSql registroSql = new RegistroSql();
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
            string resultado = matSql.addMateria(arg);
            registroSql.addRegistro(Common.Cache.UserLoginCache.IdUser, "La materia " + arg + " con id " + resultado + " ha sido agregada ", "");
            
            return resultado;

        }
        public string agregarGrupo(List<string> args)
        {
            GrupoSql grupoSql = new GrupoSql();
            
            string resultado = grupoSql.addGrupo(args);
            registroSql.addRegistro(Common.Cache.UserLoginCache.IdUser, "El grupo " + resultado + " ha sido agregado ", "");

            return resultado;
        }
        public bool addMateria(string arg1,string arg2)
        {
            GpAlumnSql gpAlumnSql = new GpAlumnSql();
            
            bool resultado = gpAlumnSql.registrarMateria(arg1, arg2);
            registroSql.addRegistro(Common.Cache.UserLoginCache.IdUser, "El alumno " + arg2 + " ha sido registrado en el grupo " + arg1, "");
            return resultado;
        }
        public bool removeMateria(string arg1, string arg2)
        {
            GpAlumnSql gpAlumnSql = new GpAlumnSql();
            
            bool resultado = gpAlumnSql.removeMateria(arg1, arg2);
            registroSql.addRegistro(Common.Cache.UserLoginCache.IdUser, "El alumno " + arg2 + " ha sido dado de baja del grupo " + arg1, "");
            return resultado;
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
            
            
            registroSql.addRegistro(Common.Cache.UserLoginCache.IdUser, "La materia " + matSql.buscarMateriaId(arg)[1] + " con id " + matSql.buscarMateriaId(arg)[0] + " ha sido Eliminada ", "");
            bool resultado = matSql.deletMateria(arg);
            return resultado;
        }
        public bool delGrupo(string arg)
        {
            GrupoSql grupoSql = new GrupoSql();
            
            registroSql.addRegistro(Common.Cache.UserLoginCache.IdUser, "El grupo  " + arg + " ha sido Eliminado ", "");
            bool resultado = grupoSql.delGrupo(arg);
            return resultado;
        }
        public bool bajaAlumno(string arg)
        {
            AlumnoSql alumnoSql = new AlumnoSql();
            string prevStat = alumnoSql.getStatus(arg);
            string nextStat = "";
            if (prevStat == "ACTIVO")
                nextStat = "BAJA";
            else
                nextStat = "ACTIVO";
            registroSql.addRegistro(Common.Cache.UserLoginCache.IdUser, "El alumno  " + arg + " ha sido cambiado a estatus: " + nextStat, prevStat);
            bool resultado = alumnoSql.bajaAlumno(arg);
            return resultado;
        }
    }
}
