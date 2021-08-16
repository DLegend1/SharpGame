using System;

namespace SharpGame.Entities {
    public class TestSword : Weapon {
        public TestSword()
        {
            this.Name = "TestSword";
        }
        public override void UseWeapon(Entity attacker, Entity target)
        {
            Console.WriteLine($"{attacker.Name} is attacking {target.Name} with a {this.Name}");
            target.TakeDamage();
        }
    }
}
