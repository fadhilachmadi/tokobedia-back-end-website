using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.controller;
using TokoBeDia.helper;
using TokoBeDia.repository;

namespace TokoBeDia.view
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String email = txtEmail.Text.ToLower();
            String password = txtPassword.Text;
            Boolean rememberMe = RememberMe.Checked;

            Response LoginUser = UserController.LoginUser(email, password);

            if (!LoginUser.successStatus) {
                ErrorMessage.print(this,LoginUser.message);
                return;
            }

            User user = LoginUser.data.user;
            Role role = LoginUser.data.role;

            Session.Add("userId", user.Id);
            Session.Add("email", email);
            Session.Add("role", role.Name);

            if (rememberMe)
            {
                HttpCookie userinfo = new HttpCookie("userinfo");
                userinfo.Value = user.Id.ToString();
                Response.Cookies.Add(userinfo);
            }


            Response.Redirect("Homepage.aspx");
        }
    }
}