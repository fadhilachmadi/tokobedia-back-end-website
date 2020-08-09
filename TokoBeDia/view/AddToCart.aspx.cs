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
    public partial class AddToCart : System.Web.UI.Page
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

                Response AddToCartView = CartController.AddToCartView(productId);
                if (!AddToCartView.successStatus)
                {
                    ErrorMessage.print(this, AddToCartView.message);
                    Response.Redirect("ViewProduct.aspx");
                }

                Product product = AddToCartView.data;

                txtName.Text = product.Name;
                txtPrice.Text = product.Price.ToString();
                txtStock.Text = product.Stock.ToString();
                txtProductTypeName.Text = product.ProductType.Name;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int productId = Int32.Parse(Request.QueryString["productId"].ToString());
            int userId = (int)Session["userId"];
            Response AddToCart = CartController.AddToCart(productId,userId, txtQty.Text.ToString());

            if (!AddToCart.successStatus)
            {
                ErrorMessage.print(this, AddToCart.message);
                return;
            }

            Response.Redirect("ViewProduct.aspx");
        }
    }
}