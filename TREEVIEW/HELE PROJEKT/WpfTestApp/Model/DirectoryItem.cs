using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace WpfTestApp.Model
{
    public class DirectoryItem : Item
    {
        private List<Item> _items;
        public List<Item> Items { get => this._items; set { this._items = value; OnPropertyChanged(); } }

        public DirectoryItem()
        {
            Items = new List<Item>();
        }

        private event EventHandler PropertyChanged;

        public void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new EventArgs());
        }
    }
}
