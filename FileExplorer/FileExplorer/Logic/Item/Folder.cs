using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Logic.Item
{
    class Folder : Item
    {
        internal List<Item> _listofItems;
        internal List<Item> ListofItems { get { return this._listofItems; } set { this._listofItems = value; OnPropertyChanged(); } }

        internal override string Open()
        {
            return $"{this.Path}{this.Name}/";
        }
    }
}
