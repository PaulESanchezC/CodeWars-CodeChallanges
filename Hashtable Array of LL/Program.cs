using System;
using System.Collections.Generic;

namespace Hashtable_Array_of_LL
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable hashTable = new HashTable(4);
            hashTable.Put(1, "Paul Sanchez");
            hashTable.Put(1, "Paul Sanchez");
            hashTable.Put(2, "Voldemort Sanchez");
            hashTable.Put(3, "Michelle Cartier");
            hashTable.Put(4, "Prince Cartier");

            hashTable.Remove(1);
            hashTable.Remove(1);
            hashTable.Remove(1);
            Console.WriteLine(hashTable.Get(1));
        }
    }
}
