using System;
using Neo.Cryptography;
using Neo.VM;
using Testbox.Utilities;
using Xunit;

namespace Testbox
{
    public class Test_HelloWorld
    {
        [Fact]
        public void HelloWorld()
        {
            byte[] program = CompileAndRun.Compile(nameof(HelloWorld));

           CompileAndRun.Run(program);
        }
    }
}
