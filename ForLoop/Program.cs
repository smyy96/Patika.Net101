using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lüften sayı giriniz ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);

                }


            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Yeni Örnek");

            int tek = 0;
            int çift = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tek += i;
                }

                else
                {
                    çift += i;
                }

            }
            Console.WriteLine("Tek sayılar toplamı :" + tek);
            Console.WriteLine("Çift sayılar toplamı :" + çift);

            Console.WriteLine("Yeni Örnek");

            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }
            Console.WriteLine("Yeni Örnek");
            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
