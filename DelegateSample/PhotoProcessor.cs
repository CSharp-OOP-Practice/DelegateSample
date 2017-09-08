using System;

namespace DelegateSample
{
    public class PhotoProcessor
    {
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            // 執行委派參數有參考到的方法
            filterHandler(photo);

            photo.Save();
        }
    }
}
