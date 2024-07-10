using ProductApp.Entities;
using ProductApp.Services;
namespace ProductApp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAll()
        {
            using (var context = new ProductContext())
            {
                var products = from product in context.products
                               select product;
                return products.ToList<Product>();
            }
        }

        public List<Product> GetById(int id)
        {
            using (var context = new ProductContext())
            {
                var products = from product in context.products
                               where product.id == id
                               select product;
                return products.ToList<Product>();
            }
        }
        public Boolean DeleteById(int id)
        {
            using (var context = new ProductContext())
            {
                var remove = from premove in context.products
                             where premove.id == id
                             select premove;
                context.products.RemoveRange(remove);
                context.SaveChanges();

            }
            return true;
        }
        public Boolean AddProduct(Product product)
        {
            using (var context = new ProductContext())
            {
                context.products.Add(product);
                context.SaveChanges();
                return true;
            }

        }
        public Boolean UpdateProduct(int id, Product product)
        {
            using (var context = new ProductContext())
            {
                context.products.UpdateRange(product);
                context.SaveChanges();
            }
            return true;
        }
        public List<Product> SearchById(int id)
        {
            using (var context = new ProductContext())
            {
                return context.products.Where(s => s.id == id).ToList<Product>();
            }
        }
        public List<Product> SortByQuantity()
        {
            using(var context = new ProductContext())
            {
                return context.products.OrderBy(p => p.quantity).ToList();
            }
        }
    }
}
