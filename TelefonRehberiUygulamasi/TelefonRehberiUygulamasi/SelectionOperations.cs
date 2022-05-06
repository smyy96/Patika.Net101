using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiUygulamasi
{
    public class SelectionOperations
    {
        public static void SaveContact() //Kişi kaydetme
        {
            Console.Write("Lütfen isim giriniz:");
            string name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz:");
            string surname = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz:");
            string numberPhone = Console.ReadLine();

            ContactInfoList.contactInfos.Add(new ContactInfo(name, surname, numberPhone));
            Console.WriteLine("Başarıyla kaydedildi.\n");

            MenuUI.UI(); //Menu sayfasının açılması
        }

        public static void RemoveContact() //Silme işlemi
        { 
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string data = Console.ReadLine();
            bool status = false;
            foreach (var item in ContactInfoList.contactInfos)
            {
                if (item.Name.ToLower() == data.ToLower() || item.Surname.ToLower() == data.ToLower())
                {
                    Console.Write($"{item.Name} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n) ");
                    char confirmation = char.Parse(Console.ReadLine().ToLower());
                    if (confirmation == 'y')
                    {
                        status = true;
                        ContactInfoList.contactInfos.Remove(item);
                        Console.WriteLine("Başarıyla silindi.\n");
                        break;
                    }
                    else
                    {
                        MenuUI.UI();
                    }
                }
            }

            NotFound(status,"Silmeyi"); // kişi bulunmazsa
            MenuUI.UI();

        }

        public static void UpdateContact()//Güncelleme işlemi
        {
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string data = Console.ReadLine();
            bool status = false;
            foreach (var item in ContactInfoList.contactInfos)
            {
                if (item.Name.ToLower() == data.ToLower() || item.Surname.ToLower() == data.ToLower())
                {
                    status = true;
                    Console.Write($"{item.PhoneNumber} numarasını, güncelemek istediginiz numarayı giriniz: ");
                    item.PhoneNumber = Console.ReadLine();
                    Console.WriteLine("Başarıyla güncellendi.\n");
                }
            }

            NotFound(status, "Güncellemeyi"); // kişi bulunmazsa
            MenuUI.UI();
        }

        public static void NotFound(bool status,string request, [CallerMemberName] string callermemberName = "")
        {
            if (status == false)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine($"* {request} sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int confirmation = int.Parse(Console.ReadLine());
                if (confirmation == 1)
                {
                    MenuUI.UI();
                }
                else
                {
                    if (callermemberName == "RemoveContact")
                    {
                        RemoveContact();
                    }
                    else if (callermemberName == "UpdateContact")
                    {
                        UpdateContact();
                    }
                }
            }

        }

        public static void ListAll() // Listeleme yapma
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (var item in ContactInfoList.contactInfos)
            {
                Console.WriteLine($"İsim: {item.Name}");
                Console.WriteLine($"Soyisim: {item.Surname}");
                Console.WriteLine($"Telefon Numarası: {item.PhoneNumber}\n-");
            }

            MenuUI.UI();
        }

        public static void SearchContact() // Kişi araması yapılacak metot
        {
            string search = "";
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************\n");
            Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");
            int selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                Console.Write(" İsim veya soyisim giriniz: ");
                search = Console.ReadLine();
                Console.WriteLine("Arama sonuçlarınız.");
                Console.WriteLine("**********************************************\n");
                foreach (var item in ContactInfoList.contactInfos)
                {
                    if (item.Name.ToLower() == search.ToLower() || item.Surname.ToLower() == search.ToLower())
                    {
                        Console.WriteLine($"İsim: {item.Name}");
                        Console.WriteLine($"Soyisim: {item.Surname}");
                        Console.WriteLine($"Telefon Numarası: {item.PhoneNumber}\n-");
                    }
                }
            }
            else if (selection == 2)
            {
                Console.Write(" Numara giriniz: ");
                search = Console.ReadLine();
                Console.WriteLine("Arama sonuçlarınız.");
                Console.WriteLine("**********************************************\n");
                foreach (var item in ContactInfoList.contactInfos)
                {
                    if (item.PhoneNumber == search)
                    {
                        Console.WriteLine($"İsim: {item.Name}");
                        Console.WriteLine($"Soyisim: {item.Surname}");
                        Console.WriteLine($"Telefon Numarası: {item.PhoneNumber}\n-");
                    }
                }
            }
            else
            {
                Console.WriteLine("Kişi Bulunamadı...\n");
            }

            MenuUI.UI();
        }
    }
}
