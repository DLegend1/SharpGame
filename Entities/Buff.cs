using SharpGame.Helpers.Interfaces;

namespace SharpGame.Entities
{
    public abstract class Buff : IAttachable
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract void Attach(Entity target);
        public abstract void Remove(Entity target);
    }
}