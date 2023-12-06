using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WinFormPoC
{
    public partial class ClientPoCExcelTestForm : Form
    {
        private string SqlQuery = string.Empty;
        public ClientPoCExcelTestForm(string sqlQuery)
        {
            InitializeComponent();
            this.SqlQuery = sqlQuery;
        }

        private void ClientPoCExcelTestForm_Load(object sender, EventArgs e)
        {
            UpdateQueryText.Text = SqlQuery;
        }
    }
    
    
}
