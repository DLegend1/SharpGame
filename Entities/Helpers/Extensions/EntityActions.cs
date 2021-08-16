namespace SharpGame.Entities.Helpers.Extensions {
    public static class EntityActions {
        public static void AddWeapon(this Entity entity, Weapon weapon)
        {
            entity.Weapon = weapon;
            entity.OnAttack += weapon.UseWeapon;
        }

        public static void RemoveWeapon(this Entity entity)
        {
            entity.OnAttack -= entity.Weapon.UseWeapon;
            entity.Weapon = null;
        }
    }
}
