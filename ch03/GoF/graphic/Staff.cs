namespace Gof.Graphic
{
    public class Staff : Graphic
    {
        private readonly string property;

        public Staff(string name, string property) : base(name)
        {
            this.property = property;
        }

        public override void Draw(Position position)
        {
            // Implementation specific to drawing a staff
        }

        public override Graphic Clone()
        {
            return new Staff(name, property);
        }
    }
}
