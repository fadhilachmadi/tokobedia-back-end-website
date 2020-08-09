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
    public partial class UpdateProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }


            if (!IsPostBack)
            {
                //call the function to load initial data into controls....
                int id = Int32.Parse(Request.QueryString["id"].ToString());
                Response ViewUpdateProductType = ProductTypeController.ViewUpdateProductType(id);
                ProductType pt = ViewUpdateProductType.data;
                txtName.Text = pt.Name;
                txtDescription.Text = pt.Description;
            }
       
        }

        protected void btnUpdateProductType_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"].ToString());
            Response UpdateProductType = ProductTypeController.UpdateProductType(id, txtName.Text, txtDescription.Text);

            if (!UpdateProductType.successStatus) {
                ErrorMessage.print(this,UpdateProductType.message);
                return;
            }
            Response.Redirect("ViewProductType.aspx");
        }
    }
}