using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ----------------Part-3-------------------
             */
            //file i/o
            String path = @"C:\Users\SMART\Documents\Visual Studio 2019\Projects\file1.txt";


            if (File.Exists(path))       //check if file exists
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                File.Create(path);       //file creation
                Console.WriteLine("File created");
            }
            
            String[] lines;                         //read from file
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

            String lines1;
            lines1 = File.ReadAllText(path);
            Console.WriteLine(lines1);

            Console.WriteLine("Please enter new content for the file:"); //write to file
            string newContent = Console.ReadLine();
            File.WriteAllText(path, newContent);

            File.AppendAllText(path, newContent);    //append the file

            String copypath = @"C:\Users\SMART\Documents\Visual Studio 2019\Projects\file_copy.txt";    //copy the file
            File.Copy(path, copypath);

            String movepath = @"C:\Users\SMART\Documents\Visual Studio 2019\Projects\file_move.txt";
            File.Move(path, movepath);              //move the file

            File.Delete(copypath);                //delete the file
            File.Delete(movepath);
            
            Console.ReadKey();
        }
    }
}