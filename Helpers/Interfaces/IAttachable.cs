using SharpGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Helpers.Interfaces
{
    public interface IAttachable
    {
        public void Attach(Entity user);
        public void Remove(Entity user);
    }
}
