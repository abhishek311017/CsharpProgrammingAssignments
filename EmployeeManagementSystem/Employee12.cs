using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitwareLib1;

namespace EmployeeManagementSystem
{
    public delegate void EmployeeDelegates();
    
    [Serializable]
    public class Manager : Employee,IPrintable
        {

        private double petrolAllowance;
        private double foodAllowance;
        private double otherAllowances;
        private readonly string address;

        public Manager(int EEmpNo, string EEmpName, double ESalary,string address) : base( EEmpNo,EEmpName,ESalary)
        {
            this.address=address;
        }
//public Manager():base()
  //      {

    //    }

        public override double calculateSalary() {
                     petrolAllowance = 0.08 * Salary;
                     foodAllowance=0.13 * Salary;
                     otherAllowances = 0.03 * Salary;
                     double NetSal=base.calculateSalary() +petrolAllowance + foodAllowance + otherAllowances;
                    return NetSal;
                }
            public void Print()
            {
              Console.WriteLine("Emplyee Number:"+EmpNo+","+"Employee Name:"+EmpName+","+"Net Salary:"+calculateSalary());
              
            }
        public void Address()
        {
            Console.WriteLine("Address:" + address);
        }

    }

        public interface IPrintable
        {
            void Print();
        }
    [Serializable]
    public class Marketingexecutive : Employee, IPrintable
    {

        private readonly double kilometertravel;
        private double tourallowance;
        private readonly int telephoneallowance = 1000;
        private readonly string address;

        public Marketingexecutive(int EEmpNo, string EEmpName, string address,double Esalary,double kilometerTravelled) : base(EEmpNo, EEmpName, Esalary)
        {
            this.address= address;
            kilometertravel = kilometerTravelled;

        }
 
        public override double calculateSalary()
        {
            tourallowance = 5 * kilometertravel;
            
            double NetSal = base.calculateSalary() + tourallowance + telephoneallowance ;
            return NetSal;
        }

        public void Print()
        {
            Console.WriteLine("Employee Number:" + EmpNo + "," + "Employee Name:" + EmpName + "," + "Net Salary:" + calculateSalary());

        }
        public void Address()
        {
            Console.Write(",Address:" + address);
        }
    }


}
