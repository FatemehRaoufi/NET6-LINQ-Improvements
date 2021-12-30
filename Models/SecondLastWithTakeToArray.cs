using BenchmarkDotNet.Attributes;

namespace NET6LINQImprovements.Models
{
    public class SecondLastWithTakeToArray
    {
        private readonly IEnumerable<int> Range;

        public SecondLastWithTakeToArray()
        {
            Range = Enumerable.Range(0, 1_000);
        }

        [Benchmark]
        public int[] FirstTenElementsWithRange() =>
                Range.Take(..10).ToArray();
        [Benchmark]
        public int[] FirstTenElementsWithTakeCount() =>
                        Range.Take(10).ToArray();

        [Benchmark]
        public int[] LastTenElementsWithRange() =>
                        Range.Take(^10..).ToArray();
        [Benchmark]
        public int[] LastTenElementsWithTakeLastCount() =>
                        Range.TakeLast(10).ToArray();

        [Benchmark]
        public int[] AllElementsExceptFirstTenWithRange() =>
                        Range.Take(10..).ToArray();
        [Benchmark]
        public int[] AllElementsExceptFirstTenWithSkip() =>
                        Range.Skip(10).ToArray();

        [Benchmark]
        public int[] AllElementsExceptTenLastWithRange() =>
                        Range.Take(..^10).ToArray();
        [Benchmark]
        public int[] AllElementsExceptTenLastWithSkipLast() =>
                        Range.SkipLast(10).ToArray();
    }
}
