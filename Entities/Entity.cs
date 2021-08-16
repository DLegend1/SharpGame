using System;
using System.Collections.Generic;

namespace SharpGame.Entities
{
    public class Entity
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

        public event EventHandler OnAttack;
        public event EventHandler OnTakingDamage;
        public event EventHandler OnTargeted;
        public event EventHandler OnDeath;
        public event EventHandler OnUseItem;
        public event EventHandler OnTurnStart;
        public event EventHandler OnTurnEnd;
        public event EventHandler OnRoundStart;
    }
}
