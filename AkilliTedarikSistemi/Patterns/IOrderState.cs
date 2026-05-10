namespace AkilliTedarikSistemi.Patterns
{
    public interface IOrderState
    {
        void Next(OrderContext order);
        void Cancel(OrderContext order);
        string GetStatus();
    }
}