namespace AkilliTedarikSistemi.Patterns
{
    public class ConfirmedState : IOrderState
    {
        public void Next(OrderContext order)
        {
            // Onaylandıktan sonra hazırlık aşamasına geçilir
            order.CurrentState = new PreparingState();
            Logger.Instance.Log("Sipariş 'Onaylandı' durumundan 'Hazırlanıyor' durumuna geçti.");
        }

        public void Cancel(OrderContext order)
        {
            // Şartnameye göre onaylı sipariş de iptal edilebilir
            Logger.Instance.Log("Onaylanmış sipariş iptal edildi.");
        }

        public string GetStatus() => "Onaylandı";
    }
}