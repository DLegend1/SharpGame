namespace SharpGame.Entities
{
    public class Resource
    {
        public string Name { get; set; }
        public int Current { get; set; }
        public int Max { get; set; }

        public void Increase(int value)
        {
            Current = (Current + value) > Max ? Max : Current + value;
        }

        public void Decrease(int value)
        {
            Current = (Current - value) < 0 ? 0 : Current - value;
        }

        public void IncreaseMax(int value)
        {
            this.Max += value;
        }

        public void DecreaseMax(int value)
        {
            this.Max -= value;
            if(this.Current > this.Max)
            {
                this.Current = this.Max;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}: {this.Current}/{this.Max}";
        }
    }
}