using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out
{
    public class User
    {
        public void SetAge(out int age)
        {
            age = 10;
        }
    }
}
