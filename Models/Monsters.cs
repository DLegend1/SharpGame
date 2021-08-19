using SharpGame.Entities;
using SharpGame.Helpers.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Models {
    public static class Monsters
    {
        public static Monster Wolf = new MonsterBuilder()
            .WithName("Wolf")
            .WithHealth(100)
            .WithEnergy(20)
            .WithAttackTrigger((s, a) => { Console.WriteLine("Awoo!"); })
            .WithWeapon(Weapons.WolfClaw)
            .Build();

        public static Monster StoneGolem = new MonsterBuilder()
            .WithName("StoneGolem")
            .WithHealth(180)
            .WithEnergy(40)
            .WithAttackTrigger((s,a) => 
            {
                var sender = s as Monster;
                a.Target.TakeDamage(10);
                Console.WriteLine($"RAAARG the stone golem dealt 10 damage to {a.Target.Name}");            
            })
            .WithDamageTrigger((s,a) => 
            {
                var sender = s as Monster;
                sender.Health.Decrease(a.Damage - 3);
                Console.WriteLine($"The golem shrugs off 3 out of {a.Damage} damage and only recieves {a.Damage-3} ");
            })
            .Build();
    }
}
