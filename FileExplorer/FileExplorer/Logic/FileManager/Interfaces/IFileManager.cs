﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Logic.FileManager.Interfaces
{
    interface IFileManager
    {
        List<Item.Item> GetFolderContents(string path);
    }
}
