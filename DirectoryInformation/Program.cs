using System;
using System.IO;

namespace DirectoryInformation
{
    class DirectoryStatistics
    {
        static void Main()
        {
            string directoryName;
            Console.WriteLine("Enter a directory name >> ");
            directoryName = Console.ReadLine();

            if (Directory.Exists(directoryName))
            {
                Console.WriteLine("Directory exists.");
                Console.WriteLine($"The list of the files in {directoryName}");
                Console.WriteLine();
                string[] files = Directory.GetDirectories(directoryName);
                //as I have directories instead of exact files

                foreach(string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine("Directory does not exists.");
            }
        }
    }
}


//Create a program named DirectoryInformation that allows a user to
//continually enter directory names until the user types end. If the
//directory name exists, display a list of the files in it; otherwise,
//display a message indicating the directory does not exist. Create as
//many test directories and files as necessary to test your program.