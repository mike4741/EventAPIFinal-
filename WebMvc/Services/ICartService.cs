using WebMvc.Models;
using WebMvc.Models.CartModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models.OrderModels;
//using WebMvc.Models.OrderModels;
//using WebMvc.Models.OrderModels;

namespace WebMvc.Services
{
    public interface ICartService
    {
      Task<Cart> GetCart(ApplicationUser user);
        Task AddItemToCart(ApplicationUser user, CartEventItem events);
        Task<Cart> UpdateCart(Cart cart);
        Task<Cart> SetQuantities(ApplicationUser user, Dictionary<string, int> quantities);
        
        Order MapCartToOrder(Cart cart);
        Task ClearCart(ApplicationUser user);

    }
}

