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

        public static int removerDia = 1;
        public static int subtrairMinuto = 1;
        public static int horas = 24 - removerDia;
        public static int minutos = 60;
        public static int segundos = 60;
        public static TimeSpan tempoDisponivelReal;
        public static TimeSpan tempoDisponivel;
        public static TimeSpan Hora = new(horas, minutos, segundos); // TimeSpan -> É uma estrutura. E aqui representa 60 horas

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n\tBem vindo a Calculadora do Tempo!\t\n");
            Operacao();
            Console.ReadKey();
        }

        public static void Operacao()
        {
            tempoDisponivel = Hora - TimeSpan.FromMinutes(30);
            tempoDisponivelReal = tempoDisponivel - TimeSpan.FromMinutes(subtrairMinuto);
            Console.WriteLine($"Tempo disponível: {tempoDisponivelReal}");
        }
    }
}