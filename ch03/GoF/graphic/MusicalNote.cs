namespace Gof.Graphic
{
    public class MusicalNote : Graphic
    {
        private readonly string note;
        private readonly int octave;
        private readonly int duration;

        public MusicalNote(string name, string note, int octave, int duration) : base(name)
        {
            this.note = note;
            this.octave = octave;
            this.duration = duration;
        }

        public override void Draw(Position position)
        {
            // Implementation specific to drawing a musical note
        }

        public override Graphic Clone()
        {
            return new MusicalNote(name, note, octave, duration);
        }
    }
}
