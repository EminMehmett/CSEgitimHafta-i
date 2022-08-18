// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine("Dğşikenler!");

Console.WriteLine("Hello World!"); // Burası ekrana yazı yazdırmamızı sağlayan metodumuz.
Console.WriteLine();// Bir satır boşluk 
Console.WriteLine("Merhaba Dünya!");
/*
   Burası çoklu yorum satırı 
   Bu şekilde 
   C# da çoklu yorum satırı yazabiliriz
   "//" Buda tekli yorum satırıdır.
 */

// Heap - Stack 
// C# ta 2 tip yapı vardır 
// 1- Değer Tipler (Stack te tutulur)
// 2- Referans Tipler (Bellekte heap bölgesinde tutulur, sınıflar (class) ve string değişkenler burada tutulur)

// C# ta Değişken Tanımlama 

// Tam sayı veri tipleri 

byte plaka_kodu; // Değişken oluşturmak için önce veri tipini sonra değişken adını yazarız. ; ise derleyiciye kodun bittiğini ifade eder. byte 0-255 arasında tam sayı taşıyabilir.
plaka_kodu = 34; // değişkene değer atama işlemi = operatörü ile gerçekleştirilir ve  eşitliğin sağ tarafındaki değer soldaki değişkene aktarılır. 
sbyte sbyteveri = 18; // değişkeni oluşturduğumuz anda değerini tanımlayabiliriz. sbyte -128 ile +127 arasında değer taşıyabilir. Sınırların dışına çıkarsak hata olur.
sbyte dolar = -128;
short kisaTamSayi = 1984;  // short 32767 ile -32768 arasında değer taşıyailir.
ushort ortaTamSayi = 12345;
int tamSayi = 123456789;
uint uzunTamSayi = 1234567898;
long upuzunTamSayii = 1234567898765;
ulong enUzunTamSayı = 12345678987654321;

//Kesirli sayı veri tipleri 
float kesirliSayi = 34.18f; // float veri tipinde sayının sonuna f harfi eklenir. 4 byte yer kaplar, 6-7 basamaklı sayı alabilir.
double kesirli_sayi = 34.18; // double veri tipi 8 byte yer kaplar, 15-16 basamak sayı alabilir.

// Decimal veri tipi 

decimal urunFiyatı = 999; // 12 byte yer kaplar 2 - 29 basamağa kadar destekler, fiyat hesaplama gibi hassas verilerde kullanılması tavsiye edilir.

// Char veri tipi 

char karakter = 'c'; // sadece bir karkteri tutar 

// string veri tipi 

string metin = "string veri tipi ile klavyeden girilen tüm karakterleri dilediğimiz gibi tutabiliriz!";

Console.WriteLine(metin); // metin değişkenini ekrana yazdır 

metin = "burada metin içeriği değişti";

Console.WriteLine(metin);

// boolean veri tipi: true ve false

bool urunDurumu = true; // ürün satışta 

bool haberDurumu = false; // haber yayında değil 

// C# ta sabit tanımlama

const int kdv = 18; // sabitlerde oluşturduğumuz anda değerini atamamız lazım 
const int iskonto = 25;
//kdv = 18; // const ile oluşturulan sabitin değeri sonradandeğiştirilmez! 

// ekrana yazdırmadığımız değişkenlerin altı yeşil olur bu değişkenin olşturulduğunu ama kullanılmadığını gösterir 




