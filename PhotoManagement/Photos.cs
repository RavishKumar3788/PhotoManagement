namespace PhotoManagement
{
    public class Photos
    {
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string Path { get; set; }
        public Photos(string fileName, string path, string extension)
        {
            FileName = fileName;
            Path = path;
            Extension = extension;
        }
    }
}
