using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProgrammingAssignments
{
     class Calculator
    {
        static void Main()
        {
            
                int a,b;
                string op;
                float answer=0;

                while (true)
                {
                    Console.Write("Enter the first Number: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the second Number: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter an operand (+, -, /, *): ");
                    op = Console.ReadLine();

                    switch (op)
                    {
                        case "-":
                            answer = a - b;
                            break;
                        case "+":
                            answer = a + b;
                            break;
                        case "/":
                            answer = a / b;
                            break;
                        case "*":
                            answer = a * b;
                            break;
                        default:
                        Console.WriteLine("invalid Operand");
                            break;
                    }

                    Console.WriteLine("Answer:{0}",answer);
                    Console.ReadLine();
                }
            
        }
    }
}

