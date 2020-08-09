using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TokoBeDia.factory
{
    public class UserFactory
    {
        public static User createUser(String name,String email, String password, String gender, Role role, String status)
        {
            User user = new User();
            user.Name = name;
            user.Email = email.ToLower();
            user.Password = password;
            user.Gender = gender.ToLower();
            user.Status = status.ToLower();
            user.RoleId = role.Id;
            return user;
        }
    }
}