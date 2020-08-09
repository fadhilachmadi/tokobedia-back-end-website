using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.repository;

namespace TokoBeDia.handler
{
    public class HomepageHandler
    {
        public static dynamic viewHomepage()
        {
            List<Product> products = ProductRepository.getListProduct();
            List<ProductType> productTypes = ProductTypeRepository.getAllProductType();
            dynamic query;
            int countProduct = ProductRepository.countProduct();

            if (countProduct <= 5)
            {
                query = from x in products
                        join y in productTypes on x.ProductTypeId equals y.Id
                        select new
                        {
                            Name = x.Name,
                            Price = x.Price,
                            Stock = x.Stock,
                            ProductTypeName = y.Name
                        };
            }
            else
            {
                Random random = new Random();
                List<Int32> randomNumber = new List<Int32>();
                List<Int32> productIds = new List<Int32>();

                foreach (var product in products)
                {
                    productIds.Add(product.Id);
                }

                List<Product> randProducts = new List<Product>();

                for (int i = 0; i < 5; i++)
                {
                    int number = 0;
                    Product check = null;
                    do
                    {

                        number = random.Next(productIds.First(), productIds.Last());
                        check = ProductRepository.searchById(number);
                    } while (check == null || randomNumber.Contains(number));
                    randomNumber.Add(number);
                    randProducts.Add(check);
                }

                query = from x in randProducts
                        join y in productTypes on x.ProductTypeId equals y.Id
                        select new
                        {
                            Name = x.Name,
                            Price = x.Price,
                            Stock = x.Stock,
                            ProductTypeName = y.Name
                        };
            }
            return query;
        }
    }
}