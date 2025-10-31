using System;
using System.ComponentModel.Design;
using System.Threading;
using System.IO;

/* 
este programa se refere as atividades passadas como "mão na massa" do curso balta.io, 
    mudulo: Fundamentos do C#
*/

namespace EstudosCsharp.Balta.io
{
    
    public class FundamentosCsharp
    {
        public static void fundamentos()
        {
            { Menu(); }
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("------------------");
            Console.WriteLine("Fundamentos Csharp");
            Console.WriteLine("------------------");
            Console.WriteLine("Menu de opções");
            Console.WriteLine("1 - Operações");
            Console.WriteLine("2 - Cronometro");
            Console.WriteLine("3 - Text Editor");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("------------------");
            Console.WriteLine("Selecione uma das opções:");

            short opcao = short.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1: Operacoes(); break;
                case 2: Stopwatch(); break;
                case 3: TextEditor();break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        static void Operacoes()
        {
            Console.Clear();


            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("A operações vai somar,subtrair,multiplicar e dividir dois valores escritos pelo usuario");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            Console.WriteLine("escreva o primeiro numero: ");

            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("escreva o segundo numero: ");
            float v2 = float.Parse(Console.ReadLine());

            float soma = v1 + v2;
            float subtracao = v1 - v2;
            float multiplicacao = v1 * v2;
            float divisao = v1 / v2;

            Console.WriteLine($"a soma é: {soma}");
            Console.WriteLine($"a subtração é: {subtracao}");
            Console.WriteLine($"a multiplicacao é: {multiplicacao}");
            Console.WriteLine($"a divisao é: {divisao}");

            Console.WriteLine("pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu();
        }
        static void Stopwatch()
        {
            Console.Clear();
            MenuCronometro();

            static void MenuCronometro()
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("digite uma das opções a seguir: ");
                Console.WriteLine("'s' para segundos => 1s = 1 segundo");
                Console.WriteLine("'m'para minutos => 1m = 1 minuto");
                Console.WriteLine("'0s' para voltar para o menu");
                Console.WriteLine("----------------------------------");

                string data = Console.ReadLine().ToLower();
                char type = char.Parse(data.Substring(data.Length - 1, 1));
                int time = int.Parse(data.Substring(0, data.Length - 1));
                int multiplier = 1;

                if (type == 'm')
                    multiplier = 60;

                if (time == 0)
                    Menu();
                Start(time * multiplier);
            }
            

                static void Start(int time)
                {

                Console.Clear();

                    int currentTime = 0;
                    Console.WriteLine("Iniciando Cronometro...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    while (currentTime != time)
                    {
                        
                        currentTime++;
                        Console.WriteLine(currentTime);
                        Thread.Sleep(1000);

                    }
                    Console.WriteLine("Cronometro finalizado");
                    Thread.Sleep(3000);
                fundamentos();
                }
            }
        static void TextEditor()
        {
            Console.Clear();
            MenuTextEditor();
        }
        static void MenuTextEditor(){ 

                Console.Clear();

                Console.WriteLine("O que voce deseja ");
                Console.WriteLine("'0' Menu");
                Console.WriteLine("'1' Abrir");
                Console.WriteLine("'2' Editar");
                Console.WriteLine("'3' Salvar");

                short option = short.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0: Menu(); break;
                    case 1: Abrir(); break;
                    case 2: Editar(); break;
                    default: TextEditor(); break;
                } 
                
            static void Abrir() { 
                Console.Clear();
                Console.WriteLine("qual o caminho do arquivo?");
                Console.WriteLine("--------------------------");
                string path = Console.ReadLine();

                using (var file = new StreamReader(path))
                {
                    string text = file.ReadToEnd();
                    Console.WriteLine(text);
                    Console.WriteLine("");
                    Console.ReadLine();
                    MenuTextEditor();
                }
            }
            static void Editar() { 
            Console.Clear();
                Console.WriteLine("digite seu texto abaixo( ESC para sair   )");
                Console.WriteLine("-----------------------");
                string text = "";

                do
                {
                    text += Console.ReadLine();
                    text += Environment.NewLine;
                }
                while (Console.ReadKey().Key != ConsoleKey.Escape);
                Salvar(text);

            }

            static void Salvar(string text) { 
                Console.Clear();
                Console.WriteLine("qual o caminho que voce deseja salvar o arquivo?");
                var path = Console.ReadLine();
                //melhor jeito de escrever em arquivos no c# abre e fecha o arquivo automaticamente
                using (var file = new StreamWriter(path))
                {
                    file.WriteLine(text);
                }
                Console.WriteLine($"arquivo salvo com sucesso!{path}");
                Console.ReadLine();
                MenuTextEditor();
            }
        }
    }
}