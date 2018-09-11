﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using FileExplorer.Logic.FileManager.Interfaces;

namespace FileExplorer.Logic.FileManager
{
    class WindowsFileManager : Interfaces.IFileManager
    {
        internal List<Logic.Item.Item> IFileManager.GetFolderContents(string path)
        {
            List<Logic.Item.Item> list = new List<Logic.Item.Item>();
            DirectoryInfo direInfo = new DirectoryInfo(path);
            foreach (var item in direInfo.EnumerateFileSystemInfos())
            {
                FileInfo fi = new FileInfo(item.FullName);
                list.Add(new Item.Item(item.FullName, item.Name, fi.Length, item.Extension, GetOwner(fi), fi.CreationTime, !fi.IsReadOnly, fi.Attributes));
            }
            return list;
        }
        private string GetOwner(FileInfo fi)
        {
            IdentityReference idref = fi.GetAccessControl().GetOwner(typeof(SecurityIdentifier));
            string[] arr = idref.Translate(typeof(NTAccount)).ToString().Split('\\');
            return arr[1];
        }
    }
}