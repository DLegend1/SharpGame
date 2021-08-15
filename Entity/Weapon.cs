namespace SharpGame.Entity
{
    public abstract class Weapon
    {
        public string Name { get; set; }
        public abstract void Attack(Entity attacker,Entity target);
    }
}