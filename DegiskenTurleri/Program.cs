using System;

namespace DegiskenTurleri
{
    class Program
    {
        static void Main(string[] args)
        {
             byte a = 1;
           sbyte b =2;

           short c = 3;
           ushort d = 4;

           Int16 e = 5;
           int f =6;
           Int32 g =7;
           Int64 h =8;

           uint i =9;
           long j =10;
           ulong k =11;

           float l =12;
           double m =13;
           decimal n =14;


          
           string p ="ab";
            
        
           bool r = true;
           bool s =false;

           DateTime dt = DateTime.Now;

           object t = "16";
           object u = "ab";
           object v = 17;
           object y = 18;
           object z = 18.1;


           string abc = string.Empty;
           abc = "deneme";
           string marka = "arçelik";
           string model = "Su ısıtıcısı";

           bool bl = 3>5;

           string vb = "20";
           int ty =20;
           string nr = vb + ty.ToString();
           int er = ty + Convert.ToInt32(vb);


            int yu = ty + int.Parse(vb);
        }
    }
}
