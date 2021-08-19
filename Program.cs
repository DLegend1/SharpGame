using SharpGame.Entities;
using SharpGame.Helpers.Builders;
using SharpGame.Models;
using System;
using static SharpGame.Models.Monsters;

namespace SharpGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster dummy = new MonsterBuilder()
                .WithName("Dummy")
                .WithHealth(10)
                .WithDamageTrigger((sender, args) => {
                    var s = sender as Monster;
                    s.Health.Current -= args.Damage;
                    Console.WriteLine($"{s.Name} took {args.Damage} damage");
                })
                .WithWeapon(Weapons.HealStaff)
                .Build();

            var testWolf = Wolf.Instance();
            
            testWolf.Attack(dummy);

            dummy.Attack(testWolf);

            Console.ReadKey();
        }
    }
}
