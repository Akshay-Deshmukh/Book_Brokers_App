namespace BookBrokersApp
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
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnBookMaintenance = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnClientOrderMaintenance = new System.Windows.Forms.Button();
            this.btnBookInfoMaintenance = new System.Windows.Forms.Button();
            this.btnClientMaintenance = new System.Windows.Forms.Button();
            this.btnVendorMaintenance = new System.Windows.Forms.Button();
            this.grpReporting = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReporting.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnBookMaintenance);
            this.grpMaintenance.Controls.Add(this.btnAddBook);
            this.grpMaintenance.Controls.Add(this.btnClientOrderMaintenance);
            this.grpMaintenance.Controls.Add(this.btnBookInfoMaintenance);
            this.grpMaintenance.Controls.Add(this.btnClientMaintenance);
            this.grpMaintenance.Controls.Add(this.btnVendorMaintenance);
            this.grpMaintenance.Location = new System.Drawing.Point(30, 33);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(258, 384);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnBookMaintenance
            // 
            this.btnBookMaintenance.Location = new System.Drawing.Point(54, 223);
            this.btnBookMaintenance.Name = "btnBookMaintenance";
            this.btnBookMaintenance.Size = new System.Drawing.Size(170, 23);
            this.btnBookMaintenance.TabIndex = 5;
            this.btnBookMaintenance.Text = "Book Maintenance";
            this.btnBookMaintenance.UseVisualStyleBackColor = true;
            this.btnBookMaintenance.Click += new System.EventHandler(this.btnBookMaintenance_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(54, 332);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(170, 23);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "Add Book to a Client Order";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnClientOrderMaintenance
            // 
            this.btnClientOrderMaintenance.Location = new System.Drawing.Point(54, 275);
            this.btnClientOrderMaintenance.Name = "btnClientOrderMaintenance";
            this.btnClientOrderMaintenance.Size = new System.Drawing.Size(170, 23);
            this.btnClientOrderMaintenance.TabIndex = 3;
            this.btnClientOrderMaintenance.Text = "Client Order Maintenance";
            this.btnClientOrderMaintenance.UseVisualStyleBackColor = true;
            this.btnClientOrderMaintenance.Click += new System.EventHandler(this.btnClientOrderMaintenance_Click);
            // 
            // btnBookInfoMaintenance
            // 
            this.btnBookInfoMaintenance.Location = new System.Drawing.Point(54, 168);
            this.btnBookInfoMaintenance.Name = "btnBookInfoMaintenance";
            this.btnBookInfoMaintenance.Size = new System.Drawing.Size(170, 23);
            this.btnBookInfoMaintenance.TabIndex = 2;
            this.btnBookInfoMaintenance.Text = "Book Info Maintenance";
            this.btnBookInfoMaintenance.UseVisualStyleBackColor = true;
            this.btnBookInfoMaintenance.Click += new System.EventHandler(this.btnBookInfoMaintenance_Click);
            // 
            // btnClientMaintenance
            // 
            this.btnClientMaintenance.Location = new System.Drawing.Point(54, 110);
            this.btnClientMaintenance.Name = "btnClientMaintenance";
            this.btnClientMaintenance.Size = new System.Drawing.Size(170, 23);
            this.btnClientMaintenance.TabIndex = 1;
            this.btnClientMaintenance.Text = "Client Maintenance";
            this.btnClientMaintenance.UseVisualStyleBackColor = true;
            this.btnClientMaintenance.Click += new System.EventHandler(this.btnClientMaintenance_Click);
            // 
            // btnVendorMaintenance
            // 
            this.btnVendorMaintenance.Location = new System.Drawing.Point(54, 47);
            this.btnVendorMaintenance.Name = "btnVendorMaintenance";
            this.btnVendorMaintenance.Size = new System.Drawing.Size(170, 23);
            this.btnVendorMaintenance.TabIndex = 0;
            this.btnVendorMaintenance.Text = "Vendor Maintenance";
            this.btnVendorMaintenance.UseVisualStyleBackColor = true;
            this.btnVendorMaintenance.Click += new System.EventHandler(this.btnVendorMaintenance_Click);
            // 
            // grpReporting
            // 
            this.grpReporting.Controls.Add(this.btnExit);
            this.grpReporting.Controls.Add(this.btnVendors);
            this.grpReporting.Controls.Add(this.btnInvoices);
            this.grpReporting.Location = new System.Drawing.Point(355, 33);
            this.grpReporting.Name = "grpReporting";
            this.grpReporting.Size = new System.Drawing.Size(289, 384);
            this.grpReporting.TabIndex = 1;
            this.grpReporting.TabStop = false;
            this.grpReporting.Text = "Reporting";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(109, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnVendors
            // 
            this.btnVendors.Location = new System.Drawing.Point(109, 110);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(75, 23);
            this.btnVendors.TabIndex = 1;
            this.btnVendors.Text = "Vendors";
            this.btnVendors.UseVisualStyleBackColor = true;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(109, 47);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(75, 23);
            this.btnInvoices.TabIndex = 0;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 470);
            this.Controls.Add(this.grpReporting);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReporting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnBookMaintenance;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnClientOrderMaintenance;
        private System.Windows.Forms.Button btnBookInfoMaintenance;
        private System.Windows.Forms.Button btnClientMaintenance;
        private System.Windows.Forms.Button btnVendorMaintenance;
        private System.Windows.Forms.GroupBox grpReporting;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnInvoices;
    }
}

