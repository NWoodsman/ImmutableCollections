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

        private MergeVector<int> testVector()
        {
            var vec = MergeVector<int>.Empty;
            for (int i = 0; i < SIZE; i++) vec = vec.Add(i);

            return vec;
        }

        [TestMethod()]
        public void test_add()
        {
            var vec =MergeVector<int>.Empty;
            for(int i=0;i<SIZE;i++) vec = vec.Add(i);

            int counter = 0;

            foreach(var i in vec)
            {
                Assert.IsTrue(i == counter);
                counter++;
            }

            Assert.IsTrue(vec.Count == SIZE);
        }

    }
}
