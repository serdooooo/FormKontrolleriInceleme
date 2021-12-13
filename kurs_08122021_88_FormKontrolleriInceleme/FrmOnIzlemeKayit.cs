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
    public partial class FrmOnIzlemeKayit : Form
    {
        public FrmOnIzlemeKayit()
        {
            InitializeComponent();
        }
        int islemSonuc;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
        //    Form yakalananform = Application.OpenForms["form2"];
        //    foreach (Form item in Application.OpenForms)
        //    {
        //        if (item.Name == "form1")
        //        {
        //            foreach (Control formıtem in item.Controls)
        //            {
        //                if (formıtem is TextBox)
        //                {
        //                    ((TextBox)formıtem).Text = string.Empty;
        //                }
        //            }
        //        }
          //  }
            islemSonuc = MusteriEkle(new Musteri()
            {
                Isim = TxtIsim.Text,
                Soyisim = TxtSoyisim.Text,
                EmailAdres = TxtEmailAdres.Text,
                TelefonNumarasi = TxtTelefonNumara.Text
            });

            Form1 cagirForm = new Form1();
            ((TextBox)cagirForm.Controls["TxtIsim"]).Text = TxtIsim.Text;
            ((TextBox)cagirForm.Controls["TxtSoyisim"]).Text = TxtSoyisim.Text;
            ((TextBox)cagirForm.Controls["TxtEmailAdres"]).Text = TxtEmailAdres.Text;
            ((TextBox)cagirForm.Controls["TxtTelefonNumara"]).Text = TxtTelefonNumara.Text;

            this.Close();
        }
        private int MusteriEkle(Musteri data)
        {
            SanalDataBase.musteriler.Add(data);
            return 1;
        }
    }
}
