using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3RealWorld
{
     public class Person
    {
        private string firstName;
        private string LastName;
        private int age;
        private string Location;
        private string occupation;
        private string hobbies;

        public Person (string firstName, string LastName, int age, string Location, string occupation, string hobbies)
        {
            this.firstName = firstName;
            this.LastName = LastName;
            this.age = age;
            this.Location = Location;
            this.occupation = occupation;
            this.hobbies = hobbies;
        }
        public void Introduce ()
        {
            Console.WriteLine($"Hello, my name is {firstName} {LastName}, I am {age} years old, and I am from {Location}. I work as a {occupation}. My hobbies include {hobbies}.");
        }
    }
 
}
