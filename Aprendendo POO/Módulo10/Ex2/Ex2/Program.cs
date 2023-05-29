using Ex2.Entities;
using System;
using System.Globalization;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Product.Line();

            Product product = new Product();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Commom, used, imported (c/u/i)?: ");
                char c = Convert.ToChar(Console.ReadLine());
                Console.Write("Name: ");
                string? name = Console.ReadLine();
                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (c == 'c')
                {
                    product.List.Add(new Product(name, price));
                }
                else if(c == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = Convert.ToDateTime(Console.ReadLine());
                    product.List.Add(new UsedProduct(date, name, price));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    product.List.Add(new ImportedProduct(customsFee, name, price));
                }
                Product.Line();
            }

            Console.WriteLine("PRICE TAGS:");
            Console.WriteLine(product);
        }
    }
}