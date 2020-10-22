using System;

namespace HashSeteSortedSet.Entities
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
    }

    /*
        Não é necessário IMPLEMENTAR o GetHashCode e Equals:
            Pois como é STRUCT vai comparar por CONTEÚDO... tipo valor e nao por tip referencia...

            • Tipos referência: compara as referências dos objetos
            • Tipos valor: comparar os valores dos atributos
    */
}