namespace AkilliTedarikSistemi.Patterns
{
    public class TransferPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            // Banka havalesi kontrolü simüle edilir
            Logger.Instance.Log($"{amount} TL tutarındaki ödeme Havale/EFT yoluyla onaylandı.");
        }
    }
}