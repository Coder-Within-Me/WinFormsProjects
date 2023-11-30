namespace WinFormPoC
{
    partial class EditNoteForm
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
            this.msgText1 = new System.Windows.Forms.TextBox();
            this.msgLable = new System.Windows.Forms.Label();
            this.TitleLable = new System.Windows.Forms.Label();
            this.TitleText1 = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msgText1
            // 
            this.msgText1.Location = new System.Drawing.Point(134, 97);
            this.msgText1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.msgText1.Multiline = true;
            this.msgText1.Name = "msgText1";
            this.msgText1.Size = new System.Drawing.Size(261, 212);
            this.msgText1.TabIndex = 2;
            // 
            // msgLable
            // 
            this.msgLable.AutoSize = true;
            this.msgLable.Location = new System.Drawing.Point(31, 100);
            this.msgLable.Name = "msgLable";
            this.msgLable.Size = new System.Drawing.Size(64, 16);
            this.msgLable.TabIndex = 3;
            this.msgLable.Text = "Message";
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Location = new System.Drawing.Point(27, 45);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(65, 16);
            this.TitleLable.TabIndex = 4;
            this.TitleLable.Text = "Note Title";
            // 
            // TitleText1
            // 
            this.TitleText1.Location = new System.Drawing.Point(136, 38);
            this.TitleText1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TitleText1.Name = "TitleText1";
            this.TitleText1.Size = new System.Drawing.Size(261, 22);
            this.TitleText1.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SaveBtn.Location = new System.Drawing.Point(213, 350);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(93, 29);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // EditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 420);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.msgText1);
            this.Controls.Add(this.msgLable);
            this.Controls.Add(this.TitleLable);
            this.Controls.Add(this.TitleText1);
            this.Name = "EditNoteForm";
            this.Text = "EditNoteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msgText1;
        private System.Windows.Forms.Label msgLable;
        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.TextBox TitleText1;
        private System.Windows.Forms.Button SaveBtn;
    }
}