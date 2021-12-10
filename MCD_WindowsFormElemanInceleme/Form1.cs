using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_WindowsFormElemanInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void sistemGirisForm()
        {
            sistemGiris sistemGirisForm = new sistemGiris();
            sistemGirisForm.ShowDialog();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            sistemGirisForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormElemanlariDoldur();
        }

        private void FormElemanlariDoldur()
        {
            cltUrunOzellikleri.Items.AddRange(Helper.urunOzellikListe.ToArray());

            //combobox değer atama - 1
            cmbUrunKategori.Items.AddRange(Helper.kategoriListe.ToArray());

            //combobox değer atama - 1
            cmbUrunRenk.Items.AddRange(Helper.urunRenk.ToArray());
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            DialogResult result = OFD.ShowDialog();
            if (result==DialogResult.OK)
            {
                pctUrunResim.Image = Image.FromFile(OFD.FileName);
                pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Urun kayiturun = new Urun();
            kayiturun.id = Guid.NewGuid();

            //Open File Dialog data alma işlemi...
            if (!string.IsNullOrEmpty(OFD.FileName))
                kayiturun.urunResimYol = OFD.FileName;

            //textbox dan değer alma işlemi...
            if (!string.IsNullOrEmpty(txtUrunTanim.Text))
                kayiturun.urunTanim = txtUrunTanim.Text;

            if (!string.IsNullOrEmpty(txtUrunKod.Text))
                kayiturun.urunKod = txtUrunKod.Text;

            //combobox dan seçilen datayı almak
            kayiturun.urunRenk = cmbUrunRenk.SelectedItem.ToString();

            kayiturun.urunKategori = cmbUrunKategori.SelectedItem.ToString();

            //RichText
            kayiturun.urunAciklama = txtAciklama.Text;

            //checkbox listeleme
            //selectedItem:  1 ürün bilgisi getirir özel tiplerde kullanılır. 
            //selectedText: özel bir tip kullanıyorsanız bir ürün seçimi dahi olsa selected text kısmında ayarlamış olduğumuz değeri yakalarız. 
            //selectedValue: kısmında ise text kısmında olduğu gibi value kısmında görmek istediğimiz değeri yakalarız.

            foreach (object item in cltUrunOzellikleri.CheckedItems)
            {
                //kısa kod yazımı
                //kayiturun.urunOzellikListe.Add((urunOzellikTanim)item);

                //uzun kod yazımı
                urunOzellikTanim Temp = (urunOzellikTanim)item;
                kayiturun.urunOzellikListe.Add(Temp);
                //bu kısımda inner type olarak kullandığınız list generic eğer yapıcı metot ile örneklenmediyse null ref hatası alırsınız...
                //bunu çözmek için ctor(urun) metot içinde List<T> koleksiyonu örneklemeniz gereklidir.
                //

            }
        }
    }
}
