using SharpGame.Helpers.Events;
using SharpGame.Helpers.Interfaces;
using System;
using System.Collections.Generic;

namespace SharpGame.Entities
{
    public abstract class Entity
    {
        public string Name { get; set; }
        public Resource Health { get; set; }
        public Resource Energy { get; set; }
        public Stats Stats { get; set; }
        public int Coins { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public Weapon Weapon { get; set; }
        public Dictionary<string, Potion> Potions { get; set; }
        public List<Buff> Buffs { get; set; }
        public List<Ability> Abilities { get; set; }

        public event EventHandler<CombatEventArgs> OnAttack;
        public event EventHandler<CombatEventArgs> OnTakingDamage;
        public event EventHandler OnTargeted;
        public event EventHandler OnDeath;
        public event EventHandler OnUseItem;
        public event EventHandler OnTurnStart;
        public event EventHandler OnTurnEnd;
        public event EventHandler OnRoundStart;

        public void Attack(Entity target) 
        {
            if (this.Weapon != null)
            {
                this.OnAttack(this, new CombatEventArgs { Target = target });
            }
            else
            {
                Console.WriteLine("No weapon equipped");
            }
        }
        public void TakeDamage(int damage)
        {
            this.OnTakingDamage(this, new CombatEventArgs { Damage = damage });
        }
        public void Target() 
        {
            this.OnTargeted(this, EventArgs.Empty);
        }
        public void Death()
        {
            this.OnDeath(this, EventArgs.Empty);
        }
        public void UseItem()
        {
            this.OnUseItem(this, EventArgs.Empty);
        }
        public void TurnStart()
        {
            this.OnTurnStart(this, EventArgs.Empty);
        }
        public void TurnEnd()
        {
            this.OnTurnEnd(this, EventArgs.Empty);
        }
        public void RoundStart()
        {
            this.OnRoundStart(this, EventArgs.Empty);
        }
    }
}
