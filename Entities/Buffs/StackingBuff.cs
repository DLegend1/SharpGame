using SharpGame.Helpers.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Entities.Buffs
{
    public class StackingBuff : Buff
    {
        public int Stacks { get; set; }

        public override void Attach(Entity target)
        {
            // this will just fail if the buff already exists
            // no extra handling needed
            target.Buffs.Add(this);

            this.OnAttach(this, new BuffEventArgs { Target = target });
            this.Stacks++;
        }

        public override void Remove(Entity target)
        {
            this.OnRemove(this, new BuffEventArgs { Target = target });
            this.Stacks--;
            if (this.Stacks < 1)
            {
                target.Buffs.Remove(this);
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} ({this.Stacks})";
        }
    }
}
