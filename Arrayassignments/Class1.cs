using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassignments
{
    internal class Class1
    {
        static void Main()
        {
            int b;
            String[] a = new String[3] { "hsdu","jhbdjs","jhgadj" };
            String[] c = new String[10];
            //  string[] b = new string[10];
            Console.WriteLine("Enter The operation In an Array:");
            b = Convert.ToInt32(Console.ReadLine());
            switch (b)
            {
                case 1:
                    Array.Copy(a, 0, c, 0, 10);
                    for (int i = 0; i < c.Length; i++)
                    {
                        Console.WriteLine(c[i]);
                    }
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 2:
                    Array.Sort(a);
                    for (int i = 0; i < a.Length; i++)
                    {
                        Console.WriteLine(a[i]);
                    }

                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 3:
                    Array.Reverse(a);
                    Console.WriteLine("Array After reversing:");
                    for (int i = 0; i < a.Length; i++)
                    {
                        Console.WriteLine(a[i]);
                    }
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case 4:
                    Array.Clear(c, 0, 10);
                    for (int i = 0; i < c.Length; i++)
                    {
                        Console.WriteLine(c[i]);
                    }
                    Console.WriteLine();
                    Console.ReadKey();
                    break;

                default: break;


            }
        }
    }
}
