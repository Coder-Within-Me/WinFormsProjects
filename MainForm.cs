using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace WinFormPoC
{
    public partial class MainForm : Form
    {
        private BackgroundWorker worker = null;
        string fname = string.Empty;
        private LoadingForm loadingForm;
        private Microsoft.Office.Interop.Excel.Range xLRange;
        //string sqlQuery = string.Empty;
        public MainForm()
        {
            InitializeComponent();
            ExcelPoCBtn.Text = Properties.Resources.buttonName;
            btnEpPlus.Text = Properties.Resources.BtnNameEpPlus;
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
        //private int RGB(int red, int green, int blue)
        //{
        //    return red + (green << 8) + (blue << 16);
        //}
        private void ExcelPoCBtn_Click(object sender, EventArgs e)
        {
            fname = "";
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
                //usedRange.AutoFilter(Field: 1, Criteria1: 255, Operator: Excel.XlAutoFilterOperator.xlFilterCellColor);
                //Excel.Range rangeRed = usedRange.SpecialCells(Excel.XlCellType.xlCellTypeVisible);
                ////usedRange.AutoFilter();


                //usedRange.AutoFilter(Field: 1, Criteria1: 65280, Operator: Excel.XlAutoFilterOperator.xlFilterCellColor);
                //Excel.Range rangeGreen = usedRange.SpecialCells(Excel.XlCellType.xlCellTypeVisible);
                ////usedRange.AutoFilter();

                //usedRange.AutoFilter(Field: 2, Criteria1: "<>*Mayur*", Operator: Excel.XlAutoFilterOperator.xlFilterValues);

                //Excel.Range rangeYellow = usedRange.SpecialCells(Excel.XlCellType.xlCellTypeVisible);
                ////usedRange.AutoFilter();

                //xlWorkbook.Saved = true;
                //xlWorkbook.Close(false);

                backgroundWorker = new BackgroundWorker();
                backgroundWorker.WorkerReportsProgress = true;
                backgroundWorker.DoWork += BackgroundWorker_DoWork;
                backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
                backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;

                loadingForm = new LoadingForm(backgroundWorker);
                loadingForm.FormClosing += LoadingForm_FormClosing;
                loadingForm.Show();

                backgroundWorker.RunWorkerAsync();
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            worker = sender as BackgroundWorker;
            string sqlQuery = "";
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fname);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xLRange = xlWorksheet.UsedRange;
            //Excel.Application excelApp = new Excel.Application();
            //Excel.Workbook workbook = excelApp.Workbooks.Open("");
            //Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

            //Microsoft.Office.Interop.Excel.Range xLrange1 = xLRange;
            //Microsoft.Office.Interop.Excel.Range xLrange2 = xLRange;

            //xLrange1.AutoFilter(Field: 1, Criteria1: (255, 0, 0), Operator: Excel.XlAutoFilterOperator.xlFilterCellColor);

            int rowCount = xLRange.Rows.Count;
            int colCount = xLRange.Columns.Count;

            //ClientExceldataGridView.ColumnCount = colCount;
            //ClientExceldataGridView.RowCount = rowCount;

            //for (int i = 1; i <= rowCount; i++)
            //{
            //    for (int j = 1; j <= colCount; j++)
            //    {
            //        if (xLRange.Cells[i, j] != null && xLRange.Cells[i, j].Value2 != null)
            //        {
            //            ClientExceldataGridView.Rows[i - 1].Cells[j - 1].Value = xLRange.Cells[i, j].Value2.ToString();
            //        }
            //    }
            //}
            List<columnNames> names = new List<columnNames>();
            StringBuilder updateQueries = new StringBuilder();
            StringBuilder insertQueries = new StringBuilder();
            bool flag = false;
            try
            {
                for (int i = 1; i <= rowCount; i++)
                {
                        backgroundWorker.ReportProgress((i * 100)/rowCount);
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            //cleanup  
                            GC.Collect();
                            GC.WaitForPendingFinalizers();

                            Marshal.ReleaseComObject(xLRange);
                            //Marshal.ReleaseComObject(rangeYellow);
                            Marshal.ReleaseComObject(xlWorksheet);

                            //close and release  
                            xlWorkbook.Close();
                            Marshal.ReleaseComObject(xlWorkbook);

                            //quit and release  
                            xlApp.Quit();
                            Marshal.ReleaseComObject(xlApp);

                            return;
                    }

                    if (flag)
                    {
                        if (xLRange.Cells[i, 1].Value != null && string.Equals(xLRange.Cells[i, 1].Value, "Update", StringComparison.OrdinalIgnoreCase))
                        {
                            string query = string.Empty;
                            var UpdateColor = 0.0D;
                            UpdateColor = xLRange.Cells[i, 1].Interior.Color;
                            for (int j = 2; j <= colCount; j++)
                            {
                                string columnName = string.Empty;
                                string columnValue = string.Empty;
                                if (xLRange.Cells[i, j] != null && xLRange.Cells[i, j].Value != null && (UpdateColor == xLRange.Cells[i, j].Interior.Color))
                                {
                                    columnName = names.Where(c => c.columnIndex == j).Select(c => c.columnName).FirstOrDefault();
                                    columnValue = xLRange.Cells[i, j].Value != null ? Convert.ToString(xLRange.Cells[i, j].Value) : string.Empty;
                                }

                                if (query == string.Empty && columnName != string.Empty && columnValue != string.Empty)
                                {
                                    query = string.Format("UPDATE MyTable SET {0} = '{1}',", columnName, columnValue);
                                }
                                else if (columnName != string.Empty && columnValue != string.Empty)
                                {
                                    query += string.Format(" {0} = '{1}',", columnName, columnValue);
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            updateQueries.Append(query.Remove(query.Length - 1));
                            updateQueries.AppendLine("");
                        }
                        else if (xLRange.Cells[i, 1].Value != null && string.Equals(xLRange.Cells[i, 1].Value, "ADD", StringComparison.OrdinalIgnoreCase))
                        {
                            string insertQuery = "INSERT INTO MyTable(";
                            string insertValuesQuery = "VALUE(";
                            var AddColor = 0.0D;
                            AddColor = xLRange.Cells[i, 1].Interior.Color;
                            for (int j = 2; j <= colCount; j++)
                            {
                                string columnName = string.Empty;
                                string columnValue = string.Empty;
                                if (xLRange.Cells[i, j] != null && xLRange.Cells[i, j].Value != null && (AddColor == xLRange.Cells[i, j].Interior.Color))
                                {
                                    columnName = names.Where(c => c.columnIndex == j).Select(c => c.columnName).FirstOrDefault();
                                    columnValue = xLRange.Cells[i, j].Value != null ? Convert.ToString(xLRange.Cells[i, j].Value) : string.Empty;
                                }

                                if (columnName != string.Empty)
                                {
                                    insertQuery += string.Format("{0},", columnName);
                                    insertValuesQuery += string.Format("'{0}',", columnValue == string.Empty ? "" : columnValue);
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            insertQueries.Append(insertQuery.Remove(insertQuery.Length - 1) + ")");
                            insertQueries.AppendLine("");
                            insertQueries.Append(insertValuesQuery.Remove(insertValuesQuery.Length - 1) + ")");
                            insertQueries.AppendLine("");
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (string.Equals(xLRange.Cells[i, 1].Value, "Updates Needed", StringComparison.OrdinalIgnoreCase))
                    {
                        flag = true;
                        for (int j = 1; j <= colCount; j++)
                        {
                            if (xLRange.Cells[i, j] != null && xLRange.Cells[i, j].Value != null)
                            {
                                var name = new columnNames()
                                {
                                    columnIndex = j,
                                    columnName = xLRange.Cells[i, j].Value != null ? Convert.ToString(xLRange.Cells[i, j].Value) : "",
                                    columnColor = xLRange.Cells[i, j].Interior.color
                                };
                                names.Add(name);
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                sqlQuery += updateQueries.ToString();
                sqlQuery += insertQueries.ToString();

                e.Result = sqlQuery;
                
                //cleanup  
                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.ReleaseComObject(xLRange);
                //Marshal.ReleaseComObject(rangeYellow);
                Marshal.ReleaseComObject(xlWorksheet);

                //close and release  
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                //quit and release  
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
            catch (Exception ex)
            {
                //cleanup  
                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.ReleaseComObject(xLRange);
                //Marshal.ReleaseComObject(rangeYellow);
                Marshal.ReleaseComObject(xlWorksheet);

                //close and release  
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                //quit and release  
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
            
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled || e.Result == null)
            {
                loadingForm.Close();
            }
            else
            {
                loadingForm.Close();
                ClientPoCExcelTestForm excelFileData = new ClientPoCExcelTestForm(e.Result as string);
                excelFileData.Show();
            }
        }
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadingForm.UpdateProgress(e.ProgressPercentage);
        }
        private void LoadingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
        }

        private void btnEpPlus_Click(object sender, EventArgs e)
        {
            ClientExcelWithEpPlusForm clientExcelWithEpPlusForm = new ClientExcelWithEpPlusForm();
            clientExcelWithEpPlusForm.ShowDialog();
        }
    }
    public class columnNames
    {
        public int columnIndex { get; set; }
        public string columnName { get; set; }
        public double columnColor { get; set; }

    }
}
