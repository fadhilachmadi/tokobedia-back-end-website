using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.helper;
using TokoBeDia.repository;

namespace TokoBeDia.handler
{
    public class CartHandler
    {
        public static Response AddToCart(int productId, int userId, int qty)
        {


            Cart cart = CartRepository.searchByUserAndProductId(productId, userId);

            if (cart != null)
            {
                CartRepository.updateCart(cart, qty);
            }
            else
            {
                CartRepository.addToCart(productId, qty, userId);
            }

            return new Response(true);
        }

        public static dynamic viewCart(int userId)
        {
            return CartRepository.searchByUserId(userId);
        }

        public static dynamic viewSpecificCartDetails(int userId, int productId)
        {
            return CartRepository.searchByUserAndProductIdDetails(productId, userId);
        }

        public static Response deleteCart(int userId, int productId)
        {
            Cart cart = CartRepository.searchByUserAndProductId(productId, userId);
            if (cart == null)
            {
                return new Response(false, "Cart not found");
            }

            CartRepository.deleteCart(cart);

            return new Response(true);
        }

        public static Response updateCart(int userId, int productId, int qty)
        {
            Cart cart = CartRepository.searchByUserAndProductId(productId, userId);
            if (cart == null)
            {
                return new Response(false, "Cart not found");
            }

            CartRepository.updateCart(cart, qty);
            return new Response(true);
        }
    }
}