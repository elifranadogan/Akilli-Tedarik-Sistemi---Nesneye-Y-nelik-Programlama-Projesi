using System.Collections.Generic;
using System.Linq;

namespace AkilliTedarikSistemi.Models
{
    /// <summary>
    /// Composite Pattern: Composite nesnesini temsil eder. 
    /// İçinde birden fazla Product (basit veya bileşik) barındırabilir.
    /// </summary>
    public class AssemblyProduct : Product
    {
        private List<Product> _parts = new List<Product>();

        public AssemblyProduct(string name)
        {
            Name = name;
        }

        public void AddPart(Product part) => _parts.Add(part);
        public void RemovePart(Product part) => _parts.Remove(part);

        public override decimal GetPrice()
        {
            // İçindeki tüm parçaların fiyatını toplar
            return _parts.Sum(x => x.GetPrice());
        }
    }
}