using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PatikaKütüphane
{
    
    public class KütüphaneVeri
    {
        public static int _kitapSayısı;// nesne örneği kullanmadan sayaç oluşturmak için static şeklinde oluşturulmuştur

         static KütüphaneVeri()//static formunda sayaç oluşturma 
        {
            _kitapSayısı = 0;
        }
        public static int kitapSayısı
        {
            get { return _kitapSayısı; }
            set { _kitapSayısı= value; }

        }

        public static void KitapSayısı()// sayaç yazdırma
        {
            Console.WriteLine($"Kayıt edilen toplam kitap sayısı--------> {_kitapSayısı}");
        }
        public string _kitapAd;
        public string _yazarİsim;
        public string _yazarSoyisim;
        public int _sayfaSayısı;
        public string _yayınEvi;
        public DateTime _yayınTarihi;
        

        public string kitapAd
        {
            get { return _kitapAd; }
            set { _kitapAd = value; }
        }
        public string yazarİsimi
        {
            get
            {
                return _yazarİsim;
            }
            set
            {
                _yazarİsim = value;
            }
        }
        public string yazarSoyisim
        {
            get { return _yazarSoyisim; }
            set { _yazarSoyisim = value;}

        }
        public int sayfaSayısı
        {
            get { return _sayfaSayısı; }
            set
            {
                if (value > 0)//kitap sayısının 0 dan büyük olması şartı
                {
                    _sayfaSayısı = value;
                }
            }

        }
        public string yayınEvi
        {
            get { return _yayınEvi;}
            set { _yayınEvi = value;}

        }
        public DateTime yayınTarihi
        {
            get { return _yayınTarihi; }
            set { _yayınTarihi = value;}
        }
        public KütüphaneVeri(string kitapad ,string yazarİsim , string yazarSoyisim, int sayfasayısı,string yayınEvi) 
        {

            _kitapAd = kitapAd;
            _yazarİsim = yazarİsim;
            _yazarSoyisim= yazarSoyisim;
            _sayfaSayısı = sayfasayısı;
            _yayınEvi = yayınEvi;
            _yayınTarihi= DateTime.Now;// kayıt yapılan starihin şu an olmasını sağlıyor
            _kitapSayısı++;//Metot her kullanıldığında sayaç da artacak 

            
        }
        public void BilgiYazma()//girilen bilgiler ile siteme kayıt edilme şekili 
        {
            Console.WriteLine($"{yazarİsimi}{yazarSoyisim}'nin {sayfaSayısı} sayfalık {yayınEvi}yayın evinden {kitapAd} kitabı kütüphaneye {yayınTarihi} tarihinde kayıt edilmiştir");

        }
        public KütüphaneVeri()//defaut yapı
        {
        }
    }

   
    
}
