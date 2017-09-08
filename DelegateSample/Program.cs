using System;

namespace DelegateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();

            // 符合委派定義的方法 指向給委派變數
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEye;

            // 傳遞的委派變數
            photoProcessor.Process("test", filterHandler);
        }

        static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Remove red eye");
        }
    }
}
