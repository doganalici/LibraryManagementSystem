using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class BorrowRecord
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public Member Member { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool IsReturned { get; set; }

        public BorrowRecord(int id, Book book, Member member, DateTime borrowDate)
        {
            Id = id;
            Book = book;
            Member = member;
            BorrowDate = borrowDate;
            ReturnDate = null;
            IsReturned = false;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"İd : {Id}\n" +
                $"Kitap Adı : {Book.Title}\n" +
                $"Üye Adı : {Member.FirstName} + {Member.LastName}\n" +
                $"Kitap Alım Tarihi : {BorrowDate:dd.MM.yyyy}");
            if (IsReturned)
            {
                Console.WriteLine($"Durum : İade Edildi\n" +
                    $"İade Tarihi : {ReturnDate:dd.MM.yyyy}");
            }
            else
            {
                Console.WriteLine("Durum : Henüz İade Edilmedi");
            }
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
        }
    }
}
