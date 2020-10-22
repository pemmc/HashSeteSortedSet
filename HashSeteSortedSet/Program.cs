using System;

using System.Collections.Generic;

namespace HashSeteSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("Maria");
            set.Add("Alex");

            //Ele testa o gethashcode e depois se existe ele usa o equals para confirmar!
            Console.WriteLine(set.Contains("Maria"));

        }

    }
}
