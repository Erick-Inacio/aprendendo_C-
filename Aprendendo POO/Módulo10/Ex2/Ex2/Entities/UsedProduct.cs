using System.Globalization;

namespace Ex2.Entities
{
    internal sealed class UsedProduct :Product
    {
        public DateTime ManufactureDate { get; set; }
        
        public UsedProduct() { }
        public UsedProduct(DateTime manufactureDate, string? name, double price) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("N2", CultureInfo.InvariantCulture)}" +
                $" (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
