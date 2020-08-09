using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.helper;
using TokoBeDia.repository;

namespace TokoBeDia.handler
{
    public class ProductHandler
    {
        public static List<Product> getAllProduct()
        {
            return ProductRepository.getListProduct();
        }

        public static dynamic getAllProductWithProductType()
        {
            return ProductRepository.getAllProductsWithTypeName();
        }

        public static Product getByName(string name)
        {
            return ProductRepository.searchByName(name);
        }

        public static Response deleteProduct(int id)
        {
            Product product = getById(id);

            if(product == null)
            {
                return new Response(false, "Product not found");
            }
            ProductRepository.deleteProduct(product);
            return new Response(true);
        }

        public static Response updateProduct(int id, String name, int stock, int price, int productTypeId) {
            Product productById = getById(id);
            Product productByName = getByName(name);

            if (productById == null)
            {
                return new Response(false, "Product not found");
            }

            if (productByName != null && productByName.Name != productById.Name)
            {
                return new Response(false, "Product must be unique");
            }


            ProductRepository.updateProduct(productById, name, stock, price, productTypeId);
            return new Response(true);
        }

        public static Product getById(int id) {
            return ProductRepository.searchById(id);
        }

        public static Response insertProduct(String name, int price, int stock, int productTypeId, int userId) {
            Product product = ProductHandler.getByName(name);

            if(product != null)
            {
                return new Response(false, "Product must be unique");
            }

            ProductRepository.createProduct(name, price, stock, productTypeId, userId);
            return new Response(true);
        }
    }
}   