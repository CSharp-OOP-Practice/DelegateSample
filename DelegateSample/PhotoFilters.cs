using System;

namespace DelegateSample
{
    internal class PhotoFilters
    {
        internal void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        internal void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }

        internal void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }
}