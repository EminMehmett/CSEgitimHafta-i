// See https://aka.ms/new-console-template for more information
//using Ders08Classlar;
public class Ev // C# da class tanımlama
{
    public int kapiNo; // Sınıf değişkenleri oluşturma
    public string sokakAdi;
}


namespace Ders08Classlar // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıflar-Classes!");

            Ev ev = new(); // ev sınıfından bir nesne oluşturduk

            ev.kapiNo = 1;
            ev.sokakAdi = "Okul Sokak,";

            Console.WriteLine("Ev Adresimiz : " + ev.sokakAdi + "  No : " + ev.kapiNo);// ev nesnesinin özelliklerini ekrana yazdırdık 
            //2.- Yöntem
            Ev yazlık = new()
            {
                sokakAdi = "Yalı Kavak Sokak,",
                kapiNo = 18
            };

            Console.WriteLine($"Yazlık Adresi : {yazlık.sokakAdi} Kapı No :{yazlık.kapiNo} Bodrum/Muğla");

            Console.WriteLine("********************************************");

            Kurs kurs = new()
            {
                KursAdi = "Arı Bilgi",
                EgitimAdi = "Yazılım Uzmanlığı",
                KapiNo = 102,
                SinifMevcudu = 6
            };

            Console.WriteLine("Kurs Bilgilerim \n : Kurs Adı : {0}   Eğitim Adı : {1}       Kapı No : {2}", kurs.KursAdi, kurs.EgitimAdi, kurs.KapiNo);



            Console.WriteLine("********************************************");



            Araba araba = new()
            {
                KasaTipi = "Sedan",
                Marka = "Fiat",
                Model = "Linea",
                Renk = "Beyaz",
                UretimYili = 2013
            };

            Console.WriteLine($"Araba Bilgilerimiz : \n Marka : {araba.Marka} \n Model : {araba.Model} \n Renk : {araba.Renk}");// \n bir alt satıra geç demektir

            Console.WriteLine("********************************************");


            Urun urun = new()
            {
                Fiyat = 99,
                Özellikler = "Işıklı klavye",
                Stok = 18,
                UrunAdi = "Oyuncu Klavye"
            };

            Console.WriteLine("Ürün Bilgileri");
            Console.WriteLine($"Ürün Adı : {urun.UrunAdi}");
            Console.WriteLine($"Ürün Fiyatı : {urun.Fiyat}");
            Console.WriteLine($"Ürün Stok : {urun.Stok}");
            Console.WriteLine($"Ürün Özellikler : {urun.Özellikler}");// $ işaretinin anlamı süslü parantez kullanarak değişkeni yazmamızı sağlar olmasaydı + kullanmak zorunda kalacaktık 

            Console.WriteLine();
            Console.WriteLine("Sınıfta Metot Kullanımı");
            SiniftaMetotKullanimi siniftaMetotKullanimi = new();
            siniftaMetotKullanimi.DinamikToplamaYap();
            //Console.WriteLine(siniftaMetotKullanimi.mesaj);
            // Static olarak belirtilmeyen metot ve değişkenler dinamiktir
            // Sınıfların içindeki Dinamik metot ve değişkenlere ulaşmak için yukarıdaki gibi new leyerek nesne oluşturmamız gerekir.

            SiniftaMetotKullanimi.StatikToplamaYap(10, 9);// statik metoda direkt classadı.metotadı şeklinde erişebiliriz nesne ye (siniftaMetotKullanimi) ihtiyacımız yok!
            Console.WriteLine(SiniftaMetotKullanimi.StatikDeğişken);








        }
    }
}

public class Kurs
{
    public int KapiNo;
    public string KursAdi;
    public string EgitimAdi;
    public int SinifMevcudu;
}

public class Araba
{
    public string Marka;
    public string Model;
    public string Renk;
    public string KasaTipi;
    public int UretimYili;


}






