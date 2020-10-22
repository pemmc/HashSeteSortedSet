using System;

using System.Collections.Generic;

namespace HashSeteSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instanciamos nosso conjuunto na memória
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook")); //True
            Console.WriteLine(set.Contains("SmartPhone")); //False

            foreach(string p in set)
            {
                Console.WriteLine(p);

            }
        }
    }
}
