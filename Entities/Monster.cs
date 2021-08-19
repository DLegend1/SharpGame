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

        public Monster Instance()
        {
            var copy = (Monster)MemberwiseClone();
            return copy;
        }
    }
}
