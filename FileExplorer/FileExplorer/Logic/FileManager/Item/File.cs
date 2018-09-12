using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Logic.Item
{
    internal class File : Item
    {
        //Attributes
        internal DateTime _lastOpenedDate;
        internal DateTime _modifiedDate;
        internal string _commandToRun;

        //Properties
        internal DateTime LastOpenedDate { get { return this._lastOpenedDate; } set { this._lastOpenedDate = value; OnPropertyChanged(); } }
        internal DateTime ModifiedDate { get { return this._modifiedDate; } set { this._modifiedDate = value; OnPropertyChanged(); } }
        internal string CommandToRun { get { return this._commandToRun; } set { this._commandToRun = value; OnPropertyChanged(); } }

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
