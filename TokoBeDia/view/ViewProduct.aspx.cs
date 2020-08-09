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
    public partial class ViewProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            if ((String)Session["role"] == "admin")
            {
                dgvProduct.Columns[4].Visible = true;
                dgvProduct.Columns[5].Visible = true;
            }

            if((String)Session["role"] == "member")
            {
                dgvProduct.Columns[6].Visible = true;
            }

            Response ViewProduct = ProductController.ViewProduct(); 
            dgvProduct.DataSource = ViewProduct.data;
            dgvProduct.DataBind();
        }

        protected void UpdateProduct_Click(object sender, EventArgs e)
        {
            int productId = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("UpdateProduct.aspx?id=" + productId.ToString());
        }

        protected void DeleteProduct_Click(object sender, EventArgs e)
        {
            int productId = Int32.Parse((sender as LinkButton).CommandArgument);
            Response DeleteProduct = ProductController.DeleteProduct(productId);
            if (!DeleteProduct.successStatus)
            {
                ErrorMessage.print(this, DeleteProduct.message);
                return;
            }
            Response.Redirect(Request.RawUrl);
        }

        protected void btnInsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct.aspx");
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            int userId = (int)Session["userId"];
            int productId = Int32.Parse((sender as LinkButton).CommandArgument);
           
            Response.Redirect("AddToCart.aspx?" + "productId=" + productId.ToString());
        }
    }
}