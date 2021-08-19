using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Entities {
    public class Monster : Entity 
    {
        public MonsterBehavior Behavior { get; set; }
    }
}
