using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xmlornek1
{
    class RSSReaderWithXml
    {
        public List <Haber> XmlOku(string url)
        {
            List<Haber> haberlerim = new List<Haber>();
            XmlReader reader = XmlReader.Create(url);    //xml alt sınıfını oluşturup xmlreadera atıyorum.   (xml verilerini çektik)
            bool itemMi = false;

            //elimizdeki verileri satır satır okucaz..
            while(itemMi || reader.Read())    //kod çalışır değer okur, okuduğu değeri saklar. okuyabiliyosam while devam etsin, okutyanıyosam boştur
            {
                if(reader.Name=="item")    //tag'in itemse, itemsın içini oku
                {
                    itemMi = false;
                    Haber haber = new Haber();
                    bool okuyayimmi = true;
                   
                    while (itemMi && reader.Read())
                    {
                        if(reader.IsStartElement())
                        {
                            
                            switch (reader.Name)
                            {
                                case "title":
                                    reader.Read();
                                    haber.Baslik = reader.Value;
                                    break;

                                case "link":
                                    reader.Read();
                                    haber.Link = reader.Value;
                                    break;

                                case "description":
                                    reader.Read();
                                    haber.Aciklama = reader.Value;
                                    break;

                                case "pubdate":
                                    reader.Read();
                                    haber.Tarih = reader.Value;
                                    break;
                                case "item":
                                    reader.Read();
                                    okuyayimmi = false;
                                    itemMi = true;
                                    break;
                            }
                        }
                        
                    }
                    haberlerim.Add(haber);
                }
            }
            return haberlerim;
        }
    }
}
