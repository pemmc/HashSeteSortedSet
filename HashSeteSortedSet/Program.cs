using System;

using System.Collections.Generic;

namespace HashSeteSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HashSet<string> sqlCommands = new HashSet<string>();

                sqlCommands.Add("SELECT * WHERE CAMPO1 = CAMPO2");
                sqlCommands.Add("UPDATE CAMPO1 = 3, CAMPO2 WHERE CAMPO10 = 2");
                sqlCommands.Add("SELECT * WHERE CAMPO1 = CAMPO10");
                sqlCommands.Add("SELECT *");
                sqlCommands.Add("UPDATE CAMPO1 = 2 WHERE CAMPO1 = CAMPO2");


                //Ele testa o gethashcode e depois se existe ele usa o equals para confirmar!
                if(sqlCommands.Contains("SELECT *"))
                {
                    throw new InvalidOperationException("Você está tentando adicionar um SQL já existente");

                }

                Console.WriteLine("Comando adicionado: " + "SELECT *");

            }

            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);

            }

        }

    }
}
