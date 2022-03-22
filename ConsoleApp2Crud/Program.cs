using System;
using System.Data.SqlClient;

namespace CrudOperations
{
    class Program
    {
        static void Main()
        {
            SqlConnection sqlConnection;
            string Constr = @"Data Source=.;Initial Catalog=Ado;Integrated Security=True";
            try
            {
                sqlConnection = new SqlConnection(Constr);
                sqlConnection.Open();
                Console.WriteLine("Connection Made");
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }


        }
    }
}

