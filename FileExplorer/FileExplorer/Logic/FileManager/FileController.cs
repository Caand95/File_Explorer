using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Logic.FileManager
{
    class FileController
    {
        Interfaces.IFileManager man;
        public FileController(string fileSystem)
        {
            if (fileSystem == "win")
            {
                man = new WindowsFileManager();
            }
            else if (fileSystem == "unix")
            {
                //man = new UnixFileSystem();
            }
        }
        public List<Item.Item> GetFolderContents(string path)
        {
            return man.GetFolderContents(path);
        }
    }
}
