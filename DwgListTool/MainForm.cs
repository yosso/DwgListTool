using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using g = DwgListTool.GlobalVar;

namespace DwgListTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ProcessFile.Enabled = false;
        }

        private async void BrowseForFile_Click(object sender, EventArgs e)
        {
            // Open a browser window to select an excel file
            Task<String> s = LoadFileAsync();
            this.FileName.Text = await s;

            // Disable browse button
            this.BrowseForFile.Enabled = false;
            // Enable process button
            this.ProcessFile.Enabled = true;

            //// https://www.dotnetperls.com/openfiledialog

        }
        // 4/5/17 - Working on asynchronous tasks...
        // Async explanation...
        // https://blogs.msdn.microsoft.com/pfxteam/2011/01/13/await-and-ui-and-deadlocks-oh-my/
        // Another async explanation...
        // https://www.codeproject.com/Articles/562021/Asynchronous-models-and-patterns
        //
        private async Task<string> LoadFileAsync()
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)// Test Result
            {
                // MessageBox.Show(string.Format("File selected: {0}", openFileDialog1.CheckPathExists  ),"TEST DIALOG"); 
                string fn = openFileDialog1.FileName;
                return fn;
            }
            else
            {
                return null;
            }
        }

        private void ProcessFile_Click(object sender, EventArgs e)
        {
            // Load the selected file into a temporary workbook
            string s = this.FileName.Text;

            //string p = Path.GetFullPath(s);
            //string f = Path.GetFileName(s);

            g.WkBkData = new DwgListTool.XLWorkBook(Path.GetFullPath(s), Path.GetFileName(s));

            // Process the selected workbook
            ProgramProcess.ProcessWorkbook(g.WkBkData);
            // this.Visible = false;
            
        }
    }
}
