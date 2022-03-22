using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SoapSerializationMine
{
    [Serializable]
    public class Student
    {
        private int rollNo;
        private string name;
        public Student()
        {
            rollNo = 5;
            name = "Rahul";
        }
        public void display()
        {
            Console.WriteLine(rollNo + " " + name);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Student student = new Student();

            using (var stream = new FileStream(@"D:\c.text", FileMode.Create, FileAccess.Write))
            {
                var soap = new SoapFormatter();
                soap.Serialize(stream, student);
            }

            using (var stream = new FileStream(@"D:\c.text", FileMode.Open, FileAccess.Read))
            {
                var soap = new SoapFormatter();

                Student st = (Student)soap.Deserialize(stream);
                st.display();
                Console.ReadKey();
            }
        }
    }
}
