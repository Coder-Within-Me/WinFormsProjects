using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormPoC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void NoteListAppBtn_Click(object sender, EventArgs e)
        {
            NoteApp noteAppForm = new NoteApp();
            noteAppForm.Show();
        }

        private void EmplayeeFormBtn_Click(object sender, EventArgs e)
        {
            EmployeeDetailsForm emplayeeFormForm = new EmployeeDetailsForm();
            emplayeeFormForm.Show();
        }

        private void ViewEmpDetailsBtn_Click(object sender, EventArgs e)
        {
            ViewEmployeeDetails viewEmployeeDetails = new ViewEmployeeDetails();
            viewEmployeeDetails.Show();
        }

        private void ExcelFormBtn_Click(object sender, EventArgs e)
        {
            string fname = "";
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Excel File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fname = fdlg.FileName;
            }

            if (fname.Length > 0)
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fname);
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

                ExcelFileData excelFileData = new ExcelFileData(xlRange);
                excelFileData.Show();

                //cleanup  
                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                //close and release  
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                //quit and release  
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
        }

        private void ExcelFormBtn_MouseHover(object sender, EventArgs e)
        {
            ExcelNoteText.Visible = true;
        }

        private void ExcelFormBtn_MouseLeave(object sender, EventArgs e)
        {
            ExcelNoteText.Visible = false;
        }
    }
}
