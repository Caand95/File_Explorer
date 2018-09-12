using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Logic.FileManager.Item
{
    class Folder : Item
    {
        //Attributes & Properties
        internal List<Item> ListofItems { get; set; }

        //Constructors
        internal Folder(string path, string name, string size, string owner, FileType type, DateTime creationDate, bool writeprotection) : base(path, name, size, owner, type, creationDate, writeprotection)
        {

        }

        //Methods
        internal override string Open()
        {
            return $"{this.Path}{this.Name}/";
        }
    }
}
