using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProgrammingAssignments
{
    class AreaCircle
    {
          static void Main()
        {
            Console.Write("Enter Radius: ");
            double Radious = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of circle: " + Area(Radious));
            Console.ReadKey();
        }
        static double Area(double r)
        {
          return Math.PI * r * r;
        }
    }
}
