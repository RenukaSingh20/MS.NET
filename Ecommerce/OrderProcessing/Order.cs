namespace OrderProcessing
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int id, DateTime orderDate)
        {
            this.Id = id;
            this.OrderDate = orderDate;
        }
        public override string ToString()
        {

            return "Order :" + Id + " " + OrderDate;
        }
    }
}
