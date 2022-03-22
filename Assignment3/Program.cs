using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    public class Employee {

        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public string Title;
        public DateTime DOB;
        public DateTime DOJ;
        public string City;
 

        public Employee(int employeeID, string firstName, string lastName, string title, DateTime dOB, DateTime dOJ, string city )
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            DOB = dOB;
            DOJ = dOJ;
            City = city;
           
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1001,"Malcolm","Daruwalla","Manager",new DateTime(1984,11,16),new DateTime(2011,06,08),"Mumbai"),
                new Employee(1002,"Asdin","Dhalia","AsstManager",new DateTime(1984,08,20),new DateTime(2012,07,07),"Mumbai"),
                new Employee(1003,"Madhavi","Oza","Consultant",new DateTime(1987,11,14),new DateTime(2015,04,12),"Pune"),
                new Employee(1004,"Saba","Shaikh","SE",new DateTime(1990,06,03),new DateTime(2016,02,02),"Pune"),
                new Employee(1005,"Nazia","Shaikh","SE",new DateTime(1991,03,08),new DateTime(2016,02,02),"Mumbai"),
                new Employee(1006,"Amit","Pathak","Consultant",new DateTime(1989,11,07),new DateTime(2014,08,08),"Chennai"),
                new Employee(1007,"VijaY","Natrajan","Consultant",new DateTime(1989,12,02),new DateTime(2015,06,01),"Mumbai"),
                new Employee(1008,"Rahul","Dubey","Associate",new DateTime(1993,11,11),new DateTime(2014,11,06),"Chennai"),
                new Employee(1009,"Suresh","Mistry","Associate",new DateTime(1992,08,12),new DateTime(2014,12,03),"Chennai"),
                new Employee(1010,"Sumit","Shah","Manager",new DateTime(1991,04,12),new DateTime(2016,01,02),"Pune")
            };


           var emp=from e in employees select e;
            Console.WriteLine("");
            foreach (Employee employee in emp)
            { 
                Console.WriteLine(employee.EmployeeID + "," + employee.FirstName + "," + employee.LastName +","+employee.Title+","+employee.DOB+","+employee.DOJ+","+employee.City);
            }
            Console.WriteLine();

            var emp1 = from e in employees where e.City !="Mumbai" select e;
            foreach (Employee employee in emp1)
            {
                Console.WriteLine(employee.EmployeeID + "," + employee.FirstName + "," + employee.LastName + "," + employee.Title + "," + employee.DOB + "," + employee.DOJ + "," + employee.City);
            }
            Console.WriteLine();

            var emp2 = from e in employees where e.Title == "AsstManager" select e;

            foreach (Employee employee in emp2)
            {
                Console.WriteLine(employee.EmployeeID + "," + employee.FirstName + "," + employee.LastName + "," + employee.Title + "," + employee.DOB + "," + employee.DOJ + "," + employee.City);
            }
            Console.WriteLine();
            var emp3 = from e in employees where e.LastName.StartsWith("S") select e;

            foreach (Employee employee in emp3)
            {
                Console.WriteLine(employee.EmployeeID + "," + employee.FirstName + "," + employee.LastName + "," + employee.Title + "," + employee.DOB + "," + employee.DOJ + "," + employee.City);
            }
            Console.WriteLine();
            var emp4 = from e in employees where e.DOJ<= new DateTime(2015, 01, 01) select e;

            foreach (Employee employee in emp4)
            {
                Console.WriteLine(employee.EmployeeID + "," + employee.FirstName + "," + employee.LastName + "," + employee.Title + "," + employee.DOB + "," + employee.DOJ + "," + employee.City);
            }
            Console.WriteLine();

            var emp5 = from e in employees where e.DOB >= new DateTime(1990, 01, 01) select e;

            foreach (Employee employee in emp5)
            {
                Console.WriteLine(employee.EmployeeID + "," + employee.FirstName + "," + employee.LastName + "," + employee.Title + "," + employee.DOB + "," + employee.DOJ + "," + employee.City);
            }
            Console.WriteLine();

            var emp6 = from e in employees where e.Title=="Consultant"|| e.Title == "Associate" select e;
           foreach (Employee employee in emp6)
            {
                Console.WriteLine(employee.EmployeeID + "," + employee.FirstName + "," + employee.LastName + "," + employee.Title + "," + employee.DOB + "," + employee.DOJ + "," + employee.City);
            }
            Console.WriteLine();

            var emp7 = employees.Count();
            Console.WriteLine(emp7);
            Console.WriteLine();

            var emp8 = employees.Where(x=>x.City=="Chennai").Count();
            Console.WriteLine(emp8);
            Console.WriteLine();

            var emp9 = employees.Max(x=>x.EmployeeID);
            Console.WriteLine(emp9);
            Console.WriteLine();

            var emp10 = employees.Where(x => x.DOJ>=new DateTime(2015,01,01)).Count();
            Console.WriteLine(emp10);
            Console.WriteLine();

            var emp11 = employees.Where(x=>x.Title!="Associate").Count();
            Console.WriteLine(emp11);
            Console.WriteLine();

            var emp12 = employees.GroupBy(x=>new { x.City, x.EmployeeID }).Count();
            Console.WriteLine(emp12);
            Console.WriteLine();

            var emp13 = employees.GroupBy(x => new { x.Title,x.City, x.FirstName }).Count();
            Console.WriteLine(emp13);
            Console.WriteLine();


            var X = employees.OrderBy(x => x.DOB).First();

            Console.WriteLine(X.FirstName);
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
