using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ModuleThree_PartOne
    {
        public void codes()
        {
            /* ----------------Part-1-------------------
            //usage of classes
            Box Box1 = new Box(5.0,6.0,7.0);   
            double volume = 0.0;  
            

            volume = Box1.getVolume();//volume
            Console.WriteLine("Volume of Box1 : {0}", volume);

            Box1.count();
            Box1.count();
            Box1.count();

            Console.WriteLine("Variable num: {0}", Box.getNum());

            //static class usage 
            Author.details();
 
            Console.WriteLine("Author name : {0} ", Author.A_name);
            Console.WriteLine("Book Name : {0} ", Author.B_name);
            Console.WriteLine("ID : {0} ",  Author.id);

            //sealed class usage
            SealedClass slc = new SealedClass();
            int total = slc.Add(6, 4);
            Console.WriteLine("Total = " + total.ToString());

            //sealed method usage
            Printer p = new Printer();
            p.show();
            p.print();

            Printer ls = new LaserJet();
            ls.show();
            ls.print();

            Printer of = new Officejet();
            of.show();
            of.print();

            //abstract class usage
            Square s = new Square(6);
            Console.WriteLine("Area  = " + s.Area()); 
            
            Console.ReadKey();

        

    //class usage
    class Box
    {
        //encapsulation
        private double length;   // Length of a box
        private double breadth;  // Breadth of a box
        private double height;   // Height of a box

        public Box(double len,double bre,double hei)//paramaterised constructor
        {
            length = len;
            breadth = bre;
            height = hei;
        }
        ~Box()//destructor
        {

        }
        public double getVolume()//method declaration
        {
            return length * breadth * height;
        }

        public static int num;   //static variable

        public void count() //accessing static variable in non-static method
        {
            num++;
        }
        public static int getNum() //static method
        {
            return num;
        }
    }

    //static class-can only have static members
    static class Author
    {
        // Static data members
        public static string A_name = "Heli";
        public static string B_name = "C#";
        public static int id = 14;

        //static constructor
        static Author()
        {
            Console.WriteLine("Static constructor");
        }

        // Static method 
        public static void details()
        {
            Console.WriteLine("The details of Author is:");
        }
    }

    //class to show sealed class
    sealed class SealedClass
    {

        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    //classes for sealed method
    class Printer
    {
        public virtual void show()//virtual methods
        {
            Console.WriteLine("Display dimension : 6*6");
        }
 
        public virtual void print()
        {
            Console.WriteLine("Printer printing....\n");
        }
    }

    class LaserJet : Printer
    {

        sealed override public void show()//sealed can only be used with override for methods
        {
            Console.WriteLine("Display dimension : 12*12");
        }

        override public void print()
        {
            Console.WriteLine("Laserjet printer printing....\n");
        }
    }

    class Officejet : LaserJet
    {

        /*can not override show function or else 
        compiler error : 'Officejet.show()' :  
        cannot override inherited member 
        'LaserJet.show()' because it is sealed.
        */
            /*
            override public void print()
            {
                Console.WriteLine("Officejet printer printing....");
            }
        }

        // classes for abstraction
        abstract class Shape
        {
            abstract public int Area();//abstract method
        }
        class Square : Shape//inheriting Shape class
        {
            int side = 0;

            public Square(int n)
            {
                side = n;
            }

            public override int Area()//overriding abstract method
            {
                return side * side;
            }
        }

             */
        }
    }
}
