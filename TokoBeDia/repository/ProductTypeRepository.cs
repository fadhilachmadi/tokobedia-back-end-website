using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.factory;

namespace TokoBeDia.repository
{
    public class ProductTypeRepository
    {
       public static DatabaseEntities db = new DatabaseEntities();
        public static void saveProductType(String name, String description)
        {
            ProductType productType = ProductTypeFactory.createProductType(name, description);
            db.ProductTypes.Add(productType);
            db.SaveChanges();
        }

        public static List<ProductType> getAllProductType()
        {
            return db.ProductTypes.ToList();
        }

        public static ProductType searchProductTypeById(int id) {
            ProductType productType = (from x in db.ProductTypes where x.Id == id select x).FirstOrDefault();
            return productType;
        }

        public static ProductType searchProductTypeByName(String name)
        {
            ProductType productType = (from x in db.ProductTypes where x.Name == name select x).FirstOrDefault();
            return productType;
        }

        public static void updateProductType(ProductType productType, String name,String description)
        {
            productType.Name = name;
            productType.Description = description;
            db.SaveChanges();
        }

        public static void DeleteProduct(ProductType productType) {
            db.ProductTypes.Remove(productType);
            db.SaveChanges();
        }
    }
}