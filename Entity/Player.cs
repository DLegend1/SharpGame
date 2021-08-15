using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Entity
{
    class Player : Entity
    {
        public int RequiredXp { get; set; }
        public int LevelPoints { get; set; }
    }
}
