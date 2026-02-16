namespace Gof.Graphic
{
    public abstract class Tool
    {
        protected Graphic prototype;

        public Tool(Graphic prototype)
        {
            this.prototype = prototype;
        }

        public abstract void Maniplate();
    }
}
