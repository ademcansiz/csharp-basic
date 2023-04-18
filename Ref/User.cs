using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref
{
    public class User
    {
        public void SetAge(ref int age)
        {
            age += 10;
        }
    }
}
