using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public bool IsBorrowed { get; set; }


        public Book(int id,string title,string author,string category,bool isBorrowed)
        {
            Id = id;
            Title=title;
            Author=author;
            Category=category;
            IsBorrowed=isBorrowed;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Kitap;\n" +
                $"Id : {Id}\n" +
                $"Adı : {Title}\n" +
                $"Yazarı : {Author}\n" +
                $"Kategorisi : {Category}\n" +
                $"Ödünç Verilmiş Mi? : {IsBorrowed}");
        }
    }

}
