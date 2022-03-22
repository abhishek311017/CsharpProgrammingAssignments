using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitwareLib1;

namespace EmployeeManagement
{
    class Program
    {
      public  static void Main()
        {   

            ArrayList ar= new ArrayList();
            ar.Add(new Employee(1, "Abhishek", 20000));
            ar.Add(new Employee(2, "Rashmi", 100000));
            ar.Add(new Employee(3, "Suresh", 120000));

            foreach (Employee e in ar)
            {
                Console.WriteLine(e.EmpNo + "," + e.EmpName + "," +"grossSalary:" +e.display()+","+"Netsalary:"+e.calculateSalary());
            }

            //Employee emp= new Employee(1,"Abhishek",20000);
            //Console.WriteLine("gross Salary:");
            //Console.WriteLine(emp.display());
            //Console.WriteLine("Net Salary:");
            //Console.WriteLine(emp.calculateSalary());
            Console.ReadLine();
        }
    }
}
