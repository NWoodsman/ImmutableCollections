using BenchmarkDotNet.Attributes;
using ImmutableCollections.Vectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks.Vector
{
    public class MergeVector
    {
        const int SIZE = 1_000_000;


        /// <summary>
        /// Perform one million additions, the state of MergeVector as of 11/27/23. Time to beat: 32ms, 146mb allocated
        /// </summary>
        [Benchmark]
        public void merge_vec()
        {
            var m_vec = MergeVector<int>.Empty;
            for (int i = 0; i < SIZE; i++) m_vec = m_vec.Add(i);
        }

    }
}
