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

        //public static int removerDia = 1;
        public static int subtrairMinuto = 1;
        public static int horas = 0; //- removerDia; // Evita aparecer dia no resultado Ex: 1.23:30:00
        public static int minutos = 0;
        public static int segundos = 0;
        //public static double removerSinal;
        public static TimeSpan tempoDisponivel;
        public static TimeSpan novoTempoHoras;
        public static TimeSpan novoTempoMinutos;
        //public static TimeSpan tempoDisponivelReal;
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
            //tempoDisponivel = Hora - TimeSpan.FromHours(horas);
            //removerSinal = Math.Abs(tempoDisponivel.TotalHours); // remove sinal de menos do total de horas
            novoTempoHoras = TimeSpan.FromHours(horas);
            novoTempoMinutos = TimeSpan.FromMinutes(minutos);
            tempoDisponivel = novoTempoHoras + novoTempoMinutos;

            //tempoDisponivelReal = tempoDisponivel - TimeSpan.FromMinutes(subtrairMinuto);
            ImprimirTela();
        }


        public static void ImprimirTela()
        {
            Console.WriteLine($"Você tem {tempoDisponivel} disponível");
        }
    }
}