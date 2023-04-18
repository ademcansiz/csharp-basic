using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            int age;
            user.SetAge(out age);
            Console.WriteLine(age);
            Console.ReadKey();

        }
    }
}
