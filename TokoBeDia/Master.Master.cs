using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.repository;

namespace TokoBeDia.view
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["userinfo"] != null)
            {
                if (Session["userId"] == null)
                {
                    User user = UserRepository.searchUserById(Int32.Parse(Request.Cookies["userinfo"].Value));
                    Role role = RoleRepository.searchRoleById((int)user.RoleId);
                    Session["userId"] = user.Id;
                    Session["email"] = user.Email;
                    Session["role"] = role.Name;
                }
            }
        }

        
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["userId"] = null;
            Session["email"] = null;
            Session["roles"] = null;
            if(Request.Cookies["userinfo"] != null)
            {
                HttpCookie cookie = Request.Cookies["userinfo"];
                cookie.Expires = DateTime.Now.AddDays(-5);
                cookie.Value = null;
                HttpContext.Current.Response.SetCookie(cookie);
            }
            //Request.Cookies.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}