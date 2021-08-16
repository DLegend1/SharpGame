using System;

namespace SharpGame.Entities {
    public class Wolf : Entity {
        public Wolf()
        {
            this.Name = "Wolf";
            this.OnTakingDamage += WolfTakeDamageEffect;
            this.OnAttack += WolfAttackEffect;
        }

        public void WolfTakeDamageEffect()
        {
            Console.WriteLine($"The {this.Name} howls in pain!");
        }

        private void WolfAttackEffect(Entity attacker, Entity target)
        {
            Console.WriteLine($"The Wolf is attacking the {target.Name}! Awoooooo!");
        }
    }
}
