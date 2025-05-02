using SuperShopCet97.Web.Data.Entities;

namespace SuperShopCet97.Web.Data
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
