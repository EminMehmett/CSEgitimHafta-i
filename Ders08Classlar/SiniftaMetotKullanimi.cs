using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders08Classlar
{
    public class SiniftaMetotKullanimi
    {
        public string mesaj = "";
        public SiniftaMetotKullanimi()  // klavyeden ctor yazıp 2 kere tab a basarak oluşturduk 
        {
            // Burası constructor (yapıcı-kurucu) metot: kurucu metotlar classlar new lendiği anda çalışan metotlardır. Böylece bir classdan nesne oluştuğu anda bir işlem yapmamızı sağlar.
            mesaj = "Kurucu metot çalıştı";
        }
        public void DinamikToplamaYap() // classlar içerisinde metotlar tanımlayabiliriz böylece tekrar eden kodları toparlayıp kod tekrarını engelleyeiliriz
        {
            Console.WriteLine(10 + 8);
        }
        public static void StatikToplamaYap(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2); // Parametreden gönderilecek sayıları topla ve sonucu ekrana yazdır 
        }
        public static string StatikDeğişken = "Statik değişkenlere sınıfadı. diyerek ulaşabiliriz";



    }
}
