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
    public partial class ViewEmployeeDetails : Form
    {
        public ViewEmployeeDetails()
        {
            InitializeComponent();
        }

        private void ViewEmployeeDetails_Load(object sender, EventArgs e)
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            EmpGridView.DataSource = dataAccessLayer.GetAllEmpployeeDetails();
        }
    }
}
