using Ex3.Entities;
using Ex3.Entities.Enums;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Globalization;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data");
            Console.Write("Name: ");
            string? name = Console.ReadLine();
            Console.Write("Email: ");
            string? email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);
            Line();

            Console.WriteLine("Enter order data");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            DateTime moment = DateTime.Now;
            Order order = new Order(moment, status, client);

            Console.Write("How many items to this order?: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Line();
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                OrderItem item = new OrderItem(quantity, price, product);

                order.AddItem(item);
            }
            Line();
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine(order);

            
        }

        public static void Line()
        {
            Console.WriteLine("----------------------------------\n");
        }
    }
}