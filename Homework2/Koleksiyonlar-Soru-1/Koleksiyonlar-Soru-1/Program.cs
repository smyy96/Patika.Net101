using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
              
              Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

                • Negatif ve numeric olmayan girişleri engelleyin.
                • Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
                • Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
             
             
             */

            int number = 0;
            ArrayList array = new ArrayList();

            Console.WriteLine("20 adet pozitif sayı giriniz.");
            int count = 0;
            while (count < 20)
            {
                Console.Write($"{count + 1}.sayıyı giriniz: ");
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number > 0)
                    {
                        count++;
                        array.Add(number);
                    }
                    else // negatif degerse uyarı veriyor
                    {
                        Console.WriteLine("Negatif değer girdiniz.");
                    }
                }
                catch (Exception) // sayı dışında başka karakter girerse uyarı veriyor
                {
                    Console.WriteLine("Sayısal deger giriniz.");
                }
            }



            ArrayList prime = new ArrayList(); //Asal
            ArrayList notPrime = new ArrayList(); // Asal olmayan


            bool status = false;
            foreach (int item in array)
            {
                status = false;
                for (int x = 2; x <= item / 2; x++)//Aldığımız sayı asal mı degil mi bulmak için bir döngü tanımlıyoruz ve o sayının yarısı kadar döngü dönüyor.
                {
                    if (item % x == 0)
                    {
                        status = true;
                        break;
                    }
                }

                if (status==true || item==1)
                    notPrime.Add(item);
                else
                    prime.Add(item);
            }

            int average = 0;
            prime.Sort();// sıralama
            Console.WriteLine("\n *** Asal Sayılar *** ");
            foreach (int item in prime)
            {
                average += item;
                Console.WriteLine(item);
            }
            Console.WriteLine($"Asal sayı dizisinin eleman sayısı: {prime.Count} - Ortalama: {average / prime.Count}\n");



            notPrime.Sort();// sıralama
            average = 0;
            Console.WriteLine("\n *** Asal Olmayan Sayılar *** ");
            foreach (int item in notPrime)
            {
                average += item;
                Console.WriteLine(item);
            }
            Console.WriteLine($"Asal olmayan sayı dizisinin eleman sayısı: {notPrime.Count} - Ortalama: {average / notPrime.Count}");
        }
    }
}
