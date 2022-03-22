using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class Main1
    {
        static void Main()
        {
            Manager em = new Manager(123,"Rahul",20000,"22/5 dhafhs");
            EmployeeDelegates ed = new EmployeeDelegates(em.Print);


            BinaryFormatter f = new BinaryFormatter();
            FileStream stream = new FileStream(@"D:\Manager.text", FileMode.Create, FileAccess.Write);
            f.Serialize(stream, em);
            stream.Close();

            stream = new FileStream(@"D:\Manager.text", FileMode.Open, FileAccess.Read);
            Manager st = (Manager)f.Deserialize(stream);
            stream.Close();

            ed += st.Address;
            Console.WriteLine("Manager:");
            ed();
            
            Marketingexecutive me = new Marketingexecutive(124, "Rahul",  "22/5 dhafhs",20000,100);
            EmployeeDelegates ed1 = new EmployeeDelegates(me.Print);
            ed1+=me.Address;
            Console.WriteLine("MarketingExecutive:");
            ed1();
            Console.ReadLine();
        }

        
    }
}
