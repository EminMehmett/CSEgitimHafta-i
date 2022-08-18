using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10OzgenlerProperties
{
    internal class User
    {
        public int İd { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }


        public bool KullaniciGiris(string mail, string sifre)
        {
            string veritabanindakiMail = "info@admin.com";
            string veritabanindakiSifre = "123456";
            bool islemSonucu = false;

            if (mail == veritabanindakiMail & sifre == veritabanindakiSifre)
            {
                islemSonucu = true; // eğer gönderilen değerler eşleşirse işlemSonucu değerini true yap 
            }
            return islemSonucu;
        }










    }
}
