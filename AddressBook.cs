using System;

namespace csharpclass
{

    //Data Object
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Name} - {PhoneNumber} - {Email}";
        }
    }
}