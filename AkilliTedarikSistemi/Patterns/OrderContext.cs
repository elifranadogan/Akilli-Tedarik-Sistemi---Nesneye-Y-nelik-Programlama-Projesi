namespace AkilliTedarikSistemi.Patterns
{
    public class OrderContext
    {
        public IOrderState CurrentState { get; set; }

        public OrderContext()
        {
            // Sipariş oluşturulduğunda otomatik olarak Beklemede durumunda başlar[cite: 1]
            CurrentState = new PendingState();
        
        }

        public void NextState() => CurrentState?.Next(this);
        public void CancelOrder() => CurrentState?.Cancel(this);
        public string GetStatusName() => CurrentState?.GetStatus() ?? "Bilinmiyor";
    }
}