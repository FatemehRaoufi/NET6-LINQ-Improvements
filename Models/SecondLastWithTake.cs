using BenchmarkDotNet.Attributes;

namespace NET6LINQImprovements.Models
{
    public class SecondLastWithTake
    {
        private readonly IEnumerable<int> Range;

        public SecondLastWithTake()
        {
            Range = Enumerable.Range(0, 1_000);
        }

        [Benchmark]
        public int[] ElementsFromTenthTillTwentiethWithRange() =>
                Range.Take(10..20).ToArray();
        [Benchmark]
        public int[] ElementsFromTenthTillTwentiethWithSkipAndTake() =>
                        Range.Skip(10).Take(10).ToArray();

        [Benchmark]
        public int[] AllElementsExceptTenFirstAndLastWithRange() =>
                        Range.Take(10..^10).ToArray();
        [Benchmark]
        public int[] AllElementsExceptTenFirstAndLastWithSkipAndTakeCount() =>
                        Range.Skip(10).Take(Range.Count() - 20).ToArray();
        [Benchmark]
        public int[] AllElementsExceptTenFirstAndLastWithSkipAndSkipLast() =>
                        Range.Skip(10).SkipLast(10).ToArray();

        [Benchmark]
        public int[] ElementsFromTwentiethLastTillTenthLastWithRange() =>
                        Range.Take(^20..^10).ToArray();
        [Benchmark]
        public int[] ElementsFromTwentiethLastTillTenthLastWithSkipCountAndTake() =>
                        Range.Skip(Range.Count() - 20).Take(10).ToArray();
        [Benchmark]
        public int[] ElementsFromTwentiethLastTillTenthLastWithTakeLastAndTake() =>
                        Range.TakeLast(20).Take(10).ToArray();
    }
}
