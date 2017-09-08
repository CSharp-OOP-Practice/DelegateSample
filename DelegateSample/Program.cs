using System;

namespace DelegateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();

            // 使用.NET generic Action Delegate
            System.Action<Photo> filterHandler = filters.ApplyBrightness;
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
