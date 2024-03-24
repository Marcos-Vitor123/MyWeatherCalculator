using System;

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
        public static double teste = 30;
        public static TimeSpan novoTeste;
        public static TimeSpan tempoDisponivel;
        public static TimeSpan tempoHoras;
        public static TimeSpan tempoMinutos;
        public static TimeSpan tempoRestante;
        public static TimeSpan Hora = new(horas, minutos, segundos); // TimeSpan -> É uma estrutura.

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

            novoTeste = TimeSpan.FromMinutes(teste);
            tempoRestante = tempoDisponivel - novoTeste;

            ImprimirTela();
        }

        public static void ImprimirTela()
        {
            Console.WriteLine($"Você tem {tempoDisponivel} disponível");
            Console.WriteLine($"Você tem {tempoRestante} restante");
        }
    }
}