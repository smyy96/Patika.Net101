using System;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                Console.WriteLine("Bir sayı giriniz");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz sayı : " + a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("İşlem Tamalandı");
            }
            Console.WriteLine("------------------");
            try
            {
                //int c = int.Parse(null);
                //int c = int.Parse("test");
                int c = int.Parse("-55000000000");
            }
            catch (ArgumentNullException ex)
            {
              Console.WriteLine("Boş değer girdiniz");
              Console.WriteLine(ex);    
            
            }
             catch (FormatException ex )
            {
              Console.WriteLine("Veri tipi uygun değil");
              Console.WriteLine(ex);    
            
            }
              catch (OverflowException ex )
            {
              Console.WriteLine("Çok küçük veya büyük değer girdiniz.");
              Console.WriteLine(ex);    
            
            }
        }
    }
}
