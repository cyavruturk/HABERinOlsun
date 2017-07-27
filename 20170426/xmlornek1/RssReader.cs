using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

namespace xmlornek1
{
    class RssReader
    {
        //ilgili xml dosyası bu tarafa bir al kardedim...

        private XmlDocument xmlCek(string url)
        {
            WebClient wb = new WebClient();
            wb.Encoding = Encoding.UTF8;   //türkçe karakter temsil ediyor
            string rssData = wb.DownloadString(url);      //dowloadstring indirme gibi
            XmlDocument xmlDosyasi = new XmlDocument();
            xmlDosyasi.LoadXml(rssData);   //xml formatındaki veriyi alıyor rssDatayı aldık
            return xmlDosyasi;
        }


        //çektiğim xml dosyayı uygun nesne modeline parçala

        public List<Haber> XmlParcala(string url)
        {
            List<Haber> haberlerim = new List<Haber>();
            XmlDocument xmlDocument = xmlCek(url);
            XmlNodeList nodelist = xmlDocument.SelectNodes("rss/channel/item");    //itemleri tek tek seçip bir nodeliste toplicak
            foreach (XmlNode item in nodelist)
            {
                Haber haber = new Haber();   //her döndüğünde yeni bir haber ekleyip liste ekliek   
                haber.Baslik = item.SelectSingleNode("title").InnerText;   //kendi içinde sadece 1 tane node seçiyoruz   *ilgili textin içerisini okuyor:innertext
                haber.Aciklama = item.SelectSingleNode("description").InnerText;   //not::::: rssdeki adları yazıyoruz
                haber.Link = item.SelectSingleNode("link").InnerText;
                haber.Tarih = item.SelectSingleNode("pubDate").InnerText;
                haberlerim.Add(haber);
            }
            return haberlerim;
        }
    }
}
