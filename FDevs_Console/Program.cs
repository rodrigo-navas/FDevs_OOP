using FDevs_Console_ClassLibrary.Pilares_OOP;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FDevs_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valor1 = 10;
            decimal valor2 = 20;

            #region [ If Comum ]
            //If Comum
            if (valor1 > valor2 && (valor1 > 10 || valor2 < 50))
                Console.WriteLine("Valor 1 é maior que Valor 2");
            else if (valor1 == valor2)
                Console.WriteLine("Valor 1 é igual a  Valor 2");
            else
                Console.WriteLine("Valor 1 é menor que Valor 2");
            #endregion [ If Comum ]

            #region [ If Ternario ]
            //Ternario
            Console.WriteLine(valor1 > valor2 ? "Valor 1 é maior que Valor 2" :
                              valor1 == valor2 ? "Valor 1 é igual a  Valor 2" :
                              "Valor 1 é menor que Valor 2");
            #endregion [ If Ternario ]

            #region [ Switch ]
            decimal valorRef = 10;

            //Switch
            switch (valorRef)
            {
                case 10:
                    Console.WriteLine("Valor é 10");
                    break;
                case 20:
                    Console.WriteLine("Valor é 20");
                    break;
                default:
                    Console.WriteLine("Valor não é 10 nem 20");
                    break;
            }
            #endregion [ Switch ]

            #region [ Repetições ]
            // Repetições
            List<string> ListaNomes = new List<string>();
            ListaNomes.Add("Rodrigo Navas");
            ListaNomes.Add("Alexandre Bigode");
            ListaNomes.Add("Felipe");

            for (int i = 0; i < ListaNomes.Count; i++)
            {
                Console.WriteLine("For_" + ListaNomes[i]);
            }

            foreach (var item in ListaNomes)
            {
                Console.WriteLine("ForEach_" + item);
            }

            var contador = 0;
            while (contador < ListaNomes.Count)
            {
                Console.WriteLine("While_" + ListaNomes[contador]);
                contador++;
            }

            var contador1 = 0;
            do
            {
                Console.WriteLine("Do_While_" + ListaNomes[contador1]);
                contador1++;

            } while (contador1 < ListaNomes.Count);
            #endregion [ Repetições ]

            #region [ Linq ]
            //Primeiro registro
            ListaNomes.FirstOrDefault(nome => nome == "Rodrigo Navas");

            //Lista de registros com o nome filtrado
            ListaNomes.Where(nome => nome == "Rodrigo Navas");

            //Lista
            ListaNomes.ForEach(nome => { });

            //Verificando se existe
            ListaNomes.Exists(a => a == "Rodrigo Navas");
            #endregion [ Linq ]

            #region [ Utilizacao das classes do OOP ]
            new ProducaoCafe();
            #endregion [ Utilizacao das classes do OOP ]

            Console.ReadKey();
        }
    }
}
