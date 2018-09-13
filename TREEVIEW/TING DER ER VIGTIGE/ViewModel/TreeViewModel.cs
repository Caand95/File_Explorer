using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTestApp.Model;

using WpfTestApp.Properties;


namespace WpfTestApp.ViewModel
{
    class TreeViewModel
    {
        public static string currentfolder = "";

        public ItemProvider itemProvider = new ItemProvider();
        public ObservableCollection<Item> items;
        public ObservableCollection<Item> Items { get { return this.items; } set { this.items = value; } }

        public TreeViewModel()
        {

            //currentfolder = DriveInfo.GetDrives().ToList()[0].RootDirectory.ToString();
            currentfolder = @"C:\ccfs";
        this.items = new ObservableCollection<Item>(new ItemProvider().GetTree(currentfolder));
    }
    }
}
