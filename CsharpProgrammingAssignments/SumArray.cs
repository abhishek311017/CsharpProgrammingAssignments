using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProgrammingAssignments
{
   class SumArray
    {
        static void Main()
        {
            int[] array = new int[10];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("element - {0} : ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sumArray(array));
            Console.ReadLine();
        }
        static int sumArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
       
    }
}
