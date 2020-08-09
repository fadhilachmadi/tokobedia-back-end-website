using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.controller;
using TokoBeDia.factory;
using TokoBeDia.helper;
using TokoBeDia.repository;

namespace TokoBeDia
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Submit_Click(object sender, EventArgs e)
        {

            Role role = RoleRepository.searchRoleByName("admin");
            String name = txtName.Text;
            String email = txtEmail.Text;
            String password = txtPassword.Text;
            String gender = txtGender.Text;
            String confirmPassword = txtConfirmPassword.Text;
            String status = "ACTIVE";

            Response RegisterUser = UserController.RegisterUser(name, email, password, confirmPassword, gender, role, status);

            if (!RegisterUser.successStatus)
            {
                ErrorMessage.print(this, RegisterUser.message);
                return;
            }

            Response.Redirect("Login.aspx");
        }
    }
}