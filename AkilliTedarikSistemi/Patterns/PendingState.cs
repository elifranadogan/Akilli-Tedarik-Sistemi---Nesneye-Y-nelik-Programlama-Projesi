namespace AkilliTedarikSistemi.Patterns
{
    public class PendingState : IOrderState
    {
        public void Next(OrderContext order)
        {
            // Beklemedeyken bir sonraki aşama Onaylandı aşamasıdır
            order.CurrentState = new ConfirmedState();
            Logger.Instance.Log("Sipariş beklemeden 'Onaylandı' durumuna geçti.");
        }

        public void Cancel(OrderContext order)
        {
            Logger.Instance.Log("Sipariş bekleme aşamasındayken iptal edildi.");
        }

        public string GetStatus() => "Beklemede";
    }
}