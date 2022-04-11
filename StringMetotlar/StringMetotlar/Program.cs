using System;

namespace StringMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz C# , Hoşgeldiniz.";
            string degisken2 = "Dersimiz C#.";

            //Lenght kaç harf olduğunu verir.
            Console.WriteLine(degisken.Length);


            
            
            Console.WriteLine(degisken.ToLower());// stringi büyük harflerle yazıyor
            Console.WriteLine(degisken.ToUpper());// stringi küçük harflerle yazıyor

            

            Console.WriteLine(String.Concat(degisken, "Merhaba!"));//Verilen değerin sonuna ekleme işlemi yapar.

           
            Console.WriteLine(degisken.CompareTo(degisken2));//
            Console.WriteLine(String.Compare(degisken, degisken2, false));//eşitse sıfır döndürür, eşit segilse boyutlarına göre 1 ya da -1 döndüür
            Console.WriteLine(String.Compare(degisken, degisken2, true));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz."));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf

            Console.WriteLine(degisken.IndexOf("C#"));
            Console.WriteLine(degisken.IndexOf("Berkcan"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba"));

            //PadLeft,PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5, 3));
            Console.WriteLine(degisken.Remove(0, 1));

            //Replace
            Console.WriteLine(degisken.Replace("C#", "C Sharp"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(" ")[1]);

            //SubString
            Console.WriteLine(degisken.Substring(4));
        }
    }
}
