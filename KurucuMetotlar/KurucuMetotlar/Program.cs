using System;

namespace KurucuMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Sümeyye","Coşkun",1,"Yazılım");
            calisan1.CalisanBilgileri();

            Console.WriteLine("-*-*-*-*-*-*-");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Azer";
            calisan2.Soyad = "Bülbül";
            calisan2.No = 2;
            calisan2.Departman = "Kültür Sanat";
            calisan2.CalisanBilgileri();

            Console.WriteLine("-*-*-*-*-*-*-");
            Calisan calisan3 = new Calisan("Sümeyye", "Coşkun");
            calisan3.CalisanBilgileri();

        }

        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;



            public Calisan() { }


            public Calisan(string ad,string soyad, int no, string departman)
            {
                this.Ad = ad;
                this.Soyad = soyad;
                this.No = no;
                this.Departman = departman;
            }

            public Calisan(string ad, string soyad)
            {
                this.Ad = ad;
                this.Soyad = soyad;
            }

            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışan Adı: {0}", Ad);
                Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
                Console.WriteLine("Çalışan Numarası: {0}", No);
                Console.WriteLine("Çalışan Departmanı: {0}", Departman);
            }
        }
    }
}
