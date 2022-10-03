namespace SoftwareHero.Core.Extensions
{
    public static class ListExtensions
    {
        public static T GetRandom<T>(this IList<T> list, Random rand)
        {
            var idx = rand.Next(list.Count);
            return list[idx];
        }

        public static void Shuffle<T>(this IList<T> list, Random rand)
        {
            var swapIdx = list.Count;
            while (swapIdx > 1)
            {
                swapIdx--;
                var randIdx = rand.Next(swapIdx + 1);
                (list[randIdx], list[swapIdx]) = (list[swapIdx], list[randIdx]);
            }
        }
    }
}
