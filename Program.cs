﻿using System;
using System.IO;

namespace MyWeatherCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Menu();
                    
            // Continuação em Breve!
        }
        public static int horas = 0; //- removerDia; // Evita aparecer dia no resultado Ex: 1.23:30:00
        public static int minutos = 0;
        public static int segundos = 0;
        public static int opcao;

        public static double tempoDisponivelTotal;
        public static TimeSpan conversaoTempoDisponivelTotal;
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
            Operacao();
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
            CapturarDados();
            tempoHoras = TimeSpan.FromHours(horas);
            tempoMinutos = TimeSpan.FromMinutes(minutos);
            tempoDisponivel = tempoHoras + tempoMinutos;

            conversaoTempoDisponivelTotal = TimeSpan.FromMinutes(tempoDisponivelTotal);
            tempoRestante = tempoDisponivel - conversaoTempoDisponivelTotal;

            ExibirTempoDisponivel();
        }

        public static void ExibirTempoDisponivel()
        {
            Console.WriteLine($"Você tem {tempoDisponivel} disponível");
            Console.WriteLine($"Você tem {tempoRestante} restante");
            MenuCriarTarefas();
        }

        public static void MenuCriarTarefas()
        {
            Console.WriteLine("0 - Para terminar as tarefas.");
            Console.WriteLine("1 - Para criar as tarefas.");

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
                    break;
                }
                case 1:
                {
                    CriarTarefas();
                    break; 
                }
                default:
                {
                    Console.WriteLine("Opção inválida!");
                    break;
                }
            }
        }

        public static void ExibirTarefas()
        {
            for (int i = 0; i < tempoTarefa.Count; i++)
            {
                tempoDisponivelTotal = tempoTarefa.Sum();

                Console.WriteLine($"{nomeTarefa[i]}: \t\t\t{tempoTarefa[i]}");
            }
            Console.WriteLine($"Tempo Disponível Total:\t{tempoDisponivelTotal}");
        }

        public static void CriarTarefas()
        {
            Console.Write("Digite o nome da tarefa: ");
            nomeTarefa.Add(Console.ReadLine());
            Console.Write("Digite o tempo dessa tarefa: ");
            tempoTarefa.Add(double.Parse(Console.ReadLine()));
            ExibirTarefas();
            MenuCriarTarefas();
        }
    }
}