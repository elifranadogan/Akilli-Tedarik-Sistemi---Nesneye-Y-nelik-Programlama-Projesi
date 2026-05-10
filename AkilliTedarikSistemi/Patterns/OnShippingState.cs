namespace AkilliTedarikSistemi.Patterns
{
    /// <summary>
    /// State Pattern: 'Kargoda' durumunu temsil eder. 
    /// Şartname gereği bu aşamada iptal işlemi engellenmiştir.
    /// </summary>
    public class OnShippingState : IOrderState
    {
        public void Next(OrderContext order)
        {
            order.CurrentState = new DeliveredState();
            Logger.Instance.Log("Sipariş teslim edildi.");
        }

        public void Cancel(OrderContext order)
        {
            // BOŞ BIRAKMALISIN veya Log atmalısın. 
            // order.CurrentState = new CancelledState(); SATIRI BURADA OLMAMALI!
            Logger.Instance.Log("HATA: Kargodaki ürün iptal edilemez.");
        }

        public string GetStatus() => "Kargoda";
    }
}