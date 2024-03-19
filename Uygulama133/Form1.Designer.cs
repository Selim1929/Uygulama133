namespace Uygulama133
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
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtNumaraN = new System.Windows.Forms.TextBox();
            this.txtAdSoyadN = new System.Windows.Forms.TextBox();
            this.Numara = new System.Windows.Forms.Label();
            this.btnEkleSayı = new System.Windows.Forms.Button();
            this.btnEkleMetin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.IBSayı = new System.Windows.Forms.ListBox();
            this.IbMetin = new System.Windows.Forms.ListBox();
            this.IbNesne = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(90, 28);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 0;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(277, 28);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtNumaraN
            // 
            this.txtNumaraN.Location = new System.Drawing.Point(598, 35);
            this.txtNumaraN.Name = "txtNumaraN";
            this.txtNumaraN.Size = new System.Drawing.Size(100, 20);
            this.txtNumaraN.TabIndex = 2;
            // 
            // txtAdSoyadN
            // 
            this.txtAdSoyadN.Location = new System.Drawing.Point(598, 70);
            this.txtAdSoyadN.Name = "txtAdSoyadN";
            this.txtAdSoyadN.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyadN.TabIndex = 3;
            // 
            // Numara
            // 
            this.Numara.AutoSize = true;
            this.Numara.Location = new System.Drawing.Point(29, 28);
            this.Numara.Name = "Numara";
            this.Numara.Size = new System.Drawing.Size(44, 13);
            this.Numara.TabIndex = 4;
            this.Numara.Text = "Numara";
            // 
            // btnEkleSayı
            // 
            this.btnEkleSayı.Location = new System.Drawing.Point(90, 67);
            this.btnEkleSayı.Name = "btnEkleSayı";
            this.btnEkleSayı.Size = new System.Drawing.Size(75, 23);
            this.btnEkleSayı.TabIndex = 5;
            this.btnEkleSayı.Text = "SayıEkle";
            this.btnEkleSayı.UseVisualStyleBackColor = true;
            this.btnEkleSayı.Click += new System.EventHandler(this.btnEkleSayı_Click);
            // 
            // btnEkleMetin
            // 
            this.btnEkleMetin.Location = new System.Drawing.Point(277, 67);
            this.btnEkleMetin.Name = "btnEkleMetin";
            this.btnEkleMetin.Size = new System.Drawing.Size(75, 23);
            this.btnEkleMetin.TabIndex = 6;
            this.btnEkleMetin.Text = "MetinEkle";
            this.btnEkleMetin.UseVisualStyleBackColor = true;
            this.btnEkleMetin.Click += new System.EventHandler(this.btnEkleMetin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "AdSoyad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Nesne Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IBSayı
            // 
            this.IBSayı.FormattingEnabled = true;
            this.IBSayı.Location = new System.Drawing.Point(90, 121);
            this.IBSayı.Name = "IBSayı";
            this.IBSayı.Size = new System.Drawing.Size(140, 212);
            this.IBSayı.TabIndex = 10;
            // 
            // IbMetin
            // 
            this.IbMetin.FormattingEnabled = true;
            this.IbMetin.Location = new System.Drawing.Point(240, 121);
            this.IbMetin.Name = "IbMetin";
            this.IbMetin.Size = new System.Drawing.Size(140, 212);
            this.IbMetin.TabIndex = 11;
            // 
            // IbNesne
            // 
            this.IbNesne.FormattingEnabled = true;
            this.IbNesne.Location = new System.Drawing.Point(609, 134);
            this.IbNesne.Name = "IbNesne";
            this.IbNesne.Size = new System.Drawing.Size(140, 212);
            this.IbNesne.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IbNesne);
            this.Controls.Add(this.IbMetin);
            this.Controls.Add(this.IBSayı);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkleMetin);
            this.Controls.Add(this.btnEkleSayı);
            this.Controls.Add(this.Numara);
            this.Controls.Add(this.txtAdSoyadN);
            this.Controls.Add(this.txtNumaraN);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtNumara);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtNumaraN;
        private System.Windows.Forms.TextBox txtAdSoyadN;
        private System.Windows.Forms.Label Numara;
        private System.Windows.Forms.Button btnEkleSayı;
        private System.Windows.Forms.Button btnEkleMetin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox IBSayı;
        private System.Windows.Forms.ListBox IbMetin;
        private System.Windows.Forms.ListBox IbNesne;
    }
}

