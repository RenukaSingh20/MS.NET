using EcommerceProduct.Entities;
using MySql.Data.MySqlClient;
namespace EcommerceProduct.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            string conString = @"server=localhost;port=3306;user=root;password=Champion007;database=ecommerce";
            MySqlConnection con = new MySqlConnection(conString);
            string Query = "Select * from products";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    int quantity = int.Parse(reader["quantity"].ToString());
                    int unitprice = int.Parse(reader["unitprice"].ToString());
                    Product prd = new Product();
                    prd.Id = id;
                    prd.Title = title;
                    prd.Description = description;
                    prd.Quantity = quantity;
                    products.Add(prd);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return products;


        }


    }
}

