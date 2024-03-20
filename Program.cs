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

        public static int horas;
        public static int minutos;
        public static int segundos;
        public static int tempoDisponivel;

        TimeSpan Hora = new(60, 0, 0); // TimeSpan -> É uma estrutura. E aqui representa 60 horas

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n\tBem vindo a Calculadora do Tempo!\t\n");
            Console.ReadKey();
        }
    }
}