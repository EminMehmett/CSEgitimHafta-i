namespace Ders14KalitiInheritance
{
    class Arac // Base Class (Ata Sınıf)
    {
        public string AracTuru;
        public void AracKornası()
        {
            Console.WriteLine("Doooooot!");
        }
    }
    class Otomobil : Arac  // Child Class
    {
        public string Marka { get; set; }
        public string Model { get; set; }
    }
    class MotoSiklet : Arac // Motosiklet araç sınıfının bir alt türüdür 
    {
        public string Marka { get; set; }
        public string Model { get; set; }
    }

    public class AtaSinif // Miras alınacak olan baba sınıf 
    {//ctor tab tab 
        public AtaSinif() // Kurucu metot, kurucu metotlar classlar ile aynı isimde olur ve class new lenerek bir yerde ullanılmak istenirse ilk çalışan metot kurucu metottur, sonra class içindeki diğer metotlar çalışır 
        {
            Console.WriteLine("Ata sınıf kurucu metot çalıştı");
        }
        public void Yaz()
        {
            Console.WriteLine("Ata sınıftaki yaz metodu çalıştı");
        }
    }
    public class OgulSinif : AtaSinif
    {
        public OgulSinif()
        {
            Console.WriteLine("Oğul sınıf kurucu metodu çalıştı");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalıtım(Miras Alma) - Inheritance!");
            Otomobil otomobil = new();
            otomobil.AracTuru = "Karayolu Taşıtı";
            otomobil.Marka = "Tofaşk";
            otomobil.Model = "Doğan SLX";
            otomobil.AracKornası();
            Console.WriteLine($"Araç Bilgileri :  Araç Türü : {otomobil.AracTuru} - Markası  : {otomobil.Marka} - Modeli : {otomobil.Model}");

            OgulSinif ogul = new();
            ogul.Yaz();

            Console.WriteLine();

            Console.WriteLine("Polimorpizm - Çok Biçimlilik");
            Cizici[] birCizici = new Cizici[4];
            birCizici[0] = new DogruCiz();
            birCizici[1] = new DaireCiz();
            birCizici[2] = new KareCiz();
            birCizici[3] = new Cizici();

            foreach (var item in birCizici) 
            {
                item.Ciz();
            }
        }


    }

    // Polimorfizm (çok biçimlilik) : Bir fonksiyonun normal davranışının ezilerek farklı bir çıktı vermesini sağladığımız yöntem 

    public class Cizici // virtual ibaresi ile Ciz metodumuzu ezilebilir hale getirdik 
    {
        public virtual void Ciz()
        {
            Console.WriteLine("Çizici");
        }
    }

    public class DogruCiz : Cizici
    {
        public override void Ciz() // override ibaresi ile ciz metodumuzu ezerek farklı çıktı üretmesini sağladık 
        {
            Console.WriteLine("Düz Çizgi");
        }
    }
    public class DaireCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("Daire Çizgi");
        }
    }
    public class KareCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("Kare Çizgi");
        }
    }

}