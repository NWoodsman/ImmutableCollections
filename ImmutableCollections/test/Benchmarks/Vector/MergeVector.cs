using BenchmarkDotNet.Attributes;
using ImmutableCollections.Vectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks.Vector
{
    [MemoryDiagnoser]
    public class MergeVector
    {
        const int SIZE = 1_000_000;

        MergeVector<int> testVector;

        [GlobalSetup]

        public void Setup()
        {
            var m_vec = MergeVector<int>.Empty;
            for (int i = 0; i < SIZE; i++) m_vec = m_vec.Add(i);
            testVector = m_vec;
        }

        [Benchmark]
        public void benchmark_add()
        {
            var m_vec = MergeVector<int>.Empty;
            for (int i = 0; i < SIZE; i++) m_vec = m_vec.Add(i);
        }

        [Benchmark]
        public void benchmark_lookup()
        {
            for (int i = 0; i < SIZE; i++)
            {
                var item = testVector[i];
            }
        }

        [Benchmark]

        public void benchmark_enumerator()
        {
            foreach(var item in testVector)
            {
                int thisi = item;
            }
        }
    }
}
