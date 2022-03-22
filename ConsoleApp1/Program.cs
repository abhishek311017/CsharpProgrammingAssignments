using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {

        static void Main()
        {
            
            MyStack<int> S = new MyStack<int>(4);

            try
            {
                S.Push(25);
                S.Push(35);
                S.Push(45);
                S.Push(56);
                //S.push(56);

            }
            catch (StackException e) { 
                Console.WriteLine(e);
            }
            
            Console.WriteLine("Items are : ");
            S.Print();

            MyStack<int> S1 = (MyStack<int>)S.Clone();
            Console.WriteLine("Items  After clonning are: ");
            S1.Print();
            try
            {
                S.Pop();
                S.Pop();
                S.Pop();
                //S.pop();
                //S.pop();


            }
            catch (StackException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
