namespace AkilliTedarikSistemi.Patterns
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            // Burada banka sanal POS işlemleri simüle edilir
            Logger.Instance.Log($"{amount} TL tutarındaki ödeme Kredi Kartı ile alındı.");
        }
    }
}