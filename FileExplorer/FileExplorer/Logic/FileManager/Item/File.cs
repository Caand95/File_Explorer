using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Logic.FileManager.Item
{
    internal class File : Item
    {
        //Properties
        internal DateTime LastOpenedDate { get; set; }
        internal DateTime ModifiedDate { get; set; }
        internal string CommandToRun { get; set; }
        internal string Extention { get; set; }

        //Constructors
        internal File(string path, string name, string size, string owner, FileType type, DateTime creationDate, bool writeprotection, DateTime lastOpenedDate, DateTime modifiedDate, string extention) : base(path, name, size, owner, type, creationDate, writeprotection)
        {
            this.LastOpenedDate = lastOpenedDate;
            this.ModifiedDate = modifiedDate;
            this.CommandToRun = "start " + path;
            this.Extention = extention;
        }

        //Methods
        internal override string Open()
        {
            return $"{this.CommandToRun}";
        }
        internal string GetPath()
        {
            return $"{this.Path}";
        }

    }
}
