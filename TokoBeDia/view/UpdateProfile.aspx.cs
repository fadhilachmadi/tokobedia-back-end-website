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
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }


            if (!IsPostBack)
            {
                int id = Int32.Parse(Session["userId"].ToString());

                Response ViewUpdateUserProfile = UserController.ViewUpdateProfile(id);
                txtEmail.Text = ViewUpdateUserProfile.data.Email;
                txtName.Text = ViewUpdateUserProfile.data.Name;
                txtGender.SelectedValue = ViewUpdateUserProfile.data.Gender;
            }
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Session["userId"].ToString());


            String email = txtEmail.Text;
            String name = txtName.Text;
            String gender = txtGender.SelectedValue;


            Response UpdateProfile = UserController.UpdateProfile(id, name, email, gender);

            if (!UpdateProfile.successStatus)
            {
                ErrorMessage.print(this, UpdateProfile.message);
                return;
            }
            Response.Redirect("Profile.aspx");
        }
    }
}