using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{ Name = "Talha"},
                new Student{ Name = "Ezgi"},
                new Person{ Name = "Rasim"}
            };

            foreach (var person in persons)
            {
              Console.WriteLine(person.Name);
            }
            Console.ReadKey();
        }
    }
    class Person {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
    class Customer:Person 
    {
        public string City{ get; set; }
    }
    class Student : Person 
    {
        public string Department { get; set; }
    }
}
