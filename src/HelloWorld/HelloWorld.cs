using System;
using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;

namespace HelloWorld
{
    public class HelloWorld : FunctionCode
    {
        public static void Main()
        {
            Storage.Put(Storage.CurrentContext, "Hello", "World");
        }
    }
}
