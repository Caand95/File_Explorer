using System.Collections.Generic;
using System.IO;
using WpfTestApp.Model;

namespace WpfTestApp
{
    public class ItemProvider
    {
        public List<Item> GetTree(string path)
        {
            var items = new List<Item>();

            var dirInfo = new DirectoryInfo(path);

            foreach (var directory in dirInfo.GetDirectories("*",SearchOption.AllDirectories))
            {
                if (directory.Exists)
                {

                    var item = new DirectoryItem
                    {
                        Name = directory.Name,
                        Path = directory.FullName,
                        Items = GetTree(directory.FullName)
                    };

                    items.Add(item);
                }
            }

            foreach (var file in dirInfo.GetFiles())
            {
                if (file.Exists)
                {

                    var item = new FileItem
                    {
                        Name = file.Name,
                        Path = file.FullName
                    };

                    items.Add(item);
                }
            }

            return items;
        }
    }
}