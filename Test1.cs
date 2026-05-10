using Microsoft.VisualStudio.TestTools.UnitTesting;
using AkilliTedarikSistemi.Patterns; // Sipariş sınıflarının olduğu yer
using AkilliTedarikSistemi.Controllers; // Eğer OrderContext buradaysa
namespace AkilliTedarikSistemi.Tests
{
    [TestClass]
    public class SiparisTestleri
    {
        [TestMethod]
        public void KargodakiSiparis_IptalEdilemez_Testi()
        {
            // 1. Hazırlık (Arrange)
            OrderContext siparis = new OrderContext();

            // 2. İşlem (Act) - Siparişi 'Kargoda' aşamasına getir
            siparis.NextState(); // Beklemede -> Onaylandı
            siparis.NextState(); // Onaylandı -> Hazırlanıyor
            siparis.NextState(); // Hazırlanıyor -> Kargoda

            string durumOnce = siparis.GetStatusName();
            siparis.CancelOrder(); // İptal etmeyi dene
            string durumSonra = siparis.GetStatusName();

            // 3. Doğrulama (Assert) - Durum değişmemeli, hala 'Kargoda' kalmalı
            Assert.AreEqual("Kargoda", durumSonra);
        }
    }
}