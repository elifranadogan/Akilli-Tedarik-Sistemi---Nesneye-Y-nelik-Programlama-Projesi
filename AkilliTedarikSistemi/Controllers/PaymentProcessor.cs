using AkilliTedarikSistemi.Patterns;

namespace AkilliTedarikSistemi.Controllers
{
    public class PaymentProcessor
    {
        private IPaymentStrategy _paymentStrategy;

        // Çalışma anında stratejiyi belirliyoruz
        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }

        public void Process(decimal amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}