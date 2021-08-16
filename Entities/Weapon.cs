namespace SharpGame.Entities {
    public abstract class Weapon {
        public string Name { get; set; }
        public abstract void UseWeapon(Entity attacker, Entity target);
    }
}