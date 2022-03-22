using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationMine
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

            using (var stream = new FileStream(@"D:\d.text", FileMode.Create, FileAccess.Write))
            {
                var json = new DataContractJsonSerializer(typeof(Student));
                json.WriteObject(stream, student);
            }

            using (var stream = new FileStream(@"D:\d.text", FileMode.Open, FileAccess.Read))
            {
                var json = new DataContractJsonSerializer(typeof(Student));

                Student st = (Student)json.ReadObject(stream);
                st.display();
                Console.ReadKey();
            }
        }
    }
}
