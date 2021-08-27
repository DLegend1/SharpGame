using SharpGame.Entities.Buffs;
using SharpGame.Helpers.Events;
using SharpGame.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
        public HashSet<Buff> Buffs { get; set; }
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
                //TODO this.OnBeginAttack
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name} ({this.Level})\r\n");
            sb.Append("---------------------\r\n");
            sb.Append($"{this.Health}\r\n");
            sb.Append($"{this.Energy}\r\n");
            sb.Append("---------------------\r\n");
            sb.Append($"Weapon: {this.Weapon}\r\n");
            sb.Append("---------------------\r\n");
            
            if (this.Buffs.Count > 0)
            {
                sb.Append($"Buffs:\r\n");

                foreach (var buff in this.Buffs)
                {
                    sb.Append($"{buff}\r\n");
                }
            }

            return sb.ToString();
        }
    }
}
