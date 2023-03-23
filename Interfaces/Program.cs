using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*InterfacesIntro();*/
            /* GetCustomerManager();*/

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
               new SqlServerCustomerDal(),
               new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadKey();
        }

        private static void GetCustomerManager()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer { Id = 1, Name = "Adem", Surname = "Cansız", Age = 21 };
            Student student = new Student { Id = 2, Name = "Hasan Atilla", Surname = "Uğur", Departman = "Military" };
            personManager.Add(customer);
            personManager.Add(student);
        }
        interface IPerson
        {
            int Id { get; set; }
            string Name { get; set; }
            string Surname { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Departman { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
