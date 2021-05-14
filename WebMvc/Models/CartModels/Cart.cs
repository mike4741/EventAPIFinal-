
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebMvc.Models.CartModels
{
    public class Cart
    {
        public List<CartEventItem> Events { get; set; } = new List<CartEventItem>();
        public string BuyerId { get; set; }
        public object Items { get; internal set; }

        public decimal Total()
        {
            return Math.Round(Events.Sum(x => x.UnitPrice * x.Quantity), 2);
        }

    }


}
