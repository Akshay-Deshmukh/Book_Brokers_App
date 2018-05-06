namespace BookBrokersApp
{
    partial class AddBookToClientOrderForm
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
            this.dgvClientOrder = new System.Windows.Forms.DataGridView();
            this.dgvClientOrderBook = new System.Windows.Forms.DataGridView();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.lblClientLastName = new System.Windows.Forms.Label();
            this.lblClientFirstName = new System.Windows.Forms.Label();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.txtClientFirstName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtRemoveBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrderBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientOrder
            // 
            this.dgvClientOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientOrder.Location = new System.Drawing.Point(12, 3);
            this.dgvClientOrder.Name = "dgvClientOrder";
            this.dgvClientOrder.Size = new System.Drawing.Size(383, 214);
            this.dgvClientOrder.TabIndex = 0;
            this.dgvClientOrder.DataMemberChanged += new System.EventHandler(this.dgvClientOrder_DataMemberChanged);
            this.dgvClientOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientOrder_CellClick);
            this.dgvClientOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientOrder_CellContentClick);
            this.dgvClientOrder.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClientOrder_RowHeaderMouseClick);
            this.dgvClientOrder.Click += new System.EventHandler(this.dgvClientOrder_Click);
            // 
            // dgvClientOrderBook
            // 
            this.dgvClientOrderBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientOrderBook.Location = new System.Drawing.Point(26, 232);
            this.dgvClientOrderBook.Name = "dgvClientOrderBook";
            this.dgvClientOrderBook.Size = new System.Drawing.Size(369, 150);
            this.dgvClientOrderBook.TabIndex = 1;
            this.dgvClientOrderBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientOrderBook_CellClick);
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(649, 232);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.Size = new System.Drawing.Size(301, 150);
            this.dgvBook.TabIndex = 2;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            this.dgvBook.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBook_RowHeaderMouseClick);
            // 
            // lblClientLastName
            // 
            this.lblClientLastName.AutoSize = true;
            this.lblClientLastName.Location = new System.Drawing.Point(578, 38);
            this.lblClientLastName.Name = "lblClientLastName";
            this.lblClientLastName.Size = new System.Drawing.Size(90, 13);
            this.lblClientLastName.TabIndex = 3;
            this.lblClientLastName.Text = "Client Last Name:";
            // 
            // lblClientFirstName
            // 
            this.lblClientFirstName.AutoSize = true;
            this.lblClientFirstName.Location = new System.Drawing.Point(579, 87);
            this.lblClientFirstName.Name = "lblClientFirstName";
            this.lblClientFirstName.Size = new System.Drawing.Size(89, 13);
            this.lblClientFirstName.TabIndex = 4;
            this.lblClientFirstName.Text = "Client First Name:";
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Location = new System.Drawing.Point(683, 35);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(100, 20);
            this.txtClientLastName.TabIndex = 5;
            this.txtClientLastName.TextChanged += new System.EventHandler(this.txtClientLastName_TextChanged);
            // 
            // txtClientFirstName
            // 
            this.txtClientFirstName.Location = new System.Drawing.Point(683, 87);
            this.txtClientFirstName.Name = "txtClientFirstName";
            this.txtClientFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtClientFirstName.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(478, 390);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(423, 393);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title:";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(126, 426);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 9;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(708, 426);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtRemoveBook
            // 
            this.txtRemoveBook.Location = new System.Drawing.Point(440, 426);
            this.txtRemoveBook.Name = "txtRemoveBook";
            this.txtRemoveBook.Size = new System.Drawing.Size(75, 23);
            this.txtRemoveBook.TabIndex = 11;
            this.txtRemoveBook.Text = "Remove Book";
            this.txtRemoveBook.UseVisualStyleBackColor = true;
            this.txtRemoveBook.Click += new System.EventHandler(this.txtRemoveBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // AddBookToClientOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 503);
            this.Controls.Add(this.txtClientLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRemoveBook);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtClientFirstName);
            this.Controls.Add(this.lblClientFirstName);
            this.Controls.Add(this.lblClientLastName);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.dgvClientOrderBook);
            this.Controls.Add(this.dgvClientOrder);
            this.Name = "AddBookToClientOrderForm";
            this.Text = "AddBookToClientOrderForm";
            this.Load += new System.EventHandler(this.AddBookToClientOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrderBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientOrder;
        private System.Windows.Forms.DataGridView dgvClientOrderBook;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label lblClientLastName;
        private System.Windows.Forms.Label lblClientFirstName;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.TextBox txtClientFirstName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button txtRemoveBook;
        private System.Windows.Forms.Label label2;
    }
}