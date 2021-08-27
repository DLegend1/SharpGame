using SharpGame.Helpers.Events;
using SharpGame.Helpers.Interfaces;
using System;

namespace SharpGame.Entities.Buffs
{
    // TODO buffs need composition instead of inheritance
    // because both static, timed and stacking buffs
    // can do things each turn, i.e. have some 'Tick' handler
    // this quickly becomes impossible w/ inheritance,
    // since we run into the multiple inheritance problem,
    // which needs either interfaces (which can't hold state though)
    // or composition in order to be fixed
    public abstract class Buff : IAttachable
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public EventHandler<BuffEventArgs> OnAttach;
        public EventHandler<BuffEventArgs> OnRemove;

        public virtual void Attach(Entity target) {
            // if we're just now adding the buff
            if (target.Buffs.Add(this))
            {
                this.OnAttach(this, new BuffEventArgs { Target = target });
            }
        }

        public virtual void Remove(Entity target) {
            this.OnRemove(this, new BuffEventArgs { Target = target });
            target.Buffs.Remove(this);
        }

        public override string ToString()
        {
            return $"{this.Name}: {this.Description}";
        }
    }
}