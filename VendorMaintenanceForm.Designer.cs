namespace BookBrokersApp
{
    partial class VendorMaintenanceForm
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
            this.lstVendors = new System.Windows.Forms.ListBox();
            this.lblVendorID = new System.Windows.Forms.Label();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.lblPostBox = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtPostBoxNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddVendor = new System.Windows.Forms.Button();
            this.btnUpdateVendor = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddVendor = new System.Windows.Forms.Panel();
            this.cboAddCountry = new System.Windows.Forms.ComboBox();
            this.cboAddCountryID = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveVendor = new System.Windows.Forms.Button();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.txtAddPostBoxNumber = new System.Windows.Forms.TextBox();
            this.txtAddVendorName = new System.Windows.Forms.TextBox();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.lblAddCountry = new System.Windows.Forms.Label();
            this.lblAddPostBox = new System.Windows.Forms.Label();
            this.lblAddVendorName = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.pnlUpdateVendor = new System.Windows.Forms.Panel();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.txtUpdatePostBox = new System.Windows.Forms.TextBox();
            this.txtUpdateVendorName = new System.Windows.Forms.TextBox();
            this.txtUpdateVendorID = new System.Windows.Forms.TextBox();
            this.lblUpdateEmail = new System.Windows.Forms.Label();
            this.lblUpdateCountry = new System.Windows.Forms.Label();
            this.lblUpdatePostBox = new System.Windows.Forms.Label();
            this.lblUpdateVendorName = new System.Windows.Forms.Label();
            this.lblUpdateVendorID = new System.Windows.Forms.Label();
            this.btnDeleteVendor = new System.Windows.Forms.Button();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.pnlAddVendor.SuspendLayout();
            this.pnlUpdateVendor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVendors
            // 
            this.lstVendors.FormattingEnabled = true;
            this.lstVendors.Location = new System.Drawing.Point(24, 23);
            this.lstVendors.Name = "lstVendors";
            this.lstVendors.Size = new System.Drawing.Size(316, 303);
            this.lstVendors.TabIndex = 0;
            this.lstVendors.SelectedIndexChanged += new System.EventHandler(this.lstVendors_SelectedIndexChanged);
            // 
            // lblVendorID
            // 
            this.lblVendorID.AutoSize = true;
            this.lblVendorID.Location = new System.Drawing.Point(396, 41);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(58, 13);
            this.lblVendorID.TabIndex = 1;
            this.lblVendorID.Text = "Vendor ID:";
            this.lblVendorID.Click += new System.EventHandler(this.lblVendorID_Click);
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Location = new System.Drawing.Point(379, 85);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(75, 13);
            this.lblVendorName.TabIndex = 2;
            this.lblVendorName.Text = "Vendor Name:";
            // 
            // lblPostBox
            // 
            this.lblPostBox.AutoSize = true;
            this.lblPostBox.Location = new System.Drawing.Point(362, 125);
            this.lblPostBox.Name = "lblPostBox";
            this.lblPostBox.Size = new System.Drawing.Size(92, 13);
            this.lblPostBox.TabIndex = 3;
            this.lblPostBox.Text = "Post Box Number:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(408, 175);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 4;
            this.lblCountry.Text = "Country:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(419, 218);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(468, 34);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(100, 20);
            this.txtVendorID.TabIndex = 6;
            this.txtVendorID.TextChanged += new System.EventHandler(this.txtVendorID_TextChanged);
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(468, 82);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(100, 20);
            this.txtVendorName.TabIndex = 7;
            // 
            // txtPostBoxNumber
            // 
            this.txtPostBoxNumber.Location = new System.Drawing.Point(468, 125);
            this.txtPostBoxNumber.Name = "txtPostBoxNumber";
            this.txtPostBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPostBoxNumber.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(468, 218);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(24, 354);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(141, 354);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddVendor
            // 
            this.btnAddVendor.Location = new System.Drawing.Point(252, 353);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(75, 23);
            this.btnAddVendor.TabIndex = 13;
            this.btnAddVendor.Text = "Add Vendor";
            this.btnAddVendor.UseVisualStyleBackColor = true;
            this.btnAddVendor.Click += new System.EventHandler(this.btnAddVendor_Click);
            // 
            // btnUpdateVendor
            // 
            this.btnUpdateVendor.Location = new System.Drawing.Point(365, 353);
            this.btnUpdateVendor.Name = "btnUpdateVendor";
            this.btnUpdateVendor.Size = new System.Drawing.Size(116, 23);
            this.btnUpdateVendor.TabIndex = 14;
            this.btnUpdateVendor.Text = "Update Vendor";
            this.btnUpdateVendor.UseVisualStyleBackColor = true;
            this.btnUpdateVendor.Click += new System.EventHandler(this.btnUpdateVendor_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(529, 406);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddVendor
            // 
            this.pnlAddVendor.Controls.Add(this.cboAddCountry);
            this.pnlAddVendor.Controls.Add(this.cboAddCountryID);
            this.pnlAddVendor.Controls.Add(this.btnCancel);
            this.pnlAddVendor.Controls.Add(this.btnSaveVendor);
            this.pnlAddVendor.Controls.Add(this.txtAddEmail);
            this.pnlAddVendor.Controls.Add(this.txtAddPostBoxNumber);
            this.pnlAddVendor.Controls.Add(this.txtAddVendorName);
            this.pnlAddVendor.Controls.Add(this.lblAddEmail);
            this.pnlAddVendor.Controls.Add(this.lblAddCountry);
            this.pnlAddVendor.Controls.Add(this.lblAddPostBox);
            this.pnlAddVendor.Controls.Add(this.lblAddVendorName);
            this.pnlAddVendor.Location = new System.Drawing.Point(322, 19);
            this.pnlAddVendor.Name = "pnlAddVendor";
            this.pnlAddVendor.Size = new System.Drawing.Size(414, 303);
            this.pnlAddVendor.TabIndex = 17;
            this.pnlAddVendor.Visible = false;
            // 
            // cboAddCountry
            // 
            this.cboAddCountry.FormattingEnabled = true;
            this.cboAddCountry.Location = new System.Drawing.Point(203, 119);
            this.cboAddCountry.Name = "cboAddCountry";
            this.cboAddCountry.Size = new System.Drawing.Size(95, 21);
            this.cboAddCountry.TabIndex = 11;
            this.cboAddCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cboAddCountryID
            // 
            this.cboAddCountryID.FormattingEnabled = true;
            this.cboAddCountryID.Location = new System.Drawing.Point(146, 119);
            this.cboAddCountryID.Name = "cboAddCountryID";
            this.cboAddCountryID.Size = new System.Drawing.Size(45, 21);
            this.cboAddCountryID.TabIndex = 10;
            this.cboAddCountryID.SelectedIndexChanged += new System.EventHandler(this.cboAddCountryID_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(285, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveVendor
            // 
            this.btnSaveVendor.Location = new System.Drawing.Point(44, 229);
            this.btnSaveVendor.Name = "btnSaveVendor";
            this.btnSaveVendor.Size = new System.Drawing.Size(147, 23);
            this.btnSaveVendor.TabIndex = 8;
            this.btnSaveVendor.Text = "Save Vendor";
            this.btnSaveVendor.UseVisualStyleBackColor = true;
            this.btnSaveVendor.Click += new System.EventHandler(this.btnSaveVendor_Click);
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(146, 156);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(100, 20);
            this.txtAddEmail.TabIndex = 7;
            // 
            // txtAddPostBoxNumber
            // 
            this.txtAddPostBoxNumber.Location = new System.Drawing.Point(146, 79);
            this.txtAddPostBoxNumber.Name = "txtAddPostBoxNumber";
            this.txtAddPostBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAddPostBoxNumber.TabIndex = 5;
            // 
            // txtAddVendorName
            // 
            this.txtAddVendorName.Location = new System.Drawing.Point(146, 34);
            this.txtAddVendorName.Name = "txtAddVendorName";
            this.txtAddVendorName.Size = new System.Drawing.Size(100, 20);
            this.txtAddVendorName.TabIndex = 4;
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Location = new System.Drawing.Point(84, 163);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(35, 13);
            this.lblAddEmail.TabIndex = 3;
            this.lblAddEmail.Text = "Email:";
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.AutoSize = true;
            this.lblAddCountry.Location = new System.Drawing.Point(84, 122);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(46, 13);
            this.lblAddCountry.TabIndex = 2;
            this.lblAddCountry.Text = "Country:";
            // 
            // lblAddPostBox
            // 
            this.lblAddPostBox.AutoSize = true;
            this.lblAddPostBox.Location = new System.Drawing.Point(49, 82);
            this.lblAddPostBox.Name = "lblAddPostBox";
            this.lblAddPostBox.Size = new System.Drawing.Size(92, 13);
            this.lblAddPostBox.TabIndex = 1;
            this.lblAddPostBox.Text = "Post Box Number:";
            this.lblAddPostBox.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAddVendorName
            // 
            this.lblAddVendorName.AutoSize = true;
            this.lblAddVendorName.Location = new System.Drawing.Point(66, 34);
            this.lblAddVendorName.Name = "lblAddVendorName";
            this.lblAddVendorName.Size = new System.Drawing.Size(75, 13);
            this.lblAddVendorName.TabIndex = 0;
            this.lblAddVendorName.Text = "Vendor Name:";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(109, 167);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(100, 20);
            this.txtCountryName.TabIndex = 19;
            this.txtCountryName.TextChanged += new System.EventHandler(this.txtCountryName_TextChanged);
            // 
            // pnlUpdateVendor
            // 
            this.pnlUpdateVendor.Controls.Add(this.txtCountryName);
            this.pnlUpdateVendor.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateVendor.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateVendor.Controls.Add(this.pnlAddVendor);
            this.pnlUpdateVendor.Controls.Add(this.txtUpdateEmail);
            this.pnlUpdateVendor.Controls.Add(this.txtUpdatePostBox);
            this.pnlUpdateVendor.Controls.Add(this.txtUpdateVendorName);
            this.pnlUpdateVendor.Controls.Add(this.txtUpdateVendorID);
            this.pnlUpdateVendor.Controls.Add(this.lblUpdateEmail);
            this.pnlUpdateVendor.Controls.Add(this.lblUpdateCountry);
            this.pnlUpdateVendor.Controls.Add(this.lblUpdatePostBox);
            this.pnlUpdateVendor.Controls.Add(this.lblUpdateVendorName);
            this.pnlUpdateVendor.Controls.Add(this.lblUpdateVendorID);
            this.pnlUpdateVendor.Location = new System.Drawing.Point(173, 23);
            this.pnlUpdateVendor.Name = "pnlUpdateVendor";
            this.pnlUpdateVendor.Size = new System.Drawing.Size(527, 366);
            this.pnlUpdateVendor.TabIndex = 12;
            this.pnlUpdateVendor.Visible = false;
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(189, 273);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCancel.TabIndex = 11;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(28, 273);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(97, 23);
            this.btnSaveChanges.TabIndex = 10;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(109, 213);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateEmail.TabIndex = 9;
            // 
            // txtUpdatePostBox
            // 
            this.txtUpdatePostBox.Location = new System.Drawing.Point(109, 130);
            this.txtUpdatePostBox.Name = "txtUpdatePostBox";
            this.txtUpdatePostBox.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePostBox.TabIndex = 7;
            // 
            // txtUpdateVendorName
            // 
            this.txtUpdateVendorName.Location = new System.Drawing.Point(109, 90);
            this.txtUpdateVendorName.Name = "txtUpdateVendorName";
            this.txtUpdateVendorName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateVendorName.TabIndex = 6;
            // 
            // txtUpdateVendorID
            // 
            this.txtUpdateVendorID.Location = new System.Drawing.Point(109, 42);
            this.txtUpdateVendorID.Name = "txtUpdateVendorID";
            this.txtUpdateVendorID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateVendorID.TabIndex = 5;
            this.txtUpdateVendorID.TextChanged += new System.EventHandler(this.txtUpdateVendorID_TextChanged);
            // 
            // lblUpdateEmail
            // 
            this.lblUpdateEmail.AutoSize = true;
            this.lblUpdateEmail.Location = new System.Drawing.Point(54, 213);
            this.lblUpdateEmail.Name = "lblUpdateEmail";
            this.lblUpdateEmail.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateEmail.TabIndex = 4;
            this.lblUpdateEmail.Text = "Email:";
            // 
            // lblUpdateCountry
            // 
            this.lblUpdateCountry.AutoSize = true;
            this.lblUpdateCountry.Location = new System.Drawing.Point(46, 170);
            this.lblUpdateCountry.Name = "lblUpdateCountry";
            this.lblUpdateCountry.Size = new System.Drawing.Size(46, 13);
            this.lblUpdateCountry.TabIndex = 3;
            this.lblUpdateCountry.Text = "Country:";
            // 
            // lblUpdatePostBox
            // 
            this.lblUpdatePostBox.AutoSize = true;
            this.lblUpdatePostBox.Location = new System.Drawing.Point(11, 133);
            this.lblUpdatePostBox.Name = "lblUpdatePostBox";
            this.lblUpdatePostBox.Size = new System.Drawing.Size(92, 13);
            this.lblUpdatePostBox.TabIndex = 2;
            this.lblUpdatePostBox.Text = "Post Box Number:";
            // 
            // lblUpdateVendorName
            // 
            this.lblUpdateVendorName.AutoSize = true;
            this.lblUpdateVendorName.Location = new System.Drawing.Point(18, 93);
            this.lblUpdateVendorName.Name = "lblUpdateVendorName";
            this.lblUpdateVendorName.Size = new System.Drawing.Size(75, 13);
            this.lblUpdateVendorName.TabIndex = 1;
            this.lblUpdateVendorName.Text = "Vendor Name:";
            // 
            // lblUpdateVendorID
            // 
            this.lblUpdateVendorID.AutoSize = true;
            this.lblUpdateVendorID.Location = new System.Drawing.Point(34, 49);
            this.lblUpdateVendorID.Name = "lblUpdateVendorID";
            this.lblUpdateVendorID.Size = new System.Drawing.Size(58, 13);
            this.lblUpdateVendorID.TabIndex = 0;
            this.lblUpdateVendorID.Text = "Vendor ID:";
            // 
            // btnDeleteVendor
            // 
            this.btnDeleteVendor.Location = new System.Drawing.Point(514, 353);
            this.btnDeleteVendor.Name = "btnDeleteVendor";
            this.btnDeleteVendor.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteVendor.TabIndex = 20;
            this.btnDeleteVendor.Text = "Delete Vendor";
            this.btnDeleteVendor.UseVisualStyleBackColor = true;
            this.btnDeleteVendor.Click += new System.EventHandler(this.btnDeleteVendor_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(468, 168);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 21;
            // 
            // VendorMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 441);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.btnDeleteVendor);
            this.Controls.Add(this.pnlUpdateVendor);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateVendor);
            this.Controls.Add(this.btnAddVendor);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPostBoxNumber);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblPostBox);
            this.Controls.Add(this.lblVendorName);
            this.Controls.Add(this.lblVendorID);
            this.Controls.Add(this.lstVendors);
            this.Name = "VendorMaintenanceForm";
            this.Text = "Vendor Maintenance";
            this.Load += new System.EventHandler(this.VendorMaintenanceForm_Load);
            this.pnlAddVendor.ResumeLayout(false);
            this.pnlAddVendor.PerformLayout();
            this.pnlUpdateVendor.ResumeLayout(false);
            this.pnlUpdateVendor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVendors;
        private System.Windows.Forms.Label lblVendorID;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Label lblPostBox;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.TextBox txtPostBoxNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddVendor;
        private System.Windows.Forms.Button btnUpdateVendor;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddVendor;
        private System.Windows.Forms.ComboBox cboAddCountry;
        private System.Windows.Forms.ComboBox cboAddCountryID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveVendor;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.TextBox txtAddPostBoxNumber;
        private System.Windows.Forms.TextBox txtAddVendorName;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.Label lblAddCountry;
        private System.Windows.Forms.Label lblAddPostBox;
        private System.Windows.Forms.Label lblAddVendorName;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Panel pnlUpdateVendor;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.TextBox txtUpdatePostBox;
        private System.Windows.Forms.TextBox txtUpdateVendorName;
        private System.Windows.Forms.TextBox txtUpdateVendorID;
        private System.Windows.Forms.Label lblUpdateEmail;
        private System.Windows.Forms.Label lblUpdateCountry;
        private System.Windows.Forms.Label lblUpdatePostBox;
        private System.Windows.Forms.Label lblUpdateVendorName;
        private System.Windows.Forms.Label lblUpdateVendorID;
        private System.Windows.Forms.Button btnDeleteVendor;
        private System.Windows.Forms.TextBox txtCountry;
    }
}