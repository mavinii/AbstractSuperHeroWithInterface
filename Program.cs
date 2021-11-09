using AbstractSuperHeroWithInterface.Models;
using System;

namespace AbstractSuperHeroWithInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Super Hero");

            SuperMan superman = new SuperMan();
            superman.Fly();
            superman.LookThroughObjects();

            Sword sword = new Sword("BatSword");
            sword.TakeDamage(10);
        }
    }
}
