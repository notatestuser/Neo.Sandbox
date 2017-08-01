using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Neo.Compiler.MSIL;
using Neo.Cryptography;
using Neo.VM;

namespace Testbox.Utilities
{
    public static class CompileAndRun
    {
        private const string SmartContractDirectory = "../../../../";

        public static byte[] Compile(string projectName)
        {
            return Converter.Convert(new FileStream(Path.Combine(SmartContractDirectory, projectName, @"bin\Debug", $"{projectName}.dll"), FileMode.Open));
        }

        public static void Run(byte[] program)
        {
            ExecutionEngine ee = new ExecutionEngine(null, Crypto.Default, null, null);
            ee.LoadScript(program);
            ee.Execute();
        }
    }
}
