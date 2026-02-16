namespace Gof.Graphic
{
    using System; // For ICloneable

    public abstract class Graphic : ICloneable
    {
        protected string name;

        public Graphic(string name)
        {
            this.name = name;
        }

        public abstract void Draw(Position position);

        public abstract object Clone();
    }
}
