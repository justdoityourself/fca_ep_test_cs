using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EchoPractice4Test.Framework
{
    class Collection : IEnumerable<Test>
    {
        List<Test> mTests;

        Collection()
        {
            mTests = new List<Test>();
        }

        void AddTest(Test test)
        {
            mTests.Add(test);
        }

        public IEnumerator<Test> GetEnumerator()
        {
            foreach (Test test in mTests)
            {
                yield return test;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
