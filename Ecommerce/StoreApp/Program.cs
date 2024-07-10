using Catalog;
using OrderProcessing;

Product product = new Product(101,"tea",30);

DateTime dateTime = new DateTime(2024,02,11);
Order order = new Order(10, dateTime);
Console.WriteLine(product);
Console.WriteLine(order);