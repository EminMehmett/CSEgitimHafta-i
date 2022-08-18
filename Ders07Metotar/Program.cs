// See https://aka.ms/new-console-template for more information
Console.WriteLine("Metotlar!");
void ToplamaYap()// void metotlar geriye değer döndürmeyen metotlardır. Görevini yapar ve işlemini tamamlar.
{
    Console.WriteLine(10 + 8);
}


void ToplamaYap2()
{
    Console.WriteLine(12 + 8);
}


void ToplamaYapParametre(int sayi1, int sayi2)// metotlar dışarıdan parametre alrak da çalışabilir
{
    Console.WriteLine(sayi1 + sayi2);// dışarıdan gönderilecek sayıları topla ve sonucu ekrana yaz 
}


bool MailGonder(string mailAdresi)// geriye değer döndüren metot
{
    string sistemdekiMailAdresi = "info@aribilgi.com";
    if (mailAdresi == sistemdekiMailAdresi)
    {
        // burada mail gönderim kodları olacak 
        return true;
    }
    else return false;

}


string MailGonder2(string mailAdresi)
{
    string sistemdekiMailAdresi = "info@bilgi.com";
    if (mailAdresi == sistemdekiMailAdresi)
    {
        // burada mail gönderim kodları olacak 
        return "Başarılı";
    }
    else return "Başarısız";
}


int kucukHarfSay(string kucukHarfSayılacakMetin)
{
    int kucukHarfSayisi = 0;//sayacağımız küçük harf sayısını tutmak için değiişkenimiz
    foreach (char harf in kucukHarfSayılacakMetin)
    {
        if (char.IsLower(harf)) kucukHarfSayisi++;// eğer ekranda okunan metin içerisindekiharf küçükse kucukHarfSayisi değerini 1 artırır
    }
    return kucukHarfSayisi;//geriye döndürülen değer

}


//    Main Metodu 


ToplamaYap();// Yazdığımız metodu bir yerde çağırmamız gerekir yoksa metot çalışmaz

ToplamaYap2();

ToplamaYapParametre(18, 20);// parametreli metotlarda metodu çağırdığımız yerde gerekli parametreleri de göndermemiz gerekir.

Console.WriteLine("Mail adresinizi giriniz");

var mail = Console.ReadLine();

bool sonuc = MailGonder(mail);
if (sonuc)// == true 
{
    Console.WriteLine(mail + " adresinde mail gönderimi başarılı.");

}
else
{
    Console.WriteLine(mail + " adresinde mail gönderimi başarısız!");
}



var sonuc2 = MailGonder2(mail);
if (sonuc2 == "Başarılı")
{
    Console.WriteLine(mail + " adresinde mail gönderimi başarılı.");

}
else
{
    Console.WriteLine(mail + " adresinde mail gönderimi başarısız!");
}

Console.WriteLine("Bir cümle yazıp enter a basınız");
string cumle = Console.ReadLine();
Console.WriteLine("Cümledeki küçük harf sayısı {0} adettir. ", kucukHarfSay(cumle));
