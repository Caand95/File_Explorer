using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Logic.Item
{
    class Folder : Item
    {
        internal List<Item> ListofItems { get; set; }

        internal override string Open()
        {
            return $"{this.Path}{this.Name}/";
        }
    }
}
