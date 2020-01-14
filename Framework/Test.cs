using System;
using System.Collections.Generic;
using System.Text;

namespace EchoPractice4Test.Framework
{
    abstract class TestInstruction
    {
        public abstract void Run();
    }

    class Test
    {
        List<TestInstruction> mInstructions;

        Test(List<TestInstruction> l)
        {
            mInstructions = l;
        }
        ~Test()
        {

        }

        public void Run()
        {
            foreach (var instruction in mInstructions)
            {
                instruction.Run();
            }
        }
    }
}
