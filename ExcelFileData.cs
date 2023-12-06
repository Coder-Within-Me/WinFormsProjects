using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OfficeOpenXml.ExcelErrorValue;

namespace WinFormPoC
{
    public partial class ExcelFileData : Form
    {
        private int RGB(int red, int green, int blue)
        {
            return red + (green << 8) + (blue << 16);
        }
        public ExcelFileData(Microsoft.Office.Interop.Excel.Range xLRange)
        {
            InitializeComponent();

            int rowCount = xLRange.Rows.Count;
            int colCount = xLRange.Columns.Count;

            ExcelGridView.ColumnCount = colCount;
            ExcelGridView.RowCount = rowCount;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (xLRange.Cells[i, j] != null && xLRange.Cells[i, j].Value2 != null)
                    {
                        ExcelGridView.Rows[i - 1].Cells[j - 1].Value = xLRange.Cells[i, j].Value2.ToString();
                    }   
                }
            }
        }

        private void ExcelQueryFormationBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            StringBuilder columnsBuilder = new StringBuilder();
            string valueQuery = string.Empty;

            foreach (DataGridViewRow row in ExcelGridView.Rows)
            {
                if (row.Index == 0)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex >= 0)
                        {
                            string columnName = cell.Value?.ToString() ?? null;
                            columnsBuilder.Append($"{columnName}, ");
                        }
                    }
                    string columns = columnsBuilder.ToString().TrimEnd(' ', ',');
                    string insertQuery = $"INSERT INTO MyTable ({columns}) Values";
                    sqlBuilder.AppendLine(insertQuery);
                }
                else if (row.Index > 0)
                {
                    StringBuilder valuesBuilder = new StringBuilder();
                    string values = string.Empty;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex >= 0)
                        {
                            string columnValue = cell.Value?.ToString() ?? null;
                            valuesBuilder.Append($"'{columnValue}', ");
                        }

                    }
                    values = valuesBuilder.ToString().TrimEnd(' ', ',');
                    valueQuery += $"({values}), " + System.Environment.NewLine;
                }
            }
            valueQuery = valueQuery.TrimEnd(' ', ',');
            sqlBuilder.AppendLine(valueQuery);
            string sqlQueries = sqlBuilder.ToString();
            DisplaySQLQueryForm displaySQLQueryForm = new DisplaySQLQueryForm(sqlQueries);
            displaySQLQueryForm.ShowDialog();
        }
    }
}
