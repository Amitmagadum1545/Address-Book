using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program\n");

            AddressBook addressBook = new AddressBook();

            addressBook.AddContact("Amit", "Magadum", "Rangoli", "Kolhapur", "Maharashtra", 416143, 9916564830, "amitmagadum1008@gmail.com");
            addressBook.ViewContact();
            Console.ReadLine();
        }
    }
}
