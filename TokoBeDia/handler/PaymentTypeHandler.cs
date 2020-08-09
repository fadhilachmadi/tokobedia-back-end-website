using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.helper;
using TokoBeDia.repository;

namespace TokoBeDia.handler
{
    public class PaymentTypeHandler
    {

        public static List<PaymentType> getAllPaymentType()
        {
            return PaymentTypeRepository.getAllPaymentType();
        }

        public  static Response saveProductType(String name)
        {
            PaymentType paymentType = getPaymentTypeByName(name);
            if (paymentType != null)
            {
                return new Response(false, "Payment type must be unique");
            }
            PaymentTypeRepository.savePaymentType(name);

            return new Response(true);
        }

        public static PaymentType getPaymentTypeById(int id)
        {
            return PaymentTypeRepository.searchPaymentTypeById(id);
        }

        public  static PaymentType getPaymentTypeByName(String name)
        {
            return PaymentTypeRepository.searchPaymentTypeByName(name);
        }

        public static Response deletePaymentType(int id)
        {
            PaymentType paymentType = getPaymentTypeById(id);
            if (paymentType == null)
            {
                return new Response(false, "Payment type not found");
            }
            PaymentTypeRepository.deletedPaymentType(paymentType);
            return new Response(true);
        }

        public static Response updatePaymentType(int id, string name)
        {
            PaymentType paymentTypeById = getPaymentTypeById(id);
            PaymentType paymentTypeByName = getPaymentTypeByName(name);

            if (paymentTypeById == null)
            {
                return new Response(false, "Payment type not found");
            }


            if (paymentTypeByName != null && paymentTypeByName.Name != paymentTypeByName.Name)
            {
                return new Response(false, "Payment type must be unique");
            }

            PaymentTypeRepository.updatePaymentType(paymentTypeById, name);
            return new Response(true);
        }

    }
}