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
    public partial class NoteApp : Form
    {
        DataTable notelist;
        public NoteApp()
        {
            InitializeComponent();
        }


        private void NoteApp_Load(object sender, EventArgs e)
        {
            notelist = new DataTable();
            notelist.Columns.Add("Title",typeof(string));
            notelist.Columns.Add("Message", typeof(string));

            
            notelist.Columns["Title"].Unique = true;
            NoteListView.DataSource = notelist;
            NoteListView.Columns["Message"].Visible = false;
            NoteListView.Columns["Title"].Width = 256;
        }
        private void NewBtn_Click(object sender, EventArgs e)
        {
            if (TitleText.Text != "")
            {
                var query = from DataRow row in notelist.Rows
                            where row.Field<string>("Title") == TitleText.Text
                            select row;

                if (!query.Any())
                {
                    notelist.Rows.Add(TitleText.Text, msgText.Text);
                }
                else
                {
                    MessageBox.Show("Title already exists. Please enter another title.");
                }
            }
            else
            {
                MessageBox.Show("Please enter title.");
            }
            TitleText.Clear();
            msgText.Clear();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            int i = -1;
            try
            {
                i = NoteListView.CurrentCell.RowIndex;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select note title to Edit.");
            }
            finally
            {
                if (i >= 0)
                {
                    string title1 = NoteListView.Rows[i].Cells[0].Value.ToString();
                    string msg1 = NoteListView.Rows[i].Cells[1].Value.ToString();
                    

                    using (EditNoteForm editNoteForm = new EditNoteForm(title: title1, msg: msg1))
                    {
                        editNoteForm.ShowDialog();
                        var query = from DataRow row in notelist.Rows
                                    where row.Field<string>("Title") == editNoteForm.Title
                                    select row;
                        if (query.Any() && title1 != editNoteForm.Title)
                        {
                            MessageBox.Show("Title already exists. Please enter another title.");
                        }
                        else
                        {
                            if (title1 != editNoteForm.Title || msg1 != editNoteForm.Msg)
                            {
                                notelist.Rows[i]["Title"] = editNoteForm.Title;
                                notelist.Rows[i]["Message"] = editNoteForm.Msg;
                                NoteListView.Refresh();
                                MessageBox.Show("Updated Successfully.");
                            } 
                        }
                    }
                }
            }  
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TitleText.Clear();
            msgText.Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes && NoteListView.RowCount > 0)
            {
                notelist.Rows[NoteListView.CurrentCell.RowIndex].Delete();
                NoteListView.Refresh();
                MessageBox.Show("Deleted Successfully.");
            }
        }

        private void DeleteAllBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
 
            if (result == DialogResult.Yes && NoteListView.RowCount > 0)
            {
                notelist.Rows.Clear();
                NoteListView.Refresh();
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {

            int i = -1;
            try
            {
                i = NoteListView.CurrentCell.RowIndex;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select note title to Edit.");
            }
            finally
            {
                if (i >= 0)
                {
                    TitleText.Text = NoteListView.Rows[i].Cells[0].Value.ToString();
                    msgText.Text = NoteListView.Rows[i].Cells[1].Value.ToString();
                }
            }
        }

    }
}
