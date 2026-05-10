using System;
using System.Windows.Forms;
using AkilliTedarikSistemi.Patterns;
using AkilliTedarikSistemi.Controllers;

namespace AkilliTedarikSistemi
{
    public partial class Form1 : Form
    {
        private OrderContext _siparis;
        private PaymentProcessor _odemeSistemi;

        public Form1()
        {
            InitializeComponent();
            _odemeSistemi = new PaymentProcessor();
        }

        private void btnSiparisOlustur_Click(object sender, EventArgs e)
        {
            // 1. Sipariş Nesnesini Oluştur (State Pattern başlar)
            _siparis = new OrderContext();

            // 2. Ödeme Stratejisini Seç (Strategy Pattern)
            _odemeSistemi.SetPaymentStrategy(new CreditCardPayment());
            _odemeSistemi.Process(1500.00m);

            // 3. Loglama (Singleton)
            Logger.Instance.Log("Arayüzden yeni bir sipariş tetiklendi.");

            GuncelleArayuz();
        }

        private void btnSonrakiAsama_Click(object sender, EventArgs e)
        {
            if (_siparis != null)
            {
                // 1. Mevcut durumun adını alıyoruz (Örn: Hazırlanıyor)
                string eskiDurum = _siparis.GetStatusName();

                // 2. State Pattern: Bir sonraki aşamaya geç (Örn: Kargoda)
                _siparis.NextState();
                GuncelleArayuz();

                // 3. Eğer YENİ durum "Kargoda" ise adaptör çalışsın
                if (_siparis.GetStatusName() == "Kargoda")
                {
                    ICargoService kargo = new ArasKargoAdapter();
                    kargo.SendOrder("Sipariş No: 123");
                    MessageBox.Show("Ürün kargoya verildi! Takip No: " + kargo.GetTrackingNumber());
                }

                // 4. Eğer YENİ durum "Teslim Edildi" ise bilgilendir
                if (_siparis.GetStatusName() == "Teslim Edildi")
                {
                    MessageBox.Show("Sipariş başarıyla müşteriye ulaştı.");
                }
            }
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            _siparis?.CancelOrder();
            GuncelleArayuz();
        }

        private void GuncelleArayuz()
        {
            lblDurum.Text = "Mevcut Durum: " + _siparis.GetStatusName();
        }
    }
}