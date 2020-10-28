using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ModuleTwo_PartFour
    {
        public void codes()
        {
            /* ----------------Part-4------------------
            //all methods are declared in "methods" class

            //method declaration and usage
            int a = 100;
            int b = 200;
            methods o = new methods();

            int res = o.add(a , b);
            Console.WriteLine("Result: "+res);

            //passing parameters by value           
            Console.WriteLine("Before swapping,a : {0}", a);
            Console.WriteLine("Before swapping,b : {0}", b);

            o.swap(a, b);

            Console.WriteLine("After swapping,a : {0}", a);
            Console.WriteLine("After swapping,b : {0}", b);

            //passing parameters by reference          
            Console.WriteLine("Before swapping,a : {0}", a);
            Console.WriteLine("Before swapping,b : {0}", b);

            o.swap(ref a, ref b);

            Console.WriteLine("After swapping,a : {0}", a);
            Console.WriteLine("After swapping,b : {0}", b);

            //passing parameters by output
            o.add(a, b, out res);
            Console.WriteLine("Result: "+res);

            //passing parameters by optional parameters
            o.scholar("Heli","Parekh");
            o.scholar("Deepika","Padukone",39);
            o.scholar("Rohan","Parekh",30,"Information Technology");

            Console.ReadKey();
        
    class methods
    {
        public int add(int a,int b)
        {
            return a + b;
        }

        public void swap(int x, int y)
        {
            int temp;

            temp = x; 
            x = y;    
            y = temp; 
        }

        public void swap(ref int x, ref int y)
        {
            int temp;

            temp = x;
            x = y;
            y = temp;
        }

        public void add(int a, int b , out int res)
        {
            res = a + b;
        }

        public void scholar(string fname,string lname,int age = 21,string branch = "Computer Engineering")
        {
            Console.WriteLine("First name: {0}", fname);
            Console.WriteLine("Last name: {0}", lname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Branch: {0}", branch);
        }

    }
            */
        }
    }
}
