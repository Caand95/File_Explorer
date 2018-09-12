using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.FileManager.Item
{
    class LinkFile: File
    {
        //Attributes
        internal string _linkPath;
        internal string[] _runArgs;
        internal FileType _runtype;
        internal string _comment;
        //Properties
        internal string LinkPath { get { return this._linkPath; } set { this._linkPath = value; OnPropertyChanged(); } }
        internal string[] RunArgs { get { return this._runArgs; } set { this._runArgs = value; OnPropertyChanged(); } }
        internal FileType RunFileType { get { return this._runtype; } set { this._runtype = value; OnPropertyChanged(); } }
        internal string Comment { get { return this._comment; } set { this._comment = value; OnPropertyChanged(); } }

        //Constructors
        internal LinkFile(): base() { }
        internal LinkFile(string path, string name, string size, string owner, FileType type, DateTime creationDate, bool writeprotection, DateTime lastOpenedDate, DateTime modifiedDate, string commandToRun, string linkPath, string[] runArgs, FileType runfileType, string comment) : base(path, name, size, owner, type, creationDate, writeprotection, lastOpenedDate, modifiedDate, commandToRun) // sorry had to
        {
            this.LinkPath = linkPath;
            this.RunArgs = runArgs;
            this.RunFileType = runfileType;
            this.Comment = comment;
        }

        //Methods
        internal override string Open()
        {
            string output = $"\"{this.CommandToRun}\" ";
            foreach (string arg in RunArgs)
            {
                output += $"{arg} ";
            }
            return output;
        }
        internal string Link()
        {
            return $"{this.LinkPath}";
        }

    }
}
 