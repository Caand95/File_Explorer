﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using FileExplorer.Logic.FileManager.Interfaces;
using FileExplorer.Logic.FileManager.Item;

namespace FileExplorer.Logic.FileManager
{
    class WindowsFileManager : Interfaces.IFileManager
    {
        List<Item.Item> IFileManager.GetFolderContents(string path)
        {
            List<Item.Item> list = new List<Item.Item>();
            DirectoryInfo direInfo = new DirectoryInfo(path);
            foreach (var item in direInfo.EnumerateFileSystemInfos())
            {
                FileInfo fi = new FileInfo(item.FullName);
                list.Add(CreateItem(fi, item));
            }
            return list;
        }
        private string GetOwner(FileInfo fi)
        {
            IdentityReference idref = fi.GetAccessControl().GetOwner(typeof(SecurityIdentifier));
            string[] arr = idref.Translate(typeof(NTAccount)).ToString().Split('\\');
            return arr[1];
        }
        private Item.Item CreateItem(FileInfo fi, FileSystemInfo item)
        {
            if (item.Attributes == FileAttributes.Directory)
            {
                return ItemFactory.CreateFolder(item.FullName, item.Name, fi.Length.ToString(), GetOwner(fi), (Item.FileType)item.Attributes, item.CreationTime, !fi.IsReadOnly);
            }
            else if (ItemIsLink(item))
            {
                return CreateLinkItem(item, fi);
            }
            else
            {
                return ItemFactory.CreateFile(item.FullName, item.Name, fi.Length.ToString(), GetOwner(fi), (Item.FileType)item.Attributes, item.CreationTime, !fi.IsReadOnly, item.LastAccessTime, item.LastWriteTime, item.Extension);
            }
        }
        private bool ItemIsLink(FileSystemInfo item)
        {
            string directory = Path.GetDirectoryName(item.FullName);
            string file = Path.GetFileName(item.FullName);

            Shell32.Shell shell = new Shell32.Shell();
            Shell32.Folder folder = shell.NameSpace(directory);
            Shell32.FolderItem folderItem = folder.ParseName(file);

            if (folderItem != null)
            {
                return folderItem.IsLink;
            }

            return false;
        }
        private LinkFile CreateLinkItem(FileSystemInfo item, FileInfo fi)
        {
            string directory = Path.GetDirectoryName(item.FullName);
            string file = Path.GetFileName(item.FullName);
            Shell32.Shell shell = new Shell32.Shell();
            Shell32.Folder folder = shell.NameSpace(directory);
            Shell32.FolderItem folderItem = folder.ParseName(file);
            Shell32.ShellLinkObject link = (Shell32.ShellLinkObject)folderItem.GetLink;
            return ItemFactory.CreateLink(item.FullName, item.Name, fi.Length.ToString(), GetOwner(fi), (FileType)item.Attributes, item.CreationTime, !fi.IsReadOnly, item.LastAccessTime, item.LastWriteTime, item.Extension, link.Path, link.Arguments, link.Description);
        }

        /// <summary>
        /// return the root of the specified path
        /// use "c" for c drive etc. etc.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string GetRootDirectory(string path)
        {
            return Directory.GetDirectoryRoot(path);
        }
    }
}
