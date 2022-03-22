using System;


namespace Bank
{
    class HDFCBANK
    {

        public event EventHandler<bool> Transaction;

        private double balance;

        public HDFCBANK(double balance)
        {

            this.balance = balance;

        }

        public void Withdrawn(double amount)
        {

            double sum = 0;
            if (balance < 1000 && balance != 0)
            {
                Transaction?.Invoke(this, true);
            }
             else if (amount < balance&&balance>=1000)
            {

                sum = balance - amount;
                if (sum < 1000) 
                {
                    Transaction?.Invoke(this, true); 
                }
                else
                {
                    Console.WriteLine("remaining balance:" + sum);
                }
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
    class Program1
    {


        static void Main()
        {

            HDFCBANK Ic = new HDFCBANK(1000);
            Ic.Transaction += Ic_Trancsation;
            Ic.Withdrawn(300);
            Console.ReadLine();
        }

        private static void Ic_Trancsation(Object sender, bool b)
        {
            Console.WriteLine("Trancsaction cannot be continued as account balance " + (b ? "can never be below specified limit of 1000" : " is Zero") + " in Account");
        }
    }
}
