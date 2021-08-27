using SharpGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Helpers.Events
{
    public class BuffEventArgs : EventArgs
    {
        public Entity Target { get; set; }
    }
}
