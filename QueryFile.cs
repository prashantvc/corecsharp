using System.Collections.Generic;
using System.Linq;

namespace csharpclass
{
    public class QueryFile
    {

        public void SearchMethod()
        {


            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 10 };

            var evenNumbers = from n in numbers
                              where n % 2 == 0
                              select n;
            // 2,4,6,8,10

            var divisibleBy3 = evenNumbers.Where(x => x % 3 == 0);
            // 6

            // Write a code that will return only even numbers
            // Code that will filter evens that are devisible by 3


            var myContact =
                new
                {
                    Email = "new@email.com",
                    PhoneNumber = "12341"
                };

            var result = contactList
                .Where(x => x.Name == "peter")
                .Where(x => x.Email.Contains("different"))
                .Select(x => new { x.Email });

            // var result =
            //     from c in contactList
            //     where c.Name.ToLower().StartsWith('k')
            //     select new { c.Email, c.PhoneNumber };

            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }
        }

        bool FilterContact(Contact c)
        {
            bool match = c.Name == "peter";
            return match;
        }



        List<Contact> contactList = new List<Contact>();
        public QueryFile()
        {
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
        }
    }
}