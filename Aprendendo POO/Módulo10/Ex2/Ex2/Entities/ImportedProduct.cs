using System.Globalization;

namespace Ex2.Entities
{
    internal sealed class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }
        public ImportedProduct(double customsFee, string? name, double price) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {(Price + CustomsFee).ToString("N2", CultureInfo.InvariantCulture)}"
                + $" (Customs fee: $ {CustomsFee.ToString("N2", CultureInfo.InvariantCulture)})";
        }
    }
}
