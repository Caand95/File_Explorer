using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Logic.Item
{
    public abstract class ItemManager
    {
        //Attributes & Properties
        internal Folder _currentFolder;
        internal Folder CurrentFolder { get { return this._currentFolder; } set { this._currentFolder = value; OnPropertyChanged(); } }



        //Methods
        public List<Item> GetContent(Folder folder)
        {
            return folder.ListofItems;
        }

        public string Open(Item item)
        {
            return item.Open();
        }
        public string GetPath(Item item)
        {
            return item.Path;
        }
        public string GetName(Item item)
        {
            return item.Name;
        }
        public string GetFileType(Item item)
        {
            return $"{item.Type}";
        }
        public string GetSize(Item item)
        {
            return item.Size;
        }
        public DateTime GetLastModifiedDate(Item item)
        {
            if (item is Folder || item.Type.ToString() == "Archive" )
                return item.CreationDate;
            else
                return (item as File).ModifiedDate;
        }
        public string GetRunCommand(Item item)
        {
            if (item is File)
                return (item as File).Open();
            else
                return "Cannot execute!";
        }
    }
}
