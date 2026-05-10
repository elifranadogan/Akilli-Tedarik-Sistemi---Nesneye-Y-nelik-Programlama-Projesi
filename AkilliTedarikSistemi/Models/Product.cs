using System.Collections.Generic;
using AkilliTedarikSistemi.Patterns;

namespace AkilliTedarikSistemi.Models
{
    /// <summary>
    /// Base Product Sınıfı: Hem basit ürünler hem de Composite (Bileşik) ürünler için temel oluşturur.
    /// </summary>
    public abstract class Product // Hem basit hem karmaşık ürünün temeli
    {
        public string Name { get; set; }
        public int StockQuantity { get; set; }
        public int Threshold { get; set; } // Eşik değer

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer) => _observers.Add(observer);

        public virtual void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                // Hata buradaydı: İkinci parametre olarak mevcut stok miktarını da gönderiyoruz
                observer.Update(message, StockQuantity);
            }
        }

        public abstract decimal GetPrice();

        public void ReduceStock(int amount)
        {
            StockQuantity -= amount;
            Logger.Instance.Log($"{Name} stoğu düşürüldü. Yeni stok: {StockQuantity}");

            if (StockQuantity < Threshold)
            {
                Notify($"{Name} stoğu kritik seviyenin altına düştü! Güncel: {StockQuantity}");
            }
        }
    }
}