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
    public partial class EditNoteForm : Form
    {
        public string Title { get; set; }
        public string Msg { get; set; }
        public EditNoteForm(string title, string msg)
        {
            InitializeComponent();
            Title = title;
            TitleText1.Text = Title;
            Msg = msg;
            msgText1.Text = Msg;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (TitleText1.Text != "")
            {
                Title = TitleText1.Text;
                Msg = msgText1.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter Title.");
            }
        }
    }
}
