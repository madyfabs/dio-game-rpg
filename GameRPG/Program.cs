using System;
using GameRPG.Entities;

namespace GameRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero heroi = new Hero("Fabricio", 12, "Knight");

            Console.WriteLine(heroi);
        }
    }
}
