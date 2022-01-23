using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = 2;
           int b = 4;
           a = a+1;
           Console.WriteLine(a);
           a+=1;
           Console.WriteLine(a);
           a/=1;
           Console.WriteLine(a);
           b*=4;
           Console.WriteLine(b);

         

           bool isSuccess = true;
           bool isCompelted = false;

           if (isSuccess && isCompelted )
           Console.WriteLine("Wonderfull!");

           if (isSuccess || isCompelted )
           Console.WriteLine("Excellent!");

           if (isSuccess && !isCompelted )
           Console.WriteLine("Good!");


         

           int c =1;
           int d =6;
           bool sonuc = c<d;           
           Console.WriteLine(sonuc);
           sonuc = d<c;
           Console.WriteLine(sonuc);
           sonuc = d==c;
           Console.WriteLine(sonuc);
           sonuc = d>=c;
           Console.WriteLine(sonuc);
           sonuc = d<=c;

        

           int g =11;
           int h =34;
           int sonuc1 = g + h;
           Console.WriteLine(sonuc1);
           sonuc1 = g + h;
           Console.WriteLine(sonuc1);
           sonuc1 = g * h;
           Console.WriteLine(sonuc1);
           sonuc1 = g / h;
           Console.WriteLine(sonuc1);
           sonuc1 = h++;
           Console.WriteLine(sonuc1);

        

           int t = 20%3;
           Console.WriteLine(t);
        }
    }
}
