using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
             */

            int[] number = new int[20];

            Console.WriteLine("20 adet sayı giriniz.");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz: ");
                number[i] = int.Parse(Console.ReadLine());
            }


            int maxnum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                for (int x = i+1; x < number.Length; x++)
                {
                    if (number[x] < number[i]) // yer degiştirme
                    {
                        maxnum = number[x];
                        number[x] = number[i];
                        number[i] = maxnum;
                    }
                }
            }

            foreach (var item in number) // ekrana yazdırma
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"En küçük 3 değer: {number[0]}, {number[1]}, {number[2]} ve Ortalaması: {(number[0] + number[1] + number[2]) / 3}\n");
            Console.WriteLine($"En büyük 3 değer: {number[5]}, {number[6]}, {number[7]} ve Ortalaması: {(number[7] + number[6] + number[5]) / 3}");

            
        }
    }
}
