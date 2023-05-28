namespace Car
{
    partial class AnaSayfa
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
            this.MusteriEkleme = new System.Windows.Forms.PictureBox();
            this.MusteriKayıt = new System.Windows.Forms.PictureBox();
            this.AracListele = new System.Windows.Forms.PictureBox();
            this.AracKayıt = new System.Windows.Forms.PictureBox();
            this.sözlesme = new System.Windows.Forms.PictureBox();
            this.satis = new System.Windows.Forms.PictureBox();
            this.cikis = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriEkleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriKayıt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AracListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AracKayıt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sözlesme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).BeginInit();
            this.SuspendLayout();
            // 
            // MusteriEkleme
            // 
            this.MusteriEkleme.Image = global::Car.Properties.Resources.add_user;
            this.MusteriEkleme.Location = new System.Drawing.Point(12, 21);
            this.MusteriEkleme.Name = "MusteriEkleme";
            this.MusteriEkleme.Size = new System.Drawing.Size(88, 83);
            this.MusteriEkleme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MusteriEkleme.TabIndex = 7;
            this.MusteriEkleme.TabStop = false;
            this.MusteriEkleme.Click += new System.EventHandler(this.MusteriEkleme_Click);
            // 
            // MusteriKayıt
            // 
            this.MusteriKayıt.Image = global::Car.Properties.Resources.customer;
            this.MusteriKayıt.Location = new System.Drawing.Point(129, 21);
            this.MusteriKayıt.Name = "MusteriKayıt";
            this.MusteriKayıt.Size = new System.Drawing.Size(88, 83);
            this.MusteriKayıt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MusteriKayıt.TabIndex = 8;
            this.MusteriKayıt.TabStop = false;
            this.MusteriKayıt.Click += new System.EventHandler(this.MusteriKayıt_Click);
            // 
            // AracListele
            // 
            this.AracListele.Image = global::Car.Properties.Resources.cars;
            this.AracListele.Location = new System.Drawing.Point(242, 21);
            this.AracListele.Name = "AracListele";
            this.AracListele.Size = new System.Drawing.Size(88, 83);
            this.AracListele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AracListele.TabIndex = 9;
            this.AracListele.TabStop = false;
            this.AracListele.Click += new System.EventHandler(this.AracListele_Click);
            // 
            // AracKayıt
            // 
            this.AracKayıt.Image = global::Car.Properties.Resources.plus;
            this.AracKayıt.Location = new System.Drawing.Point(357, 21);
            this.AracKayıt.Name = "AracKayıt";
            this.AracKayıt.Size = new System.Drawing.Size(88, 83);
            this.AracKayıt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AracKayıt.TabIndex = 10;
            this.AracKayıt.TabStop = false;
            this.AracKayıt.Click += new System.EventHandler(this.AracKayıt_Click);
            // 
            // sözlesme
            // 
            this.sözlesme.Image = global::Car.Properties.Resources.contract;
            this.sözlesme.Location = new System.Drawing.Point(472, 21);
            this.sözlesme.Name = "sözlesme";
            this.sözlesme.Size = new System.Drawing.Size(88, 83);
            this.sözlesme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sözlesme.TabIndex = 11;
            this.sözlesme.TabStop = false;
            this.sözlesme.Click += new System.EventHandler(this.sözlesme_Click);
            // 
            // satis
            // 
            this.satis.Image = global::Car.Properties.Resources.promoting;
            this.satis.Location = new System.Drawing.Point(587, 21);
            this.satis.Name = "satis";
            this.satis.Size = new System.Drawing.Size(88, 83);
            this.satis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.satis.TabIndex = 12;
            this.satis.TabStop = false;
            this.satis.Click += new System.EventHandler(this.satis_Click);
            // 
            // cikis
            // 
            this.cikis.Image = global::Car.Properties.Resources.logout;
            this.cikis.Location = new System.Drawing.Point(700, 21);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(88, 83);
            this.cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cikis.TabIndex = 13;
            this.cikis.TabStop = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Müşteri Ekleme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(114, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Müşteri Listeleme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(253, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Araç Listele";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(365, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Araç Kayit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(482, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sözleşme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkRed;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(606, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Satışlar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkRed;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(726, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Çıkış";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(12, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 37);
            this.label8.TabIndex = 21;
            this.label8.Text = "ARAÇ KİRALAMA";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Car.Properties.Resources.genis_filo_kiralama;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.satis);
            this.Controls.Add(this.sözlesme);
            this.Controls.Add(this.AracKayıt);
            this.Controls.Add(this.AracListele);
            this.Controls.Add(this.MusteriKayıt);
            this.Controls.Add(this.MusteriEkleme);
            this.DoubleBuffered = true;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Otomasyon";
            ((System.ComponentModel.ISupportInitialize)(this.MusteriEkleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriKayıt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AracListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AracKayıt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sözlesme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox MusteriEkleme;
        private System.Windows.Forms.PictureBox MusteriKayıt;
        private System.Windows.Forms.PictureBox AracListele;
        private System.Windows.Forms.PictureBox AracKayıt;
        private System.Windows.Forms.PictureBox sözlesme;
        private System.Windows.Forms.PictureBox satis;
        private System.Windows.Forms.PictureBox cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

