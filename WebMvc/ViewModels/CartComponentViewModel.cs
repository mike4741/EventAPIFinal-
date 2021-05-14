using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.ViewModels
{
    public class CartComponentViewModel
    {
        public int EventsInCart { get; set; }
        public decimal TotalCost { get; set; }
        public string Disabled => (EventsInCart == 0) ? "is-disabled" : "";
    }
}
