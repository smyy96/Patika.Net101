using System;

namespace TelefonRehberiUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
                 Telefon Numarası Kaydet
                Telefon Numarası Sil
                Telefon Numarası Güncelle
                Rehber Listeleme (A-Z, Z-A seçimli)
                Rehberde Arama

             * Başlangıç olarak 5 kişinin numarasını varsayılan olarak ekleyiniz.
             * 
             * 
             * 
             */

            ContactInfoList.contactInfos.Add(new ContactInfo("Sümeyye", "Coşkun", "123456"));
            ContactInfoList.contactInfos.Add(new ContactInfo("Büşra", "Işık", "654321"));
            ContactInfoList.contactInfos.Add(new ContactInfo("Kader", "Yılmaz", "524163"));
            ContactInfoList.contactInfos.Add(new ContactInfo("Ali", "Tuncer", "142536"));
            ContactInfoList.contactInfos.Add(new ContactInfo("Veli", "Bulut", "415263"));

            MenuUI.UI();
           
            
        }
    }
}
