namespace WinFormPoC
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NoteListAppBtn = new System.Windows.Forms.Button();
            this.EmplayeeFormBtn = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewEmpDetailsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.ExcelFormBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExcelNoteText = new System.Windows.Forms.TextBox();
            this.ExcelPoCBtn = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoteListAppBtn
            // 
            this.NoteListAppBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.NoteListAppBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.NoteListAppBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteListAppBtn.ForeColor = System.Drawing.Color.Transparent;
            this.NoteListAppBtn.Location = new System.Drawing.Point(55, 51);
            this.NoteListAppBtn.Name = "NoteListAppBtn";
            this.NoteListAppBtn.Size = new System.Drawing.Size(300, 100);
            this.NoteListAppBtn.TabIndex = 2;
            this.NoteListAppBtn.Text = "Note List App";
            this.NoteListAppBtn.UseVisualStyleBackColor = false;
            this.NoteListAppBtn.Click += new System.EventHandler(this.NoteListAppBtn_Click);
            // 
            // EmplayeeFormBtn
            // 
            this.EmplayeeFormBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.EmplayeeFormBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.EmplayeeFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmplayeeFormBtn.ForeColor = System.Drawing.Color.Transparent;
            this.EmplayeeFormBtn.Location = new System.Drawing.Point(0, 0);
            this.EmplayeeFormBtn.Name = "EmplayeeFormBtn";
            this.EmplayeeFormBtn.Size = new System.Drawing.Size(150, 100);
            this.EmplayeeFormBtn.TabIndex = 1;
            this.EmplayeeFormBtn.Text = "Register Employee";
            this.EmplayeeFormBtn.UseVisualStyleBackColor = false;
            this.EmplayeeFormBtn.Click += new System.EventHandler(this.EmplayeeFormBtn_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(262, 20);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Please select application to view :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee Details Form (using SQL)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Note List App";
            // 
            // ViewEmpDetailsBtn
            // 
            this.ViewEmpDetailsBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ViewEmpDetailsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ViewEmpDetailsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEmpDetailsBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ViewEmpDetailsBtn.Location = new System.Drawing.Point(150, 0);
            this.ViewEmpDetailsBtn.Name = "ViewEmpDetailsBtn";
            this.ViewEmpDetailsBtn.Size = new System.Drawing.Size(150, 100);
            this.ViewEmpDetailsBtn.TabIndex = 0;
            this.ViewEmpDetailsBtn.Text = "View Employee Details";
            this.ViewEmpDetailsBtn.UseVisualStyleBackColor = false;
            this.ViewEmpDetailsBtn.Click += new System.EventHandler(this.ViewEmpDetailsBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EmplayeeFormBtn);
            this.panel1.Controls.Add(this.ViewEmpDetailsBtn);
            this.panel1.Location = new System.Drawing.Point(455, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            this.panel1.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Excel Upload and Read";
            // 
            // ExcelFormBtn
            // 
            this.ExcelFormBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ExcelFormBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExcelFormBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExcelFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcelFormBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ExcelFormBtn.Location = new System.Drawing.Point(0, 0);
            this.ExcelFormBtn.Name = "ExcelFormBtn";
            this.ExcelFormBtn.Size = new System.Drawing.Size(297, 100);
            this.ExcelFormBtn.TabIndex = 0;
            this.ExcelFormBtn.Text = "Upload Excel and View Data";
            this.ExcelFormBtn.UseVisualStyleBackColor = false;
            this.ExcelFormBtn.Click += new System.EventHandler(this.ExcelFormBtn_Click);
            this.ExcelFormBtn.MouseLeave += new System.EventHandler(this.ExcelFormBtn_MouseLeave);
            this.ExcelFormBtn.MouseHover += new System.EventHandler(this.ExcelFormBtn_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ExcelFormBtn);
            this.panel2.Location = new System.Drawing.Point(55, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 100);
            this.panel2.TabIndex = 10;
            // 
            // ExcelNoteText
            // 
            this.ExcelNoteText.ForeColor = System.Drawing.Color.Red;
            this.ExcelNoteText.Location = new System.Drawing.Point(16, 208);
            this.ExcelNoteText.Multiline = true;
            this.ExcelNoteText.Name = "ExcelNoteText";
            this.ExcelNoteText.Size = new System.Drawing.Size(427, 83);
            this.ExcelNoteText.TabIndex = 5;
            this.ExcelNoteText.Text = "Note : Spread sheet should have only one table and should be starting with (RowIn" +
    "dex = 0,ColumnIndex = 0). First row is considered as column names of SQL table.";
            this.ExcelNoteText.Visible = false;
            // 
            // ExcelPoCBtn
            // 
            this.ExcelPoCBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ExcelPoCBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExcelPoCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcelPoCBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ExcelPoCBtn.Location = new System.Drawing.Point(455, 267);
            this.ExcelPoCBtn.Name = "ExcelPoCBtn";
            this.ExcelPoCBtn.Size = new System.Drawing.Size(297, 100);
            this.ExcelPoCBtn.TabIndex = 11;
            this.ExcelPoCBtn.Text = "Client PoC Excel Test";
            this.ExcelPoCBtn.UseVisualStyleBackColor = false;
            this.ExcelPoCBtn.Click += new System.EventHandler(this.ExcelPoCBtn_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExcelPoCBtn);
            this.Controls.Add(this.ExcelNoteText);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.NoteListAppBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "List Of Applications";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NoteListAppBtn;
        private System.Windows.Forms.Button EmplayeeFormBtn;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewEmpDetailsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExcelFormBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ExcelNoteText;
        private System.Windows.Forms.Button ExcelPoCBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}