﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ModuleFour_PartTwo
    {
        public void codes()
        {
            /* ----------------Part-2-------------------
            
            //interfaces-An interface is defined as a syntactical contract that all the classes inheriting 
            //the interface should follow. The interface defines the 'what' part of the syntactical contract and 
            //the deriving classes define the 'how' part of the syntactical contract.Interfaces define properties, 
            //methods, and events, which are the members of the interface. Interfaces contain only the declaration
            //of the members.It is the responsibility of the deriving class to define the members.It often helps 
            //in providing a standard structure that the deriving classes would follow.Abstract classes to some 
            //extent serve the same purpose, however, they are mostly used when only few methods are to be declared 
            //by the base class and the deriving class implements the functionalities.Interfaces are declared using 
            //the interface keyword. It is similar to class declaration. Interface statements are public by default.
            Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);

            t1.showTransaction();
            t2.showTransaction();

            //inheritance-single[one base,one child] 
            //           -multi level[one base->child->grand child->....]
            //           -multiple[two or more base->one child]-not supported so implemented using interfaces
            //           -hierarchical[one base,two or more child]
            Rectangle Rect = new Rectangle();
            Rect.setWidth(5);
            Rect.setHeight(7);
            Console.WriteLine("Total area: {0}", Rect.getArea());

            Console.ReadKey();
        

    
    //for interface
    public interface ITransactions
    {
        // interface members
        void showTransaction();
        double getAmount();
    }
    public class Transaction : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }
        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }
        public double getAmount()
        {
            return amount;
        }
        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
    }
    //for inheritance
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }
        */
        }
    }
}
