using System;
using System.Collections.Generic;
using System.Transactions;
using System.Xml.Serialization;

namespace AddressBook
{
    class Program
    {

        static void Main(string[] args)
        {
            int choice = 0;
            AddressBook ab = new AddressBook();
            do
            {
                Console.WriteLine("Enter your choice :");
                Console.WriteLine("1. Add Contact.");
                Console.WriteLine("2. View all Contacts.");
                Console.WriteLine("3.Exit.");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {

                    Console.WriteLine("Enter your Name : ");
                    String name = Console.ReadLine();
                    Console.WriteLine("Enter your address : ");
                    String address = Console.ReadLine();
                    Console.WriteLine("Enter your city : ");
                    String city = Console.ReadLine();
                    Console.WriteLine("Enter your state : ");
                    String state = Console.ReadLine();
                    Console.WriteLine("Enter your zip : ");
                    String zip = Console.ReadLine();
                    Console.WriteLine("Enter your contact no. : ");
                    String contactNo = Console.ReadLine();
                    Console.WriteLine("Enter your email : ");
                    String mailID = Console.ReadLine();

                    Constr c = new Constr(name, address, city, state, zip, contactNo, mailID);

                    ab.AddAddress(c);
                }
                else if (choice == 2)
                {
                    List<Constr> li = ab.ViewAddressBook();
                    foreach (Constr i in li)
                    {
                        Console.WriteLine("Name : " + i.GetName());
                        Console.WriteLine("Address : " + i.GetAddress());
                        Console.WriteLine("City : " + i.GetCity());
                        Console.WriteLine("State : " + i.GetState());
                        Console.WriteLine("zip : " + i.GetZip());
                        Console.WriteLine("Contact No. : " + i.GetPhoneNo());
                        Console.WriteLine("Email ID : " + i.GetEmail());
                    }
                }
                else
                {
                    break;
                }
            } while (choice != 3);
        }
    }
}