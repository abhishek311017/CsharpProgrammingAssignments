using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProgrammingAssignments
{
    class MaxMarks
    {

        static void Main()
        {
            int[] a= new int[10] ;
            int i;
            int m=0;

            for (i = 0; i < 5; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < 5; i++)
            {
                if (a[i] > m)
                {
                    m = a[i];
                }
            }
            Console.WriteLine("max:{0}",m);
            Console.ReadLine();
        } 
    }
}
