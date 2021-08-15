using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Entity
{
    public class Entity
    {
        public string Name { get; set; }
        public Resource Health { get; set; }
        public Resource Energy { get; set; }
        public Stats Stats { get; set; }
        public int Coins { get; set; }
        public Dictionary<string, Potion> Potions { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public List<Buff> Buffs { get; set; }
        public Weapon Weapon { get; set; }
        public List<Ability> Abilities { get; set; }

    }
}
