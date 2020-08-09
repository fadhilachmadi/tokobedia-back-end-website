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
    public partial class UpdateProduct1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
           
            if (!IsPostBack)
            {

                int id = Int32.Parse(Request.QueryString["id"].ToString());
                Response ViewUpdateProduct = ProductController.ViewUpdateProduct(id);

                if (!ViewUpdateProduct.successStatus)
                {
                    ErrorMessage.print(this, ViewUpdateProduct.message);
                    Response.Redirect("ViewProduct.aspx");
                    return;
                }
                
                txtPrice.Text = ViewUpdateProduct.data.product.Price.ToString();
                txtName.Text = ViewUpdateProduct.data.product.Name.ToString();
                txtStock.Text = ViewUpdateProduct.data.product.Stock.ToString();

                List<ProductType> productTypes = ViewUpdateProduct.data.productType;

                if (productTypes.Count == 0)
                {
                    foreach (ProductType productType in productTypes)
                    {
                        ProductTypeList.Items.Add(new ListItem(productType.Name, productType.Id.ToString()));
                    }
                }
 
                ProductTypeList.SelectedValue = ViewUpdateProduct.data.product.ProductTypeId.ToString();   
            }
        }

        protected void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"].ToString());
            String name = txtName.Text;
            int stock = Int32.Parse(txtStock.Text);
            int price = Int32.Parse(txtPrice.Text);
            int ptid = Int32.Parse(ProductTypeList.SelectedValue);

            Response UpdateProduct = ProductController.UpdateProduct(id, name, stock, price, ptid);

            if (!UpdateProduct.successStatus)
            {
                ErrorMessage.print(this, UpdateProduct.message);
                return;
            }
            Response.Redirect("ViewProduct.aspx");
        }
    }
}