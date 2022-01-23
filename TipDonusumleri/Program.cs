using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 1;
            sbyte y = 2;
            short z = 3;

            int v = x+y+z;
            Console.WriteLine("v:"+v);

            long a = v;
            Console.WriteLine("a:"+ a);

            float b = a;
            Console.WriteLine("b:"+b);

            string c = "alperen";
            char d = 'f';
            object e = c+d+v;
            Console.WriteLine("e:"+e);

           Console.WriteLine("------------------------");
          

           int r = 3;
           byte t = (byte)r;
           Console.WriteLine("t:"+t);
           
           float j = 5.2f;
           byte l =(byte)j;
           Console.WriteLine("l:"+l);

           Console.WriteLine("------------------------");

           int abc = 9;
           string xyz = "5";
           int yy = abc + Convert.ToInt32(xyz);
            Console.WriteLine(yy);

            int def = 9;
           string ghj = def.ToString();
            Console.WriteLine("ghj:"+ghj);
            ParseMethod();
        }

        public static void ParseMethod()
        {

           string yazi1 = "6";
           string yazi2 = "9";
           int sayi1;
           double sayi2,toplam;

           sayi1 = Int32.Parse(yazi1);
           sayi2 = Double.Parse(yazi2);
           toplam = Convert.ToDouble(sayi1)+sayi2;
           Console.WriteLine(toplam);
        }
    }
}
