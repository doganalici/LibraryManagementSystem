using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }


        public Member(int id,string firstName,string lastName,string phoneNumber)
        {
            Id=id;
            FirstName=firstName;
            LastName=lastName;
            PhoneNumber=phoneNumber;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Kişi;\n" +
                $"Id : {Id}\n" +
                $"İsim Soyisim : {FirstName} {LastName}\n" +
                $"Telefon Numarası : {PhoneNumber}");
        }

    }
}


