using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace FileExplorer.GUI.Converters
{
    class ItemToImageConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Logic.FileManager.Item.File fi)
            {
                return @"/FileExplorer;component/GUI/Images/File.png";
            }
            else if (value is Logic.FileManager.Item.LinkFile)
            {
                return @"/FileExplorer;component/GUI/Images/LinkFile.png";
            }
            else if (value is Logic.FileManager.Item.Folder)
            {
                return @"/FileExplorer;component/GUI/Images/Folder.png";
            }
            else
                return @"/FileExplorer;component/GUI/Images/SomeFile.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
