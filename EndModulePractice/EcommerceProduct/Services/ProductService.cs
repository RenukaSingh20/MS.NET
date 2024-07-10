using EcommerceProduct.Entities;
using EcommerceProduct.Repositories;
namespace EcommerceProduct.Services
{
    public class ProductService:IProductService
    {
        
       public List<Product> GetAll()
        {
            IProductRepository repositories = new ProductRepository();
            return repositories.GetProducts();
        }
      
      
    }
}
