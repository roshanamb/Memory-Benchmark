using System;
using System.Linq;
using System.Text;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace StringBenchmark
{
    public class Benchmarks
    {
        [Benchmark (Baseline =true)]
        public string StringJoin()
        {
            return string.Join(", ", Enumerable.Range(0,5).Select(i=> i.ToString()));
        }

        [Benchmark]
        public string StringBuilder()
        {
            var sb = new StringBuilder();
            for(int i=0; i<5; i++)
            {
                sb.Append(i);
                sb.Append(", ");
            }

            return sb.ToString();
        }
    }
}
