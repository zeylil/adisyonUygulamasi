using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adisyonUygulamasi
{
    public partial class uygulama : Form
    {
        //buraya weri tabanı bağlanıyor Sıla'dan not
       
        public uygulama()
        {
            InitializeComponent();
        }

        private void uygulama_Load(object sender, EventArgs e)
        {
           // Form1 frm = new Form1();
            //frm.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private string seciliMasa = "";

        private void btn_masa1_Click(object sender, EventArgs e)
        {
            seciliMasa = "Masa 1";
            MessageBox.Show("Masa 1 açıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_masa2_Click(object sender, EventArgs e)
        {
            seciliMasa = "Masa 2";
            MessageBox.Show("Masa 2 açıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_masa3_Click(object sender, EventArgs e)
        {
            seciliMasa = "Masa 3";
            MessageBox.Show("Masa 3 açıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_masa4_Click(object sender, EventArgs e)
        {
            seciliMasa = "Masa 4";
            MessageBox.Show("Masa 4 açıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_masa5_Click(object sender, EventArgs e)
        {
            seciliMasa = "Masa 5";
            MessageBox.Show("Masa 5 açıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_cayy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seciliMasa))
            {
                MessageBox.Show("Lütfen masa seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataGridView1.Rows.Add("Çay", 15);
            ToplamHesapla();
        }

        private void btn_kahve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seciliMasa))
            {
                MessageBox.Show("Lütfen masa seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataGridView1.Rows.Add("Kahve", 100);
            ToplamHesapla();
        }

        private void btn_ihlamur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seciliMasa))
            {
                MessageBox.Show("Lütfen masa seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataGridView1.Rows.Add("Ihlamur", 50);
            ToplamHesapla();

        }

        private void btn_limonata_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seciliMasa))
            {
                MessageBox.Show("Lütfen masa seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataGridView1.Rows.Add("Limonata", 70);
            ToplamHesapla();
        }

        private void btn_su_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seciliMasa))
            {
                MessageBox.Show("Lütfen masa seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataGridView1.Rows.Add("Su", 10);
            ToplamHesapla();

        }

        private void btn_hamburger_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seciliMasa))
            {
                MessageBox.Show("Lütfen masa seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataGridView1.Rows.Add("Hamburger", 175);
            ToplamHesapla();

        }

        private void btn_pizza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seciliMasa))
            {
                MessageBox.Show("Lütfen masa seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataGridView1.Rows.Add("Pizza", 125);
            ToplamHesapla();

        }

        private void btn_sosisli_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seciliMasa))
            {
                MessageBox.Show("Lütfen masa seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataGridView1.Rows.Add("Sosisli", 80);
            ToplamHesapla();

        }

        private void btn_makarna_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seciliMasa))
            {
                MessageBox.Show("Lütfen masa seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataGridView1.Rows.Add("Makarna", 100);
            ToplamHesapla();
        }

        private void btn_salata_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seciliMasa))
            {
                MessageBox.Show("Lütfen masa seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataGridView1.Rows.Add("Salata", 60);
        }
        private decimal ToplamHesapla()   //pek anlamadım
        {
            decimal toplam = 0;

            // DataGridView'deki her satırı döngüye al
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Boş satırları geç (satırda veri yoksa işlemi atla)
                if (row.Cells[1].Value != null && !string.IsNullOrEmpty(row.Cells[1].Value.ToString()))
                {
                    string fiyatString = row.Cells[1].Value.ToString().Replace("₺", "").Trim();

                    // Sayıya çevrilip çevrilemediğini kontrol et
                    if (decimal.TryParse(fiyatString, out decimal fiyat))
                    {
                        toplam += fiyat;
                    }
                }
            }

            return toplam;
        }
        private void btn_hesapkes_Click(object sender, EventArgs e)
        {
            // Toplamı hesapla
            decimal toplam2 = ToplamHesapla();

            // Hesap ekranda göster
            MessageBox.Show("Hesabınız: " + toplam2.ToString("C2"));

            // DataGridView'i temizle
            dataGridView1.Rows.Clear();

            // Seçili masa bilgisini sıfırla
            seciliMasa = "";

            // Belirli bir masa seçilmesi için kullanıcıyı bilgilendir
            MessageBox.Show("Yeni masa seçebilirsiniz.");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //satır seçme seçeneğini aktif ettik

            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                ToplamHesapla();
            }
            else
            {
                MessageBox.Show("Silinecek bir ürün seçmelisiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

