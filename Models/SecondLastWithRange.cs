using BenchmarkDotNet.Attributes;

namespace NET6LINQImprovements.Models
{
    public class SecondLastWithRange
    {
        private readonly IEnumerable<int> Range;

        public SecondLastWithRange()
        {
            Range = Enumerable.Range(0, 1_000);
        }

        [Benchmark]
        public int SecondLastWithIndex() =>
                        Range.ElementAt(^2);

        [Benchmark]
        public int SecondLastWithCount() =>
                        Range.ElementAt(Range.Count() - 2);

        [Benchmark]
        public int SecondLastWithTakeLast() =>
                        Range.TakeLast(2).ElementAt(0);
    }
}
