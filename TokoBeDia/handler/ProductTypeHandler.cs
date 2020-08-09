using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.helper;
using TokoBeDia.repository;

namespace TokoBeDia.handler
{
    public class ProductTypeHandler
    {
        public static List<ProductType> getAllProductType()
        {
            return ProductTypeRepository.getAllProductType();
        }
        

        public static Response saveProductType(String name, String description)
        {
            ProductType productType = getProductTypeByName(name);
            if (productType != null)
            {
                return new Response(false,"Product type must be unique");
            }
            ProductTypeRepository.saveProductType(name, description);
            return new Response(true);
        }

        public static ProductType getProductTypeById(int id)
        {
            return ProductTypeRepository.searchProductTypeById(id);
        }

        public static ProductType getProductTypeByName(String name)
        {
            return ProductTypeRepository.searchProductTypeByName(name);
        }
        

        public static Response updateProductType(int id,String name, String description)
        {
            ProductType productTypeById = getProductTypeById(id);
            ProductType productTypeByName = getProductTypeByName(name);

            if (productTypeById == null)
            {
                return new Response(false,"Product type not found");
            }


            if(productTypeByName != null && productTypeById.Name != productTypeByName.Name)
            {
                return new Response(false, "Product type must be unique");
            }


            ProductTypeRepository.updateProductType(productTypeById, name, description);
            return new Response(true);
        }

        public static Response deleteProductType(int id) {
            ProductType productType = getProductTypeById(id);

            if(productType == null)
            {
                return new Response(false, "Product type not found");
            }

            ProductTypeRepository.DeleteProduct(productType);
            return new Response(true);
        }
    }
}