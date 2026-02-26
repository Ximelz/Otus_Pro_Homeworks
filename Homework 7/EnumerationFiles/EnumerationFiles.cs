namespace Homework_7
{
    public class EnumerationFiles
    {
        public delegate int FilesEventHandler(FileArgs e);
        public event FilesEventHandler FileFound;
        public EnumerationFiles() => FileFound += (e) => { return 0; };
        public void StartEnumeration(string path)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                var files = dir.GetFiles();
                foreach (var file in files)
                {
                    var code = FileFound(new FileArgs() { fileName = file.Name });
                    if (code == 1)
                        return;
                }
            }
            catch
            {
                throw;
            }
        }
    }

    public class FileArgs : EventArgs
    {
        public string fileName;
    }
}
