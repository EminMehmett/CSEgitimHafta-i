// See https://aka.ms/new-console-template for more information
Console.WriteLine("Karar Yapıları!");
Console.WriteLine("Bir sayı girip enter a basınız..");

var s = Console.ReadLine(); // var anahtar kelimesideğişken oluşturmak için kullanılır ve oluşan değişkene atanan değerin veri tipine göre değişkenin tipini otomatik belirler. Console.ReadLine() metodu ekrandaki satıra girilen değeri okur.

int sayi = Convert.ToInt32(s);

if (sayi > 0) // eğer sayı 0 dan büyükse 
{
    // Buradaki kodlar çalışır
    Console.WriteLine("Girilen sayı 0 dan büyük!");
}
else if (sayi == 0) //yukarıdaki şartı sağlamadıysa burası çalışır 
{
    Console.WriteLine("Girilen sayı 0");
}
else // yukarıdakilerden hiçbiri değilse burası çalışır 
{
    Console.WriteLine("Negatif sayı girdiniz");
}




// Örnek-2 

Console.WriteLine("Kullanıcı Adını Giriniz");
string kullaniciAdi = Console.ReadLine(); // Console.ReadLine() metodu ekrandan girilen değeri yakalar ve kullaniciAdi değişkenine atar.

Console.WriteLine("Şifre Giriniz");
string sifre = Console.ReadLine(); // Console.ReadLine() metodu ekrandan girilen değeri yakalar ve sifre değişkenine atar.

string veritabanindakiKullaniciAdi = "admin";
string veritabanindekiSifre = "123456";

if (kullaniciAdi == veritabanindakiKullaniciAdi && sifre == veritabanindekiSifre)
{
    Console.WriteLine("Sisteme Giriş Yapıldı");
}
else
{
    Console.WriteLine("Kullanıcı Bulunamadı!");
}



// Örnk 3

int saat = DateTime.Now.Hour; // geçerli zamanın saat bilgisinii alıp saat değişkenine atadık 
int dakika = DateTime.Now.Minute;
if (saat < 18)
{
    Console.WriteLine("Saat : " + saat + " : " + dakika + " İyi Günler Üstat Splinter");
}
else Console.WriteLine("Saat : " + saat + " : " + dakika + " İyi Akşamlar Çekirge"); // eğer tek satırlık bir kod yazacaksak süslü parantez kullanmak zorunda değiliz böylede yazılabilir! 
Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.ToShortTimeString()); // anlık saat ve dakika 
Console.WriteLine(DateTime.Now.ToLongTimeString()); // anlık saat, dakika, saniye
Console.WriteLine(DateTime.Now.ToShortDateString()); // anlık tarih


Console.WriteLine("Ternary Operatörü ile if else yazmadan");
Console.WriteLine((saat < 20) ? "İyi Günler" : "İyi Akşamlar");// Eğer sadece if ve else kullanacaksak bu operatörle daha kısa bir kodla işimizi çözebiliriz. Burada şartı (saat < 20) ? kısmı belirler burası if şartı olarak çalışır. : karakterinden sonraki bölüm ise değilse yani else kısmıdır 

int ay = DateTime.Now.Month;
Console.WriteLine("Ay Değeri : " + ay);
switch (ay)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış Mevsimi");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar Mevsimi");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz Mevsimi");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar Mevsimi");
        break;
    default:
        Console.WriteLine("Yanlış Bilgi!");
        break;
}
