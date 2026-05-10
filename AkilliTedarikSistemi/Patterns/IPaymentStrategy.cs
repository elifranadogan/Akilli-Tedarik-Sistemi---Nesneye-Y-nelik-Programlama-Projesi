namespace AkilliTedarikSistemi.Patterns
{
    public interface IPaymentStrategy
    {
        // Her ödeme yöntemi bu metodu kendine göre dolduracak
        void Pay(decimal amount);
    }
}