using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    public class User
    {  
        public int Calc(params int[] numbers) 
        {
            int result=0;
            foreach (var item in numbers)
            {
                result += item;
            }
            return result;
        }
    }
}
