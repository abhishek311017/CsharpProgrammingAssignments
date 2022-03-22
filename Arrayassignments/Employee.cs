using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayassignments
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public int EmpSal;
        public Employee(int eid, string ename, int esal)



        {
            this.EmpId = eid;
            this.EmpName = ename;
            this.EmpSal = esal;
        }



    }
   class Program1
    {
        static void Main()
        {
            //Create an List<Employee>
            List<Employee> list = new List<Employee>
            {
                new Employee(1, "Abhishek", 20000),
                new Employee(2, "Rashmi", 100000),
                new Employee(3, "Suresh", 120000),
                new Employee(4, "Abhishek", 12000),
                new Employee(5, "Vineshesh", 1200000),
                new Employee(6, "Naresh", 100000)
            };



            List<Employee> emp = list.FindAll(employee => employee.EmpName == "Abhishek");
            foreach (Employee e in emp)
            {
                Console.WriteLine(e.EmpId + ", " + e.EmpName + "," + e.EmpSal);
            }
            Console.ReadKey();



        }
    }
}
