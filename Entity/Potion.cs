namespace SharpGame.Entity
{
    public abstract class Potion
    {
        public string Name { get; set; }
        public abstract void Consume(Entity user);
    }
}