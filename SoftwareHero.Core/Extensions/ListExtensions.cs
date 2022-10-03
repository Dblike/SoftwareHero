namespace SoftwareHero.Core.Extensions
{
    public static class ListExtensions
    {
        public static T GetRandom<T>(this List<T> list)
        {
            return list.GetRandom(new Random());
        }

        public static T GetRandom<T>(this List<T> list, Random rand)
        {
            var idx = rand.Next(list.Count);
            return list[idx];
        }
    }
}
