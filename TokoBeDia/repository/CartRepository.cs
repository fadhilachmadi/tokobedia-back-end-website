using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.repository
{
    public class CartRepository
    {

        public static DatabaseEntities db = new DatabaseEntities();

        public static void addToCart(int productId, int qty, int userId)
        {
            Cart cart = new Cart();
            cart.ProductId = productId;
            cart.UserId = userId;
            cart.Quantity = qty;
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static dynamic searchByUserId(int userId)
        {
            return (from c in db.Carts
                    join p in db.Products on c.ProductId equals p.Id
                    where c.UserId == userId
                    select new
                    {
                        Quantity = c.Quantity,
                        ProductId = p.Id,
                        ProductName = p.Name,
                        ProductPrice = p.Price,
                        Subtotal = c.Quantity * p.Price,
                    }).ToList();
        }

        public static Cart searchByUserAndProductId(int productId, int userId)
        {
            return (from c in db.Carts where c.UserId == userId && c.ProductId == productId select c).FirstOrDefault();
        }

        public static dynamic searchByUserAndProductIdDetails(int productId, int userId)
        {
            return (from c in db.Carts
                    join p in db.Products on c.ProductId equals p.Id
                    join
pt in db.ProductTypes on p.ProductTypeId equals pt.Id
                    where c.UserId == userId && c.ProductId == productId
                    select new
                    {
                        Quantity = c.Quantity,
                        ProductId = p.Id,
                        ProductName = p.Name,
                        ProductPrice = p.Price,
                        ProductTypeName = pt.Name,
                        ProductStock = p.Stock
                    }).FirstOrDefault();
        }

        public static void updateCart(Cart cart, int qty)
        {
            Console.WriteLine(qty);
            cart.Quantity = qty;
            db.SaveChanges();
        }

        public static void deleteCart(Cart cart)
        {
            db.Carts.Remove(cart);
            db.SaveChanges();
        }
    }
}