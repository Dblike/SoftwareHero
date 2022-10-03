namespace SoftwareHero.Core
{
    public struct Skill
    {
        public short Low;
        public short High;
        public short Actual;

        public Skill(short actual)
        {
            Low = -1;
            High = -1;
            Actual = actual;
        }
    }
}
