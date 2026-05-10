namespace AkilliTedarikSistemi.Patterns
{
    public interface ICargoService
    {
        // Tüm kargo firmaları bu iki metodu zorunlu olarak sunacak
        void SendOrder(string orderDetails);
        string GetTrackingNumber();
    }
}