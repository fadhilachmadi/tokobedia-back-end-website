using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.helper;
using TokoBeDia.repository;

namespace TokoBeDia.handler
{
    public class UserHandler
    {
        public static dynamic getUserForAdmin(int id)
        {
            return UserRepository.viewUserToAdmin(id);
        }

        public static User getUserById(int id)
        {
            return UserRepository.searchUserById(id);
        }


        public static void changePassword(User user, string newPassword)
        {
            UserRepository.changePassword(user, newPassword);
        }
        public static User getUserByEmail(string email)
        {
            return UserRepository.searchUserByEmail(email);
        }

        public static Response insertUser(String name, String email, String password, String gender, Role role, String status)
        {
            User user = getUserByEmail(email);

            if (user != null)
            {
                return new Response(false, "User has already created");
            }

            return new Response(true, UserRepository.saveUser(name, email, password, gender, role, status));
        }

        public static Response updateUser(int id, string name, string email, string status)
        {
            User user = getUserById(id);
            if (user == null)
            {
                return new Response(false, "User not found");
            }


            UserRepository.updateUser(user, name, email, status);

            return new Response(true);
        }

        public static Response updateProfile(int id, string name, string email, string gender)
        {
            User user = getUserById(id);

            if (user == null)
            {
                return new Response(false, "User not found");
            }

            UserRepository.updateProfile(user, name, email, gender);

            return new Response(true);
        }

        public static Response updateStatus(int id, string status)
        {
            User user = getUserById(id);

            if (user == null)
            {
                return new Response(false, "User not found");
            }

            UserRepository.updateStatus(user, status);

            return new Response(true);
        }


        public static Response updateRole(int id, string roleName)
        {
            User user = getUserById(id);
            Role role = RoleRepository.searchRoleByName(roleName);

            if (user == null)
            {
                return new Response(false, "User not found");
            }

            UserRepository.updateRoles(user, role);

            return new Response(true);
        }

        public static User searchProfile(int id)
        {
            return UserRepository.searchUserProfileById(id);
        }


    }
}