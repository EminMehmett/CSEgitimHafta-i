// See https://aka.ms/new-console-template for more information
/*
 C# nesne yönelimli bir programlama dili olduğu için her şey sınıflar içinde tanımlanır. Sınıflara ve sınıf öğelerine erişim kısıtlanabilir veya belirli düzeylerde erişime izin verebilir.
Öğelere erişimi kısıtlayan ya da yetkiveren anahtan sözcüklere "Erişim Belirteçleri" (acces modifiers) denir.

Erişim belirteçleri 4 ana sınıfa ayrılır; 

=> public    :Erişim kısıtı yoktur, her yerden erişilebilir. 
=> protected : Ait olduğu sınıftan ve o sınıftan türetilen sınıfardan erişilebilir. 
=> internal  : Etkin projeye ait sınıflardan erişilebilir, onların dışında erişilemez.
=> private   : Yalnız bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez.

Bir öğe yalnızca 1 erişim belirteci alabilir. 
namespace erişim belirleyici alamaz çünkü o daima public tir. 
Sınıflar public ya da internal nitelemesi alabilirler ama protected yada private nitelemesi alamazlar.
enum erişim belirteci almaz çünkü daima public tir.
*/


using Ders08Classlar;

public class deneme
{
    public string urunAdi = "Bu değişkene herkes erişebilir public olduğu için";

}

internal class Test
{
    string urunAdi = "Klavye";
}

namespace Ders09ErisimBelirleyiciler
{
    class Progrm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Erişim Belirleyiciler!");


            Kullanici kullanici = new();
            kullanici.Adi = "Taha";
            kullanici.SoyAdi = "Çağlar";
            //kullanici.

            Console.WriteLine($"Kullanıcı Bilgileri : ");
            Console.WriteLine($"Adı : {kullanici.Adi} - Soyadı : {kullanici.SoyAdi}");


            SiniftaMetotKullanimi siniftaMetotKullanimi = new();
            siniftaMetotKullanimi.DinamikToplamaYap();

        }
    }
}








