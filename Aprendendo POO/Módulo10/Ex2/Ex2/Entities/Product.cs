using System.Text;
using System.Globalization;

namespace Ex2.Entities
{
    internal class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public List<Product> List { get; set; } = new List<Product>();

        public Product() { }
        public Product(string? name, double price)
        {
            Name = name;
            Price = price;
        }
               
        public virtual string PriceTag()
        {
            return $"{Name} $ {Price.ToString("N2", CultureInfo.InvariantCulture)}";
        }
        public static void Line()
        {
            Console.WriteLine("-------------------------------------\n");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Product product in List)
            {
                sb.Append(product.PriceTag() + "\n");
            }

            return sb.ToString();
        }
    }
}
