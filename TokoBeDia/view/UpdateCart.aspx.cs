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
    public partial class UpdateCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }


            if ((String)Session["role"] != "member")
            {
                ErrorMessage.print(this, "Must be member");
                return;
            }

            if (!IsPostBack)
            {

                int productId = Int32.Parse(Request.QueryString["productId"].ToString());
                int userId = (int)Session["userId"];

                Response UpdateCart = CartController.ViewUpdateCart(userId, productId);

                dynamic cart = UpdateCart.data;
                txtName.Text = cart.ProductName;
                txtPrice.Text = ((int)cart.ProductPrice).ToString();
                txtQty.Text = cart.Quantity.ToString();
                txtProductTypeName.Text = cart.ProductTypeName;
                txtStock.Text = cart.ProductStock.ToString();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int productId = Int32.Parse(Request.QueryString["productId"].ToString());
            int userId = (int)Session["userId"];
            Response UpdateCart = CartController.UpdateCart(userId,productId,txtQty.Text);

            if (!UpdateCart.successStatus)
            {
                ErrorMessage.print(this, UpdateCart.message);
                return;
            }
            Response.Redirect("ViewCart.aspx");
        }
    }
}