namespace SharpGame.Entities
{
    public class Potion
    {
        public string Name { get; set; }
        public abstract void Consume(Entity user);
    }
}