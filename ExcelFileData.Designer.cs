namespace WinFormPoC
{
    partial class ExcelFileData
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
            this.ExcelGridView = new System.Windows.Forms.DataGridView();
            this.ExcelQueryFormationBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExcelGridView
            // 
            this.ExcelGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExcelGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExcelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExcelGridView.Location = new System.Drawing.Point(-1, 106);
            this.ExcelGridView.Name = "ExcelGridView";
            this.ExcelGridView.RowHeadersWidth = 51;
            this.ExcelGridView.RowTemplate.Height = 24;
            this.ExcelGridView.Size = new System.Drawing.Size(1291, 653);
            this.ExcelGridView.TabIndex = 0;
            // 
            // ExcelQueryFormationBtn
            // 
            this.ExcelQueryFormationBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ExcelQueryFormationBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExcelQueryFormationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExcelQueryFormationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcelQueryFormationBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ExcelQueryFormationBtn.Location = new System.Drawing.Point(0, 0);
            this.ExcelQueryFormationBtn.Name = "ExcelQueryFormationBtn";
            this.ExcelQueryFormationBtn.Size = new System.Drawing.Size(1290, 100);
            this.ExcelQueryFormationBtn.TabIndex = 10;
            this.ExcelQueryFormationBtn.Text = "Excel To SQL Query Formation";
            this.ExcelQueryFormationBtn.UseVisualStyleBackColor = false;
            this.ExcelQueryFormationBtn.Click += new System.EventHandler(this.ExcelQueryFormationBtn_Click);
            // 
            // ExcelFileData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 758);
            this.Controls.Add(this.ExcelQueryFormationBtn);
            this.Controls.Add(this.ExcelGridView);
            this.Name = "ExcelFileData";
            this.Text = "Excel File Data";
            ((System.ComponentModel.ISupportInitialize)(this.ExcelGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ExcelGridView;
        private System.Windows.Forms.Button ExcelQueryFormationBtn;
    }
}