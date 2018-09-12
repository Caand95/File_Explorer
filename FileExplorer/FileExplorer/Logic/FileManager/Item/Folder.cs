using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Logic.Item
{
    class Folder : Item
    {
        //Attributes & Properties
        internal List<Item> _listofItems;
        internal List<Item> ListofItems { get { return this._listofItems; } set { this._listofItems = value; OnPropertyChanged(); } }

        //Constructors
        internal Folder(): base() { }
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
