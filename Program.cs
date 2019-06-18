using System;
using System.Collections.Generic;
using System.Linq;

namespace csharpclass
{
    class Program
    {
        static List<Contact> contactList = new List<Contact>();


        static void Main(string[] args)
        {

            var queryClass = new QueryFile();
            queryClass.SearchMethod();
            return;

            contactList.Add(new Contact
            {
                Name = "Prahant",
                PhoneNumber = "1235342",
                Email = "me@gmail.com"
            });

            contactList.Add(new Contact
            {
                Name = "Olive",
                PhoneNumber = "98797342",
                Email = "olive@gmail.com"
            });
            contactList.Add(new Contact
            {
                Name = "Kintu",
                PhoneNumber = "123214",
                Email = "kintu@gmail.com"
            });

            contactList.Add(new Contact
            {
                Name = "peter",
                PhoneNumber = "21423465",
                Email = "peter@outlook.com"
            });
            contactList.Add(new Contact
            {
                Name = "peter",
                PhoneNumber = "21423465",
                Email = "different-peter@outlook.com"
            });

            ListContacts();

            Console.WriteLine("\n search results");

            var result =
                from c in contactList
                where c.Name.ToLower().StartsWith('k')
                select c;

            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }


            // if (result == null)
            //     System.Console.WriteLine("No records found");
            // else
            //     System.Console.WriteLine($"Search result {result}");

        }

        private static Contact SearchByName(string name)
        {
            foreach (Contact c in contactList)
            {
                if (c.Name == name)
                {
                    return c;
                }
            }

            return null;
        }

        // static void Main(string[] args)
        // {

        //     //(done) 1. We should be able to list contacts
        //     //(done) 2. Add new contact
        //     //3. Update
        //     //4. Delete
        //     //5. search

        //     Console.WriteLine("Address Book");
        //     Console.WriteLine("1. List contacts");
        //     Console.WriteLine("2. Add Contacts");

        //     Console.WriteLine("Enter choice: ");
        //     string userChoice = Console.ReadLine();

        //     //AddContact();
        //     int choice = int.Parse(userChoice);

        //     switch (choice)
        //     {
        //         case 1:
        //             ListContacts();
        //             break;
        //         case 2:
        //             AddContact();
        //             break;

        //         default:
        //             break;
        //             case 3:
        //             DeleteContact();
        //     }



        //     // for(int i=0; i<contactList.Count; i++){
        //     //     Contact item = contactList[i];
        //     // }
        // }

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
