using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.handler;
using TokoBeDia.helper;

namespace TokoBeDia.controller
{
    public class ProductAndProductType
    {
        public Product product;
        public List<ProductType> productType;
        public ProductAndProductType(Product product, List<ProductType> productType) {
            this.product = product;
            this.productType = productType;
        }
    }

    public class ProductController
    {
        public static Response ViewProduct()
        {
            return new Response(true, ProductHandler.getAllProductWithProductType());
        }

        public static Response ViewUpdateProduct(int id)
        {

            Product product = ProductHandler.getById(id);
            List<ProductType> productType = ProductTypeHandler.getAllProductType();

            if(product == null)
            {
                return new Response(false, "Product not found");
            }

            return new Response(true, new ProductAndProductType(product, productType));
        }

        public static Response DeleteProduct(int id)
        {
            Response deleteProduct = ProductHandler.deleteProduct(id);
            if (!deleteProduct.successStatus)
            {
                return new Response(false, deleteProduct.message);
            }
            return new Response(true);
        }

        public static Response UpdateProduct(int id, String name, int stock, int price, int productTypeId)
        {

            if (name == null || name == "")
            {
                return new Response(false, "Product name must be specified");
            }

            if (stock <= 0)
            {
                return new Response(false, "Product stock can't be lower or equal to 0");
            }

            if (price < 1000)
            {
                return new Response(false, "Product price can't be lower than 1000");
            }

            if (price % 1000 != 0)
            {
                return new Response(false, "Product price must be fraction of 1000");
            }
            
            Response updateProduct = ProductHandler.updateProduct(id, name, stock, price, productTypeId);
            
            return new Response(true);
        }


        public static Response SaveProduct(String name, string priceText, string stockText, int productTypeId, int userId)
        {
            if (name == null || name == "")
            {
                return new Response(false, "Product name must be specified");
            }

            if (stockText == null || stockText == "")
            {
                return new Response(false, "Product stock must be specified");
            }


            if (priceText == null || priceText == "")
            {
                return new Response(false, "Product price must be specified");
            }
            
            int stock = Int32.Parse(stockText);
            int price = Int32.Parse(priceText);

            if (stock <= 0)
            {
                return new Response(false, "Product stock can't be lower or equal to 0");
            }

            if (price < 1000)
            {
                return new Response(false, "Product price can't be lower than 1000");
            }

            if (price % 1000 != 0)
            {
                return new Response(false, "Product price must be fraction of 1000");
            }


            Response insertProduct = ProductHandler.insertProduct(name, price, stock, productTypeId, userId);

            if (!insertProduct.successStatus)
            {
                return new Response(false, insertProduct.message);
            }

            return new Response(true);
        }
    }
}
