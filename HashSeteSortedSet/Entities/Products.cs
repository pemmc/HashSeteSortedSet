using System;
using System.Collections.Generic;

using HashSeteSortedSet.Entities;

namespace HashSeteSortedSet.Entities
{
    public class Products
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Products(string name, int price)
        {
            Name = name;
            Price = price;
        }

        /* 
            *  Tivemos que implementar o GetHashCode e Equals nesta CLASSE PRODUCTS, pois diferentemente da STRUCT
                Para seguir esta regra de implentação:
                • Primeiro GetHashCode. Se der igual, usa Equals para confirmar.

                Porque Se GetHashCode e Equals NÃO estiverem implementados:
                    • Tipos referência: compara as referências dos objetos
                    • Tipos valor: comparar os valores dos atributos

                Ou seja, tenho esta classe que é tipo referência que se não fosse implementada nela,
                então ele compararia a REFERÊNCIA DE MEMÓRIA (de objetos)...
                Como são 2 objetos diferentes... RETORNARIA TRUE!
             
        IMPLEMENTEI AQUI 
        */
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();

        }

        public override bool Equals(object obj)
        {
            if(!(obj is Products))
            {
                return false;

            }

            //DowCasting
            Products other = obj as Products;

            Console.WriteLine(other.Name + " + " +  other.Price);
            return Name.Equals(other.Name) && Price.Equals(other.Price);

        }
    }
}