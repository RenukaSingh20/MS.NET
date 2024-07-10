using ProductApp.Entities;
using ProductApp.Repositories;
namespace ProductApp.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetById(int id);
        Boolean DeleteById(int id); 
        Boolean AddProduct(Product product);
        Boolean UpdateProduct(int id,Product product);
        List<Product> SearchById(int id);
        List<Product> SortByQuantity();
    }
}
