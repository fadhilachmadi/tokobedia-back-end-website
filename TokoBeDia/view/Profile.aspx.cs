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
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            
            Response ViewUserProfile = UserController.ViewUserProfile((int)Session["userId"]);
            List<User> users = new List<User>();
            users.Add(ViewUserProfile.data);
            dgvProfile.DataSource = users;
            dgvProfile.DataBind();
        }

        protected void btnGoToProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }
    }
}