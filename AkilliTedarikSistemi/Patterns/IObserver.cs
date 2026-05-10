namespace AkilliTedarikSistemi.Patterns
{
    /// <summary>
    /// Observer Pattern: Stok değişikliklerinden haberdar olmak isteyen sınıflar için arayüz.
    /// </summary>
   
    // Bildirim alacak herkes bu arayüzü kullanacak
    public interface IObserver
    {
        void Update(string productName, int quantity);
    }
}