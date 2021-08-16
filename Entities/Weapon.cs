using SharpGame.Helpers.Interfaces;
using System;

namespace SharpGame.Entities
{
    public abstract class Weapon : IAttachable
    {
        public string Name { get; set; }


        public abstract void Use (object attacker, EventArgs weaponEventArgs);

        public void Add(Entity user)
        {
            user.Weapon = this;
            user.OnAttack += this.Use;
        }

        public void Remove(Entity user)
        {
            user.OnAttack -= this.Use;
            user.Weapon = null;
        }
    }
}