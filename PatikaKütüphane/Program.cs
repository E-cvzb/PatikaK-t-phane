// See https://aka.ms/new-console-template for more information
using PatikaKütüphane;
  

Console.WriteLine("Merhabalar Patika Kütüphanesine hosşgeldiniz ");
KütüphaneVeri kitap=new KütüphaneVeri();
kitap.yazarİsimi = "Ahmet";
kitap.yazarSoyisim = "Yılmaz";
kitap.yayınTarihi= DateTime.Now;
kitap.sayfaSayısı = 320;
kitap.yayınEvi = "Alfa Yayınları";
kitap.kitapAd = "Bir Kitap";
kitap.BilgiYazma();
KütüphaneVeri._kitapSayısı++;// static türünde tanımlanan  değişkenler verilen sınıf adı ile  birlikte yazılır 



KütüphaneVeri kitap1 = new KütüphaneVeri("Başak Bir Kitap", "Ayşe","Karan",215,"Beta Yayıncılık");
kitap1.BilgiYazma();

KütüphaneVeri kitap2 = new KütüphaneVeri("Daha Başka Bir Kitap","Mehmet","Demir",450,"Gama Yayıncılık");
kitap2 .BilgiYazma();

KütüphaneVeri kitap3 = new KütüphaneVeri("Son Kitap", "Elif", "Şahin", 275, "Deta Yayıncılık");
kitap3 .BilgiYazma();

KütüphaneVeri kitap4 = new KütüphaneVeri("Örnek Kitap","Selin","Yurt",198,"Epsilon Yyınları");
kitap4 .BilgiYazma();

    KütüphaneVeri.KitapSayısı();// toplmda kaç tane kitap kayıt edildiğini yazdıracak







