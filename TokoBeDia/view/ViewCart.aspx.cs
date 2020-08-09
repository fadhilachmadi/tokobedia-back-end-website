using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.controller;
using TokoBeDia.helper;

namespace TokoBeDia.view
{
    public partial class ViewCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }


            if ((String)Session["role"] != "member")
            {
                ErrorMessage.print(this, "Must be admin");
                return;
            }

            if (!IsPostBack)
            {
                int userId = Int32.Parse(Session["userId"].ToString());
                Response ViewCart = CartController.ViewCart(userId);
                dynamic carts = ViewCart.data;
                int grandTotal = 0;
                foreach (var cart in carts)
                {
                    grandTotal += cart.Subtotal;
                }

                dgvCart.DataSource = ViewCart.data;
                dgvCart.DataBind();

                txtGrandtotal.Text = "<strong>Grandtotal : <strong> " + grandTotal;
            }
        }

        protected void DeleteCart_Click(object sender, EventArgs e)
        {
            int userId = Int32.Parse(Session["userId"].ToString());

            int productId = Int32.Parse((sender as LinkButton).CommandArgument);
            Response DeleteCart = CartController.DeleteCart(userId,productId);

            if (!DeleteCart.successStatus)
            {
                ErrorMessage.print(this, DeleteCart.message);
                return;
            }

            Response.Redirect(Request.RawUrl);
        }

        protected void UpdateCart_Click(object sender, EventArgs e)
        {
            int userId = Int32.Parse(Session["userId"].ToString());

            int productId = Int32.Parse((sender as LinkButton).CommandArgument);

            Response.Redirect("UpdateCart.aspx?productId=" + productId);
        }
    }
}