namespace BookBrokersApp
{
    partial class VendorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorsForm));
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.printVendors = new System.Drawing.Printing.PrintDocument();
            this.prvlnVendors = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnVendors
            // 
            this.btnVendors.Location = new System.Drawing.Point(77, 62);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(125, 23);
            this.btnVendors.TabIndex = 0;
            this.btnVendors.Text = "Print Vendors";
            this.btnVendors.UseVisualStyleBackColor = true;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(331, 62);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(127, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // printVendors
            // 
            this.printVendors.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printVendors_PrintPage);
            // 
            // prvlnVendors
            // 
            this.prvlnVendors.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvlnVendors.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvlnVendors.ClientSize = new System.Drawing.Size(400, 300);
            this.prvlnVendors.Document = this.printVendors;
            this.prvlnVendors.Enabled = true;
            this.prvlnVendors.Icon = ((System.Drawing.Icon)(resources.GetObject("prvlnVendors.Icon")));
            this.prvlnVendors.Name = "prvlnVendors";
            this.prvlnVendors.Visible = false;
            // 
            // VendorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 167);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnVendors);
            this.Name = "VendorsForm";
            this.Text = "VendorsForm";
            this.Load += new System.EventHandler(this.VendorsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnReturn;
        private System.Drawing.Printing.PrintDocument printVendors;
        private System.Windows.Forms.PrintPreviewDialog prvlnVendors;
    }
}