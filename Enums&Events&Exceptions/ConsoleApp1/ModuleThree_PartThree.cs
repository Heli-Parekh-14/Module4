using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ModuleThree_PartThree
    {
        public void codes()
        {
            /* ----------------Part-3-------------------
            //public access modifier-Access is granted to the entire program(another assembly/method)
            Student S = new Student(1, "Heli");
            Console.WriteLine("Roll number: {0}", S.rollNo);//directly accessing members
            Console.WriteLine("Name: {0}", S.name);
            Console.WriteLine("Roll number: {0}", S.getRollNo());//via member method
            Console.WriteLine("Name: {0}", S.getName());

            //protected-Access is limited to the class that contains the member and derived types of this class
            X obj1 = new X();
            Y obj2 = new Y();
            Console.WriteLine("Value of x is : {0}", obj2.getX());

            //internal-Access is limited to only the current Assembly
            Complex c = new Complex();//can't be accessed in another namespace
            c.setData(2, 1);
            c.displayData();

            //protected internal-Access is limited to the current assembly
            //(if class accessing member is not derived class then that class  
            //must be in same assembly as of containing class) or 
            //the derived types of the containing class(if accessing class is derived 
            //then it can be within/outside assembly as of containing class)

            //private-Access is only granted to the containing class
            Parent obj = new Parent();
            //no meaning to create obj of child as showValue will give error
            // obj.value = 5; 
            // Also gives an error 
            // Use public functions to assign 
            // and use value of the member 'value' 
            obj.setValue(4);
            Console.WriteLine("Value = " + obj.getValue());

            //private protected-Access is granted to the containing class 
            //or its derived types present in the current assembly
            //(derived class in another assembly can't access)
            Child obj3 = new Child();
            // obj3.value1 = 5; 
            // Also gives an error
            // Use public functions to assign 
            // and use value of the member 'value1' 
            obj3.setValue1(4);
            Console.WriteLine("Value1 = " + obj3.getValue1());
            obj3.showValue1();

            Console.ReadKey();

    
    //class for public modifier
    class Student
    {
        public int rollNo;
        public string name;

        public Student(int r, string n)
        {
            rollNo = r;
            name = n;
        }

        public int getRollNo()
        {
            return rollNo;
        }
        public string getName()
        {
            return name;
        }
    }

    //classes for protected modifier
    class X
    {
        protected int x;

        public X()
        {
            x = 10;
        }
    }

    class Y : X  
    {

        public int getX()
        {
            return x;  
        }
    }

    //class for internal modifier
    internal class Complex
    {
        int real;
        int img;

        public void setData(int r, int i)
        {
            real = r;
            img = i;
        }

        public void displayData()
        {
            Console.WriteLine("Real = {0}", real);
            Console.WriteLine("Imaginary = {0}", img);
        }
    }

    //classes for private and private protected modifier
    class Parent
    {
        private int value;
        private protected int value1;

        public void setValue(int v)
        {
            value = v;
        }

        public int getValue()
        {
            return value;
        }
        public void setValue1(int v)
        {
            value1 = v;
        }

        public int getValue1()
        {
            return value1;
        }
    }
    class Child : Parent
    {
        public void showValue()
        {
            // Trying to access value 
            // Inside a derived class 
            // Console.WriteLine( "Value = " + value ); 
            // Gives an error 
        }

        public void showValue1()
        {
            //Console.WriteLine("Value1 = " + value1);
        }
    }
            */
        }
    }
}
