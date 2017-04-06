using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace DwgListTool
//=============================================================\\
// Global Variable Class 
// Contains constants and static objects
// which will need to be utilized by various
// methods in the process of merging the
// old and the new.
//=============================================================\\

// https://www.dotnetperls.com/global-variable
{
    public static class GlobalVar
    {
        // Define the range for copying the original data
        // from the original workbook
        public const string MasterData = "A6:AD283";
        public const string ContractData = "E6:AB6";
        public const string ProjData = "J1:J7";
        public const string ProjCategories = "N1:023";

        // Temporary XLWorkbook 
        public static XLWorkBook WkBkData;

        // Temporary Excel Workbook
        public static Excel.Workbook XLTemp;

        // New Excel Workbook created from merging the existing
        // into the template
        public static Excel.Workbook XLNew;

    }
}
