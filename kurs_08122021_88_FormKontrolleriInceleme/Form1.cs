using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs_08122021_88_FormKontrolleriInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int islemSonuc;
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            DialogResult resultEnum = MessageBox.Show("Form içerisinde bulunan değerleri silmek istediğinizden emin misiniz?", "Form Temizleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultEnum == DialogResult.Yes)
            {
                formTemizle();
                formElemanIndexTemizle();
            }
            else
            {
                //işlem iptal edildi...
            }
        }


        private void formTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) // item control == textbox
                {
                    TextBox T = (TextBox)item;
                    T.Text = string.Empty;
                }
            }
        }


        private void formElemanIndexTemizle()
        {
            ((TextBox)this.Controls["TxtIsim"]).Text = string.Empty;
            ((TextBox)this.Controls["TxtSoyisim"]).Text = string.Empty;
            ((TextBox)this.Controls["TxtEmailAdres"]).Text = string.Empty;
            ((TextBox)this.Controls["TxtTelefonNumara"]).Text = string.Empty;
        }
        private void BtnOnizleme_Click(object sender, EventArgs e)
        {
            FrmOnIzlemeKayit onizlemeKayit = new FrmOnIzlemeKayit();
            ((TextBox)onizlemeKayit.Controls["TxtIsim"]).Text = TxtIsim.Text;
            ((TextBox)onizlemeKayit.Controls["TxtSoyisim"]).Text = TxtSoyisim.Text;
            ((TextBox)onizlemeKayit.Controls["TxtEmailAdres"]).Text = TxtEmailAdres.Text;
            ((TextBox)onizlemeKayit.Controls["TxtTelefonNumara"]).Text = TxtTelefonNumara.Text;
            onizlemeKayit.ShowDialog();
            formTemizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtIsim.Text) || string.IsNullOrWhiteSpace(TxtSoyisim.Text) || string.IsNullOrWhiteSpace(TxtEmailAdres.Text) || string.IsNullOrWhiteSpace(TxtTelefonNumara.Text))
            {
                MessageBox.Show("Hiçbir alan boş bırakılamaz.");
                formTemizle();
            }
            else
            {
                islemSonuc = MusteriEkle(new Musteri()
                {
                    Isim = TxtIsim.Text,
                    Soyisim = TxtSoyisim.Text,
                    EmailAdres = TxtEmailAdres.Text,
                    TelefonNumarasi = TxtTelefonNumara.Text
                });
                if (islemSonuc > 0)
                {

                    EkranListele();
                    formTemizle();
                }
            }
        }

        private void EkranListele()
        {
            LstMusteriler.Items.Clear();
            foreach (var item in SanalDataBase.musteriler)
            {
                LstMusteriler.Items.Add(item);
            }
        }

        private int MusteriEkle(Musteri data)
        {
            SanalDataBase.musteriler.Add(data);
            return 1;
        }

        private void OnIzlemeKayit_Click(object sender, EventArgs e)
        {
            EkranListele();
        }
    }
}
