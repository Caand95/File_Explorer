using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Logic.Item
{
    public abstract class ItemManager
    {

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
    }
}
