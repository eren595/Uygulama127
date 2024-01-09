namespace Uygulama127
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnEnYuksek = new System.Windows.Forms.Button();
            this.btnEnDusuk = new System.Windows.Forms.Button();
            this.btnOrtalama = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDersNotu = new System.Windows.Forms.TextBox();
            this.txtEnDuşuk = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtEnyuksek = new System.Windows.Forms.TextBox();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(24, 166);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnEnYuksek
            // 
            this.btnEnYuksek.Location = new System.Drawing.Point(24, 195);
            this.btnEnYuksek.Name = "btnEnYuksek";
            this.btnEnYuksek.Size = new System.Drawing.Size(75, 23);
            this.btnEnYuksek.TabIndex = 1;
            this.btnEnYuksek.Text = "EnYüksek";
            this.btnEnYuksek.UseVisualStyleBackColor = true;
            this.btnEnYuksek.Click += new System.EventHandler(this.btnEnYuksek_Click);
            // 
            // btnEnDusuk
            // 
            this.btnEnDusuk.Location = new System.Drawing.Point(24, 224);
            this.btnEnDusuk.Name = "btnEnDusuk";
            this.btnEnDusuk.Size = new System.Drawing.Size(75, 23);
            this.btnEnDusuk.TabIndex = 2;
            this.btnEnDusuk.Text = "En Düşük";
            this.btnEnDusuk.UseVisualStyleBackColor = true;
            this.btnEnDusuk.Click += new System.EventHandler(this.btnEnDusuk_Click);
            // 
            // btnOrtalama
            // 
            this.btnOrtalama.Location = new System.Drawing.Point(24, 253);
            this.btnOrtalama.Name = "btnOrtalama";
            this.btnOrtalama.Size = new System.Drawing.Size(75, 23);
            this.btnOrtalama.TabIndex = 3;
            this.btnOrtalama.Text = "Oltarama";
            this.btnOrtalama.UseVisualStyleBackColor = true;
            this.btnOrtalama.Click += new System.EventHandler(this.btnOrtalama_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(475, 62);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ders Notu:";
            // 
            // txtDersNotu
            // 
            this.txtDersNotu.Location = new System.Drawing.Point(83, 91);
            this.txtDersNotu.Name = "txtDersNotu";
            this.txtDersNotu.Size = new System.Drawing.Size(100, 20);
            this.txtDersNotu.TabIndex = 7;
            // 
            // txtEnDuşuk
            // 
            this.txtEnDuşuk.Location = new System.Drawing.Point(105, 224);
            this.txtEnDuşuk.Name = "txtEnDuşuk";
            this.txtEnDuşuk.Size = new System.Drawing.Size(100, 20);
            this.txtEnDuşuk.TabIndex = 8;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(83, 62);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 9;
            // 
            // txtEnyuksek
            // 
            this.txtEnyuksek.Location = new System.Drawing.Point(105, 195);
            this.txtEnyuksek.Name = "txtEnyuksek";
            this.txtEnyuksek.Size = new System.Drawing.Size(100, 20);
            this.txtEnyuksek.TabIndex = 10;
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Location = new System.Drawing.Point(336, 62);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(120, 95);
            this.lbListe.TabIndex = 12;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(105, 256);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 20);
            this.txtOrtalama.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.txtEnyuksek);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtEnDuşuk);
            this.Controls.Add(this.txtDersNotu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnOrtalama);
            this.Controls.Add(this.btnEnDusuk);
            this.Controls.Add(this.btnEnYuksek);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnEnYuksek;
        private System.Windows.Forms.Button btnEnDusuk;
        private System.Windows.Forms.Button btnOrtalama;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDersNotu;
        private System.Windows.Forms.TextBox txtEnDuşuk;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtEnyuksek;
        private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.TextBox txtOrtalama;
    }
}

