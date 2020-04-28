using Business.Abstract;
using Entities.Concrete;
using Entities.DomainModels;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            var cartLine = cart.CartLines.FirstOrDefault(c => c.Product.Id == product.Id);
            if (cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }

            cart.CartLines.Add(new CartLine {Product = product, Quantity = 1});
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFormCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.Id == productId));
        }
    }
}
