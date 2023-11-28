﻿using BenchmarkDotNet.Attributes;
using ImmutableCollections.Vectors;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarks
{
    [MemoryDiagnoser]
    public class BenchmarkVectors
    {
        const int SIZE = 1_000_000;

        [Benchmark]
        public void ms_mutable_list()
        {
            var ms_list = new List<int>();
            for (int i = 0; i < SIZE; i++) ms_list.Add(i);
        }

        [Benchmark]
        public void ms_immutable_list()
        {
            var ms_list = ImmutableList<int>.Empty;
            for(int i=0;i<SIZE;i++) ms_list = ms_list.Add(i);  
        }

        [Benchmark]
        public void s_maggi_vec()
        {
            var s_vec = new Fvec<int>();
            for (int i = 0; i < SIZE; i++) s_vec = s_vec.Add(i);
        }

        [Benchmark]
        public void fixed_merge_vec()
        {
            var fm_vec = FixedMergeVector<int>.Empty;
            for (int i = 0; i < SIZE; i++) fm_vec = fm_vec.Add(i);
        }

        [Benchmark]
        public void merge_vec()
        {
            var m_vec = MergeVector<int>.Empty;
            for (int i = 0; i < SIZE; i++) m_vec = m_vec.Add(i);
        }

        [Benchmark]
        public void fixed_vec()
        {
            var f_vec = new FixedVector<int>();
            for (int i = 0; i < SIZE; i++) f_vec = f_vec.Add(i);
        }

        [Benchmark]
        public void resize_vec()
        {
            var r_vec = ResizeVector<int>.Empty;
            for (int i = 0; i < SIZE; i++) r_vec = r_vec.Add(i);
        }

    }
}
