namespace SharpGame.Entities
{
    public abstract class Potion
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public abstract void Consume(Entity user);
    }
}