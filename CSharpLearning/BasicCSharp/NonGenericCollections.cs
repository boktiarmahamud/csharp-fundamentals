using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp
{

    internal class NonGenericCollections
    {
        public static void Main(string[] args)
        {
       
            ArrayList arrayList = new ArrayList();
            
            arrayList.Add(1); 
            arrayList.Add("Hello"); 
            arrayList.Add(3.14);
            arrayList.Add("Boktiar Mahamud");

            // date time
            DateTime dateTime = DateTime.Now;
            arrayList.Add(dateTime);

            // Iterate through the collection and print the elements
            Console.WriteLine("Elements in the ArrayList:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            // Hashtable
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "One");
            hashtable.Add(2, "Two");
            hashtable.Add(3, "Three");
            hashtable.Add("date", dateTime);

            // Iterate through the Hashtable and print the key-value pairs
            Console.WriteLine("Elements in the Hashtable:");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            // Queue
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14);
            
            // Iterate through the Queue and print the elements
            Console.WriteLine("Elements in the Queue:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Stack
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("Hello");
            stack.Push(3.14);

            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
