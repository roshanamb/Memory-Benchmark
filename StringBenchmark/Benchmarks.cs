using System;
using System.Linq;
using System.Text;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace StringBenchmark
{
    [MemoryDiagnoser]
    public class Benchmarks
    {
        [Params(5,50,500,5000)]
        public int N { get; set; }

        [Benchmark (Baseline =true)]
        public string StringJoin()
        {
            return string.Join(", ", Enumerable.Range(0,N).Select(i=> i.ToString()));
        }

        [Benchmark]
        public string StringBuilder()
        {
            var sb = new StringBuilder();
            for(int i=0; i<N; i++)
            {
                sb.Append(i);
                sb.Append(", ");
            }

            return sb.ToString();
        }
    }
}
