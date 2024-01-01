using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormPoC
{
    public partial class ClientExcelWithEpPlusForm : Form
    {
        private ExcelPackage excelPackage;
        private string fname = string.Empty;
        private bool isComboboxChanged = false;
        public ClientExcelWithEpPlusForm()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            this.Text = Properties.Resources.EpPlusFormTitle;
            UploadExcelBtn.Text = Properties.Resources.BtnUploadExcel;
            comboBoxEpPlus.SelectedIndex = -1;
        }

        private void UploadExcelBtn_Click(object sender, EventArgs e)
        {
            fname = "";
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select a Excel File";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Excel Files|*.xlsx;*.xls|All Files|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fname = fdlg.FileName;
            }

            if (fname.Length > 0)
            {
                try
                {
                    excelPackage = null;
                    using (excelPackage = new ExcelPackage(new FileInfo(fname)))
                    {
                        List<string> worksheetNames = new List<string>();
                        foreach (var worksheet in excelPackage.Workbook.Worksheets)
                        {
                            worksheetNames.Add(worksheet.Name);
                        }
                        comboBoxEpPlus.DataSource = null;
                        comboBoxEpPlus.Items.Clear();
                        isComboboxChanged = false;
                        comboBoxEpPlus.DataSource = worksheetNames;
                        comboBoxEpPlus.SelectedIndex = -1;
                        isComboboxChanged = true;
                        dataGridViewEpPlus.Rows.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading Excel file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        static string GetMergedCellValue(ExcelWorksheet worksheet, int row, int column)
        {
            string mergedCellRef = worksheet.MergedCells[row, column];

            if (mergedCellRef != null)
            {
                return worksheet.Cells[mergedCellRef].Text;
            }
            else
            {
                return worksheet.Cells[row, column].Text;
            }
        }
        private void comboBoxEpPlus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEpPlus.SelectedIndex != -1 && isComboboxChanged)
            {
                try
                {
                    string selectedSheetName = comboBoxEpPlus.SelectedItem.ToString();
                    using (excelPackage = new ExcelPackage(new FileInfo(fname)))
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[selectedSheetName];

                        if (worksheet != null && worksheet.Dimension != null)
                        {
                            int rowCount = worksheet.Dimension.Rows;
                            int colCount = worksheet.Dimension.Columns;
                            dataGridViewEpPlus.Rows.Clear();
                            dataGridViewEpPlus.ColumnCount = colCount;
                            dataGridViewEpPlus.RowCount = rowCount;
                            progressBarEpPlus.Maximum = rowCount;
                            progressBarEpPlus.Minimum = 0;

                            for (int row = 1; row <= rowCount; row++)
                            {
                                progressBarEpPlus.Value = row;
                                double perc = Convert.ToDouble(row) / Convert.ToDouble(rowCount);
                                ProgressBarLabel.Text = (perc * 100).ToString("F2") + "%";
                                //ProgressBarLabel.Invalidate();
                                ProgressBarLabel.Refresh();
                                for (int col = 1; col <= worksheet.Dimension.Columns; col++)
                                {
                                    var cellValue = GetMergedCellValue(worksheet, row, col);
                                    dataGridViewEpPlus.Rows[row - 1].Cells[col - 1].Value = cellValue;
                                }
                            }
                            
                        }
                        else
                        {
                            dataGridViewEpPlus.Rows.Clear();
                            MessageBox.Show("This worksheet is empty.","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading Excel file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }
        }
    }
}
