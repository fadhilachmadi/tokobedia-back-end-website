using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.handler;
using TokoBeDia.helper;

namespace TokoBeDia.controller
{
    public class PaymentTypeController
    {
        public static Response ViewPaymentType()
        {
            List<PaymentType> paymentType = PaymentTypeHandler.getAllPaymentType();
            return new Response(true, paymentType);
        }

        public static Response ViewUpdatePaymentType(int id)
        {
            PaymentType paymentType = PaymentTypeHandler.getPaymentTypeById(id);
            if (paymentType == null)
            {
                return new Response(false, "Payment Type not found");
            }

            return new Response(true, paymentType);
        }

        public static Response InsertPaymentType(string name)
        {
            if (name == null || name == "")
            {
                return new Response(false, "Payment type name must be specified");
            }

            if (name.Length < 3)
            {
                return new Response(false, "Payment type can't be lower than 3 characters");
            }

            Response insertPaymentType = PaymentTypeHandler.saveProductType(name);

            if (!insertPaymentType.successStatus)
            {
                return new Response(false, insertPaymentType.message);
            }

            return new Response(true);
        }

        public static Response DeletePaymentType(int id)
        {
            Response deletePaymentType = PaymentTypeHandler.deletePaymentType(id);
            if (!deletePaymentType.successStatus)
            {
                return new Response(false, deletePaymentType.successStatus);
            }

            return new Response(true);
        }

        public static Response UpdatePaymentType(int id, string name)
        {

            if (name == null || name == "")
            {
                return new Response(false, "Payment type name must be specified");
            }

            if (name.Length < 3)
            {
                return new Response(false, "Payment type can't be lower than 3 characters");
            }

            Response updatePaymentType = PaymentTypeHandler.updatePaymentType(id, name);


            if (!updatePaymentType.successStatus)
            {
                return new Response(false, updatePaymentType.message);
            }

            return new Response(true);
        }
    }
}
