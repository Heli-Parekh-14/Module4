using System;

delegate int NumberChanger(int n);

namespace ConsoleApp1
{
    class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        static void Main(string[] args)
        {
            /* ----------------Part-1-------------------
             */
            //enums-An enumeration is a set of named integer constants. An enumerated type is declared
            //using the enum keyword.C# enumerations are value data type. In other words, enumeration contains 
            //its own values and cannot inherit or cannot pass inheritance.Each of the symbols in the enumeration 
            //list stands for an integer value, one greater than the symbol that precedes it. By default, the value 
            //of the first enumeration symbol is 0. 
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;
            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);

            //events-refer module3-part5 for delegates and events
            Event.display();

            //handling exceptions
            //system exception
            try
            {
                int a = 4;
                int b = 0;
                if (b == 0)
                    throw new Exception("B can't be zero");
                else
                {
                    int ans = a / b;
                    Console.WriteLine(ans);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("oops bye!");
            }

            //custom exception
            try
            {
                Age o = new Age();
                o.checkAge(0);
            }
            catch (AgeNotNegative e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }           
         
    }

    //class for event
    class Event
    {
        public event NumberChanger MyEvent;
        public Event()
        {
            this.MyEvent = new NumberChanger(this.MultiplyFive);
        }
        public int MultiplyFive(int n) //same signature as of delegate
        {
            return n * 5;
        }
        public static void display()
        {
            Event obj1 = new Event();
            Console.WriteLine(obj1.MyEvent(5));
        }

    }

    //classes for exceptions
    class AgeNotNegative : ApplicationException
    {
        public AgeNotNegative(string s)
            : base(s)
        {

        }
    }
    public class Age
    {
        public void checkAge(int a)
        {
            if (a <= 0)
                throw new AgeNotNegative("Age is negative");
            else
                Console.WriteLine("Age is:" + a);
        }
    }
}