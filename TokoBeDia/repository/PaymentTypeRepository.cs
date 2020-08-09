using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.factory;

namespace TokoBeDia.repository
{
    public class PaymentTypeRepository
    {
        public static DatabaseEntities db = new DatabaseEntities();

        public static void savePaymentType(String name)
        {
            PaymentType paymentType = PaymentTypeFactory.createPaymentType(name);
            db.PaymentTypes.Add(paymentType);
            db.SaveChanges();
        }

        public static List<PaymentType> getAllPaymentType()
        {
            return db.PaymentTypes.ToList();
        }

        public static PaymentType searchPaymentTypeById(int id)
        {
            PaymentType paymentType = (from x in db.PaymentTypes where x.Id == id select x).FirstOrDefault();
            return paymentType;
        }

        public static PaymentType searchPaymentTypeByName(String name)
        {
           PaymentType paymentType = (from x in db.PaymentTypes where x.Name == name select x).FirstOrDefault();
            return paymentType;
        }

        public static void updatePaymentType(PaymentType paymentType, String name)
        {
            paymentType.Name = name;

            db.SaveChanges();
        }

        public static void deletedPaymentType(PaymentType paymentType)
        {
            db.PaymentTypes.Remove(paymentType);
            db.SaveChanges();
        }
    }
}