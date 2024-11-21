using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoYonetimSistemi
{
    public partial class FormDepoYonetimi : Form
    {
        public FormDepoYonetimi()
        {
            InitializeComponent();
        /*    textBoxBirimFiyatı.Enabled = false;
            textBoxMiktar.Enabled = false;
            textBoxUrunAdi.Enabled = false;
            textBoxUrunKodu.Enabled = false;
            comboBoxIslem.Enabled = false;
            dataGridView1.Enabled = false;
        */}

        private void buttonStokYukle_Click(object sender, EventArgs e)
        {/*
            if (comboBoxDepo.SelectedItem != null)
            {
                string Depo = @"C:\Users\ÖmerSelimBERK\Desktop" + "\\" + $"{DateTime.Now:yyyy}_{comboBoxDepo.SelectedItem.ToString()}.csv";

                if (File.Exists(Depo))
                {
                    textBoxUrunKodu.Enabled = true;
                    textBoxMiktar.Enabled = true;
                    textBoxBirimFiyatı.Enabled = true;
                    textBoxUrunAdi.Enabled = true;
                    comboBoxDepo.Enabled = false;
                    dataGridView1.Enabled = true;
                }
            }
        */}
        int IDPlus = 1;
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (comboBoxDepo.SelectedItem != "Çıkış")
            {
                try
                {
                    int ID = IDPlus++;
                    string UrunAdi = textBoxUrunAdi.Text;
                    long UrunKodu = Convert.ToUInt32(textBoxUrunKodu.Text);
                    int DğşnMiktar = Convert.ToInt32(textBoxMiktar.Text);
                    int Miktar = DğşnMiktar + Miktar;
                    int BirimFiyatı = Convert.ToInt32(textBoxBirimFiyatı.Text);
                    int ToplamDeger = Miktar * BirimFiyatı;
                    string IslemTipi = comboBoxIslem.SelectedItem.ToString();
                    dataGridView1.Rows.Add(ID, UrunAdi, UrunKodu, Miktar, BirimFiyatı, ToplamDeger, IslemTipi);
                    textBoxUrunAdi.Clear();
                    textBoxUrunKodu.Clear();
                    textBoxMiktar.Clear();
                    textBoxBirimFiyatı.Clear();
                    comboBoxIslem.SelectedItem = null;
                    Kayıt();

                }
                catch
                {
                    MessageBox.Show("Lütfen doğru biçimde veri giriniz!");
                }
            }
            else
            {
                int ID = IDPlus++;
                string UrunAdi = textBoxUrunAdi.Text;
                long UrunKodu = Convert.ToUInt32(textBoxUrunKodu.Text);
                int Miktar = Convert.ToInt32(textBoxMiktar.Text);
                int BirimFiyatı = Convert.ToInt32(textBoxBirimFiyatı.Text);
                int ToplamDeger = Miktar * BirimFiyatı;
                string IslemTipi = comboBoxIslem.SelectedItem.ToString();
                dataGridView1.Rows.Add(ID, UrunAdi, UrunKodu, Miktar, BirimFiyatı, ToplamDeger, IslemTipi);
                textBoxUrunAdi.Clear();
                textBoxUrunKodu.Clear();
                textBoxMiktar.Clear();
                textBoxBirimFiyatı.Clear();
                comboBoxIslem.SelectedItem = null;
                Kayıt();
            }
        }
        public void Kayıt()
        {
            string Dosya = @"C:\Users\ÖmerSelimBERK\Desktop" + "\\" + $"{DateTime.Now:yyyy}_{comboBoxDepo.SelectedItem.ToString()}.csv";
            using (StreamWriter writer = new StreamWriter(Dosya, true))
            {
                if (new FileInfo(Dosya).Length == 0)
                {
                    writer.WriteLine("ID, UrunAdi, UrunKodu, Miktar, BirimFiyatı, ToplamDeger, IslemTipi");
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        string ID = " ";
                        string UrunAdi = " ";
                        string UrunKodu = " ";
                        string Miktar = " ";
                        string BirimFiyatı = " ";
                        string ToplamDeger = " ";
                        string IslemTipi = " ";

                        if (dataGridView1.Rows[i].Cells[0].ToString() != null &&
                            dataGridView1.Rows[i].Cells[1].ToString() != null &&
                            dataGridView1.Rows[i].Cells[2].ToString() != null &&
                            dataGridView1.Rows[i].Cells[3].ToString() != null &&
                            dataGridView1.Rows[i].Cells[4].ToString() != null &&
                            dataGridView1.Rows[i].Cells[5].ToString() != null &&
                            dataGridView1.Rows[i].Cells[6].ToString() != null)
                        {
                            ID = dataGridView1.Rows[i].Cells[0].ToString();
                            UrunAdi = dataGridView1.Rows[i].Cells[0].ToString();
                            UrunKodu = dataGridView1.Rows[i].Cells[0].ToString();
                            Miktar = dataGridView1.Rows[i].Cells[0].ToString();
                            BirimFiyatı = dataGridView1.Rows[i].Cells[0].ToString();
                            ToplamDeger = dataGridView1.Rows[i].Cells[0].ToString();
                            IslemTipi = dataGridView1.Rows[i].Cells[0].ToString();
                        }
                    }
                }
            }
        }
    }
}
