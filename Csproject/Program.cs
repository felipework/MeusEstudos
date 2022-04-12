using Csproject.Entities;
using System;

namespace Csproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string texto = "What are your orders? ";
            EscritaYellow amarelo = new EscritaYellow(texto);

            string texto2 = "[Y/N] - Are you cheater? ";
            EscritaYellow amarelo2 = new EscritaYellow(texto2);


            char choice = char.Parse(Console.ReadLine());
            if (choice == 'Y' || choice == 'y')
            {
                string texto3 = "You reprogram the module and become the second person to beat the no-win scenario. How original of you.";
                EscritaRed vermelho = new EscritaRed(texto3);
            }
            else if (choice == 'N' || choice == 'n')
            {
                Choicetwo Choiceum = new Choicetwo();
            }
            else
            {
                Console.WriteLine("Não seja burro capitão! Responda corretamente!");
                Program c3 = new Program();
            }
        }
    }
}