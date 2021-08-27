﻿using SharpGame.Helpers.Events;
using SharpGame.Helpers.Interfaces;
using System;

namespace SharpGame.Entities
{
    public class Weapon : IAttachable
    {
        public string Name { get; set; }

        public EventHandler<CombatEventArgs> Use;
        
        public void Attach(Entity user)
        {
            user.Weapon = this;
            user.OnAttack += this.Use;
        }

        public void Remove(Entity user)
        {
            user.OnAttack -= this.Use;
            user.Weapon = null;
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}