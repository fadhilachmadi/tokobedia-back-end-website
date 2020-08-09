using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.factory;

namespace TokoBeDia.repository
{
    public class ProductRepository
    {
       public static DatabaseEntities db = new DatabaseEntities();
        public static void createProduct(String name,int price,int stock,int productTypeId,int userId) {
            Product product = ProductFactory.createProduct(name,price,stock,productTypeId,userId);
            db.Products.Add(product);
            db.SaveChanges();
        }       


        public static List<Product> getListProduct()
        {
            return db.Products.ToList();
        }



        public static dynamic getAllProductsWithTypeName()
        {
            var list = (from p in db.Products
                        join pt in db.ProductTypes on p.ProductTypeId equals pt.Id
                        select new
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Stock = p.Stock,
                            Price = p.Price,
                            ProductTypeName = pt.Name
                        }).ToList();
            return list;
        }

        public static Product searchById(int id)
        {
            Product product = (from x in db.Products join pt in db.ProductTypes on x.ProductTypeId equals pt.Id where x.Id == id select x).FirstOrDefault();
            return product;
        }
        
        public static Product searchByName(string name)
        {
            Product product = (from x in db.Products where x.Name == name select x).FirstOrDefault();
            return product;
        }

        public static void updateProduct(Product product, String name ,int stock ,int price,int productTypeId)
        {
            
            product.Name = name;
            product.Stock = stock;
            product.Price = price;
            product.ProductTypeId = productTypeId;
            db.SaveChanges();
        }

        public static int countProduct()
        {
            return db.Products.Count();
        }

        public static void deleteProduct(Product product) {
            db.Products.Remove(product);
            db.SaveChanges();
        }
    }
}