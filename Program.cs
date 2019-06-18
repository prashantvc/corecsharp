using System;
using System.Collections.Generic;

namespace csharpclass
{
    class Program
    {
        static List<Contact> contactList = new List<Contact>();
        static void Main(string[] args)
        {

            //(done) 1. We should be able to list contacts
            //2. Add new contact
            //3. Update
            //4. Delete
            //5. search

            Console.WriteLine("Address Book");
            Console.WriteLine("1. List contacts");
            Console.WriteLine("2. Add Contacts");

            Console.WriteLine("Enter choice: ");
            string userChoice = Console.ReadLine();

            //AddContact();
            int choice = int.Parse(userChoice);

            switch (choice)
            {
                case 1:
                    ListContacts();
                    break;
                case 2:
                    AddContact();
                    break;

                default:
                    break;
            }



            // for(int i=0; i<contactList.Count; i++){
            //     Contact item = contactList[i];
            // }
        }

        private static void AddContact()
        {
            //name, phone number, email
            System.Console.WriteLine("Enter contact: \n");
            string contact = Console.ReadLine();

            //"name,,email"
            string[] contactDetails = contact.Split(',');

            //assume user always entered right format
            Contact newContact = new Contact();
            newContact.Name = contactDetails[0];
            newContact.PhoneNumber = contactDetails[1];
            newContact.Email = contactDetails[2];

            contactList.Add(newContact);

            ListContacts();
        }

        private static void ListContacts()
        {
            System.Console.WriteLine("List of contacts");
            System.Console.WriteLine("Name\tPhone Nummber");
            foreach (Contact item in contactList)
            {
                System.Console.WriteLine(item);
            }
        }
    }

}
