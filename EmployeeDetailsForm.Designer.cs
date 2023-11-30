namespace WinFormPoC
{
    partial class EmployeeDetailsForm
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
            this.NameText = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameText = new System.Windows.Forms.TextBox();
            this.dobDatePicker = new System.Windows.Forms.DateTimePicker();
            this.MaritalStatusLabel = new System.Windows.Forms.Label();
            this.NationalityLabel = new System.Windows.Forms.Label();
            this.NationalityText = new System.Windows.Forms.TextBox();
            this.EmployerLabel = new System.Windows.Forms.Label();
            this.EmployerText = new System.Windows.Forms.TextBox();
            this.DesignationLabel = new System.Windows.Forms.Label();
            this.DesignationText = new System.Windows.Forms.TextBox();
            this.MaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.FemaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.OtherRadioBtn = new System.Windows.Forms.RadioButton();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.MaritalStatusComboBox = new System.Windows.Forms.ComboBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(110, 34);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(225, 22);
            this.NameText.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(42, 37);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 16);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(50, 85);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(36, 16);
            this.dobLabel.TabIndex = 3;
            this.dobLabel.Text = "DOB";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(389, 34);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(61, 16);
            this.SurnameLabel.TabIndex = 5;
            this.SurnameLabel.Text = "Surname";
            // 
            // SurnameText
            // 
            this.SurnameText.Location = new System.Drawing.Point(478, 31);
            this.SurnameText.Name = "SurnameText";
            this.SurnameText.Size = new System.Drawing.Size(225, 22);
            this.SurnameText.TabIndex = 4;
            // 
            // dobDatePicker
            // 
            this.dobDatePicker.Location = new System.Drawing.Point(110, 85);
            this.dobDatePicker.Name = "dobDatePicker";
            this.dobDatePicker.Size = new System.Drawing.Size(225, 22);
            this.dobDatePicker.TabIndex = 6;
            // 
            // MaritalStatusLabel
            // 
            this.MaritalStatusLabel.AutoSize = true;
            this.MaritalStatusLabel.Location = new System.Drawing.Point(363, 151);
            this.MaritalStatusLabel.Name = "MaritalStatusLabel";
            this.MaritalStatusLabel.Size = new System.Drawing.Size(87, 16);
            this.MaritalStatusLabel.TabIndex = 7;
            this.MaritalStatusLabel.Text = "Marital Status";
            // 
            // NationalityLabel
            // 
            this.NationalityLabel.AutoSize = true;
            this.NationalityLabel.Location = new System.Drawing.Point(380, 209);
            this.NationalityLabel.Name = "NationalityLabel";
            this.NationalityLabel.Size = new System.Drawing.Size(70, 16);
            this.NationalityLabel.TabIndex = 9;
            this.NationalityLabel.Text = "Nationality";
            // 
            // NationalityText
            // 
            this.NationalityText.Location = new System.Drawing.Point(478, 206);
            this.NationalityText.Name = "NationalityText";
            this.NationalityText.Size = new System.Drawing.Size(225, 22);
            this.NationalityText.TabIndex = 8;
            // 
            // EmployerLabel
            // 
            this.EmployerLabel.AutoSize = true;
            this.EmployerLabel.Location = new System.Drawing.Point(21, 268);
            this.EmployerLabel.Name = "EmployerLabel";
            this.EmployerLabel.Size = new System.Drawing.Size(65, 16);
            this.EmployerLabel.TabIndex = 13;
            this.EmployerLabel.Text = "Employer";
            // 
            // EmployerText
            // 
            this.EmployerText.Location = new System.Drawing.Point(110, 268);
            this.EmployerText.Name = "EmployerText";
            this.EmployerText.Size = new System.Drawing.Size(225, 22);
            this.EmployerText.TabIndex = 12;
            // 
            // DesignationLabel
            // 
            this.DesignationLabel.AutoSize = true;
            this.DesignationLabel.Location = new System.Drawing.Point(371, 271);
            this.DesignationLabel.Name = "DesignationLabel";
            this.DesignationLabel.Size = new System.Drawing.Size(79, 16);
            this.DesignationLabel.TabIndex = 11;
            this.DesignationLabel.Text = "Designation";
            // 
            // DesignationText
            // 
            this.DesignationText.Location = new System.Drawing.Point(478, 268);
            this.DesignationText.Name = "DesignationText";
            this.DesignationText.Size = new System.Drawing.Size(225, 22);
            this.DesignationText.TabIndex = 10;
            // 
            // MaleRadioBtn
            // 
            this.MaleRadioBtn.AutoSize = true;
            this.MaleRadioBtn.Location = new System.Drawing.Point(478, 88);
            this.MaleRadioBtn.Name = "MaleRadioBtn";
            this.MaleRadioBtn.Size = new System.Drawing.Size(58, 20);
            this.MaleRadioBtn.TabIndex = 14;
            this.MaleRadioBtn.TabStop = true;
            this.MaleRadioBtn.Text = "Male";
            this.MaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioBtn
            // 
            this.FemaleRadioBtn.AutoSize = true;
            this.FemaleRadioBtn.Location = new System.Drawing.Point(551, 88);
            this.FemaleRadioBtn.Name = "FemaleRadioBtn";
            this.FemaleRadioBtn.Size = new System.Drawing.Size(74, 20);
            this.FemaleRadioBtn.TabIndex = 15;
            this.FemaleRadioBtn.TabStop = true;
            this.FemaleRadioBtn.Text = "Female";
            this.FemaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // OtherRadioBtn
            // 
            this.OtherRadioBtn.AutoSize = true;
            this.OtherRadioBtn.Location = new System.Drawing.Point(643, 88);
            this.OtherRadioBtn.Name = "OtherRadioBtn";
            this.OtherRadioBtn.Size = new System.Drawing.Size(60, 20);
            this.OtherRadioBtn.TabIndex = 16;
            this.OtherRadioBtn.TabStop = true;
            this.OtherRadioBtn.Text = "Other";
            this.OtherRadioBtn.UseVisualStyleBackColor = true;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(398, 88);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(52, 16);
            this.GenderLabel.TabIndex = 17;
            this.GenderLabel.Text = "Gender";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(28, 151);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(58, 16);
            this.AddressLabel.TabIndex = 18;
            this.AddressLabel.Text = "Address";
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(110, 148);
            this.AddressText.Multiline = true;
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(225, 96);
            this.AddressText.TabIndex = 19;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SaveBtn.Location = new System.Drawing.Point(223, 346);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(112, 48);
            this.SaveBtn.TabIndex = 20;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // MaritalStatusComboBox
            // 
            this.MaritalStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaritalStatusComboBox.FormattingEnabled = true;
            this.MaritalStatusComboBox.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widowed",
            "Divorced",
            "Separated"});
            this.MaritalStatusComboBox.Location = new System.Drawing.Point(478, 151);
            this.MaritalStatusComboBox.Name = "MaritalStatusComboBox";
            this.MaritalStatusComboBox.Size = new System.Drawing.Size(225, 24);
            this.MaritalStatusComboBox.TabIndex = 22;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClearBtn.Location = new System.Drawing.Point(478, 346);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(112, 48);
            this.ClearBtn.TabIndex = 23;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // EmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaleRadioBtn);
            this.Controls.Add(this.FemaleRadioBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.OtherRadioBtn);
            this.Controls.Add(this.MaritalStatusComboBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.EmployerLabel);
            this.Controls.Add(this.EmployerText);
            this.Controls.Add(this.DesignationLabel);
            this.Controls.Add(this.DesignationText);
            this.Controls.Add(this.NationalityLabel);
            this.Controls.Add(this.NationalityText);
            this.Controls.Add(this.MaritalStatusLabel);
            this.Controls.Add(this.dobDatePicker);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.SurnameText);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeDetailsForm";
            this.Text = "EmployeeDetailsForm";
            this.Load += new System.EventHandler(this.EmployeeDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox SurnameText;
        private System.Windows.Forms.DateTimePicker dobDatePicker;
        private System.Windows.Forms.Label MaritalStatusLabel;
        private System.Windows.Forms.Label NationalityLabel;
        private System.Windows.Forms.TextBox NationalityText;
        private System.Windows.Forms.Label EmployerLabel;
        private System.Windows.Forms.TextBox EmployerText;
        private System.Windows.Forms.Label DesignationLabel;
        private System.Windows.Forms.TextBox DesignationText;
        private System.Windows.Forms.RadioButton MaleRadioBtn;
        private System.Windows.Forms.RadioButton FemaleRadioBtn;
        private System.Windows.Forms.RadioButton OtherRadioBtn;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox MaritalStatusComboBox;
        private System.Windows.Forms.Button ClearBtn;
    }
}