using SharpGame.Entities;
using SharpGame.Helpers.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Models {
    public static class Weapons {
        public static Weapon Sword = new WeaponBuilder()
            .WithName("Sword")
            .WithUseEffect((sender, args) => { args.Target.TakeDamage(5); })
            .Build();

        public static Weapon WolfClaw = new WeaponBuilder()
            .WithName("Wolf Claw")
            .WithUseEffect((s, args) => {
                var sender = s as Monster;
                sender.Health.Increase(5);
                args.Target.TakeDamage(5);
                Console.WriteLine($"{sender.Name} steals 5 life from {args.Target.Name}!");})
            .Build();

        public static Weapon HealStaff = new WeaponBuilder()
            .WithName("Healing Staff")
            .WithUseEffect((s, args) => {
                var sender = s as Entity;
                int amount = 5;
                sender.Health.Increase(amount);
                Console.WriteLine($"{sender.Name} heals itself for {amount}. (Now at {sender.Health.Current} HP)");
            })
            .Build();
    }
}
