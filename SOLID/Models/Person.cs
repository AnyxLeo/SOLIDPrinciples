using System;

namespace SOLID.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }

        public Person(string name, string middleName, string lastName, string nickName)
        {
            Name = name;
            MiddleName = middleName;
            LastName = lastName;
            NickName = nickName;
        }

        public void Greets()
        => Console.WriteLine($"Hi! I am {Name} {MiddleName} {LastName} better known as {NickName}");
    }
}
