using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Logic.Item
{
    public class Item
    {
        //Attributes
        internal string _path;
        internal string _name;
        internal string _size;
        internal string _owner;
        internal FileType _type;
        internal DateTime _creationDate;
        internal bool _isWriteProtected;

        //Properties
        internal string Path { get { return this._path; } set { this._path = value; OnPropertyChanged(); } }
        internal string Name { get { return this._name; } set { this._name = value; OnPropertyChanged(); } }
        internal string Size { get { return this._size; } set { this._size = value; OnPropertyChanged(); } }
        internal string Owner { get { return this._owner; } set { this._owner = value; OnPropertyChanged(); } }
        internal FileType Type { get { return this._type; } set { this._type = value; OnPropertyChanged(); } }
        internal DateTime CreationDate { get { return this._creationDate; } set { this._creationDate = value; OnPropertyChanged(); } }
        internal bool IsWriteProtected { get { return this._isWriteProtected; } set { this._isWriteProtected = value; OnPropertyChanged(); } }

        //EventHandlers
        internal event EventHandler PropertyChanged;

        public void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new EventArgs());
        }

        //Constructor
        internal Item() { }
        internal Item(string path, string name, string size, string owner, FileType type, DateTime creationDate, bool writeprotection)
        {
            this._path = path;
            this._name = name;
            this._size = size;
            this._owner = owner;
            this._type = type;
            this._creationDate = creationDate;
            this._isWriteProtected = writeprotection;
        }
        //Methods
        internal virtual string Open()
        {
            return $"{this.Path}";
        }

    }
}
