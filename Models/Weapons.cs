using SharpGame.Entities;
using SharpGame.Helpers.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Models {
    public static class Weapons {
        public static Weapon Sword = new WeaponBuilder()
            .WithName("Sword")
            .WithUseEffect((sender, args) => { args. })
            .Build();
    }
}
