using CartApi.Models;
using System.Collections.Generic;

namespace CartApi.Models
{
    public class Cart
    {
        public string BuyerId { get; set; }
        public List<CartEventItem> Events { get; set; }
        public Cart() { }


        public Cart(string cartId)
        {
            BuyerId = cartId;
            Events = new List<CartEventItem>();
        }
    }
}
