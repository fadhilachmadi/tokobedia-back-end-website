using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.handler;
using TokoBeDia.helper;

namespace TokoBeDia.controller
{
    public class UserAndRole
    {

        public User user;
        public Role role;
        public UserAndRole(User user)
        {
            this.user = user;
            role = RoleHandler.getById((int)user.RoleId);
        }
    }

    public class UserController
    {

        public static Response ViewUserToAdmin(int id)
        {
            return new Response(true, UserHandler.getUserForAdmin(id));
        }

        public static Response ViewUpdateUser(int id)
        {
            User user = UserHandler.getUserById(id);

            if (user == null)
            {
                return new Response(false, "User not found");
            }

            return new Response(true, user);
        }

        public static Response ViewUpdateProfile(int id)
        {
            User user = UserHandler.getUserById(id);

            if (user == null)
            {
                return new Response(false, "User not found");
            }

            return new Response(true, user);
        }

        public static Response UpdateUser(int id, string name, string email, string status)
        {


            if (name == null || name == "")
            {
                return new Response(false, "Name can't be null");
            }

            if (email == null || email == "")
            {
                return new Response(false, "Email can't be null");
            }

            if (status == null || status == "")
            {
                return new Response(false, "Status can't be null");
            }

            Response updateUser = UserHandler.updateUser(id, name, email, status);
            if (updateUser.data == null)
            {
                return new Response(false, "User not found");
            }

            return new Response(true);
        }

        public static Response UpdateProfile(int id, string name, string email, string gender)
        {
            if (name == null || name == "")
            {
                return new Response(false, "Name can't be null");
            }

            if (email == null || email == "")
            {
                return new Response(false, "Email can't be null");
            }

            if (gender == null || gender == "")
            {
                return new Response(false, "Gender can't be null");
            }


            Response updateProfile = UserHandler.updateProfile(id, name, email, gender);

            if (!updateProfile.successStatus)
            {
                return new Response(false, updateProfile.message);
            }

            return new Response(true);
        }

        public static Response UpdateStatus(int id, string status)
        {
            UserHandler.updateStatus(id, status);
            return new Response(true);
        }

        public static Response UpdateRole(int id, string roleName)
        {
            UserHandler.updateRole(id, roleName);
            return new Response(true);
        }

        public static Response ViewUserProfile(int id)
        {
            return new Response(true, UserHandler.searchProfile(id));
        }

        public static Response LoginUser(string email, string password)
        {
            if (email == null || email == "")
            {
                return new Response(false, "Email must be specified");
            }

            if (password == null || password == "")
            {
                return new Response(false, "Password must be specified");
            }

            User user = UserHandler.getUserByEmail(email);


            if (user == null)
            {
                return new Response(false, "User not found");
            }

            if (user.Password != password)
            {
                return new Response(false, "User not found");
            }


            if (user.Status == "banned")
            {
                return new Response(false, "User not active");
            }


            return new Response(true, new UserAndRole(user));
        }

        public static Response RegisterUser(String name, String email, String password, String confirmPassword, String gender, Role role, String status)
        {
            if (name == null || name == "")
            {
                return new Response(false, "Name is empty");
            }


            if (password == null || password == "")
            {
                return new Response(false, "Password is empty");

            }


            if (password != confirmPassword)
            {
                return new Response(false, "Confirm password field must be the same as Password field");
            }


            Response insertUser = UserHandler.insertUser(name, email, password, gender, role, status);

            if (!insertUser.successStatus)
            {
                return new Response(false, insertUser.message);
            }

            return new Response(true);
        }

        public static Response ChangePassword(int id, string oldPassword, string confirmPassword, string newPassword)
        {
            if (oldPassword == "" || oldPassword == null)
            {
                return new Response(false, "Old password is empty");
            }

            if (newPassword == "" || newPassword == null)
            {
                return new Response(false, "new password is empty");

            }

            if (!newPassword.Equals(confirmPassword))
            {
                return new Response(false, "New password doesn't same as Confirm password");
            }

            User user = UserHandler.getUserById(id);

            UserHandler.changePassword(user, newPassword);

            return new Response(true, "Successfully change password");
        }
    }
}