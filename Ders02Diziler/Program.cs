// See https://aka.ms/new-console-template for more information

Console.WriteLine("Diziler!");

int[] ogrenciler = new int[6];// Dizi oluturma 
ogrenciler[0] = 100; // yazılımda genelde ilk eleman hep sfırıncı elemandır. Saymaya sıfırdan başlar.
ogrenciler[1] = 200;
ogrenciler[2] = 200;
ogrenciler[3] = 300;
ogrenciler[4] = 400;
ogrenciler[5] = 500;
//ogrenciler[6] = 600; // 6 elemanlı diziye 6 dan fazla eleman ekleyemeyiz! Eklersek hata alırız.


Console.WriteLine("seçilen Öğrenci No : " + ogrenciler[5]);


ogrenciler[5] = 800;

Console.WriteLine("seçilen Öğrenci No : " + ogrenciler[5]);

string[] isimler = new string[5];

isimler[0] = "Ali";
isimler[1] = "Veli";
isimler[2] = "Ayşe";
isimler[3] = "Aylin";
isimler[4] = "Mehmet";

Console.WriteLine("Öğrenci Adı : " + isimler[1]);

Console.WriteLine("2. Yöntem");

int[] ogrenciler2 = { 100, 200, 300, 400, 500 };

Console.WriteLine("Seçilen Öğrenci No : " + ogrenciler2[1]);

ogrenciler2[1] = 250;

Console.WriteLine("Seçilen Öğrenci No : " + ogrenciler2[1]);

string[] kategoriler = { "Bilgisayar", "Monitör", "Klavye", "Mouse" };

Console.WriteLine("Seçilen Kategori : " + kategoriler[1]);
 
//Örnek1   

string[] isimler2 = new string[2];

isimler2[0] = "emin";
isimler2[1] = "enes";
isimler2[2] = "ali";


Console.WriteLine("Seçilen isim : "+isimler2[0]);