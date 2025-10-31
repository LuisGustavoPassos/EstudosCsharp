using ConsoleApp.Csharp.Balta.io;
using ConsoleApp.Csharp.MicrosoftLearn;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Csharp
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("escreva o nome do programa a ser executado");
            String? opcao = Console.ReadLine();
            switch (opcao.ToLower())
            {

                case "fundamentoscsharp": FundamentosCsharp.fundamentos();  break;
                case "introducaodotnet":  IntroducaoDotNet.DotNet(); break;


                default: Console.WriteLine("Programa não encontrado");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                    break;

            }
        }
    }
}
