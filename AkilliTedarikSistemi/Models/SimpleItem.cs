namespace AkilliTedarikSistemi.Models
{
    /// <summary>
    /// Composite Pattern: Yaprak (Leaf) nesnesini temsil eder. 
    /// Tek başına fiyatı olan temel üründür.
    /// </summary>
    public class SimpleItem : Product
    {
        public decimal Price { get; set; }

        public SimpleItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override decimal GetPrice() => Price;
    }
}