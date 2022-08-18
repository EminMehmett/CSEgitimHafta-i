using System.Collections;
using System.Collections.Specialized;

namespace Ders18CollectionsKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections - Koleksiyonlar!");

            //ArrayListKoleksiyon();
            //StringKoleksiyonu();
            //StringDictionaryKoleksiyonu();
            // DictionaryKoleksiyonu();
            StringListKoleksiyonu();
        }
        static void ArrayListKoleksiyon()
        {
            // Koleksiyonlara farklı veri tipinden değerler atama 
            int tamSayi = 10;
            double dabil = 18.8;
            ArrayList koleksiyon = new(); // Array = Dizi , ArrayList = Dizi Listesi
            koleksiyon.Add("Başkent Angara");
            koleksiyon.Add(tamSayi);
            koleksiyon.Add(dabil);
            for (int index = 0; index < koleksiyon.Count; index++)
            {
                Console.WriteLine(koleksiyon[index]);
            }
            foreach (var item in koleksiyon)
            {
                Console.WriteLine("Koleksiyondaki Değer : " + item);
            }
        }
        static void StringKoleksiyonu()
        {
            StringCollection strlist = new();// string içeriklerden oluşacakkoleksyonlara özel StringCollection sınıfı kullanabiliriz
            strlist.Add("Çankırı");
            strlist.Add("Angara");
            strlist.Add("İstanbul");
            foreach (var item in strlist)
            {
                Console.WriteLine(item);
            }
        }
        static void StringDictionaryKoleksiyonu()
        {
            StringDictionary strlist = new StringDictionary(); // string içeriklerden oluşacak koleksiyonlara özel StringDictionary sınıfını kullanabiliriz böylece verilere key ve vaue değeri atanabilir
            strlist.Add("18", "Çankırı");
            strlist.Add("06", "Angara");
            strlist.Add("34", "İstanbul");
            strlist.Add("58", "Sivas");

            Console.WriteLine(strlist["06"]);


            foreach (var item in strlist.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in strlist.Values)
            {
                Console.WriteLine(item);
            }

        }
        static void DictionaryKoleksiyonu()
        {
            Dictionary<string, string> dictionary = new();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "masa");
            dictionary.Add("computer", "bilgisayar");
            Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, string> liste = new();
            liste.Add(18, "Çankırı");
            liste.Add(58, "Sivas");
            liste.Add(34, "İstanbul");

            foreach (var item in liste)
            {
                Console.WriteLine(item.Value);
            }
        }
        static void StringListKoleksiyonu()
        {
            List<string> sehirler = new(); // veri tipi string olan sehirler isminde liste oluşturduk 
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("Çankırı");

            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }

            List<User> users = new();

            users.Add(new User
            {
                Id = 1,
                Ad = "Taha",
                Soyad = "Yılmaz"
            });


            users.Add(new User
            {
                Id = 2,
                Ad = "Murat",
                Soyad = "Yılmaz"
            });

            foreach (var item in users)
            {
                Console.WriteLine(item.Ad + " " + item.Soyad);
            }

            List<User> kullanicilar = new();
            {
                new User { Id = 1, Ad = "Yunus", Soyad = "kiraz" };
                new User { Id = 2, Ad = "Yunus", Soyad = "kiraz" };

            }

        }

    }
}