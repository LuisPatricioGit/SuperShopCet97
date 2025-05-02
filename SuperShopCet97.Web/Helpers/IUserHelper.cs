using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SuperShopCet97.Web.Data.Entities;

namespace SuperShopCet97.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);
    }
}
