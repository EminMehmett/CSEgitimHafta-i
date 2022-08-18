namespace Ders10OzgenlerProperties
{
    class Skorlar
    {
        private int skor;
        public int Skor // Klasik property yapııs 
        {
            get { return skor; } // get bloğu yukarıdaki skor değişkeninin değerini döndürür
            set { skor = value; } // set bloğu ise yukarıdaki skor değişkenine değer atamayı sağlar 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Özgenler-Properties!");

            Skorlar skorlar = new();
            skorlar.Skor = 5;// skorlar nesnesinin Skor özelliğine değer ata (set bloğu çalışır)

            Console.WriteLine("Skor Değeri : " + skorlar.Skor);// skorlar nesnesinin Skor özelliğinin değerini oku ve ekrana yaz (get bloğu çalışır)

            Kisi Taha = new Kisi();
            Taha.DogumYeri = "İstanbul";
            Taha.Maas = 4000;
            Taha.Yas = 15;

            Kisi Betul = new()
            {
                DogumYeri = "Ankara",
                Maas = 5000,
                Yas = 25

            };

            Console.WriteLine("Taha'nın Bilgileri");
            Console.WriteLine($"Doğum Yeri : {Taha.DogumYeri} - Yas : {Taha.Yas} - Maaş : {Taha.Maas}");

            Console.WriteLine("Betül'ün Bilgileri");
            Console.WriteLine($"Doğum Yeri : {Betul.DogumYeri} - Yas : {Betul.Yas} - Maaş : {Betul.Maas}");

            User user = new();
            user.Email = "info@admin.com";
            user.Password = "123456";
            user.Name = "Taha";
            user.CreateDate = DateTime.Now;

            Console.WriteLine("Email Giriniz: ");
            var email = Console.ReadLine();
            user.Email = email;
            Console.WriteLine("Şifre Giriniz: ");
            user.Password = Console.ReadLine();

            var giris = user.KullaniciGiris(user.Email, user.Password); // var variable yani değişken demek ve veri trünü kendisine atanan değere bakarak otomatik belirleyendeğişken oluşturmamızı sağlar. 

            if (giris == true)// eğer giriş metodunun sonucu true ise
            {
                Console.WriteLine("Giriş Başarılı!");
            }
            else Console.WriteLine("Giriş Başarısız!");








        }
    }
}