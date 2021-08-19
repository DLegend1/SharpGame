using SharpGame.Entities;
using SharpGame.Helpers.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Models {
    public static class Monsters {
        public static Monster Wolf = new MonsterBuilder()
            .WithName("Wolf")
            .WithHealth(100)
            .WithEnergy(20)
            .Build();
    }
}
