namespace Access
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Güncelle = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Btn_Kaydet = new System.Windows.Forms.Button();
            this.Btn_Listele = new System.Windows.Forms.Button();
            this.txt_syf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_tür = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_yzr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Güncelle
            // 
            this.Btn_Güncelle.Location = new System.Drawing.Point(466, 132);
            this.Btn_Güncelle.Name = "Btn_Güncelle";
            this.Btn_Güncelle.Size = new System.Drawing.Size(92, 28);
            this.Btn_Güncelle.TabIndex = 37;
            this.Btn_Güncelle.Text = "Güncelle";
            this.Btn_Güncelle.UseVisualStyleBackColor = true;
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Location = new System.Drawing.Point(466, 103);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(92, 28);
            this.Btn_Sil.TabIndex = 36;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Location = new System.Drawing.Point(466, 74);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(92, 28);
            this.Btn_Kaydet.TabIndex = 35;
            this.Btn_Kaydet.Text = "Kaydet";
            this.Btn_Kaydet.UseVisualStyleBackColor = true;
            // 
            // Btn_Listele
            // 
            this.Btn_Listele.Location = new System.Drawing.Point(466, 45);
            this.Btn_Listele.Name = "Btn_Listele";
            this.Btn_Listele.Size = new System.Drawing.Size(92, 28);
            this.Btn_Listele.TabIndex = 34;
            this.Btn_Listele.Text = "Listele";
            this.Btn_Listele.UseVisualStyleBackColor = true;
            this.Btn_Listele.Click += new System.EventHandler(this.Btn_Listele_Click);
            // 
            // txt_syf
            // 
            this.txt_syf.Location = new System.Drawing.Point(288, 119);
            this.txt_syf.Name = "txt_syf";
            this.txt_syf.Size = new System.Drawing.Size(113, 20);
            this.txt_syf.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(231, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Sayfa:";
            // 
            // cmb_tür
            // 
            this.cmb_tür.FormattingEnabled = true;
            this.cmb_tür.Location = new System.Drawing.Point(288, 145);
            this.cmb_tür.Name = "cmb_tür";
            this.cmb_tür.Size = new System.Drawing.Size(113, 21);
            this.cmb_tür.TabIndex = 31;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(370, 182);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 17);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sıfır";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(291, 182);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kullanılmış";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(224, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Durum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(233, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tür";
            // 
            // txt_yzr
            // 
            this.txt_yzr.Location = new System.Drawing.Point(288, 93);
            this.txt_yzr.Name = "txt_yzr";
            this.txt_yzr.Size = new System.Drawing.Size(113, 20);
            this.txt_yzr.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(231, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Yazar:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(288, 61);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(113, 20);
            this.txt_ad.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(213, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Kitap Ad:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(288, 35);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(113, 20);
            this.txt_id.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(213, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kitap İD:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(119, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 174);
            this.dataGridView1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Güncelle);
            this.Controls.Add(this.Btn_Sil);
            this.Controls.Add(this.Btn_Kaydet);
            this.Controls.Add(this.Btn_Listele);
            this.Controls.Add(this.txt_syf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_tür);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_yzr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Güncelle;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button Btn_Kaydet;
        private System.Windows.Forms.Button Btn_Listele;
        private System.Windows.Forms.TextBox txt_syf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_tür;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_yzr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

