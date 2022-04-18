using System;

namespace StaticSinif
{
    class Program
    {

        /*
         *Bir sınıfın static olmayan üyelerine nesneler aracılığıyla erişirken static olan metotlara ve özelliklere ise nesne oluşturmadan o sınıfın ismi aracılığıyla erişiriz.
         *
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: " + Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Ali", "Veli", "İK");
            Console.WriteLine("Çalışan Sayısı: " + Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Ali", "Veli", "İK");
            Calisan calisan3 = new Calisan("Ali", "Veli", "İK");
            Console.WriteLine("Çalışan Sayısı: " + Calisan.CalisanSayisi);

            Console.WriteLine($"Toplama Sonucu: {Islemler.Topla(200, 50)}");
            Console.WriteLine($"Çıkarma Sonucu: {Islemler.Cikar(200, 50)}");
        }
    }


    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string isim;
        private string soyisim;
        private string departman;

        static Calisan() //bir kere çalıştırılır.
        {
            calisanSayisi = 0;
        }

        public Calisan(string Isim, string Soyisim, string Departman)
        {
            this.isim = Isim;
            this.soyisim = Soyisim;
            this.departman = Departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int x, int y)
        {
            return x + y;
        }
        public static long Cikar(int x, int y)
        {
            return x - y;
        }
    }
}
