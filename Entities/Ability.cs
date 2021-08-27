namespace SharpGame.Entities
{
    public abstract class Ability
    {
        public int Cost { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // TODO figure out a way to make 
        // targeted and global/self abilities work
        // either events or subclassing
    }
}