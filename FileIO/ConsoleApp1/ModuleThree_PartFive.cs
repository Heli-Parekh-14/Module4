using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

//delegate declaration-Delegate declaration determines the methods 
//that can be referenced by the delegate. A delegate can refer to a method, 
//which has the same signature as that of the delegate.
//delegate int NumberChanger(int n);

namespace ConsoleApp1
{
    class ModuleThree_PartFive
    {
        public void codes()
        {
            /* ----------------Part-5-------------------
            
            //reflection-Reflection objects are used for obtaining type information at runtime. The classes
            //that give access to the metadata of a running program are in the System.Reflection namespace.
            //It allows view attribute information at runtime.
            //It allows examining various types in an assembly and instantiate these types.
            //It allows late binding to methods and properties.
            //It allows creating new types at runtime and then performs some tasks using those types.

            //load assembly file which we want to dig 
            var assembly = Assembly.LoadFile(@"C:\Users\SMART\Documents\Visual Studio 2019\Projects\ConsoleApp1\bin\Debug\ConsoleApp1.exe");

            //if we want to dig current file:
            //var assembly = Assembly.GetExecutingAssembly();

            Console.WriteLine(assembly.FullName);

            //to get all the things like class,interfaces etc ,if exist ,from assembly
            var type = assembly.GetTypes();
            foreach (var t in type)
            {
                Console.WriteLine("Base type:" + t.BaseType);
                Console.WriteLine("Name:" + t.Name);
                Console.WriteLine("Full Name:" + t.FullName);
                Console.WriteLine("Namespace:" + t.Namespace);

                //particular class t digging
                var field = t.GetFields();
                foreach (var f in field)
                {
                    //only accessible if fields are public
                    Console.WriteLine("Field Name:" + f.Name);
                    Console.WriteLine("Whether Private:" + f.IsPrivate);
                }

                var method = t.GetMethods();
                foreach (var m in method)
                {
                    //only accessible if fields are not private
                    Console.WriteLine("Method Name:" + m.Name);
                    Console.WriteLine("Whether Private:" + m.IsPrivate);

                    var parameter = m.GetParameters();
                    foreach (var p in parameter)
                    {
                        Console.WriteLine("parameter name:" + p.Name);
                        Console.WriteLine("parameter type:" + p.ParameterType);
                    }
                }

                var cons = t.GetConstructors();
                foreach (var c in cons)
                {
                    Console.WriteLine("Constructor name:" + c.Name);
                }

                var prop = t.GetProperties();
                foreach (var p in prop)
                {
                    Console.WriteLine("Property name:" + p.Name);
                    Console.WriteLine("Property type:" + p.PropertyType);
                }

                //leaving line between components
                Console.WriteLine();
            }

            //properties-Properties are named members of classes, structures, and interfaces. 
            //Member variables or methods in a class or structures are called Fields. Properties
            //are an extension of fields and are accessed using the same syntax. They use accessors 
            //through which the values of the private fields can be read, written or manipulated.
            //Properties do not name the storage locations. Instead, they have accessors that read, 
            //write, or compute their values.
            //Abstract properties can also be there where abstract class contains abstract properties and 
            //derived class will have variables for which properties would be overriden.
            Student s = new Student();

            // Setting code, name and the age of the student
            s.Code = "C1";
            s.Name = "Heli";
            s.Age = 21;
            Console.WriteLine("Student Info:\n{0}", s);

            //let us increase age
            s.Age += 1;
            Console.WriteLine("Student Info:\n{0}", s);

            //indexer-allows an object to be indexed such as an array. 
            //When you define an indexer for a class, this class behaves similar to a virtual array. 
            //You can then access the instance of this class using the array access operator ([ ]).
            //Declaration of behavior of an indexer is to some extent similar to a property
            //, you use get and set accessors for defining an indexer.However, properties return or 
            //set a specific data member, whereas indexers returns or sets a particular value from the object instance.
            //In other words,it breaks the instance data into smaller parts and indexes each part, gets or sets each part.
            //Defining a property involves providing a property name. Indexers are not defined with names, but with 
            //the this keyword, which refers to the object instance.
            A o1 = new A();
            o1[0] = "heli";
            Console.WriteLine(o1[0]);
            o1[1] = 1;
            Console.WriteLine(o1[1]);

            B o = new B();
            o[0] = "hi";
            o[1] = "heli";

            Console.WriteLine(o[0]);
            Console.WriteLine(o[1]);

            //delegates-C# delegates are similar to pointers to functions, in C or C++. 
            //A delegate is a reference type variable that holds the reference to a method. The reference 
            //can be changed at runtime.Delegates are especially used for implementing events and the call - back
            //methods.All delegates are implicitly derived from the System.Delegate class.
            //create delegate instances-Once a delegate type is declared, a delegate object must be created with 
            //the new keyword and be associated with a particular method. When creating a delegate, the argument 
            //passed to the new expression is written similar to a method call, but without the arguments to the method. 
            NumberChanger nc1 = new NumberChanger(Delegate.AddNum);
            NumberChanger nc2 = new NumberChanger(Delegate.MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", Delegate.getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", Delegate.getNum());

            //multicasting of delegates-Delegate objects can be composed using the "+" operator. 
            //A composed delegate calls the two delegates it was composed from. Only delegates of the same 
            //type can be composed. The "-" operator can be used to remove a component delegate from a composed delegate.
            //Using this property of delegates you can create an invocation list of methods that will be called 
            //when a delegate is invoked.This is called multicasting of a delegate.
            NumberChanger nc;

            nc = nc1;
            nc += nc2;

            //calling multicast
            nc(5);
            Console.WriteLine("Value of Num: {0}", Delegate.getNum());

            //events-Events are user actions such as key press, clicks, mouse movements, etc., or some occurrence such as
            //system generated notifications. Applications need to respond to events when they occur. For example, 
            //interrupts. Events are used for inter-process communication.The events are declared and raised in a 
            //class and associated with the event handlers using delegates within the same class or some other class. 
            //The class containing the event is used to publish the event. This is called the publisher class. Some other 
            //class that accepts this event is called the subscriber class. Events use the publisher-subscriber model.
            //A publisher is an object that contains the definition of the event and the delegate. The event-delegate
            //association is also defined in this object. A publisher class object invokes the event and it is notified 
            //to other objects.A subscriber is an object that accepts the event and provides an event handler.
            //The delegate in the publisher class invokes the method(event handler) of the subscriber class.
            Event.display();//events can't be accessed outside the loc at which it is declared

            //anonymous methods-provide a technique to pass a code block as a delegate parameter. 
            //Anonymous methods are the methods without a name, just the body.
            //You need not specify the return type in an anonymous method; it is inferred from the 
            //return statement inside the method body.Anonymous methods are declared with the creation 
            //of the delegate instance, with a delegate keyword.The delegate could be called both with anonymous 
            //methods as well as named methods in the same way, i.e., by passing the method parameters to the delegate
            //object.

            //create delegate instances using anonymous method
            nc = delegate (int x) {
                return x;//body of anonymous method
            };
            //calling the delegate using the anonymous method             
            Console.WriteLine(nc(10));

            Console.ReadKey();
        
    

    //class for property
    class Student
    {
        private string code = "N.A";
        private string name = "not known";
        private int age = 0;

        // Declare a Code property of type string:
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        // Declare a Name property of type string:
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Declare a Age property of type int:
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }
    }

    //classes for indexer
    class A
    {
        string name;
        int i;
        public object this[int j]
        {
            get
            {
                if (j == 0)
                    return (string)name;
                else
                    return (int)i;
            }
            set
            {
                if (j == 0)
                    name = (string)value;

                else
                    i = (int)value;
            }
        }
    }
    class B
    {
        string[] name = new string[2];
        int[] i = new int[2];
        public object this[int j]
        {
            get
            {
                if (j == 0 || j == 1)
                {
                    return (string)name[j];
                }
                else if (j == 2)
                {
                    return i[0];
                }
                else
                {
                    return i[1];
                }
            }
            set
            {
                if (j == 0 || j == 1)
                { name[j] = (string)value; }


                else if (j == 2)
                {
                    i[0] = (int)value;
                }
                else
                {
                    i[1] = (int)value;
                }
            }
        }
    }

    //class for delegate
    class Delegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
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
            return n*5;
        }
        public static void display()
        {
            Event obj1 = new Event();
            Console.WriteLine(obj1.MyEvent(5));
        }

    }
            */
        }
    }
}
