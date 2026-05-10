namespace AkilliTedarikSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSiparisOlustur = new System.Windows.Forms.Button();
            this.btnSonrakiAsama = new System.Windows.Forms.Button();
            this.btnIptalEt = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSiparisOlustur
            // 
            this.btnSiparisOlustur.Location = new System.Drawing.Point(468, 118);
            this.btnSiparisOlustur.Name = "btnSiparisOlustur";
            this.btnSiparisOlustur.Size = new System.Drawing.Size(177, 23);
            this.btnSiparisOlustur.TabIndex = 0;
            this.btnSiparisOlustur.Text = "Yeni Sipariş Oluştur";
            this.btnSiparisOlustur.UseVisualStyleBackColor = true;
            this.btnSiparisOlustur.Click += new System.EventHandler(this.btnSiparisOlustur_Click);
            // 
            // btnSonrakiAsama
            // 
            this.btnSonrakiAsama.Location = new System.Drawing.Point(468, 173);
            this.btnSonrakiAsama.Name = "btnSonrakiAsama";
            this.btnSonrakiAsama.Size = new System.Drawing.Size(177, 23);
            this.btnSonrakiAsama.TabIndex = 0;
            this.btnSonrakiAsama.Text = "Sonraki Aşamaya Geç";
            this.btnSonrakiAsama.UseVisualStyleBackColor = true;
            this.btnSonrakiAsama.Click += new System.EventHandler(this.btnSonrakiAsama_Click);
            // 
            // btnIptalEt
            // 
            this.btnIptalEt.Location = new System.Drawing.Point(468, 221);
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.Size = new System.Drawing.Size(177, 23);
            this.btnIptalEt.TabIndex = 0;
            this.btnIptalEt.Text = "Siparişi İptal Et";
            this.btnIptalEt.UseVisualStyleBackColor = true;
            this.btnIptalEt.Click += new System.EventHandler(this.btnIptalEt_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(480, 267);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(113, 16);
            this.lblDurum.TabIndex = 1;
            this.lblDurum.Text = "Durum:Bekleniyor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnIptalEt);
            this.Controls.Add(this.btnSonrakiAsama);
            this.Controls.Add(this.btnSiparisOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiparisOlustur;
        private System.Windows.Forms.Button btnSonrakiAsama;
        private System.Windows.Forms.Button btnIptalEt;
        private System.Windows.Forms.Label lblDurum;
    }
}

