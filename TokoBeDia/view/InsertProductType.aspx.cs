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
    public partial class InsertProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }


        protected void btnInsertProductType_Click(object sender, EventArgs e)
        {
    
            String name = txtName.Text;
            String description = txtDescription.Text;

            Response InsertProductType = ProductTypeController.InsertProductType(name, description);
            if (!InsertProductType.successStatus)
            {
                ErrorMessage.print(this, InsertProductType.message);
            }
            Response.Redirect("ViewProductType.aspx");
        }
    }
}