using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class ModuleThree_PartFour
    {
        public void codes()
        {
            /* ----------------Part-4-------------------            

            //arraylist-an ordered collection of an object that can be indexed individually
            //unlike array you can add and remove items from a list at a specified position 
            //using an index and the array resizes itself automatically. 
            //It also allows dynamic memory allocation, adding, searching and sorting items in the list.
            ArrayList al = new ArrayList();

            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);

            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);

            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("Sorted Content: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //hashtable-collection of key-and-value pairs 
            //that are organized based on the hash code of the key. 
            //It uses the key to access the elements in the collection.
            Hashtable ht = new Hashtable();

            ht.Add("001", "Heli");
            ht.Add("002", "Deepika");
            ht.Add("003", "Ranveer");
            ht.Add("004", "Shahrukh");
            ht.Add("005", "Salman");
            ht.Add("006", "Alia");
            ht.Add("007", "Neha");

            if (ht.ContainsValue("Durga"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("008", "Durga");
            }

            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }

            //sortedlist-collection of key-and-value pairs that are sorted by the keys 
            //and are accessible by key and by index.
            //A sorted list is a combination of an array and a hash table.
            //It contains a list of items that can be accessed using a key or an index.
            //If you access items using an index, it is an ArrayList, and if you access items using a key, 
            //it is a Hashtable. The collection of items is always sorted by the key value.
            SortedList sl = new SortedList();

            sl.Add("001", "Heli");
            sl.Add("002", "Deepu");
            sl.Add("003", "Ranveer");
            sl.Add("004", "Nehu");
            sl.Add("005", "Rohanpreet");
            sl.Add("006", "Alia");
            sl.Add("007", "Ritesh");

            if (sl.ContainsValue("Durga"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                sl.Add("008", "Durga");
            }

            ICollection key_sl = sl.Keys;

            foreach (string k in key_sl)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }

            //stack-a last-in, first out collection of object. 
            //It is used when you need a last-in, first-out access of items. When you add an item in the list, 
            //it is called pushing the item and when you remove it, it is called popping the item.
            Stack st = new Stack();

            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            st.Push('V');
            st.Push('H');
            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());

            Console.WriteLine("Removing values ");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            //queue-a first-in, first out collection of object. It is used when 
            //you need a first-in, first-out access of items. 
            //When you add an item in the list, it is called enqueue,
            //and when you remove an item, it is called deque.
            Queue q = new Queue();

            q.Enqueue('A');
            q.Enqueue('M');
            q.Enqueue('G');
            q.Enqueue('W');

            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " ");
            Console.WriteLine();

            q.Enqueue('V');
            q.Enqueue('H');
            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " ");
            Console.WriteLine();

            Console.WriteLine("Removing some values ");
            char ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);

            Console.ReadKey();

            */
        }
    }
}
