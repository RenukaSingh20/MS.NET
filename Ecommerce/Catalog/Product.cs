namespace Catalog
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double UnitPrice { get; set; }

         public Product(int id, string title, double unitPrice)
        {
            this.Id = id;   
            this.Title = title;
            this.UnitPrice = unitPrice;
        }
        public override string ToString()
        {
            return "Product: "+Id + " "+Title+" "+UnitPrice;   
        }
    }
}
