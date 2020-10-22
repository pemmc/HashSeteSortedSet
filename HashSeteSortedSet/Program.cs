using System;

using System.Collections.Generic;

namespace HashSeteSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPERAÇÕES ALGÉBRICAS
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            PrintCollection(a); //Resultado: 0 2 4 5 6 8 10

            //União

            SortedSet<int> c = new SortedSet<int>(a);

            c.UnionWith(b);

            PrintCollection(c); //Resultado: 0 2 4 5 6 7 8 9 10 

            //Interseção

            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            PrintCollection(d); //Resultado: 5 6 8 10

            //Diferenca
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);


            PrintCollection(e); //Resultado: 0 2 4
        }

        static void PrintCollection<T>(IEnumerable<T> collection){
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");

            }

            Console.WriteLine();

        }


    }
}
