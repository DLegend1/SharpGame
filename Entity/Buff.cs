namespace SharpGame.Entity
{
    public abstract class Buff
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public abstract void Add(Entity target);
        public abstract void Remove(Entity target);
    }
}