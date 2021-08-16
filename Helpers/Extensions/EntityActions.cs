using SharpGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Helpers.Extensions
{
    public static class EntityActions
    {
        public static void AddWeapon(this Entity user, Weapon weapon)
        {
            weapon.Add(user);
        }
        
        public static void RemoveWeapon(this Entity user, Weapon weapon)
        {
            weapon.Remove(user);
        }
    }
}
