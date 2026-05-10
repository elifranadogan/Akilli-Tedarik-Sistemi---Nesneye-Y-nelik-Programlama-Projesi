namespace AkilliTedarikSistemi.Patterns
{
    public class PreparingState : IOrderState
    {
        public void Next(OrderContext order)
        {
            // Hazırlık bitince kargoya verilir
            order.CurrentState = new OnShippingState();
            Logger.Instance.Log("Sipariş 'Hazırlanıyor' durumundan 'Kargoda' durumuna geçti.");
        }

        public void Cancel(OrderContext order)
        {
            Logger.Instance.Log("Hazırlık aşamasındaki sipariş iptal edildi.");
        }

        public string GetStatus() => "Hazırlanıyor";
    }
}