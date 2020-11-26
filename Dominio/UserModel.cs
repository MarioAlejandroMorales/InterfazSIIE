using AccesoDatos;
using Common.Cache;

namespace Dominio
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string user, string pass)
        {
            return userDao.login(user, pass);
        }
        public bool onLoged()
        {
            string query = "SELECT * FROM ";
            if (UserLoginCache.Rol == "0")
            {
                query += "Usuarios WHERE idUsuario='";
                return true;
            }
            else if (UserLoginCache.Rol == "1")
                query+="Coordinadores WHERE idCoordinador='";
            else if (UserLoginCache.Rol == "2")
                query+="Docentes WHERE idDocente='";
            else if (UserLoginCache.Rol == "3")
                query+="Alumnos WHERE idAlumno='";

            query += UserLoginCache.IdUser+"'";
            //userDao.onLogon(query);

            return userDao.onLogon(query);
        }
        public string recoverPassword(string userRequesting)
        {

            return userDao.recoverPassword(userRequesting);
        }

    }
}
