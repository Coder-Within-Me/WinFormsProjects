namespace WinFormPoC
{
    partial class ClientPoCExcelTestForm
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
            this.UpdateQueryText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UpdateQueryText
            // 
            this.UpdateQueryText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateQueryText.Location = new System.Drawing.Point(0, 0);
            this.UpdateQueryText.Multiline = true;
            this.UpdateQueryText.Name = "UpdateQueryText";
            this.UpdateQueryText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.UpdateQueryText.Size = new System.Drawing.Size(800, 450);
            this.UpdateQueryText.TabIndex = 0;
            // 
            // ClientPoCExcelTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateQueryText);
            this.Name = "ClientPoCExcelTestForm";
            this.Text = "ClientPoCExcelTestForm";
            this.Load += new System.EventHandler(this.ClientPoCExcelTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UpdateQueryText;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}