using System;
using System.IO;

namespace DelegatesandEventsAssignments
{
    public delegate void MyDel();
    class Account
    {    
        public event MyDel MyDel;
        public int Account_Num { get; set; }
        public string Customer_Name { get; set; }
        public double Balance { get; set; }

       public Account(int account_Num,string customer_name,double balance)
        {
            this.Account_Num = account_Num;
            this.Customer_Name = customer_name;
            this.Balance = balance;

        }
        
        public void Withdrawn(double amount)
        {

            double sum = 0;
            if (amount < Balance)
            {
                sum =  Balance-amount;
                Console.WriteLine("remaining balance:" + sum);
            }
            else if (amount > Balance&&Balance!=0)
            {

                MyDel += new MyDel(Underbalance);
                MyDel();
                sum = Balance;
                Console.WriteLine("Account balance:" + sum);
            }
            else if (Balance == 0)
            {

               MyDel += new MyDel(Zerobalance);
               MyDel();
            }
          
        }
        public void Underbalance()
        {
          Console.WriteLine("Underbalance");
        }
        public void Zerobalance()
        {
            Console.WriteLine("Zerobalance");
        }
        protected double Deposit(double amount)
        {
            
            return amount+Balance;
        }
    }
   class Program
    {
        static void Main()
        {
            Account a = new Account(12, "Abhishek", 1203);
              
            using (StreamWriter sw = new StreamWriter("Account.txt"))
            {
                string emp = "Id: " + a.Account_Num + Environment.NewLine + "Name: " + a.Customer_Name + Environment.NewLine + "Balance: " + a.Balance;
                sw.WriteLine(emp);
            }

            
               a.Withdrawn(600);
          

         
            using (StreamReader sr = new StreamReader("Account.txt"))
            {
              
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
