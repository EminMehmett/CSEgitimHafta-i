namespace Ders15KapsüllemeEncapsulation
{
    //Metot kullanarak kapsülleme 

    public class Bolum
    {
        private string bolumAdi;
        //Accessor (Getter) - Veri Getirici
        public string GetBolumAdi() //Bu metot çağrıldığında 
        {
            return bolumAdi;// Yukarıdaki private bolumAdi değişkeni geriye döner 
        }
        //Mutator (Setter) - Ayarlayıcı
        public void SetBolumAdi(string parametre)
        {
            if (parametre == "İstemediğimizDeğer")
            {
                Console.WriteLine("Bu bizim pek" + parametre);
            }
            else bolumAdi = parametre;
        }
    }

    //Property kullanarak kapsülleme 
    public class Fakulte
    {
        private string bolum;
        public string Bolum
        {
            get { return bolum; }// get bloğu içindeki return(dön) komutundan anlaşılacağı üzere geriye içerdeki private tanımladığımız kapsüllenen bolum değişkenine atanan veriyi döndürür 
            set
            {
                if (value == "Yazılım Mühendisliği")
                {
                    Console.WriteLine("Üniversitemizde {0} bölümü bulunmamaktadır!", value);
                }
                else bolum = value;
            }//set bloğu ise dışarıya açık Bolum değişkenine atanan veriyi alıp içeride içeride kapsüllediğimiz private bolum değişkenine atar
        }
    }

    //Yalnız okunur (Read only property)
    public class Universite
    {
        private string bolum;
        public Universite(string str)// kurucu metotta parametre alarak işlem yapıyoruz
        {
            bolum = str;
        }
        public string Bolum()
        {
            return bolum; // set bloğu kullanmadığımız için bu sadece okunur yani readonly oluş olur 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kapsülleme - Encapsulation!");
            /*
            Bolum bolum = new();
            Console.WriteLine("Bölüm Adı Giriniz : ");
            var bolumAdi = Console.ReadLine();
            bolum.SetBolumAdi(bolumAdi);
            Console.WriteLine("Seçilen Bölüm : " + bolum.GetBolumAdi());
            */
            Fakulte fakulte = new();
            fakulte.Bolum = "Bilgisayar Mühendisliği";
            Console.WriteLine("Seçilen Bölüm : " + fakulte.Bolum);

            Universite universite = new("Yazılım Mühendisliği");// burada kurucu metoda bir deer yollamalıyız
            Console.WriteLine("Seçilen Bölüm : " + universite.Bolum());

        }
    }
}