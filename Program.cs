using SharpGame.Entities;
using SharpGame.Entities.Buffs;
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
                .WithEnergy(15)
                .WithDamageTrigger((sender, args) => {
                    var s = sender as Monster;
                    s.Health.Current -= args.Damage;
                    Console.WriteLine($"{s.Name} took {args.Damage} damage");
                })
                .WithWeapon(Weapons.VampSword)
                .Build();

            Console.WriteLine(dummy);

            //StaticBuff testBuff = new StaticBuff
            //{
            //    Name = "TestHealthBuff",
            //    Description = "Increases max health by 15",
            //    OnAttach = (s, a) => { a.Target.Health.IncreaseMax(15); a.Target.Health.Increase(15); },
            //    OnRemove = (s, a) => { a.Target.Health.DecreaseMax(15); }
            //};

            var testBuff = new StackingBuff
            {
                Name = "TestHealthBuff",
                Description = "Increases max health by 15",
                OnAttach = (s, a) => { a.Target.Health.IncreaseMax(15); a.Target.Health.Increase(15); },
                OnRemove = (s, a) => { a.Target.Health.DecreaseMax(15); }
            };

            testBuff.Attach(dummy);
            testBuff.Attach(dummy);

            Console.WriteLine(dummy);

            testBuff.Remove(dummy);

            Console.WriteLine(dummy);

            //var testWolf = Wolf.Instance();
            //testwolf.attack(dummy);
            //dummy.attack(testwolf);


            //var testGolem = StoneGolem.Instance();
            //var testGolem2 = StoneGolem.Instance();
            //testGolem.Attack(dummy);
            //dummy.Attack(testGolem);
            //Console.WriteLine(testGolem2.Health.Current);

            //Monster vampire = new MonsterBuilder()
            //    .WithName("Alucard")
            //    .WithHealth(50)
            //    .WithDamageTrigger((sender,args) =>
            //    {
            //        var s = sender as Monster;
            //        s.Health.Current -= args.Damage;
            //        Console.WriteLine($"{s.Name} took {args.Damage} damage");
            //    })
            //    .WithWeapon(Weapons.VampSword)
            //    .Build();

            //var testWolf = Wolf.Instance();
            //testWolf.OnTakingDamage += (sender, args) =>
            //{
            //    var s = sender as Monster;
            //    s.Health.Current -= args.Damage;
            //    Console.WriteLine($"RRRRRRR {s.Name} took {args.Damage} damage");
            //};
            
            //testWolf.Attack(vampire);
            //testWolf.Attack(vampire);
            //vampire.Attack(testWolf);
            //Console.WriteLine(vampire.Health.Current);

            Console.ReadKey();
        }
    }
}
