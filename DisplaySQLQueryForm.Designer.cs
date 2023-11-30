namespace WinFormPoC
{
    partial class DisplaySQLQueryForm
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
            this.QueryText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // QueryText
            // 
            this.QueryText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryText.Location = new System.Drawing.Point(0, 0);
            this.QueryText.Multiline = true;
            this.QueryText.Name = "QueryText";
            this.QueryText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.QueryText.Size = new System.Drawing.Size(1382, 653);
            this.QueryText.TabIndex = 0;
            this.QueryText.UseSystemPasswordChar = true;
            // 
            // DisplaySQLQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.QueryText);
            this.Name = "DisplaySQLQueryForm";
            this.Text = "SQL Query";
            this.Load += new System.EventHandler(this.DisplaySQLQueryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QueryText;
    }
}