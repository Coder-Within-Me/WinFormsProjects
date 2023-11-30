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
    public partial class EmployeeDetailsForm : Form
    {
        public EmployeeDetailsForm()
        {
            InitializeComponent();

            var hiddenTextBox = new TextBox();
            hiddenTextBox.Text = "0";
            hiddenTextBox.Visible = false;
            Controls.Add(hiddenTextBox);
        }

        public EmployeeDetailsForm(EmployeeDetailsModel empModel)
        {
            InitializeComponent();

            var hiddenTextBox = new TextBox();
            hiddenTextBox.Text = empModel.Id.ToString();
            hiddenTextBox.Visible = false;
            Controls.Add(hiddenTextBox);
        }

        public void clear()
        {
            NameText.Text = string.Empty;
            SurnameText.Text = string.Empty;
            dobDatePicker.Text = string.Empty;
            foreach (Control control in Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
            AddressText.Text = string.Empty;
            MaritalStatusComboBox.SelectedIndex = -1;
            NationalityText.Text = string.Empty;
            EmployerText.Text = string.Empty;
            DesignationText.Text = string.Empty;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (NameText.Text != "")
            {
                string gender = "";
                foreach (Control control in Controls)
                {
                    if (control is RadioButton radioButton && radioButton.Checked)
                    {
                        gender = radioButton.Text;
                    }
                }
                EmployeeDetailsModel employeeDetailsModels = new EmployeeDetailsModel
                {
                    Name = NameText.Text,
                    Surname = SurnameText.Text,
                    DOB = dobDatePicker.Value,
                    Gender = gender,
                    Address = AddressText.Text,
                    MaritalStatus = MaritalStatusComboBox.Text,
                    Nationality = NationalityText.Text,
                    Employer = EmployerText.Text,
                    Designation = DesignationText.Text,
                };
                DataAccessLayer accessLayer = new DataAccessLayer();
                accessLayer.AddEmployeeDetails(employeeDetailsModels);
                clear();
            }
            else
            {
                MessageBox.Show("Please enter employee name.");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void EmployeeDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
