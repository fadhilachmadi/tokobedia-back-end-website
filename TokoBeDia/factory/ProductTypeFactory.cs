using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.factory
{
    public class ProductTypeFactory
    {
         public static ProductType createProductType(String name, String description) {
            ProductType type = new ProductType();
            type.Name = name;
            type.Description = description;
            return type;
        }
    }
}