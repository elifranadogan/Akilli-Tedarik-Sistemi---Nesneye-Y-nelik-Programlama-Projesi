namespace AkilliTedarikSistemi.Patterns
{
    public class DeliveredState : IOrderState
    {
        public void Next(OrderContext order)
        {
            // Son aşama olduğu için gidecek yer yok
            Logger.Instance.Log("Sipariş zaten teslim edilmiş durumda.");
        }

        public void Cancel(OrderContext order)
        {
            Logger.Instance.Log("Teslim edilen ürün iptal edilemez, iade prosedürü uygulanmalıdır.");
        }

        public string GetStatus() => "Teslim Edildi";
    }
}