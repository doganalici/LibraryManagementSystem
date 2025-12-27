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
                    Console.WriteLine($"X {book.Id} numaralı kitap zaten kayıtlı!");
                    Console.WriteLine("Devam etmek için bir tuşa basınız...");
                    Console.ReadKey();
                    return;
                }
            }
            // 2 - Kitabı ekle
            books.Add(book);

            // 3 - Bilgi Mesajı
            Console.WriteLine("> Kitap başarıyla eklendi!");
            Console.WriteLine("Devam etmek için bir tuşa basınız...");
            Console.ReadKey();
            Console.Clear();
        }

        public void DeleteBook()
        {
            Console.Clear();
            Console.WriteLine("KİTAP SİL");
            Console.WriteLine("----------------------");

            Console.WriteLine("Silinecek kitabın ıd numarasını yazınız");
            Console.Write("ID : ");
            int id;
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("X Geçerli bir sayı giriniz!");
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
                Console.WriteLine("X Bu ID ile kayıtlı kitap bulunamadı!");
            }

            else
            {
                // 3 - Sil
                books.Remove(bookToDelete);
                Console.WriteLine("> Kitap başarıyla silindi!");
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
                Console.WriteLine("X Henüz sisteme eklenmiş kitap yok.");
            }
            else
            {
                Console.WriteLine($"Toplam Kitap: {books.Count}");
                Console.WriteLine("////////////////");
                // 2 - Tüm kitapları sırayla yazdır
                foreach (var book in books)
                {
                    book.DisplayInfo();
                    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*");
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
                    Console.WriteLine($"X {m.Id} numaralı üye zaten kayıtlı!");
                    Console.WriteLine("Devam etmek için bir tuşa basınız...");
                    Console.ReadKey();
                    return;
                }
            }
            // 2 - Üyeyi ekle
            members.Add(member);

            // 3 - Bilgi Mesajı
            Console.WriteLine("> Üye başarıyla eklendi!");
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
                Console.WriteLine("X Geçerli bir sayı giriniz!");
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
                Console.WriteLine("X Bu ID ile kayıtlı üye bulunamadı!");
            }
            else
            {
                // 3 - Sil
                members.Remove(memberToRemove);
                Console.WriteLine("> Üye başarıyla silindi!");
            }

            Console.WriteLine("Devam etmek için bir tuşa basınız...");
            Console.ReadKey();
            Console.Clear();
        }

        public void ShowMembers()
        {
            Console.Clear();
            Console.WriteLine("KAYITLI ÜYE LİSTESİ");
            Console.WriteLine("-------------------");

            // 1 - Liste boş mu?
            if (members.Count == 0)
            {
                Console.WriteLine("X Henüz sisteme eklenmiş üye yok.");
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
            Console.Clear();
            Console.WriteLine("📚 KİTAP ÖDÜNÇ VERME");
            Console.WriteLine("--------------------");

            Console.Write("Kitap ID : ");
            int bookId = Convert.ToInt32(Console.ReadLine());

            var book = books.FirstOrDefault(b => b.Id == bookId);
            if (book == null)
            {
                Console.WriteLine("X Böyle bir kitap bulunamadı.");
                Console.ReadKey();
                return;
            }
            if (book.IsBorrowed)
            {
                Console.WriteLine("! Bu kitap zaten ödünçte.");
                Console.ReadKey();
                return;
            }

            Console.Write("Üye ID : ");
            int memberId = Convert.ToInt32(Console.ReadLine());

            var member = members.FirstOrDefault(m => m.Id == memberId);
            if (member == null)
            {
                Console.WriteLine("X Böyle bir üye bulunamadı.");
                Console.ReadKey();
                return;
            }
            BorrowRecord record = new BorrowRecord(
               borrowRecords.Count + 1,
               book,
               member,
               DateTime.Now
            );

            borrowRecords.Add(record);
            book.IsBorrowed = true;

            Console.WriteLine("> Kitap başarıyla ödünç verildi!");
            Console.ReadKey();

        }

        public void ReturnBook()
        {
            Console.Clear();
            Console.WriteLine("📚 KİTAP İADE ETME");
            Console.WriteLine("------------------");


            Console.Write("Kitap ID : ");
            int bookId = Convert.ToInt32(Console.ReadLine());

            var book = books.FirstOrDefault(b => b.Id == bookId);
            if (book == null)
            {
                Console.WriteLine("❌ Böyle bir kitap bulunamadı.");
                Console.ReadKey();
                return;
            }
            if (!book.IsBorrowed)
            {
                Console.WriteLine("⚠️ Bu kitap zaten iade edilmiş veya hiç ödünç verilmemiş.");
                Console.ReadKey();
                return;
            }

            BorrowRecord activeRecord = null;

            foreach (var r in borrowRecords)
            {
                if (r.Book.Id == bookId && r.IsReturned == false)
                {
                    activeRecord = r;
                    break;
                }
            }

            if (activeRecord == null)
            {
                Console.WriteLine("❌ Bu kitap için aktif bir ödünç kaydı bulunamadı.");
                Console.ReadKey();
                return;
            }

            activeRecord.IsReturned = true;
            activeRecord.ReturnDate = DateTime.Now;
            book.IsBorrowed = false;

            Console.WriteLine("✅ Kitap başarıyla iade alındı!");
            Console.ReadKey();
        }



        public void BorrowingHistory()
        {
            Console.Clear();
            Console.WriteLine("📚 ÖDÜNÇ ALMA GEÇMİŞİ");
            Console.WriteLine("----------------------");

            if (borrowRecords.Count == 0)
            {
                Console.WriteLine("❌ Henüz ödünç işlemi yapılmamış.");
            }

            else
            {
                foreach (var record in borrowRecords)
                {
                    record.DisplayInfo();
                }
            }

            Console.WriteLine("Devam etmek için bir tuşa basınız...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
