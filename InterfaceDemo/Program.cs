using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2] 
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats) 
            {
                eat.Eat();
            }
            IGetSalary[] getSalaries = new IGetSalary[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var getSalary in getSalaries) 
            {
                getSalary.GetSalary();
            }

            Console.ReadKey();

        }
        interface IWorker
        {
            void Work();
        }
        interface IEat
        {
            void Eat();
        }
        interface IGetSalary
        {
            void GetSalary();
        }

        class Worker : IWorker, IEat, IGetSalary
        {
            public void Work()
            {
                Console.WriteLine("İşciler Çalışıyor");
            }
            public void Eat()
            {
                Console.WriteLine("İşciler Yemek Yiyor");
            }

            public void GetSalary()
            {
                Console.WriteLine("İşciler Maaş Alıyor");
            }

        }

        class Manager : IWorker, IEat, IGetSalary
        {
            public void Work()
            {
                Console.WriteLine("Müdür Çalışıyor");
            }
            public void Eat()
            {
                Console.WriteLine("Müdür Yemek Yiyor");
            }

            public void GetSalary()
            {
                Console.WriteLine("Müdür Maaş Alıyor");
            }

        }
        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Garibim Robot Sadece Çalışıyor");
            }
        }
    }
}
