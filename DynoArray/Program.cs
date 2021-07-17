using System;

namespace DynoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(3);
            array.Insert(1);
            array.Insert(2);
            array.Insert(3);
            array.Insert(4);
            array.Insert(5);
            Console.WriteLine(array.Print());
            Console.WriteLine(array.IndexOf(5));
            array.RemoveAt(1);
            Console.WriteLine(array.Print());
            Console.WriteLine(array.IndexOf(5));
            
            
        }
    }
}
