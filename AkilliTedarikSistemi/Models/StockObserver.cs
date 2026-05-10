using AkilliTedarikSistemi.Patterns;

namespace AkilliTedarikSistemi.Models
{
    /// <summary>
    /// Observer Pattern: Concrete Observer sınıfı.
    /// Stok miktarı değiştiğinde bilgilendirilen birimi temsil eder.
    /// </summary>
    public class StockObserver : IObserver
    {
        private string _observerName;

        public StockObserver(string name)
        {
            _observerName = name;
        }

        public void Update(string productName, int quantity)
        {
            // Stok değiştiğinde Singleton Logger üzerinden kayıt tutar
            Logger.Instance.Log($"[STOK UYARISI - {_observerName}]: {productName} ürününün yeni stoğu: {quantity}");
        }
    }
}