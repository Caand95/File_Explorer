using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.Logic.Item
{
    enum FileType
    {
        ReadOnly,
        Hidden,
        System,
        Directory,
        Archive,
        Device,
        Normal,
        Temporary,
        SparseFile,
        ReparsePoint,
        Compressed,
        Offline,
        NotContentIndexed,
        Encrypted,
        IntegrityStream,
        NoScrubData
    }
}
