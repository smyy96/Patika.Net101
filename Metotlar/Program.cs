using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 2;
            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));
            
            int sonuc2 = ornek.ArttirVeTopla(a,b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));


        }
        static int Topla(int deger1,int deger2)
            {
                return deger1 + deger2;
            }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(int deger1 , int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}