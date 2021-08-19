using System;

namespace SharpGame.Entities
{
    public class Potion
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public EventHandler Consume;
    }
}