using System;

namespace DelegateSample
{
    delegate string TestDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            //TestDelegate testDelegate = TestMethod;
            //Console.WriteLine(testDelegate());
            var photoProcessor = new PhotoProcessor();
            photoProcessor.Process("test");
        }

        private static string TestMethod()
        {
            return "測試委派成功";
        }
    }
}
