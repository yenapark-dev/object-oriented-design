using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace w3_serialization
{
    class Program
    {
        [Serializable]
        public class Person
        {
            public string Name { get; set; }
            public string Job { get; set; }
        }

        static void Main(string[] args)
        {
            string filename = "C:\\test\\test.txt";

            //Person person = new Person() { Name = "Steve", Job = "Programmer" };

            ////Save object to file
            //FileStream stream = new FileStream(filename, FileMode.Create);

            //BinaryFormatter formatter = new BinaryFormatter();
            //formatter.Serialize(stream, person);
            //stream.Close();

            ////Open file
            FileStream stream = new FileStream(filename, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            object obj = formatter.Deserialize(stream);
            if (obj is Person)
            {
                // we've found a person in the stream
                Person person = (Person)obj;
                Console.WriteLine("Person's name: {0}", person.Name);
            }
            else
            {
                Console.WriteLine("Invalid file");
            }

            stream.Close();
        }
    }
}