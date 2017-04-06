using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
//using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace DwgListTool

// Helpful Links:
// http://stackoverflow.com/questions/3066603/opening-ms-excel-worksheet-in-c-sharp
// http://www.leniel.net/2009/07/creating-excel-spreadsheets-xls-xlsx-c.html
//
// Program Flow - no-blocking UI
// https://blogs.msdn.microsoft.com/pfxteam/2011/01/13/await-and-ui-and-deadlocks-oh-my/
//
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Load the UI form
            Application.Run(new MainForm());
            
            MessageBox.Show("File Selected!");
            MessageBox.Show(string.Format("Global Variable Test: {0}", GlobalVar.MasterData), "DEBUG TIME");
        }
    }
}
