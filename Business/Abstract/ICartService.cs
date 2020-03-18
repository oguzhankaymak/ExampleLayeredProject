using Entities.Concrete;
using Entities.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface ICartService
    { 
        void AddToCart(Cart cart, Product product);
        void RemoveFormCart(Cart cart, int productId);

        List<CartLine> List(Cart cart);
    }
}
