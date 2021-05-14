using System.Collections.Generic;
using System.Threading.Tasks;

namespace CartApi.Models
{
    public interface ICartRepository
    {
        Task<Cart> GetCartAsync(string cartId);
        Task<Cart> UpdateCartAsync(Cart basket);
        Task<bool> DeleteCartAsync(string Id);
        IEnumerable<string> GetUsers();

    }
}
