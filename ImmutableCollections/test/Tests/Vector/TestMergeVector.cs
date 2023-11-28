using ImmutableCollections.Vectors;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Vector
{
    [TestClass()]
    public class TestMergeVector
    {
        const int SIZE = 1_000_000;

        [TestMethod()]
        public void test_init()
        {
            var ms_list = ImmutableList<int>.Empty;
            for(int i=0;i<SIZE;i++) ms_list = ms_list.Add(i);  
        }

    }
}
