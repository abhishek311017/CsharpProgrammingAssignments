using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializationMine
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
          
            using (var stream = new FileStream(@"D:\b.text", FileMode.Create, FileAccess.Write))
            {
                var xml = new XmlSerializer(typeof(Student));
                xml.Serialize(stream, student);
            }

            using (var stream = new FileStream(@"D:\b.text", FileMode.Open, FileAccess.Read))
            {
                var xml = new XmlSerializer(typeof(Student));
                
                Student st = (Student)xml.Deserialize(stream);
                st.display();
                Console.ReadKey();
            }

           


        }
    }
}
