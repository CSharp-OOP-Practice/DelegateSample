namespace DelegateSample
{
    public class PhotoProcessor
    {
        // 定義委派
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            // 執行委派參數有參考到的方法
            filterHandler(photo);

            photo.Save();
        }
    }
}
