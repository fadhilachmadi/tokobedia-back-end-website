using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.handler;
using TokoBeDia.helper;

namespace TokoBeDia.controller
{
    public class ProductTypeController
    {
        public static Response ViewProductType()
        {
            List<ProductType> productTypes = ProductTypeHandler.getAllProductType();
            return new Response(true, productTypes);
        }

        public static Response ViewUpdateProductType(int id)
        {
            ProductType productType = ProductTypeHandler.getProductTypeById(id);
            if(productType == null)
            {
                return new Response(false, "Product Type not found");
            }

            return new Response(true, productType);
        }

        public static Response InsertProductType(string name, string description) {
            if (name == null || name == "")
            {
                return new Response(false, "Product type name must be specified");
            }

            if (name.Length < 5)
            {
                return new Response(false, "Product type can't be lower than 5 characters");
            }

            if (description == null || description == "")
            {
                return new Response(false, "Product type description must be specified");
            }

            Response insertProductType = ProductTypeHandler.saveProductType(name, description);

            if (!insertProductType.successStatus) {
                return new Response(false, insertProductType.message);
            }


            return new Response(true);
        }

        public static Response DeleteProductType(int id)
        {
            Response deleteProductType = ProductTypeHandler.deleteProductType(id);
            if (!deleteProductType.successStatus)
            {
                return new Response(false, deleteProductType.successStatus);
            }

            return new Response(true);
        }

        public static Response UpdateProductType(int id, string name, string description)
        {

            if (name == null || name == "")
            {
                return new Response(false, "Product type name must be specified");
            }

            if (name.Length < 5)
            {
                return new Response(false, "Product type can't be lower than 5 characters");
            }

            if (description == null || description == "")
            {
                return new Response(false, "Product type description must be specified");
            }

            Response updateProductType = ProductTypeHandler.updateProductType(id, name, description);


            if (!updateProductType.successStatus)
            {
                return new Response(false, updateProductType.message);
            }

            return new Response(true);
        }
    }
}