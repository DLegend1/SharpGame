using SharpGame.Entities.Buffs;
using SharpGame.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Entities {
    public class Monster : Entity, IPrototype<Monster>
    {
        public MonsterBehavior Behavior { get; set; }

        public Monster() {
            this.Buffs = new();
            this.Potions = new();
            this.Abilities = new();
        }

        public Monster Instance()
        {
            var copy = (Monster)MemberwiseClone();
            return copy;
        }
    }
}
