namespace AkilliTedarikSistemi.Patterns
{
    /// <summary>
    /// Adapter Pattern: Dış bir servis olan ArasKargoAPI'sini, 
    /// sistemimizin standart ICargoService arayüzüne uyarlar.
    /// </summary>
    public class ArasKargoAdapter : ICargoService
    {
        private ArasKargoAPI _arasApi;

        public ArasKargoAdapter()
        {
            _arasApi = new ArasKargoAPI();
        }

        public void SendOrder(string orderDetails)
        {
            // Bizim metodumuz çağrıldığında, arka planda Aras'ın metodunu çalıştırıyor
            _arasApi.ArasGonder(orderDetails, 34); // 34 sabit şube ID olsun
        }

        public string GetTrackingNumber()
        {
            // Bizim barkod istediğimizde, Aras'ın barkod üreten metodunu çağırıyor
            return _arasApi.BarkodUret();
        }
    }
}