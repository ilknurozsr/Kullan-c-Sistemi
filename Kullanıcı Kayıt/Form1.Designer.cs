namespace Kullanıcı_Kayıt
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
            this.kullaniciadi = new System.Windows.Forms.Label();
            this.adsoyad = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.Label();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.işlemikaydet = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.AutoSize = true;
            this.kullaniciadi.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciadi.Location = new System.Drawing.Point(73, 58);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(104, 16);
            this.kullaniciadi.TabIndex = 0;
            this.kullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // adsoyad
            // 
            this.adsoyad.AutoSize = true;
            this.adsoyad.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adsoyad.Location = new System.Drawing.Point(82, 101);
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(85, 16);
            this.adsoyad.TabIndex = 1;
            this.adsoyad.Text = "Ad Soyad:";
            // 
            // telefon
            // 
            this.telefon.AutoSize = true;
            this.telefon.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefon.Location = new System.Drawing.Point(89, 149);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(70, 16);
            this.telefon.TabIndex = 2;
            this.telefon.Text = "Telefon:";
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(221, 61);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(111, 22);
            this.txtkullaniciadi.TabIndex = 4;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(221, 149);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(111, 22);
            this.txttelefon.TabIndex = 5;
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(221, 104);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(111, 22);
            this.txtadsoyad.TabIndex = 6;
            // 
            // işlemikaydet
            // 
            this.işlemikaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.işlemikaydet.Location = new System.Drawing.Point(147, 209);
            this.işlemikaydet.Name = "işlemikaydet";
            this.işlemikaydet.Size = new System.Drawing.Size(132, 44);
            this.işlemikaydet.TabIndex = 7;
            this.işlemikaydet.Text = "İşlemi Kaydet";
            this.işlemikaydet.UseVisualStyleBackColor = true;
            this.işlemikaydet.Click += new System.EventHandler(this.işlemikaydet_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Location = new System.Drawing.Point(45, 304);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(132, 44);
            this.btnguncelle.TabIndex = 8;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(247, 304);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(132, 44);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(448, 373);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.işlemikaydet);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.adsoyad);
            this.Controls.Add(this.kullaniciadi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullaniciadi;
        private System.Windows.Forms.Label adsoyad;
        private System.Windows.Forms.Label telefon;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.Button işlemikaydet;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
    }
}

