using System;
using System.Text;
using System.Threading;
using System.Collections.Generic;

namespace Farmacia
{
    internal class Program
    {


        static void Main(string[] args)
        {
            {
                string[] remedio = new string[] { "Dorflex", "Losartana", "Rivotril", "Dipirona", "Torsilax" };
                char inicializar;

                Console.WriteLine("********* Bem vindo a Farmácia Bom Valor ****************");

                inicio:
                Console.WriteLine();
                Console.WriteLine($"Escreva o nome do Medicamento que que você deseja (Ex.: Rivotril); \n\n" +
                    $"01- {remedio[0]}\n" +
                    $"02- {remedio[1]}\n" +
                    $"02- {remedio[2]}\n" +
                    $"03- {remedio[3]}\n" +
                    $"04- {remedio[4]}\n");
                    

                string escolha = Console.ReadLine().ToLower();
                escolha = escolha.ToLower();
                
                
                while (true)
                {
                    if (escolha == "dorflex")
                        Console.WriteLine("Medicamento selecionado : Dorflex; temos 220 Unidades em estoque; Posição no Array:[0]");

                        
                    else if (escolha == "losartana")
                        Console.WriteLine("Medicamento selecionado : Losartana; temos 128 Unidades em estoque; Posição no Array:[1]");

                    else if (escolha == "rivotril")
                        Console.WriteLine("Medicamento selecionado : Rivotril; temos 355 Unidades em estoque; Posição no Array:[2]");

                    else if (escolha == "dipirona")
                        Console.WriteLine("Medicamento selecionado : Dipirona; temos 258 Unidades em estoque; Posição no Array:[3]");

                    else if (escolha == "torsilax")
                        Console.WriteLine("Medicamento selecionado : Torsilax; temos 550 Unidades em estoque; Posição no Array:[4]");

                    break;


                }

                Console.WriteLine();
                Console.Write("Deseja fazer uma nova consulta ? [s/n]");
                inicializar = char.Parse(Console.ReadLine().ToUpper());
                if (inicializar == 'S' )
                {
                    Console.Clear();
                    goto inicio;
                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Fim do Programa");
                }
               




            }







        }








    }
}
