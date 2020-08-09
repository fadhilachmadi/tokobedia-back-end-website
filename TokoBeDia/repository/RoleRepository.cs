using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.repository
{
    public class RoleRepository
    {

        public static DatabaseEntities db = new DatabaseEntities();

        public static List<Role> getAllRole()
        {
            return db.Roles.ToList();
        }
        public static Role searchRoleByName(String name)
        {
            Role role = (from x in db.Roles where x.Name == name select x).FirstOrDefault();
            return role;
        }

        public static Role searchRoleById(int id)
        {
            Role role = (from x in db.Roles where x.Id == id select x).FirstOrDefault();
            return role;
        }
    }
}