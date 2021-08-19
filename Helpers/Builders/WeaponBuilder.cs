using SharpGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Helpers.Builders {
    public class WeaponBuilder {
        private Weapon weapon;

        public WeaponBuilder()
        {
            this.weapon = new();
        }

        public Weapon Build()
        {
            return this.weapon;
        }

        public WeaponBuilder WithName(string name)
        {
            this.weapon.Name = name;
            return this;
        }

        public WeaponBuilder WithUseEffect(EventHandler useEffect)
        {
            this.weapon.Use = useEffect;
            return this;
        }
    }
}
