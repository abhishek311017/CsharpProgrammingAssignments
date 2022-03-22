using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LitwareLib1
{
    [Serializable]
    public class Employee
    {

        public int EmpNo;
        public string EmpName { get; set; }
        public double Salary;
        double HRA;
        double TA;
        double DA;
        double PF;
        double TDS;
        double NetSalary;
        double GrossSalary;
     //   public Employee() { }
        public Employee(int EEmpNo, string EEmpName, double ESalary)
        {
            EmpNo = EEmpNo;
            EmpName = EEmpName;
            Salary = ESalary;
        }

        public Employee(double ESalary)
        {
            Salary = ESalary;
        }

        public double grossSalary(double Sal)

        {
            if (Sal < 5000)
            {
                HRA = 0.1 * Sal;
                TA = 0.05 * Sal;
                DA = 0.15 * Sal;
                GrossSalary=Sal + HRA + TA + DA;
                return GrossSalary;
            }
            else if (Sal >= 5000 && Sal < 10000)
            {
                HRA = 0.15 * Sal;
                TA = 0.1 * Sal;
                DA = 0.2 * Sal;
                GrossSalary = Sal + HRA + TA + DA;
                return GrossSalary;

            }

            else if (Sal >= 10000 && Sal < 15000)
            {
                HRA = 0.2 * Sal;
                TA = 0.15 * Sal;
                DA = 0.25 * Sal;
                GrossSalary = Sal + HRA + TA + DA;
                return GrossSalary;

            }
            else if (Sal >= 15000 && Sal < 20000)
            {
                HRA = 0.25 * Sal;
                TA = 0.2 * Sal;
                DA = 0.3 * Sal;
                GrossSalary = Sal + HRA + TA + DA;
                return GrossSalary;

            }
            else
            {
                HRA = 0.3 * Sal;
                TA = 0.25 * Sal;
                DA = 0.35 * Sal;
                GrossSalary = Sal + HRA + TA + DA;
                return GrossSalary;

            }
        }

        public virtual double  calculateSalary()
        {
            PF = 0.1 * grossSalary(Salary);
            TDS = 0.18 * grossSalary(Salary);
            NetSalary = grossSalary(Salary) - (PF + TDS);
            return NetSalary;
        }
        public string display()
        {
            return $"{ grossSalary(this.Salary)}";
        }

        
        

}
}

