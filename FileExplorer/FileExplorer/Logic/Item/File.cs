using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Logic.Item
{
    internal class File : Item
    {
        //Properties
        internal DateTime LastOpenedDate { get; set; }
        internal DateTime ModifiedDate { get; set; }
        internal string CommandToRun { get; set; }

        //Constructors
        internal File() : base() { }
        internal File(string path, string name, string size, string owner, FileType type, DateTime creationDate, bool writeprotection, DateTime lastOpenedDate, DateTime modifiedDate, string commandToRun) : base(path, name, size, owner, type, creationDate, writeprotection)
        {
            this.LastOpenedDate = lastOpenedDate;
            this.ModifiedDate = modifiedDate;
            this.CommandToRun = commandToRun;
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
