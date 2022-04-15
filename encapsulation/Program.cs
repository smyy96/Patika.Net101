using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci=new Ogrenci();
            ogrenci.Isim="Sümeyye";
            ogrenci.Soyisim="Coşkun";
            ogrenci.OgrNo=16;
            ogrenci.Sinif=4;

            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.Sinifdusur();
            ogrenci.Sinifdusur();

            ogrenci.OgrenciBilgileriniGetir();


            Ogrenci ogrenci=new Ogrenci();
            ogrenci.Isim="Sümeyye";
            ogrenci.Soyisim="Coşkun";
            ogrenci.OgrNo=16;
            ogrenci.Sinif=2;
            ogrenci.Sinifdusur();
            ogrenci.Sinifdusur();

            ogrenci.OgrenciBilgileriniGetir();
            
            ogrenci.Sinifatlat();
            ogrenci.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci{


        private string isim;
        private string soyisim;
        private int ogrNo;
        private int sinif;

        
        public string Isim 
        { 
            get {return isim;} 
            set {isim=value;} 
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrNo { get => ogrNo; set => ogrNo = value; }
        
        public int Sinif { 
            get => sinif; 
            set 
            {
                if(value<=1){
                    Console.WriteLine("Sınıf 1 den küçük olamaz");
                    sinif=1;
                }
                else{
                    sinif = value;
                }
                
            }  
        }

        ///yapıcı metot
        public Ogrenci(string ısim, string soyisim, int ogrNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrNo = ogrNo;
            Sinif = sinif;
        }
        public Ogrenci(){}



        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("***********Ogrenci Bilgileri**********");
            Console.WriteLine("Öğrenci Adı:{0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı:{0}",this.Soyisim);
            Console.WriteLine("Öğrenci No:{0}",this.OgrNo);
            Console.WriteLine("Sınıfı:{0}",this.Sinif);
        }

        public void Sinifatlat()
        {
            this.Sinif=this.Sinif+1;
        }
        public void Sinifdusur()
        {

            this.Sinif=this.Sinif-1;
        }
    }
}
