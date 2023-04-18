using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            var toplam =  user.Calc(4,9,82,56);
            Console.WriteLine("Sayıların toplamı : " + toplam);
            Console.ReadKey();
        }
    }
}
