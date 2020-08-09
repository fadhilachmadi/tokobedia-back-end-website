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
    public partial class InsertProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["userId"] == null) {
                Response.Redirect("Login.aspx");
            }

            if(ProductTypeList.Items.Count == 0)
            {
                List<ProductType> productTypes = ProductTypeRepository.getAllProductType();
                foreach (ProductType productType in productTypes)
                {
                    ProductTypeList.Items.Add(new ListItem(productType.Name, productType.Id.ToString()));
                }
            }
        }

        protected void btnInsertProduct_Click(object sender, EventArgs e)
        {
            int productTypeId = 0;


            foreach (ListItem item in ProductTypeList.Items)
            {
                if (item.Selected)
                {
                    productTypeId = Int32.Parse(item.Value);
                }
            }

            Response InsertProduct = ProductController.SaveProduct(txtName.Text, txtPrice.Text, txtStock.Text, productTypeId, (int)Session["userId"]);

            if (!InsertProduct.successStatus)
            {
                ErrorMessage.print(this,InsertProduct.message);
                return;
            }

            Response.Redirect("ViewProduct.aspx");
        }

  
    }
}