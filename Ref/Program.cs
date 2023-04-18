using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            var age = 5;
            Console.WriteLine(age);
            user.SetAge(ref age);
            Console.WriteLine(age);
            Console.ReadKey();
        }
    }
}
