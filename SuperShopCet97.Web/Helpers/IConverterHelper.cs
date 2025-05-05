using SuperShopCet97.Web.Data.Entities;
using SuperShopCet97.Web.Models;

namespace SuperShopCet97.Web.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, string path, bool isNew);
        ProductViewModel ToProductViewModel(Product product);
    }
}
