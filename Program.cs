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
                .WithHealth(50)
                .WithDamageTrigger((sender, args) => {
                    var s = sender as Monster;
                    s.Health.Current -= args.Damage;
                    Console.WriteLine($"{s.Name} took {args.Damage} damage");
                })
                .WithWeapon(Weapons.VampSword)
                .Build();

            //var testWolf = Wolf.Instance();
            //testwolf.attack(dummy);
            //dummy.attack(testwolf);

            var testGolem = StoneGolem.Instance();
            var testGolem2 = StoneGolem.Instance();
            testGolem.Attack(dummy);
            dummy.Attack(testGolem);
            Console.WriteLine(testGolem2.Health.Current);

            Console.ReadKey();
        }
    }
}
