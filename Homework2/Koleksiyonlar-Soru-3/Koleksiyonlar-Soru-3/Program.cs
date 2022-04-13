using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.*/

            ArrayList ArrayVowel = new ArrayList();

            string vowels= "aeıioöuü";

            Console.Write("Cümle giriniz:");
            string sentence = Console.ReadLine();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))// sesli harf var mı diye kontrol ediyor
                {
                    ArrayVowel.Add(sentence[i]); // diziye ekleme
                }
            }

            ArrayVowel.Sort(); // sıralama
            Console.WriteLine("---- Sıralaması ----");
            foreach (var item in ArrayVowel) // ekrana yazdırma
            {
                Console.WriteLine(item);
            }
        }
    }
}
