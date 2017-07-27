using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xmlornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btngetir_Click(object sender, EventArgs e)
        {
            try
            {
                //ilgili linkten xml veriyi çek, parçala ve haberler listiyle ekle 
                RssReader rss = new RssReader();
                List<Haber> haberlerim = rss.XmlParcala(txturl.Text);


                //haberlerden listinden ilgili verileri listview elşe
                ListviewDoldur(haberlerim, lsvlistele);
            }
            catch (Exception)
            {

                MessageBox.Show("Linke ulaşılamadı!");
            }
           
        }

        private void lsvlistele_DoubleClick(object sender, EventArgs e)
        {
            //eğer bir seçili ise item içinden linki oku ve webtarayıcı üzerinde göster
            if(lsvlistele.SelectedItems.Count>0)
            {
                string link = ((lsvlistele.SelectedItems[0].Tag) as Haber).Link;   //haberlere cast ettik
                wbtarayici.Navigate(link);    //web tarayıcısına linki gönderdik
            }
        }

        private void ListviewDoldur(List<Haber>haberlerim, ListView listview)  //list ya da dizi olur list daha jenerik bir yapı oluşturur
        {
            foreach (Haber item in haberlerim)
            {
                ListViewItem lvi = new ListViewItem();   //listview ekleme yapmak için listviewitem nesnesi oluşturuyoruz
                lvi.Text = item.Baslik;
                lvi.SubItems.Add(item.Link);
                lvi.Tag = item;    //şu ana kadatr listview itemi doldurduk..

                listview.Items.Add(lvi);
            }
        }
    }
}
