namespace WinFormPoC
{
    partial class NoteApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteApp));
            this.TitleText = new System.Windows.Forms.TextBox();
            this.TitleLable = new System.Windows.Forms.Label();
            this.msgLable = new System.Windows.Forms.Label();
            this.msgText = new System.Windows.Forms.TextBox();
            this.NoteListLable = new System.Windows.Forms.Label();
            this.NoteListView = new System.Windows.Forms.DataGridView();
            this.NewBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteAllBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NoteListView)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(127, 81);
            this.TitleText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(261, 27);
            this.TitleText.TabIndex = 1;
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Location = new System.Drawing.Point(18, 88);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(81, 20);
            this.TitleLable.TabIndex = 0;
            this.TitleLable.Text = "Note Title";
            // 
            // msgLable
            // 
            this.msgLable.AutoSize = true;
            this.msgLable.Location = new System.Drawing.Point(22, 143);
            this.msgLable.Name = "msgLable";
            this.msgLable.Size = new System.Drawing.Size(77, 20);
            this.msgLable.TabIndex = 0;
            this.msgLable.Text = "Message";
            // 
            // msgText
            // 
            this.msgText.Location = new System.Drawing.Point(125, 140);
            this.msgText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.msgText.Multiline = true;
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(261, 212);
            this.msgText.TabIndex = 2;
            // 
            // NoteListLable
            // 
            this.NoteListLable.AutoSize = true;
            this.NoteListLable.Location = new System.Drawing.Point(489, 81);
            this.NoteListLable.Name = "NoteListLable";
            this.NoteListLable.Size = new System.Drawing.Size(87, 20);
            this.NoteListLable.TabIndex = 3;
            this.NoteListLable.Text = "Note List :";
            // 
            // NoteListView
            // 
            this.NoteListView.AllowUserToAddRows = false;
            this.NoteListView.AllowUserToDeleteRows = false;
            this.NoteListView.AllowUserToResizeColumns = false;
            this.NoteListView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoteListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoteListView.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.NoteListView.Location = new System.Drawing.Point(492, 140);
            this.NoteListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NoteListView.Name = "NoteListView";
            this.NoteListView.ReadOnly = true;
            this.NoteListView.RowHeadersVisible = false;
            this.NoteListView.RowHeadersWidth = 51;
            this.NoteListView.RowTemplate.Height = 24;
            this.NoteListView.RowTemplate.ReadOnly = true;
            this.NoteListView.Size = new System.Drawing.Size(260, 212);
            this.NoteListView.TabIndex = 5;
            // 
            // NewBtn
            // 
            this.NewBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.NewBtn.Location = new System.Drawing.Point(125, 409);
            this.NewBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(93, 29);
            this.NewBtn.TabIndex = 3;
            this.NewBtn.Text = "Add New";
            this.NewBtn.UseVisualStyleBackColor = false;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EditBtn.Location = new System.Drawing.Point(492, 409);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(93, 29);
            this.EditBtn.TabIndex = 5;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteBtn.ForeColor = System.Drawing.Color.Red;
            this.DeleteBtn.Location = new System.Drawing.Point(660, 409);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(93, 29);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.Red;
            this.ClearBtn.Location = new System.Drawing.Point(293, 409);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(93, 29);
            this.ClearBtn.TabIndex = 4;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteAllBtn
            // 
            this.DeleteAllBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteAllBtn.ForeColor = System.Drawing.Color.Red;
            this.DeleteAllBtn.Location = new System.Drawing.Point(659, 360);
            this.DeleteAllBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteAllBtn.Name = "DeleteAllBtn";
            this.DeleteAllBtn.Size = new System.Drawing.Size(93, 29);
            this.DeleteAllBtn.TabIndex = 7;
            this.DeleteAllBtn.Text = "Delete All";
            this.DeleteAllBtn.UseVisualStyleBackColor = false;
            this.DeleteAllBtn.Click += new System.EventHandler(this.DeleteAllBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewBtn.Location = new System.Drawing.Point(493, 360);
            this.ViewBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(93, 29);
            this.ViewBtn.TabIndex = 8;
            this.ViewBtn.Text = "View";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // NoteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 491);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.DeleteAllBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.NoteListView);
            this.Controls.Add(this.NoteListLable);
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.msgLable);
            this.Controls.Add(this.TitleLable);
            this.Controls.Add(this.TitleText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteApp";
            this.Text = "Note App";
            this.Load += new System.EventHandler(this.NoteApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NoteListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.Label msgLable;
        private System.Windows.Forms.TextBox msgText;
        private System.Windows.Forms.Label NoteListLable;
        private System.Windows.Forms.DataGridView NoteListView;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteAllBtn;
        private System.Windows.Forms.Button ViewBtn;
    }
}

