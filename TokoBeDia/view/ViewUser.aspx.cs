    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.controller;
using TokoBeDia.handler;
using TokoBeDia.helper;
using TokoBeDia.repository;

namespace TokoBeDia.view
{
    public partial class ViewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }


            if ((String)Session["role"] != "admin")
            {
                ErrorMessage.print(this, "Must be admin");
                return;
            }

            if (!IsPostBack)
            {
                Response ViewUserForAdmin = UserController.ViewUserToAdmin((int)Session["userId"]);
                dynamic users = ViewUserForAdmin.data;
                dgvUser.DataSource = ViewUserForAdmin.data;
                dgvUser.DataBind();
            }
        }

        protected void toggleStatus_Click(object sender, EventArgs e)
        {
            LinkButton toggleStatus = (sender as LinkButton);
            int id = Int32.Parse(toggleStatus.CommandArgument);
            string status = toggleStatus.Text;
            if (status == "active") {
                UserController.UpdateStatus(id, "active");
            }
            else
            {
                UserController.UpdateStatus(id, "banned");
            }
            Response.Redirect(Request.RawUrl);
        }

        protected void toggleRole_Click(object sender, EventArgs e)
        {
            LinkButton toggleRole = (sender as LinkButton);
            int id = Int32.Parse(toggleRole.CommandArgument);
            string roleName = toggleRole.Text;
            UserController.UpdateRole(id, roleName);
            Response.Redirect(Request.RawUrl);
        }
    }
}