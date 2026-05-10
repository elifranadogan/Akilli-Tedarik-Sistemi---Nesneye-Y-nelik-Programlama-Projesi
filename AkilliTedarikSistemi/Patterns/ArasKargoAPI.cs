namespace AkilliTedarikSistemi.Patterns
{
    // Bu sınıfı Aras Kargo'nun yazdığını ve değiştiremeyeceğimizi düşünelim
    public class ArasKargoAPI
    {
        public void ArasGonder(string detay, int subeId)
        {
            // Aras'ın kendine has metod ismi ve parametresi var
            Logger.Instance.Log($"Aras Kargo API ile gönderildi: {detay}");
        }

        public string BarkodUret()
        {
            return "ARAS-" + System.Guid.NewGuid().ToString().Substring(0, 8);
        }
    }
}