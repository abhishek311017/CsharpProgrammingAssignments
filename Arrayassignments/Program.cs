using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassignments
{
    class Program
    {
        static void Main()
        {
            int b;
            int[] a = new int[10] { 4, 5, 6, 8, 9, 9, 8, 5, 2, 3 };
            int[] c = new int[10];
            //  string[] b = new string[10];
            Console.WriteLine("Enter The operation In an Array:");
            b = Convert.ToInt32(Console.ReadLine());
            switch (b)
            {
                case 1:
                    Array.Copy(a, 0, c, 0, 10);
                    foreach (int i in c)
                        Console.WriteLine(c[i]);
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 2:
                    Array.Sort(a);
                    foreach (int i in a)
                        Console.WriteLine(a[i]);
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 3:
                    Array.Reverse(a);
                    foreach (int i in a)
                        Console.WriteLine(a[i]);
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 4:
                    Array.Clear(c, 0, 10);
                    foreach (int i in c)
                        Console.WriteLine(c[i]);
                    Console.WriteLine();
                    Console.ReadKey();
                    break;

                default: break;


            }
        }
    }
}
