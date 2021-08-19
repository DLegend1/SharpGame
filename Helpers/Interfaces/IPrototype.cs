using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Helpers.Interfaces {
    public interface IPrototype<T> {
        public T Instance();
    }
}
