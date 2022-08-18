namespace Ders12StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Sınıfı!");
            string degisken;
            char karakter = 'k';
            string metinlerİçin = "string sınıfı yan yana dizilmiş karakter dizisinden oluşur";
            Console.WriteLine(metinlerİçin);

            //Ornek1();
            Ornek2();
        }
        static void Ornek1()
        {
            string birMetin = "Angara başkenttir";
            String birSayi = "123456789";
            System.String tarih = "30.06.2022";

            Console.WriteLine("Bir İsim Giriniz");
            string metin = Console.ReadLine();
            Console.WriteLine("for ile metin i ekrana yazdırma");
            for (int i = 0; i < metin.Length; i++)
            {
                Console.WriteLine("metin[" + i + "] = " + metin[i]);
            }
            Console.WriteLine("foreach ile metin i ekrana yazdırma");
            foreach (var karakter in metin)
            {
                Console.WriteLine(karakter);
            }
        }

        static void Ornek2()
        {
            string metin = "String Metotları ile metin düzenleme işlemleri";
            Console.WriteLine(metin);
            Console.WriteLine("Metin Uzunluğunu Bul : " + metin.Length);
            Console.WriteLine("Metin i ile mi bitiyor? " + metin.EndsWith("i"));
            Console.WriteLine("Mtin i ile mi başlıyor? " + metin.StartsWith("i"));
            Console.WriteLine("Metin içindeki ilk i karakteri " + metin.IndexOf("i"));
            Console.WriteLine("Metin içindeki son i karakteri nerede " + metin.LastIndexOf("i"));

            Console.WriteLine(metin .Insert (0,"Konumuz : "));
            Console.WriteLine(metin .Substring (6,10));
            Console.WriteLine(metin.ToLower ());
            Console.WriteLine(metin .ToUpper ());
            Console.WriteLine(metin.ToLower ().Replace ("ş","s").Replace (" ","-"));
            Console.WriteLine(metin .Remove (2,5)); // Metinin 2. karekterinden başla ve 5 karekter sil 
        }

    }
}