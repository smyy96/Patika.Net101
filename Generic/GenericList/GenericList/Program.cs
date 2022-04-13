using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class T bize generic olduğunu söylüyor. Bu object türündedir bir  
            // nesne alabilir Liste içindeki nesnelerin tipini belirtiyor
            // System.Collections.Generic ()

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count eleman sayısını verir
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            // foreach ve List.foreach ile elemanlara erişim
            foreach (var item in sayiListesi)
            {
                Console.Write(item + ",");
            }

            foreach (var renkler in renkListesi)
            {
                Console.Write(renkler + ",");
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Listeden eleman çıkartma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Listeden index numarasına göre çıkartma
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Liste içerisinde arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 sayi listesi içerisinde bulundu");

            // Eleman ile index e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            // Diziyi List'e çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };

            List<string> hayvanlarListesi = new List<string>(hayvanlar);
            hayvanlarListesi.ForEach(hayvans => Console.Write(hayvans));

            // Listeyi nasıl temizleriz
            hayvanlarListesi.Clear();
            hayvanlarListesi.ForEach(hayvans => Console.Write(hayvans));

            // Liste içerisinde Nesne tutmak
            // Kullanıcı class ına ait nesneleri tutmak için
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            // Kullanıcılar sınıfına ait nesne oluşturalım 2 tane
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yas = 26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Özcan";
            kullanıcı2.Soyisim = "Çalışkan";
            kullanıcı2.Yas = 28;

            // Yukarıdaki nesneleri şimdi Liste kullanıcıListesine a ekleyelim
            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });

            foreach (var item in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + item.Isim);
                Console.WriteLine("Kullanıcı Adı:" + item.Soyisim);
                Console.WriteLine("Kullanıcı Adı:" + item.Yas);
            }

            foreach (var item in yeniListe)
            {
                Console.WriteLine("Kullanıcı Adı:" + item.Isim);
                Console.WriteLine("Kullanıcı Adı:" + item.Soyisim);
                Console.WriteLine("Kullanıcı Adı:" + item.Yas);
            }

            
            yeniListe.Clear();


        }
    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }

    }
}



