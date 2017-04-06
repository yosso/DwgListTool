using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwgListTool
{
    public class XLWorkBook
    {
        private string _wrkBookName;
        private string _path;

        public XLWorkBook(string WrkBookName, string Path)
        {
            this._path = Path;
            this._wrkBookName = WrkBookName;
        }

        public string WrkBookName { get; set; }
        public string Path { get; set; }

    }
}
