using System.Collections.Generic;
using System.Threading.Tasks;
using SuperShopCet97.Web.Data.Entities;

namespace SuperShopCet97.Web.Data
{
    public class MockRepository : IRepository
    {
        public void AddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            var products = new List<Product>();
            product.Add(new Product { Id = 1, Name = "Um", Price = 10 });
            product.Add(new Product { Id = 2, Name = "Dois", Price = 20 });
            product.Add(new Product { Id = 3, Name = "Três", Price = 30 });
            product.Add(new Product { Id = 4, Name = "Quatro", Price = 40 });
            product.Add(new Product { Id = 5, Name = "Cinco", Price = 50 });

            return products;
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new System.NotImplementedException();
        }

        public bool ProductExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
