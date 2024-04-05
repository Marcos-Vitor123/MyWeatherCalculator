using System;
using System.IO;

namespace MyWeatherCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Menu();
        }
        public static int horas = 0;
        public static int minutos = 0;
        public static int segundos = 0;
        public static int opcao;
        public static int i;

        public static double tempoDisponivelTotal;

        public static TimeSpan tempoDisponivel;
        public static TimeSpan tempoHoras;
        public static TimeSpan tempoMinutos;
        public static TimeSpan tempoRestante;
        public static TimeSpan Hora = new(horas, minutos, segundos); // TimeSpan -> É uma estrutura.

        public static List<string> nomeTarefa = [];
        public static List<double> tempoTarefa = [];

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n\tBem vindo a Calculadora do Tempo!\t\n");
            CapturarDados();
            MenuCriarTarefas();
            Console.ReadKey();
        }

        public static void CapturarDados()
        {
            Console.Write("Quantas horas você tem? ");
            horas = int.Parse(Console.ReadLine());
            Console.Write("E quantos minutos você tem? ");
            minutos = int.Parse(Console.ReadLine());
        }
        
        public static void Operacao()
        {
            tempoHoras = TimeSpan.FromHours(horas);
            tempoMinutos = TimeSpan.FromMinutes(minutos);
            tempoDisponivel = tempoHoras + tempoMinutos;

            tempoRestante = tempoDisponivel - TimeSpan.FromMinutes(tempoDisponivelTotal);
        }
        public static void ExibirTarefas()
        {
            Console.WriteLine("\nTarefas \t\tTempo\t\n");
            for (i = 0; i < tempoTarefa.Count; i++)
            {
                tempoDisponivelTotal = tempoTarefa.Sum();

                Console.WriteLine($"{nomeTarefa[i]}: \t\t\t{tempoTarefa[i]}");
            }
            Console.WriteLine($"\nTempo em minutos Total:\t{tempoDisponivelTotal}\n");
        }

        public static void ExibirTempoDisponivel()
        {
            Console.WriteLine($"Você tem {tempoDisponivel} minutos disponíveis");
            Console.WriteLine($"Você tem {tempoRestante} minutos restantes\n");
        }

        public static void MenuCriarTarefas()
        {
            Console.WriteLine("0 - Para terminar as tarefas.");
            Console.WriteLine("1 - Para criar as tarefas.");
            Console.WriteLine("2 - Para salvar o arquivo.");

            Console.Write("Digite a opção: ");
            opcao = int.Parse(Console.ReadLine());

            do
            {
                Console.Clear();
                Opcao();
            } while(opcao == 1);
        }

        public static void Opcao()
        {
            switch (opcao)
            {
                case 0:
                {
                    ExibirTarefas();
                    ExibirTempoDisponivel();
                    break;
                }
                case 1:
                {
                    CriarTarefas();
                    break; 
                }
                case 2:
                    Salvar();
                    break;
                default:
                {
                    Console.WriteLine("Opção inválida!");
                    break;
                }
            }
        }

        public static void CriarTarefas()
        {
            Console.Write("Digite o nome da tarefa: ");
            nomeTarefa.Add(Console.ReadLine());
            Console.Write("Digite o tempo dessa tarefa: ");
            tempoTarefa.Add(double.Parse(Console.ReadLine()));
            ExibirTarefas();
            Operacao();
            MenuCriarTarefas();
        }


        // Em desenvolvimento

        public static void Salvar() 
        {
            string[] linhas = 
            [
                //$"{nomeTarefa[i]}: \t\t\t{tempoTarefa[i]}",
                $"\nTempo em minutos Total:\t{tempoDisponivelTotal}\n"
            ];

            string caminho = @"D:\";

            using (StreamWriter saidaArquivo = new StreamWriter(Path.Combine(caminho, "Minha Calculadora do tempo.txt")))
            {
                foreach (string linha in linhas)
                {
                    saidaArquivo.WriteLine(linha);
                }
                Console.WriteLine("\nArquivo salvo com sucesso!");
            }
        }
    }
}