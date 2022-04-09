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





        /* 2.Ödev
           Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        */

        public static void PositiveDivisor(int n, int m)
        {
            int[] num = new int[n];
            Console.WriteLine($"{n} adet positif sayı giriniz.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz: ");
                num[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine($"Girdiginiz sayılar arasındaki {m}'e bölünen sayılar.");
            foreach (var item in num)
            {
                if (item % m == 0)
                    Console.Write($"{item}, ");
            }

        }



        /*3. Ödev
         Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        */

        public static void ReverseWord(int n)
        {
            string[] words = new string[n];
            Console.WriteLine($"{n} adet kelime giriniz.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}. kelimeyi giriniz: ");
                words[i] = Console.ReadLine();
            }

            Array.Reverse(words);//reverse metodu ile diziyi ters cevirme
           
            Console.WriteLine($"Girdiginiz kelimelerin sondan başa doğru sıralanması.");
            foreach (var item in words) // diziyi ekrana yazdırma
            {
                Console.Write($"{item}, ");
            }
        }




        /* 4.Ödev
            Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
         */
        public static void Sentence(string sente)
        {
            string[] word = sente.Split(" ");
            Console.WriteLine("Kelime sayısı: " + word.Length);
            Console.WriteLine("Kelime sayısı: " + (sente.Length-(word.Length-1)));// cümledeki harf sayısını bulmak için cümledeki toplam karakter sayısından boşlukları cıkartıyoruz.
        }


        static void Main(string[] args)
        {
            Console.WriteLine("1. Ödev");// Ödev 1
            Console.Write("Positif bir sayı giriniz: ");
            int postiveNum = int.Parse(Console.ReadLine());
            PositiveNumber(postiveNum);


            Console.WriteLine("2. Ödev"); //Ödev 2
            Console.Write("Positif bir sayı giriniz: ");
            int size = int.Parse(Console.ReadLine());
            Console.Write("Positif bir sayı giriniz: ");
            int dividing = int.Parse(Console.ReadLine());
            PositiveDivisor(size,dividing);


            Console.WriteLine("3. Ödev");// Ödev 3
            Console.Write("Positif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            ReverseWord(n);

            Console.WriteLine("4. Ödev");// Ödev 4
            Console.Write("Bir cümle yazınız: ");
            string sentence = Console.ReadLine();
            Sentence(sentence);
        }
    }
}
