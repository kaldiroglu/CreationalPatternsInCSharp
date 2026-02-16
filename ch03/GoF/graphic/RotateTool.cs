namespace Gof.Graphic
{
    public class RotateTool : Tool
    {
        public RotateTool(Graphic prototype) : base(prototype)
        {
        }

        public override void Maniplate()
        {
            Graphic graphic = (Graphic)prototype.Clone();
            graphic.Draw(new Position());
        }
    }
}
