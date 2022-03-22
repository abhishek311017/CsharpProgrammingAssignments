using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    [Serializable] // allow to serialize
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }


    class DataSerialezer
    {
        public void BinarySerialize(object data, string filePath)
        {
            FileStream fileStream;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            if (File.Exists(filePath)) File.Delete(filePath);
            fileStream = File.Create(filePath);
            binaryFormatter.Serialize(fileStream, data);
            fileStream.Close();

        }

        public object BinaryDeSerializer(string filePath)
        {
            object obj = null;

            FileStream fileStream;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            if (File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                obj = binaryFormatter.Deserialize(fileStream);
                fileStream.Close();
            }

            return obj;
        }

    }
}