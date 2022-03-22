using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
//using System.Text;
using System.IO;

using System.Runtime.Serialization.Formatters.Soap;

namespace JsonSerializationMine
{
    [Serializable]
    class MyStringData : ISerializable
    {
        public string dataItemOne, dataItemTwo;

        public MyStringData() { }

        private MyStringData(SerializationInfo si, StreamingContext ctx)
        {
            dataItemOne = si.GetString("First_Item").ToLower();
            dataItemTwo = si.GetString("dataItemTwo").ToLower();
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext ctx)
        {
            // Fill up the SerializationInfo object with the formatted data.
            info.AddValue("First_Item", dataItemOne.ToUpper());
            info.AddValue("dataItemTwo", dataItemTwo.ToUpper());
        }
    }

    [Serializable]
    class MoreData
    {
        public string dataItemOne, dataItemTwo;

        [OnSerializing]
        internal void OnSerializing(StreamingContext context)
        {
            dataItemOne = dataItemOne.ToUpper();
            dataItemTwo = dataItemTwo.ToUpper();
        }

        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            dataItemOne = dataItemOne.ToLower();
            dataItemTwo = dataItemTwo.ToLower();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStringData sd = new MyStringData();
            sd.dataItemOne = "some data.";
            sd.dataItemTwo = "some more data";

            using (Stream k = new FileStream(@"D:\e.text", FileMode.Create, FileAccess.Write))
            {
                SoapFormatter sf1 = new SoapFormatter();
                sf1.Serialize(k, sd);
                
            }
            using (Stream f = new FileStream(@"D:\e.text", FileMode.Open, FileAccess.Read))
            {
                SoapFormatter sf2 = new SoapFormatter();
                sd = (MyStringData)sf2.Deserialize(f);
                Console.WriteLine("Item 1: {0}", sd.dataItemOne);
                Console.WriteLine("Item 2: {0}", sd.dataItemTwo);
                Console.ReadLine();

            }

            //s = File.OpenRead(@"D:\e.text");
          //  sd = (MyStringData)sf.Deserialize(s);
          //  Console.WriteLine("Item 1: {0}", sd.dataItemOne);
            //Console.WriteLine("Item 2: {0}", sd.dataItemTwo);

            MoreData md = new MoreData();
            md.dataItemOne = "1, 2, 3.";
            md.dataItemTwo = "One more test...";


            using (Stream strea = new FileStream(@"D:\f.text", FileMode.Create, FileAccess.Write)) 
            {
                SoapFormatter sf3 = new SoapFormatter();
                sf3.Serialize(strea, md);

            }



            using (Stream f = new FileStream(@"D:\f.text", FileMode.Open, FileAccess.Read))
            {
                SoapFormatter sf4 = new SoapFormatter();
                md = (MoreData)sf4.Deserialize(f);
                Console.WriteLine("Item 1: {0}", md.dataItemOne);
                Console.WriteLine("Item 2: {0}", md.dataItemTwo);
                Console.ReadLine();
               }

            
           
        }
    }

}