using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalForTest
{
   class Class123
    {
        static void Main()
        {
            AddTest add = new AddTest();
            add.Add();
            Console.WriteLine(add.Add());
            Console.ReadLine();
        }
    }
}
