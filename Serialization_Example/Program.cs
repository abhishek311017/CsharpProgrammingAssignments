using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serialization_Example
{

    [Serializable]
    public class Student
    {
        private readonly int rollNo;
        private readonly string name;
        public Student()
        {
            rollNo = 5;
            name = "Abhishek";
        }
        public void Display()
        {
            Console.WriteLine(rollNo + " " + name);
        }
    }
    class Program
    {

        static void Main()
        {
            Student student = new Student();
            BinaryFormatter f=new BinaryFormatter();
            FileStream stream = new FileStream(@"D:\a.text", FileMode.Create, FileAccess.Write);
            f.Serialize(stream, student);
            stream.Close();
            stream = new FileStream(@"D:\a.text", FileMode.Open, FileAccess.Read);
            Student st = (Student)f.Deserialize(stream);
            stream.Close();
            st.Display();
            Console.ReadKey();

        }
    }
}
