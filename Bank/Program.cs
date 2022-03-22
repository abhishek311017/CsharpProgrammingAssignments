using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{


    class ICICIBANK
    {

        public event EventHandler<bool> Transaction;

        private double balance;

        public ICICIBANK( double balance)
        {
            
            this.balance = balance;

        }



        public void Withdrawn(double amount)
        {

            double sum = 0;
            if (amount < balance)
            {
                sum = balance - amount;
                Console.WriteLine("remaining balance:" + sum);
            }
            else if (amount > balance && balance != 0)
            {
                Transaction?.Invoke(this, true);
                
            }
            else if (balance == 0)
            {
                Transaction?.Invoke(this, false);
            }

        }
       
    }
    class Program
    {


        static void Main()
        {

            ICICIBANK Ic = new ICICIBANK(0);
            Ic.Transaction += Ic_Trancsation;
            Ic.Withdrawn(300);
            Console.ReadLine();
        }

        private static void Ic_Trancsation(Object sender,bool b)
        {
            Console.WriteLine("Trancsaction cannot be continued as account balance is " +(b? "insufficiant":"Zero")+" in Account");
        }
    }
}
