using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Logic.Item
{
    public class Item
    {
        //Properties
        internal string Path { get; set; }
        internal string Name { get; set; }
        internal string Size { get; set; }
        internal string Owner { get; set; }
        internal FileType Type { get; set; }
        internal DateTime CreationDate { get; set; }
        internal bool IsWriteProtected { get; set; }

        //Constructor
        internal Item() { }
        internal Item(string path, string name, string size, string owner, FileType type, DateTime creationDate, bool writeprotection)
        {
            this.Path = path;
            this.Name = name;
            this.Size = size;
            this.Owner = owner;
            this.Type = type;
            this.CreationDate = creationDate;
            this.IsWriteProtected = writeprotection;
        }
        //Methods
        internal virtual string Open()
        {
            return $"{this.Path}";
        }

    }
}
