using SharpGame.Entities;
using SharpGame.Entities.Helpers.Extensions;
using System;

namespace SharpGame {
    class Program {
        static void Main(string[] args)
        {
            var hero = new Entity { Name = "Hero" };
            hero.OnTakingDamage += () => { Console.WriteLine($"The Hero yelps in pain!"); };
            var wolf = new Wolf();

            var sword = new TestSword();

            hero.AddWeapon(sword);

            hero.Attack(wolf);

            hero.RemoveWeapon();

            hero.Attack(wolf);

            wolf.AddWeapon(sword);

            wolf.Attack(hero);

            Console.ReadKey();
        }
    }
}
