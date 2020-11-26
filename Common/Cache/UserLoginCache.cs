using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        public static string IdUser { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Email { get; set; }
        public static string Rol { get; set; }

        public static void resetCache()
        {
            IdUser = "";
            FirstName = "";
            LastName = "";
            Email = "";
            Rol = "";
        }
    }
}
