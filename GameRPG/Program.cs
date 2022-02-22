using System;
using GameRPG.Entities;

namespace GameRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight cavaleiro = new("Fabricio", 12, "Knight");

            Console.WriteLine(cavaleiro);
            Console.WriteLine(cavaleiro.Attack());
        }
    }
}
