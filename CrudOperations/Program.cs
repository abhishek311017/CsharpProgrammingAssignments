using System;
using System.Data.SqlClient;
using System.Threading;
using System.Configuration;

namespace CrudOperations
{


    class Crud
    {
        SqlConnection sqlConnection;
       

        string Constr = "server=LAPTOP-EH5M0PR6\\SQLEXPRESS;Initial Catalog=Ado;Integrated Security=true";

        public void CreateOperation()
        {
            try
            {
             
                sqlConnection= new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

                sqlConnection.Open();
                Console.WriteLine("Enter Employee Id:");
                int EmpId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                string EmpName = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary:");
                double EmpSal = double.Parse(Console.ReadLine());
                string insertQuery = "Insert into Employees(EmpId,EmpName,Empsal) values (" + EmpId + ",'" + EmpName + "'," + EmpSal + ") ";
                SqlCommand incmd = new SqlCommand(insertQuery, sqlConnection);
                incmd.ExecuteNonQuery();

                Console.WriteLine("-------Inserted Successfullly------");
                Console.ReadLine();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }
        public void ReadOperation()
        {
            try
            {
                sqlConnection = new SqlConnection(Constr);
                sqlConnection.Open();
                string rdcmd = "Select * from Employees";
                SqlCommand incmd = new SqlCommand(rdcmd, sqlConnection);
                SqlDataReader dtrd = incmd.ExecuteReader();
                while (dtrd.Read())
                {
                    Console.WriteLine("Employee Id:" + dtrd.GetValue(0).ToString()+ "  ,  Employee Name:" + dtrd.GetValue(1).ToString()+ "  ,  Employee Salary:" + dtrd.GetValue(2).ToString());
                }
                Console.ReadLine();
                dtrd.Close();
                sqlConnection.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateOperation()
        {
            try
            {
                sqlConnection = new SqlConnection(Constr);
                sqlConnection.Open();

                string rdQuery = "Select * from Employees";
                SqlCommand rdcmd = new SqlCommand(rdQuery, sqlConnection);
                SqlDataReader dtrd = rdcmd.ExecuteReader();
                while (dtrd.Read())
                {
                    Console.WriteLine("Employee Id:" + dtrd.GetValue(0).ToString() + "  ,  Employee Name:" + dtrd.GetValue(1).ToString() + "  ,  Employee Salary:" + dtrd.GetValue(2).ToString());
                }
               
                dtrd.Close();
                Console.WriteLine("Enter Employee Id You need to update:");
               
                int EmpId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                string EmpName = Console.ReadLine();
                string UpdateQuery = "Update Employees set EmpName='"+ EmpName + "'where EmpId= " + EmpId +"";
                SqlCommand incmd = new SqlCommand(UpdateQuery, sqlConnection);
                incmd.ExecuteNonQuery();

                Console.WriteLine("-------Updated Successfullly------");
                Console.ReadLine();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }

        }

        public void DeleteOperation()
        {
            try
            {
                sqlConnection = new SqlConnection(Constr);
                sqlConnection.Open();
                Console.WriteLine("Enter Employee Id You need to Delete:");

                int EmpId = int.Parse(Console.ReadLine());

                string DeleteQuery = "Delete from Employees where EmpId= " + EmpId + "";
                SqlCommand incmd = new SqlCommand(DeleteQuery, sqlConnection);
                incmd.ExecuteNonQuery();

                Console.WriteLine("-------Deleted Successfullly------");
                Console.ReadLine();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }

        }
    }
    class Program
    {
        static void Main()
        {
            Crud cd = new Crud();
           
            do
            {
                Console.WriteLine("CRUD OPERATIONS(Employee Table)");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1.Create operation");
                Console.WriteLine("2.Read operation");
                Console.WriteLine("3.Update operation");
                Console.WriteLine("4.Delete operation");
                Console.WriteLine("5.Exit");
                Console.WriteLine("-------------------------");

                Console.WriteLine("Enter Any Operation(1/2/3/4/5):");

               int OpId = int.Parse(Console.ReadLine());

                switch (OpId)
                {
                    case 1:
                        cd.CreateOperation();
                        break;
                    case 2:
                        cd.ReadOperation();
                        break;
                    case 3:
                        cd.UpdateOperation();
                        break;
                    case 4:
                        cd.DeleteOperation();
                        break;
                    default:
                        Console.WriteLine("Thank You For Choosing Our Service");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;

                }
                Console.Clear();
            } while (true);
          


        }
    }
}
