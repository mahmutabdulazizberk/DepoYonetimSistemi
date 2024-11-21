namespace DepoYonetimSistemi
{
    partial class FormDepoYonetimi
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
            this.textBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.textBoxUrunKodu = new System.Windows.Forms.TextBox();
            this.textBoxMiktar = new System.Windows.Forms.TextBox();
            this.textBoxBirimFiyatı = new System.Windows.Forms.TextBox();
            this.comboBoxIslem = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDepo = new System.Windows.Forms.ComboBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonStokYukle = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÜrünAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÜrünKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DğşnMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyatı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamDeğer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İşlemTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUrunAdi
            // 
            this.textBoxUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.textBoxUrunAdi.Location = new System.Drawing.Point(222, 80);
            this.textBoxUrunAdi.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxUrunAdi.Name = "textBoxUrunAdi";
            this.textBoxUrunAdi.Size = new System.Drawing.Size(223, 37);
            this.textBoxUrunAdi.TabIndex = 0;
            // 
            // textBoxUrunKodu
            // 
            this.textBoxUrunKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.textBoxUrunKodu.Location = new System.Drawing.Point(222, 129);
            this.textBoxUrunKodu.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxUrunKodu.Name = "textBoxUrunKodu";
            this.textBoxUrunKodu.Size = new System.Drawing.Size(223, 37);
            this.textBoxUrunKodu.TabIndex = 1;
            // 
            // textBoxMiktar
            // 
            this.textBoxMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.textBoxMiktar.Location = new System.Drawing.Point(222, 178);
            this.textBoxMiktar.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxMiktar.Name = "textBoxMiktar";
            this.textBoxMiktar.Size = new System.Drawing.Size(223, 37);
            this.textBoxMiktar.TabIndex = 2;
            // 
            // textBoxBirimFiyatı
            // 
            this.textBoxBirimFiyatı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.textBoxBirimFiyatı.Location = new System.Drawing.Point(222, 227);
            this.textBoxBirimFiyatı.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxBirimFiyatı.Name = "textBoxBirimFiyatı";
            this.textBoxBirimFiyatı.Size = new System.Drawing.Size(223, 37);
            this.textBoxBirimFiyatı.TabIndex = 3;
            // 
            // comboBoxIslem
            // 
            this.comboBoxIslem.FormattingEnabled = true;
            this.comboBoxIslem.Items.AddRange(new object[] {
            "Giriş",
            "Çıkış"});
            this.comboBoxIslem.Location = new System.Drawing.Point(222, 30);
            this.comboBoxIslem.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxIslem.Name = "comboBoxIslem";
            this.comboBoxIslem.Size = new System.Drawing.Size(223, 38);
            this.comboBoxIslem.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ÜrünAdı,
            this.ÜrünKodu,
            this.DğşnMiktar,
            this.Miktar,
            this.BirimFiyatı,
            this.ToplamDeğer,
            this.İşlemTipi});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(15, 300);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1324, 348);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürün Kodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Miktarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Birim Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "İşlem Tipi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(925, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Depo Seçiniz:";
            // 
            // comboBoxDepo
            // 
            this.comboBoxDepo.FormattingEnabled = true;
            this.comboBoxDepo.Items.AddRange(new object[] {
            "Batıkent Deposu",
            "Koru Deposu",
            "Dikmen Deposu"});
            this.comboBoxDepo.Location = new System.Drawing.Point(1116, 15);
            this.comboBoxDepo.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxDepo.Name = "comboBoxDepo";
            this.comboBoxDepo.Size = new System.Drawing.Size(223, 38);
            this.comboBoxDepo.TabIndex = 12;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(454, 224);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(198, 40);
            this.buttonKaydet.TabIndex = 13;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonStokYukle
            // 
            this.buttonStokYukle.Location = new System.Drawing.Point(1141, 62);
            this.buttonStokYukle.Name = "buttonStokYukle";
            this.buttonStokYukle.Size = new System.Drawing.Size(198, 40);
            this.buttonStokYukle.TabIndex = 14;
            this.buttonStokYukle.Text = "Stok Yükle";
            this.buttonStokYukle.UseVisualStyleBackColor = true;
            this.buttonStokYukle.Click += new System.EventHandler(this.buttonStokYukle_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.FillWeight = 56.95187F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 15;
            this.ID.Name = "ID";
            // 
            // ÜrünAdı
            // 
            this.ÜrünAdı.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ÜrünAdı.FillWeight = 93.29258F;
            this.ÜrünAdı.HeaderText = "ÜrünAdı";
            this.ÜrünAdı.MinimumWidth = 6;
            this.ÜrünAdı.Name = "ÜrünAdı";
            // 
            // ÜrünKodu
            // 
            this.ÜrünKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ÜrünKodu.FillWeight = 93.29258F;
            this.ÜrünKodu.HeaderText = "ÜrünKodu";
            this.ÜrünKodu.MinimumWidth = 6;
            this.ÜrünKodu.Name = "ÜrünKodu";
            // 
            // DğşnMiktar
            // 
            this.DğşnMiktar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DğşnMiktar.FillWeight = 93.29258F;
            this.DğşnMiktar.HeaderText = "DğşnMiktar";
            this.DğşnMiktar.MinimumWidth = 6;
            this.DğşnMiktar.Name = "DğşnMiktar";
            // 
            // Miktar
            // 
            this.Miktar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Miktar.FillWeight = 93.29258F;
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.MinimumWidth = 6;
            this.Miktar.Name = "Miktar";
            // 
            // BirimFiyatı
            // 
            this.BirimFiyatı.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BirimFiyatı.FillWeight = 93.29258F;
            this.BirimFiyatı.HeaderText = "BirimFiyatı";
            this.BirimFiyatı.MinimumWidth = 6;
            this.BirimFiyatı.Name = "BirimFiyatı";
            // 
            // ToplamDeğer
            // 
            this.ToplamDeğer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToplamDeğer.FillWeight = 93.29258F;
            this.ToplamDeğer.HeaderText = "ToplamDeğer";
            this.ToplamDeğer.MinimumWidth = 6;
            this.ToplamDeğer.Name = "ToplamDeğer";
            // 
            // İşlemTipi
            // 
            this.İşlemTipi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.İşlemTipi.FillWeight = 93.29258F;
            this.İşlemTipi.HeaderText = "İşlemTipi";
            this.İşlemTipi.MinimumWidth = 6;
            this.İşlemTipi.Name = "İşlemTipi";
            // 
            // FormDepoYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 663);
            this.Controls.Add(this.buttonStokYukle);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.comboBoxDepo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxIslem);
            this.Controls.Add(this.textBoxBirimFiyatı);
            this.Controls.Add(this.textBoxMiktar);
            this.Controls.Add(this.textBoxUrunKodu);
            this.Controls.Add(this.textBoxUrunAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormDepoYonetimi";
            this.Text = "Zirve Asrin Depo Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrunAdi;
        private System.Windows.Forms.TextBox textBoxUrunKodu;
        private System.Windows.Forms.TextBox textBoxMiktar;
        private System.Windows.Forms.TextBox textBoxBirimFiyatı;
        private System.Windows.Forms.ComboBox comboBoxIslem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDepo;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonStokYukle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÜrünAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÜrünKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DğşnMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyatı;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamDeğer;
        private System.Windows.Forms.DataGridViewTextBoxColumn İşlemTipi;
    }
}

