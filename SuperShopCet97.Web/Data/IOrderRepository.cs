using System.Linq;
using System.Threading.Tasks;
using SuperShopCet97.Web.Data.Entities;

namespace SuperShopCet97.Web.Data
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IQueryable<Order>> GetOrderAsync(string userName);
    }
}
