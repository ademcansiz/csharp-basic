using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomManager customManager = new CustomManager();
            customManager.Add();
            Product product = new Product { Id = 1, Name="Laptop" };
            Product product2 = new Product(2,"Computer");
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();
            PersonManager personManager = new PersonManager("Product");
            personManager.Add();    
            Console.ReadLine();
        }

        class CustomManager {
            int _count=12;
            public CustomManager(int count)
            {
                _count = count;
            }
            public CustomManager()
            {
                
            }
            public void List() {
                Console.WriteLine("Listed!");
            }
            public void Add() { 
            Console.WriteLine("Added! {0}",_count);
            }
        }

        class Product
        {
            public Product()
            {
                
            }
            int _id;
            string _name;
            public Product(int id, string name)
            {
                _id = id;
                _name = name;
            }
            public int Id { get; set; }
            public string Name { get; set; }

        }


        interface ILogger 
        {
            void Log(); 
        }

        class DatabaseLogger : ILogger 
        {
            public void Log() 
            {
                Console.Write("Logged to database");
            }
        }
        class FileLogger : ILogger 
        {
            public void Log() 
            {
                Console.Write("Logged to file");
            }
        }

        class EmployeeManager 
        {   
            private ILogger _logger;
            public EmployeeManager(ILogger logger)
            {
                _logger = logger;
            }
            public void Add() 
            {
                _logger.Log();
                Console.WriteLine("Added!");
            }
        }

        class BaseClass 
        {
            private string _entity;
            public BaseClass(string entity)
            {
                _entity = entity;
            }
            public void Message()
            { 
                Console.WriteLine("{0} message" , _entity);
            }
        }

        class PersonManager : BaseClass 
        {
            public PersonManager(string entity):base(entity)
            {
                
            }
            public void Add() {
                Console.WriteLine("Added!");
                Message();
            }
        }
    }
}
