using ClassLibrary1;
using System;
using CA2=ConsoleApp2;

//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ModuleOneCodes
    {
        public void codes() //method declaration
        {
            /* ----------------Part-1-------------------
            string name = "heli";       //variable declaration and usage

            Console.WriteLine("Hello "+name);//simple hello world program with some modification

            int x = (int)5.005;                          //datatype conversion-explicit
            Console.WriteLine("\nFloat to integer:"+x);

            object o1 = name;               //boxing 
            string name1 = (string)o1;      //unboxing

            if(name1==name)                 //if-else
            {
                Console.WriteLine("\nTrue[Boxing & Unboxing]");
            }
            else
            {
                Console.WriteLine("\nFalse[Boxing & Unboxing]");
            }

            Console.WriteLine("\n1.Addition\n2.Subtraction\n\nEnter choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)                  //switch 
            {
                case 1:
                    Console.WriteLine("\nEnter 2 numbers:");
                    int a= int.Parse(Console.ReadLine());
                    int b= int.Parse(Console.ReadLine());
                    Console.WriteLine("\nAddition: "+(a+b));
                    break;
                case 2:
                    Console.WriteLine("Enter 2 numbers:");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nSubtraction: "+(a - b));
                    break;
                default:
                    Console.WriteLine("Enter valid choice !");
                    break;
            }
            Console.Read();                 //make output window wait for us to press enter
            */

            /* ----------------Part-2-------------------
            int x = 5;
            int y = 10;

            Class1 o = new Class1();        //class 1 belongs to class library 1

            int res=o.add(x, y);

            Console.WriteLine(res);

            Console.Read();
            */

            /* ----------------Part-3-------------------
            CA2.Program.display();          //namespace in another solution/project-added reference,using alias=<namspace name>,use the namespace

            Console.Read();
            */

        }
    }
}

