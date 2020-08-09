using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia;

namespace TokoBeDia.factory
{
    public class PaymentTypeFactory
    {
        public  static PaymentType createPaymentType(string name)
        {
            PaymentType type = new PaymentType();
            type.Name = name;
            return type;

        }
    }
}