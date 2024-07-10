using ProductApp.Entities;
using ProductApp.Repositories;

namespace ProductApp.Services
{
    public class ProductService : IProductService
    {

        public List<Product> GetAll()
        {
            IProductRepository productRepository = new ProductRepository();
            return productRepository.GetAll();
        }
        public List<Product> GetById(int id)
        {
            IProductRepository productRepository = new ProductRepository();
            return productRepository.GetById(id);
        }
        public Boolean DeleteById(int id)
        {
            IProductRepository productRepository = new ProductRepository();
            return productRepository.DeleteById(id);
        }
        public Boolean AddProduct(Product product)
        {
            IProductRepository productRepository = new ProductRepository();
            return productRepository.AddProduct(product);
        }
        public Boolean UpdateProduct(int id, Product product)
        {
            IProductRepository productRepository = new ProductRepository();
            return productRepository.UpdateProduct(id, product);
        }
        public List<Product> SearchById(int id)
        {
            IProductRepository productRepository = new ProductRepository();
            return productRepository.SearchById(id);
        }
        public List<Product> SortByQuantity()
        {
            IProductRepository productRepository = new ProductRepository();
            return productRepository.SortByQuantity();
        }
    }
}
