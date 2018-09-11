using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Logic.Item
{
    abstract class Item
    {
        private string path;
        private string name;
        private string size;
        private string owner;
        private FileType type;
        private DateTime creationDate;
        private bool isWriteProtected;

        internal string Path { get; set; }
        internal string Name { get; set; }
        internal string Size { get; set; }
        internal string Owner { get; set; }
        internal FileType Type { get; set; }
        internal DateTime CreationDate { get; set; }
        internal bool IsWriteProtected { get; set; }

        public abstract void Open();

    }
}
