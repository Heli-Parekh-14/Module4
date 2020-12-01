using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ModuleTwo_PartOneAndTwo
    {
        public void codes()
        {
            /* ----------------Part-1-------------------
            int A = 10;
            int B = 20;

            //arithmetic operators
            int res = 0;
            res = A + B;
            Console.WriteLine("Addition: "+res);
            res = A - B;
            Console.WriteLine("Subtraction: "+res);
            res = A * B;
            Console.WriteLine("Multiplication: "+res);
            res = B / A;
            Console.WriteLine("Division: "+res);
            res = B % A;
            Console.WriteLine("Modulo: "+res);
            res = A++;
            Console.WriteLine("Post Increment A: "+res);
            res = ++A;
            Console.WriteLine("Pre Increment A: "+res);
            res = B--;
            Console.WriteLine("Post Decrement B: "+res);
            res = --B;
            Console.WriteLine("Pre Decrement B: "+res);

            //relational operators
            bool res1;
            res1 = A == B;
            Console.WriteLine("A==B: "+res1);
            res1 = A != B;
            Console.WriteLine("A!=B: "+res1);
            res1 = A > B;
            Console.WriteLine("A>B: "+res1);
            res1 = A < B;
            Console.WriteLine("A<B: "+res1);
            res1 = A >= B;
            Console.WriteLine("A>=B: "+res1);
            res1 = A <= B;
            Console.WriteLine("A<=B: "+res1);

            //logical operators
            bool a = true;
            bool b = false;
            res1 = a && b;
            Console.WriteLine("And: "+res1);
            res1 = a || b;
            Console.WriteLine("Or: " + res1);
            res1 = ! (a || b) ;
            Console.WriteLine("Not: " + res1);

            //bitwise operators
            A = 60;
            B = 13;
            res = A & B;
            Console.WriteLine("Bitwise And: "+res);
            res = A | B;
            Console.WriteLine("Bitwise Or: "+res);
            res = A ^ B;
            Console.WriteLine("Bitwise Xor: "+res);
            res = ~A;
            Console.WriteLine("Bitwise 1's Complement: "+res);
            res = A << 2;
            Console.WriteLine("Bitwise Shift Left: "+res);
            res = A >> 2;
            Console.WriteLine("Bitwise Shift Right: "+res);

            //assignment operator-every arithmetic and bitwise operators can be used as follows:
            //res += A;

            //misc operators
            res = sizeof(int);
            Console.WriteLine("Size of Integer: "+res);
            res = A > B ? 100 : 200;
            Console.WriteLine("Ternary Operator: "+res);

            Console.ReadKey();
            */

            /* ----------------Part-2------------------- 
            int i;

            //for loop
            for(i=0 ; i<5 ; i++)
                Console.WriteLine(i);

            //while loop
            while(i > 0)
            {
                Console.WriteLine(i);
                i--;
            }

            //do-while loop
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);

            //for-each loop
            int []x = { 1, 2, 3, 4, 5 };
            foreach(int item in x)
                Console.WriteLine(item);

            //continue control stmt
            for (i = 0; i < 5; i++)
            {
                if (i == 3)
                    continue;
                Console.WriteLine(i);
            }

            //break control stmt
            for (i = 0; i < 5; i++)
            {
                if (i == 3)
                    break;
                Console.WriteLine(i);
            }

            //goto control stmt
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)            
                goto ineligible;
            
            else
            {
                Console.WriteLine("You are eligible to vote!");
                goto exit;
            }
                

            ineligible:
                Console.WriteLine("You are not eligible to vote!");
            exit:

            //infinite loop
            /*for (i = 0; ; i++)
            {
                Console.WriteLine(i);
            }
            
            for (; ;)
            {
                Console.WriteLine("Trapped");
            }
            */
            //Console.ReadKey();                  

        }
    }
}

