using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool state = true;
            Console.WriteLine("\t KİTAP YÖNETİM SİSTEMİ");
            Console.Write("\t-----------------------\n");
            LibraryManager libraryManager = new LibraryManager();
            while (state)
            {
                Console.WriteLine("Lütfen menüden 0-9 arasında tuşlama yapınız\n");
                Console.WriteLine("1 - Kitap Ekle\n" +
                    "2 - Kitap Sil\n" +
                    "3 - Kitapları Listele\n" +
                    "4 - Üye Ekle\n" +
                    "5 - Üye Sil\n" +
                    "6 - Üyeleri Listele\n" +
                    "7 - Kitap Ödünç Ver\n" +
                    "8 - Kitap İade Et\n" +
                    "9 - Ödünç Geçmişi\n" +
                    "0 - Çıkış\n" +
                    "*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
                Console.Write("Seçiminiz : ");
                int option;
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.Write("Hatalı giriş! Lütfen sayı giriniz: ");
                }
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("KİTAP EKLE");
                        Console.WriteLine("----------");
                        Console.Write("Id : ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Adı : ");
                        string title = Console.ReadLine();

                        Console.Write("Yazarı : ");
                        string author = Console.ReadLine();

                        Console.Write("Kategorisi : ");
                        string category = Console.ReadLine();

                        Book newBook = new Book(id, title, author, category, false);
                        libraryManager.AddBook(newBook);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("KİTAP SİL");
                        Console.WriteLine("---------");
                        libraryManager.DeleteBook();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("KİTAP LİSTELE");
                        Console.WriteLine("-------------");
                        libraryManager.ShowBooks();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("ÜYE EKLE");
                        Console.WriteLine("---------");

                        Console.Write("Id : ");
                        int mid = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Ad : ");
                        string fn = Console.ReadLine();

                        Console.Write("Soyad : ");
                        string ln = Console.ReadLine();

                        Console.Write("Telefon : ");
                        string phone = Console.ReadLine();

                        Member newMember = new Member(mid, fn, ln, phone);
                        libraryManager.AddMember(newMember);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("ÜYE SİL");
                        Console.WriteLine("-------");
                        libraryManager.RemoveMember(0);
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("ÜYE LİSTELE");
                        Console.WriteLine("-----------");
                        libraryManager.ShowMembers();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("KİTAP ÖDÜNÇ VERME");
                        Console.WriteLine("-----------------");
                        libraryManager.BorrowBooks();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("KİTAP İADE ETME");
                        Console.WriteLine("-----------------");
                        libraryManager.ReturnBook();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("KİTAP İADE GEÇMİŞİ");
                        Console.WriteLine("------------------");
                        libraryManager.BorrowingHistory();
                        break;
                    case 0:
                        Console.Write("Çıkış yapılıyor. Lütfen bir tuşa basınız");
                        state = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Menü dışındaki bir rakam tuşlaması yaptınız. Lütfen tekrar deneyin!!!\n");
                        break;
                }
            }
        }
    }
}
