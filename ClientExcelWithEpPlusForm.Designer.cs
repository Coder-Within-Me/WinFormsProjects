namespace WinFormPoC
{
    partial class ClientExcelWithEpPlusForm
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
            this.UploadPanelEpPlus = new System.Windows.Forms.Panel();
            this.ProgressBarLabel = new System.Windows.Forms.Label();
            this.comboBoxEpPlus = new System.Windows.Forms.ComboBox();
            this.UploadExcelBtn = new System.Windows.Forms.Button();
            this.progressBarEpPlus = new System.Windows.Forms.ProgressBar();
            this.dataGridViewEpPlus = new System.Windows.Forms.DataGridView();
            this.UploadPanelEpPlus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEpPlus)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadPanelEpPlus
            // 
            this.UploadPanelEpPlus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadPanelEpPlus.Controls.Add(this.ProgressBarLabel);
            this.UploadPanelEpPlus.Controls.Add(this.comboBoxEpPlus);
            this.UploadPanelEpPlus.Controls.Add(this.UploadExcelBtn);
            this.UploadPanelEpPlus.Controls.Add(this.progressBarEpPlus);
            this.UploadPanelEpPlus.Location = new System.Drawing.Point(0, 0);
            this.UploadPanelEpPlus.Name = "UploadPanelEpPlus";
            this.UploadPanelEpPlus.Size = new System.Drawing.Size(982, 75);
            this.UploadPanelEpPlus.TabIndex = 0;
            // 
            // ProgressBarLabel
            // 
            this.ProgressBarLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProgressBarLabel.AutoSize = true;
            this.ProgressBarLabel.Location = new System.Drawing.Point(228, 28);
            this.ProgressBarLabel.Name = "ProgressBarLabel";
            this.ProgressBarLabel.Size = new System.Drawing.Size(0, 16);
            this.ProgressBarLabel.TabIndex = 3;
            // 
            // comboBoxEpPlus
            // 
            this.comboBoxEpPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEpPlus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEpPlus.FormattingEnabled = true;
            this.comboBoxEpPlus.Location = new System.Drawing.Point(743, 23);
            this.comboBoxEpPlus.Name = "comboBoxEpPlus";
            this.comboBoxEpPlus.Size = new System.Drawing.Size(206, 24);
            this.comboBoxEpPlus.TabIndex = 2;
            this.comboBoxEpPlus.SelectedIndexChanged += new System.EventHandler(this.comboBoxEpPlus_SelectedIndexChanged);
            // 
            // UploadExcelBtn
            // 
            this.UploadExcelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UploadExcelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadExcelBtn.Location = new System.Drawing.Point(399, 17);
            this.UploadExcelBtn.Name = "UploadExcelBtn";
            this.UploadExcelBtn.Size = new System.Drawing.Size(184, 37);
            this.UploadExcelBtn.TabIndex = 1;
            this.UploadExcelBtn.Text = "Upload Excel";
            this.UploadExcelBtn.UseVisualStyleBackColor = true;
            this.UploadExcelBtn.Click += new System.EventHandler(this.UploadExcelBtn_Click);
            // 
            // progressBarEpPlus
            // 
            this.progressBarEpPlus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.progressBarEpPlus.Location = new System.Drawing.Point(36, 23);
            this.progressBarEpPlus.Name = "progressBarEpPlus";
            this.progressBarEpPlus.Size = new System.Drawing.Size(186, 23);
            this.progressBarEpPlus.TabIndex = 0;
            // 
            // dataGridViewEpPlus
            // 
            this.dataGridViewEpPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEpPlus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEpPlus.Location = new System.Drawing.Point(0, 73);
            this.dataGridViewEpPlus.Name = "dataGridViewEpPlus";
            this.dataGridViewEpPlus.RowHeadersWidth = 51;
            this.dataGridViewEpPlus.RowTemplate.Height = 24;
            this.dataGridViewEpPlus.Size = new System.Drawing.Size(982, 517);
            this.dataGridViewEpPlus.TabIndex = 1;
            // 
            // ClientExcelWithEpPlusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 578);
            this.Controls.Add(this.dataGridViewEpPlus);
            this.Controls.Add(this.UploadPanelEpPlus);
            this.Name = "ClientExcelWithEpPlusForm";
            this.Text = "Excel Processing With EPPLUS";
            this.UploadPanelEpPlus.ResumeLayout(false);
            this.UploadPanelEpPlus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEpPlus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UploadPanelEpPlus;
        private System.Windows.Forms.ComboBox comboBoxEpPlus;
        private System.Windows.Forms.Button UploadExcelBtn;
        private System.Windows.Forms.ProgressBar progressBarEpPlus;
        private System.Windows.Forms.DataGridView dataGridViewEpPlus;
        private System.Windows.Forms.Label ProgressBarLabel;
    }
}