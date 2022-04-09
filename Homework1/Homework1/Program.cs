using System;

namespace Homework1
{
    class Program
    {

        /* Ödev 1
         * Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
         */
        public static void PositiveNumber(int number)
        {
            int[] num = new int[number];
            Console.WriteLine($"{number} adet positif sayı giriniz.");
            for (int i = 0; i < number; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz: ");
                num[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Girdiginiz sayılar arasındaki çift sayılar.");
            foreach (var item in num)
            {
                if (item % 2 == 0)
                    Console.Write($"{item}, ");
            }
        }




        static void Main(string[] args)
        {
            Console.WriteLine("1. Ödev");
            Console.Write("Positif bir sayı giriniz: ");
            int postiveNum = int.Parse(Console.ReadLine());
            PositiveNumber(postiveNum);
        }
    }
}
