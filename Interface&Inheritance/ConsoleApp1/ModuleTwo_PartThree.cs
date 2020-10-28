using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ModuleTwo_PartThree
    {
        public void codes()
        {
            /* ----------------Part-3-------------------
            //single dimensional array
            int []n = new int[10]; 
            int i;

            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            foreach (int m in n)
            {
                i = m - 100;
                Console.WriteLine("Element[{0}] = {1}", i, m);
            }

            //multi dimensional array
            int [,]a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            int j;

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("a[{0},{1}] = {2} ", i, j, a[i, j]);
                }
                Console.WriteLine();
            }

            //jagged array
            int [][]b = new int[][]{new int[]{0,0},new int[]{1,2},new int[]{2,4},new int[]{ 3, 6 }, new int[]{ 4, 8 } };

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("a[{0}][{1}] = {2} ", i, j, b[i][j]);
                }
                Console.WriteLine();
            }

            //passing array as parameter
            double avg;

            avg = getAverage(n,10);
            Console.WriteLine("Average value is: {0} ", avg);

            //param array
            int sum = AddElements(512, 720, 250, 567, 889);
            Console.WriteLine("The sum is: {0}", sum);

            //array class
            Object o = 100;

            Console.WriteLine("Array Length Property: "+n.Length);                      //ans in 32 bit integer
            Console.WriteLine("Array LongLength Property: " + n.LongLength);            //ans in 64 bit integer
            Console.WriteLine("Array Rank Property: " + a.Rank);                        //dimensions of array
            
            Console.WriteLine("Array GetLength Method: " + n.GetLength(0));             //ans in 32 bit integer
            Console.WriteLine("Array GetLongLength Method: " + n.GetLongLength(0));     //ans in 64 bit integer
            Console.WriteLine("Array GetValue Method: " + n.GetValue(1));               //value at given index
            Console.WriteLine("Array IndexOf Method: " + Array.IndexOf(n,o));           //first occurance of obj in array
            
            Console.WriteLine("Array Reverse Method: ");
            Array.Reverse(n);                                                           //reverse array
            foreach (int m in n)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Array SetValue Method: ");
            n.SetValue(o,1);                                                            //set obj value at given index
            foreach (int m in n)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Array Sort Method: ");
            Array.Sort(n);                                                              //sort array
            foreach (int m in n)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Array ToString Method: ");
            n.ToString();                                                               //convert array to string
            foreach (int m in n)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Array Copy Method: ");
            int[] n1 = new int[20];
            Array.Copy(n,n1,10);                                                       //copy one array to another 
            foreach (int m in n1)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Array CopyTo method: ");
            n.CopyTo(n1, 10);                                                         //copy one array to another from given index
            foreach (int m in n1)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Array Clear method: ");
            Array.Clear(n,0,10);                                                     //clear array
            foreach (int m in n)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        
        //methods for part-3
        public static double getAverage(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; ++i)
            {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }

        public static int AddElements(params int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
            */
        }
    }
}
