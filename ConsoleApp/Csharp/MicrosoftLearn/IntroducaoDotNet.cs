using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Este programa se refere ao roteiro de aprendizagem "Criar aplicativos .NET com C#" do Microsoft Learn
 */
namespace ConsoleApp.Csharp.MicrosoftLearn
{
    internal class IntroducaoDotNet
    {
        public static void DotNet()
        {
            { Menu(); }
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("------------------");
            Console.WriteLine("Introducao DotNet");
            Console.WriteLine("------------------");
            Console.WriteLine("Menu de opções");
            Console.WriteLine("1:");
            Console.WriteLine("------------------");
            Console.WriteLine("Selecione uma das opções:");
            Console.ReadLine();
        }
        /*
        * NuGet pelo terminal 
       *adicionando dependencias => dotnet add package Newtonsoft.Json
       *listando dependencias    => dotnet list package
       *removendo dependencias   => dotnet remove package Newtonsoft.Json
       *restaurando dependencias => dotnet restore
        */
    }
}


