using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fname = Console.ReadLine();
            string lname = Console.ReadLine();

            Person person = new Person() { FirstName = fname, LastName = lname };
            string filePath = "data.save";
            DataSerialezer dataSerialezer = new DataSerialezer();
            Person p = null;

            dataSerialezer.BinarySerialize(person, filePath);

            p = dataSerialezer.BinaryDeSerializer(filePath) as Person;
            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.LastName);
            Console.ReadLine();

        }
    }
}
