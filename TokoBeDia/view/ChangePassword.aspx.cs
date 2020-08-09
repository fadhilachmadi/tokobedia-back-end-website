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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            String confirmPassword = txtConfirmPassword.Text;
            String newPassword = txtNewPassword.Text;
            String oldPassword = txtOldPassword.Text;

            Response ChangePassword = UserController.ChangePassword((int)Session["userId"], oldPassword, confirmPassword, newPassword);
            if (!ChangePassword.successStatus)
            {
                ErrorMessage.print(this, ChangePassword.message);
                return;
            }

            ErrorMessage.print(this, ChangePassword.message);
        }
    }
}