using MySql.EntityFrameworkCore;

namespace ProductApp.Entities
{
    public class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int unitprice { get; set; }
        public string imageurl { get; set; }
        public int quantity { get; set; }
        public override string ToString()
        {
            return "Id: " + this.id + " Title: " + this.title +
                   " Description: " + this.description +
                   " ImageUrl: " + this.imageurl +
                   " Quantity: " + this.quantity +
                   " UnitPrice: " + this.unitprice;
        }

    }
}

