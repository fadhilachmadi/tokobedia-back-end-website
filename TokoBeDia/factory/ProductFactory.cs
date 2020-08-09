using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.factory
{
    public class ProductFactory
    {
        public static Product createProduct(String name,int price ,int stock, int productTypeId ,int userId) {
            Product product = new Product();
            product.Name = name.ToLower();
            product.Price = price;
            product.Stock = stock;
            product.ProductTypeId = productTypeId;
            product.UserId = userId;
            return product;
        }
    }
}