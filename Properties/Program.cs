using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Name = "Test";
            Console.WriteLine(user.Name);
            Console.ReadKey();
        }
    }
}
