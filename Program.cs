using System;
using sxfsharp.builders;
using sxfsharp.reads;

namespace sxfsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestObject testObject = new TestObject();
            testObject.testObject = new TestObject();
            string input = Sxf.Convert(testObject, ConvertFieldSetting.ALL);
            Console.WriteLine(input);

            Console.WriteLine("Hello World!");
        }
    }
}