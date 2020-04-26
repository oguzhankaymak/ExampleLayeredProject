using Entities.DomainModels;
using Microsoft.AspNetCore.Http;
using MvcWebUI.Extensions;

namespace MvcWebUI.Helpers
{
    public class CartSessionHelper : ICartSessionHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartSessionHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public void Clear()
        {
            _httpContextAccessor.HttpContext.Session.Clear();
        }

        public Cart GetCart(string key)
        {
            var cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>(key);
            if (cartToCheck != null)
                return cartToCheck;
            
            SetCart(key,new Cart());
            return _httpContextAccessor.HttpContext.Session.GetObject<Cart>(key);
        }
        
        public void SetCart(string key, Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject(key, cart);
        }
    }
}
