using System;

namespace DelegateSample
{
    delegate string TestDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            TestDelegate testDelegate = TestMethod;
            Console.WriteLine(testDelegate());
        }

        private static string TestMethod()
        {
            return "測試委派成功";
        }
    }
}
