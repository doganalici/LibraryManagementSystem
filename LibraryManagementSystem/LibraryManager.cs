using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class LibraryManager
    {
        List<Book> books = new List<Book>();
        List<Member> members = new List<Member>();
        List<BorrowRecord> borrowRecords = new List<BorrowRecord>();

        public void AddBook(Book book)
        {
            Console.Clear();
            Console.WriteLine("KİTAP EKLE");
            Console.WriteLine("----------------------");
            // 1 - Aynı ID var mı diye kontrol
            foreach (var b in books)
            {
                if (b.Id == book.Id)
                {
                    Console.WriteLine($"❌ {book.Id} numaralı kitap zaten kayıtlı!");
                    Console.WriteLine("Devam etmek için bir tuşa basınız...");
                    Console.ReadKey();
                    return;
                }
            }
            // 2 - Kitabı ekle
            books.Add(book);

            // 3 - Bilgi Mesajı
            Console.WriteLine("✔ Kitap başarıyla eklendi!");
            Console.WriteLine("Devam etmek için bir tuşa basınız...");
            Console.ReadKey();
            Console.Clear();
        }

        public void DeleteBook(int id)
        {
            Console.Clear();
            Console.WriteLine("KİTAP SİL");
            Console.WriteLine("----------------------");

            Console.WriteLine("Silinecek kitabın ıd numarasını yazınız");
            Console.Write("ID : ");
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("❌ Geçerli bir sayı giriniz!");
                return;
            }
            Book bookToDelete = null;

            // 1 - Kitabı bul
            foreach (var b in books)
            {
                if (b.Id == id)
                {
                    bookToDelete = b;
                    break;
                }
            }

            // 2 - Bulamadıysa mesaj ver
            if (bookToDelete == null)
            {
                Console.WriteLine("❌ Bu ID ile kayıtlı kitap bulunamadı!");
            }

            else
            {
                // 3 - Sil
                books.Remove(bookToDelete);
                Console.WriteLine("✔ Kitap başarıyla silindi!");
            }
            Console.WriteLine("Devam etmek için bir tuşa basınız...");
            Console.ReadKey();
            Console.Clear();
        }

        public void ShowBooks()
        {
            Console.Clear();
            Console.WriteLine("KAYITLI KİTAP LİSTESİ");
            Console.WriteLine("----------------------");

            // 1 - Liste boş mu?
            if (books.Count == 0)
            {
                Console.WriteLine("❌ Henüz sisteme eklenmiş kitap yok.");
            }
            else
            {
                Console.WriteLine($"Toplam Kitap: {books.Count}");
                Console.WriteLine("//////////////");
                // 2 - Tüm kitapları sırayla yazdır
                foreach (var book in books)
                {
                    book.DisplayInfo();
                    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*");
                }
            }
            Console.WriteLine("Devam etmek için bir tuşa basınız...");
            Console.ReadKey();
            Console.Clear();
        }

        public void AddMember(Member member)
        {
            Console.Clear();
            Console.WriteLine("ÜYE EKLE");
            Console.WriteLine("----------------------");
            // 1 - Aynı ID var mı diye kontrol
            foreach (var m in members)
            {
                if (m.Id == member.Id)
                {
                    Console.WriteLine($"❌ {m.Id} numaralı üye zaten kayıtlı!");
                    Console.WriteLine("Devam etmek için bir tuşa basınız...");
                    Console.ReadKey();
                    return;
                }
            }
            // 2 - Üyeyi ekle
            members.Add(member);

            // 3 - Bilgi Mesajı
            Console.WriteLine("✔ Üye başarıyla eklendi!");
            Console.WriteLine("Devam etmek için bir tuşa basınız...");
            Console.ReadKey();
            Console.Clear();

        }

        public void RemoveMember(int id)
        {
            Console.Clear();
            Console.WriteLine("ÜYE SİL");
            Console.WriteLine("----------------------");

            Console.WriteLine("Silinecek üyenin ID numarasını yazınız");
            Console.Write("ID : ");
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("❌ Geçerli bir sayı giriniz!");
                return;
            }

            Member memberToRemove = null;
            // 1 - Üyeyi bul
            foreach (var m in members)
            {
                if (m.Id == id)
                {
                    memberToRemove = m;
                    break;
                }
            }
            // 2 - Bulamadıysa mesaj ver
            if (memberToRemove == null)
            {
                Console.WriteLine("❌ Bu ID ile kayıtlı üye bulunamadı!");
            }
            else
            {
                // 3 - Sil
                members.Remove(memberToRemove);
                Console.WriteLine("✔ Üye başarıyla silindi!");
            }

            Console.WriteLine("Devam etmek için bir tuşa basınız...");
            Console.ReadKey();
            Console.Clear();
        }

        public void ShowMembers()
        {
            Console.Clear();
            Console.WriteLine("KAYITLI ÜYE LİSTESİ");
            Console.WriteLine("----------------------");

            // 1 - Liste boş mu?
            if (members.Count == 0)
            {
                Console.WriteLine("❌ Henüz sisteme eklenmiş üye yok.");
            }

            // 2 - Tüm üyeleri sırayla yazdır
            else
            {
                Console.WriteLine($"Toplam Üye: {members.Count}");
                Console.WriteLine("//////////////");
                foreach (var m in members)
                {
                    m.DisplayInfo();
                    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*");
                }
            }
            Console.WriteLine("Devam etmek için bir tuşa basınız...");
            Console.ReadKey();
            Console.Clear();
        }


        public void BorrowBooks()
        {

        }

        public void ReturnBook()
        {

        }

        public void BorrowingHistory()
        {

        }
    }
}
