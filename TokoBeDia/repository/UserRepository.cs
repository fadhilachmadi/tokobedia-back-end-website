using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.factory;

namespace TokoBeDia.repository
{


    public class UserRepository
    {

        private static DatabaseEntities db = new DatabaseEntities();

        public static User saveUser(String name, String email, String password, String gender, Role role, String status)
        {

            User user = UserFactory.createUser(name, email, password, gender, role, status);
            db.Users.Add(user);
            db.SaveChanges();
            return user;
        }

        public static User searchUserByEmail(String email)
        {
            User user = (from x in db.Users join o in db.Roles on x.RoleId equals o.Id where x.Email == email select x).FirstOrDefault();
            return user;
        }

        public static List<User> getAllUser()
        {
            return db.Users.ToList();
        }

        public static User searchUserById(int id)
        {
            User user = (from x in db.Users where x.Id == id select x).FirstOrDefault();
            return user;
        }

        public static dynamic viewUserToAdmin(int id)
        {
            var userWithRole = (from x in db.Users
                                join o in db.Roles on x.RoleId equals o.Id
                                where x.Id != id
                                select new
                                {
                                    Id = x.Id,
                                    Name = x.Name,
                                    RoleName = o.Name,
                                    Email = x.Email,
                                    Status = x.Status,
                                    Gender = x.Gender
                                }).ToList();
            return userWithRole;
        }


        public static User searchUserProfileById(int id)
        {
            User user = (from x in db.Users.AsEnumerable()
                         where x.Id == id
                         select new User
                         {
                             Name = x.Name,
                             Email = x.Email,
                             Gender = x.Gender
                         }).FirstOrDefault();
            return user;
        }

        public static void updateStatus(User user, string status) {
            user.Status = status.TrimEnd();
            db.SaveChanges();
        }

        public static void updateRoles(User user, Role role)
        {
            user.RoleId = role.Id;
            db.SaveChanges();
        }

        public static void updateUser(User user, String name, String email, String status)
        {
            user.Name = name;
            user.Email = email;
            user.Status = status;
            db.SaveChanges();
        }

        public static void updateProfile(User user, String name, String email, String gender)
        {
            user.Name = name;
            user.Email = email;
            user.Gender = gender;
            db.SaveChanges();
        }

        public static void changePassword(User user, String password)
        {
            user.Password = password;
            db.SaveChanges();
        }
    }
}