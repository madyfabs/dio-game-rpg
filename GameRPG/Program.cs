using System;
using GameRPG.Entities;

namespace GameRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item cavaleiroItem = new("Machado", 2000, 6);
            Knight cavaleiro = new("Fabricio", 12, "Knight", 50, 20, cavaleiroItem);

            Item ninjaItem = new("Shuriken", 600, 2);
            Ninja ninja = new("Naruto", 25, "Ninja", 30, 15, ninjaItem);

            Item whitewizardItem = new("Tomo", 5000, 10);
            WhiteWizard whitewizard = new("Moira", 5, "White Wizard", 20, 20, whitewizardItem);

            Item blackwizardItem = new("Ametista Diabólica", 8500, 12);
            BlackWizard blackwizard = new("Lilith", 8, "Black Wizard", 20, 20, blackwizardItem);

            Console.WriteLine(cavaleiro);
            Console.WriteLine(cavaleiro.Attack());
            Console.WriteLine(cavaleiro);

            Console.WriteLine(ninja);
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(ninja);

            Console.WriteLine(whitewizard);
            Console.WriteLine(whitewizard.Attack());
            Console.WriteLine(whitewizard);

            Console.WriteLine(blackwizard);
            Console.WriteLine(blackwizard.Attack());
            Console.WriteLine(blackwizard);


        }
    }
}
