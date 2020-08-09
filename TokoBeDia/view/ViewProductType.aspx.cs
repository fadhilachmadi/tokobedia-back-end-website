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
    public partial class ViewProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if ((String)Session["role"] == "admin")
            {
                dgvProductType.Columns[2].Visible = true;
                dgvProductType.Columns[3].Visible = true;
            }

            Response viewProductType = ProductTypeController.ViewProductType();
            dgvProductType.DataSource = viewProductType.data;
            dgvProductType.DataBind();
        }


        protected void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            int productTypeId = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("UpdateProductType.aspx?id=" + productTypeId);
        }

        protected void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int productTypeId = Int32.Parse((sender as LinkButton).CommandArgument);
            Response DeleteProductType = ProductTypeController.DeleteProductType(productTypeId);
            if (!DeleteProductType.successStatus) {
                ErrorMessage.print(this,DeleteProductType.message);
            }
            Response.Redirect(Request.RawUrl);
        }

        protected void btnInsertProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductType.aspx");
        }
    }
}