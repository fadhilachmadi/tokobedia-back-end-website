using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.handler;
using TokoBeDia.helper;

namespace TokoBeDia.controller
{
    public class CartController
    {
        public static Response AddToCart(int productId, int userId, string qtyString)
        {
            Product product = ProductHandler.getById(productId);
            if (product == null)
            {
                return new Response(false, "Product not found");
            }

            if (qtyString == null)
            {
                return new Response(false, "Quantity cannot be null");
            }

            int qty = Int32.Parse(qtyString);

            if (qty <= 0)
            {
                return new Response(false, "Quantity must be more than 0");
            }

            if (product.Stock - qty < 0)
            {
                return new Response(false, "Product stock is not sufficient for your request");
            }

            CartHandler.AddToCart(productId, userId, qty);
            return new Response(true);
        }

        public static Response AddToCartView(int productId)
        {
            Product product = ProductHandler.getById(productId);
            if (product == null)
            {
                return new Response(false, "Product not found");
            }



            return new Response(true, product);
        }

        public static Response ViewCart(int userId)
        {
            return new Response(true, CartHandler.viewCart(userId));
        }

        public static Response DeleteCart(int userId, int productId)
        {
            Response deleteCart = CartHandler.deleteCart(userId, productId);
            if (!deleteCart.successStatus)
            {
                return new Response(false, deleteCart.message);
            }

            return new Response(true);
        }

        public static Response UpdateCart(int userId, int productId, string qtyString)
        {
            Product product = ProductHandler.getById(productId);

            if (product == null)
            {
                return new Response(false, "Product not found");
            }


            if (qtyString == null || qtyString == "")
            {
                return new Response(false, "Quantity cannot be null");
            }


       
            int qty = Int32.Parse(qtyString);

            if (qty <= 0)
            {
                return new Response(false, "Quantity must be more than 0");
            }

            if (product.Stock - qty < 0)
            {
                return new Response(false, "Product stock is not sufficient for your request");
            }

            CartHandler.updateCart(userId, productId, qty);

            return new Response(true);
        }

        public static Response ViewUpdateCart(int userId, int productId)
        {
            Product product = ProductHandler.getById(productId);

            if (product == null)
            {
                return new Response(false, "Product not found");
            }

            return new Response(true, CartHandler.viewSpecificCartDetails(userId, productId));
        }
    }
}