using System;
using System.Collections.Generic;

using HashSeteSortedSet.Entities;

namespace HashSeteSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui uma coleção HASH com a classe PRODUCTS
            HashSet<Products> a = new HashSet<Products>();

            a.Add(new Products("TV", 900));
            a.Add(new Products("Notebook", 1200));

            //Aqui somente a classe PRODUCTS
            Products prod = new Products("Notebook", 1200);

            //COMPARANDO COM A IMPLEMENTAÇÃO, mesmo sendo um outro objeto, o conteúdo é igual
            Console.WriteLine(a.Contains(prod)); //Resultado COM A IMPLEMENTAÇÃO: true

            /* O CODIGO SEM IMPLEMENTACAO ERA ASSIM:

            Este Console.WriteLine(a.Contains(prod) SEM A IMPLEMENTAÇÃO tinha como RESULTADO: False

               Pois neste caso não estava implementados segue este regra...
             
                Se GetHashCode e Equals NÃO estiverem implementados:                    • Tipos referência: compara as referências dos objetos                    • Tipos valor: comparar os valores dos atributos

                Ou seja, tenho uma classe que é tipo referência que não está implementada nela,
                então ele comparou a REFERÊNCIA DE MEMÓRIA (de objetos)...
                Como são 2 objetos diferentes
              


             
               Agora não vamos implementar o GetHashCode e Equals lá na classe PRODUCTS, daí segue esta regra:
                Se GetHashCode e Equals estiverem implementados:                    • Primeiro GetHashCode. Se der igual, usa Equals para confirmar.
            
            */

            HashSet<Point> b = new HashSet<Point>();

            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Point p = new Point(5, 10);

            //Neste caso mesmo eu não tenho implementado á na Point
            //sabendo-se que lá o tipo é STRUCT ele vai comparar mesmo por REFERÊNCIA
            Console.WriteLine(b.Contains(p));

        }

    }
}
