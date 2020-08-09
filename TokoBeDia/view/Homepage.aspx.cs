using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.controller;
using TokoBeDia.repository;

namespace TokoBeDia.view
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["userId"] != null)
            {
                Label1.Text = "<h1> Hi " + Session["email"].ToString() + "</h1>";
            }
            else
            {
                Label1.Text = "";
            }


            if (!IsPostBack)
            {
                //List<Product> products = ProductRepository.getListProduct();
                //List<ProductType> productTypes = ProductTypeRepository.getAllProductType();

                //int countProduct = ProductRepository.countProduct();
                //if (countProduct <= 5)
                //{
                //    var query = from x in products
                //                join y in productTypes on x.ProductTypeId equals y.Id
                //                select new
                //                {
                //                    Name = x.Name,
                //                    Price = x.Price,
                //                    Stock = x.Stock,
                //                    ProductTypeName = y.Name
                //                };
                //    dgvRandProd.DataSource = query;
                //    dgvRandProd.DataBind();
                //}
                //else
                //{
                //    Random random = new Random();
                //    List<Int32> randomNumber = new List<Int32>();
                //    List<Int32> productIds = new List<Int32>();

                //    foreach (var product in products)
                //    {
                //        productIds.Add(product.Id);
                //    }

                //    List<Product> randProducts = new List<Product>();

                //    for (int i = 0; i < 5; i++)
                //    {
                //        int number = 0;
                //        Product check = null;
                //        do
                //        {

                //            number = random.Next(productIds.First(), productIds.Last());
                //            check = ProductRepository.searchById(number);
                //        } while (check == null || randomNumber.Contains(number));
                //        randomNumber.Add(number);
                //        randProducts.Add(check);
                //    }

                //    var query = from x in randProducts
                //                join y in productTypes on x.ProductTypeId equals y.Id
                //                select new
                //                {
                //                    Name = x.Name,
                //                    Price = x.Price,
                //                    Stock = x.Stock,
                //                    ProductTypeName = y.Name
                //                };

                dgvRandProd.DataSource = HomepageController.ViewHomepage().data;
                dgvRandProd.DataBind();
            }
        }

        protected void btn_ViewPaymentType_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPaymentType.aspx");
        }
    }

}
