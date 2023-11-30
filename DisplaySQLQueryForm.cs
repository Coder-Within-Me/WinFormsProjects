using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormPoC
{
    public partial class DisplaySQLQueryForm : Form
    {
        private string sqlQuery;
        public DisplaySQLQueryForm(string sqlQuery)
        {
            InitializeComponent();
            this.sqlQuery = sqlQuery;
        }

        private void DisplaySQLQueryForm_Load(object sender, EventArgs e)
        {
            QueryText.Text = sqlQuery;
        }
    }
}
