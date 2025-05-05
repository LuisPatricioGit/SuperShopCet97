using System.Linq;
using SuperShopCet97.Web.Data.Entities;

namespace SuperShopCet97.Web.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public IQueryable GetAllWithUsers();
    }
}
