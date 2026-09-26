using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp
{
    internal class GenericCollectios
    {
        public static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);
            // Iterate through the List and print the elements
            Console.WriteLine("Elements in the List:");
            foreach (int item in intList)
            {
                Console.WriteLine(item);
            }

            // Dictionary
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("One", 1);
            dictionary.Add("Two", 2);
            dictionary.Add("Three", 3);
            dictionary.Add("Four", 4);

            // Iterate through the Dictionary and print the key-value pairs
            Console.WriteLine("Elements in the Dictionary:");
            foreach (KeyValuePair<string, int> entry in dictionary)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }
    }
}
