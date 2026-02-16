namespace Gof.Graphic
{
    public class GraphicTool : Tool
    {
        public GraphicTool(Graphic graphic) : base(graphic)
        {
        }

        public override void Maniplate()
        {
            Graphic graphic = (Graphic)prototype.Clone();
            graphic.Draw(new Position());
        }
    }
}
