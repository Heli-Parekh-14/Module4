using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ModuleTwo_PartFive
    {
        public void codes()
        {
            /* ----------------Part-5------------------            
            //calling different constructors
            char[] a = { 'H', 'e', 'l', 'i', ' ', 'P', 'a', 'r', 'e', 'k', 'h' };
            string org = "Hello";
            string s1 = org;//copy constructor
            Console.WriteLine(s1);
            string s2 = new string(a);//joining character array
            Console.WriteLine(s2);
            string s3 = new string(a, 2, 5);//creating a substring
            Console.WriteLine(s3);
            string s4 = new string('c', 3);//joins 3 times the character specified
            Console.WriteLine(s4);

            //creating string using different ways
            string fname, lname;
            fname = "Heli";
            lname = "Parekh";

            string[] sarray = { "Hello", "Everyone" };

            string fullname = fname + " " + lname;//concatenation
            Console.WriteLine("Full Name: {0}", fullname);

            string message = String.Join(" ", sarray);//join method
            Console.WriteLine("Message: {0}", message);

            DateTime time = new DateTime(2012, 10, 10, 17, 58, 1);//formatting
            string chat = String.Format("Message sent at {0:t} on {0:D}", time);
            Console.WriteLine("Time: {0}", chat);

            //Properties
            Console.WriteLine("Char Property: " + s4[2]);//chars property
            Console.WriteLine("Length Property: " + s4.Length);//gives length of string

            //methods            
            char[] b = { 'a', 'e', 'r', 'p' };
            char[] c = new char[5];

            Console.WriteLine("Compare Method: " + String.Compare("abc", "Abc"));
            Console.WriteLine("Compare Method: " + String.Compare("abc", "ABC", true));//ignores case-true
            Console.WriteLine("CompareTo Method: " + s1.CompareTo("hello"));//compare s1 and hello
            Console.WriteLine("Concat Method: " + String.Concat(fname, lname));
            Console.WriteLine("Concat Method: " + String.Concat(fname, " ", lname));
            Console.WriteLine("Contains Method: " + s1.Contains("H"));//s1 contains "H" or not
            Console.WriteLine("Copy Method: " + String.Copy(s1));//copies s1

            s2.CopyTo(0, c, 0, 5);
            Console.WriteLine("CopyTo Method: "); //copies 'heli ' from s2 to char array c
            for (int i = 0; i < c.Length; i++)
                Console.Write(c[i]);
            Console.WriteLine();

            Console.WriteLine("Equals Method: " + s2.Equals(fullname));//compares s2 and fullname
            Console.WriteLine("EndsWith Method: " + s2.EndsWith("h"));//s2 endswith "h" or not
            Console.WriteLine("StartsWith Method: " + s2.StartsWith("H"));
            Console.WriteLine("IndexOf Method: " + s2.IndexOf('h'));
            Console.WriteLine("IndexOfAny Method: " + s2.IndexOfAny(b));
            Console.WriteLine("LastIndexOfAny Method: " + s2.LastIndexOfAny(b));
            Console.WriteLine("Substring Method: " + s2.Substring(2));
            Console.WriteLine("Insert Method: " + s1.Insert(5, " Everyone"));
            Console.WriteLine("Replace Method: " + s1.Replace('e', 'E'));
            Console.WriteLine("Remove Method: " + s1.Remove(3));
            Console.WriteLine("ToLower Method: " + s1.ToLower());
            Console.WriteLine("ToUpper Method: " + s1.ToUpper());
            Console.WriteLine("Trim Method: " + s2.Trim());

            //string builder
            StringBuilder sb = new StringBuilder("Heli", 10);
            //StringBuilder s = new StringBuilder("Heli");
            //StringBuilder s = new StringBuilder(10);
            //StringBuilder s = new StringBuilder();
            sb.Append(" Parekh");
            sb.AppendLine(" 14");//new line added after 14
            sb.Append("Hello Everyone");
            Console.WriteLine(sb);

            StringBuilder sb1 = new StringBuilder("Amount: ");
            sb1.AppendFormat("{0:C} ", 50);
            Console.WriteLine(sb1);

            sb.Insert(21, ",Hi!!");
            Console.WriteLine(sb);

            sb.Remove(21, 5);
            Console.WriteLine(sb);

            sb.Replace("Hello", "Hi");
            Console.WriteLine(sb);

            Console.ReadKey();
            */
        }
    }
}
