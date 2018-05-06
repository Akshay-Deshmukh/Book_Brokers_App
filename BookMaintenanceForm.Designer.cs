namespace BookBrokersApp
{
    partial class BookMaintenanceForm
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
            this.lstBookID = new System.Windows.Forms.ListBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblVendorID = new System.Windows.Forms.Label();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.lblClientOrderID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDatePublished = new System.Windows.Forms.TextBox();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtClientOrderID = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblBookInfoID = new System.Windows.Forms.Label();
            this.pnlAddBook = new System.Windows.Forms.Panel();
            this.dtpAddBookPublished = new System.Windows.Forms.DateTimePicker();
            this.btnAddBookCancel = new System.Windows.Forms.Button();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.txtAddBookInfoPrice = new System.Windows.Forms.TextBox();
            this.txtAddBookInfoCost = new System.Windows.Forms.TextBox();
            this.cboAddBookVendorID = new System.Windows.Forms.ComboBox();
            this.cboAddBookVendorName = new System.Windows.Forms.ComboBox();
            this.cboAddBookInfoTitle = new System.Windows.Forms.ComboBox();
            this.cboAddBookInfoID = new System.Windows.Forms.ComboBox();
            this.lblAVendor = new System.Windows.Forms.Label();
            this.lblADateOfPublished = new System.Windows.Forms.Label();
            this.lblAprice = new System.Windows.Forms.Label();
            this.lblAddCost = new System.Windows.Forms.Label();
            this.lblABookInfo = new System.Windows.Forms.Label();
            this.pnlUpdateBook = new System.Windows.Forms.Panel();
            this.txtUpdateBookID = new System.Windows.Forms.TextBox();
            this.lblUpdateBookInfoID = new System.Windows.Forms.Label();
            this.dtpUpdateDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtUpdateVendorName = new System.Windows.Forms.TextBox();
            this.txtUpdateVendorID = new System.Windows.Forms.TextBox();
            this.txtUpdateBookPrice = new System.Windows.Forms.TextBox();
            this.txtUpdateBookCost = new System.Windows.Forms.TextBox();
            this.txtUpdateBookTitle = new System.Windows.Forms.TextBox();
            this.lblUpdateVendorName = new System.Windows.Forms.Label();
            this.lblUpdateVendorID = new System.Windows.Forms.Label();
            this.lblUpdateDateP = new System.Windows.Forms.Label();
            this.lblUpdateBookP = new System.Windows.Forms.Label();
            this.lblUpdateBookC = new System.Windows.Forms.Label();
            this.lblupdateBtitle = new System.Windows.Forms.Label();
            this.lblUpdateBID = new System.Windows.Forms.Label();
            this.pnlAddBook.SuspendLayout();
            this.pnlUpdateBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBookID
            // 
            this.lstBookID.FormattingEnabled = true;
            this.lstBookID.Location = new System.Drawing.Point(22, 12);
            this.lstBookID.Name = "lstBookID";
            this.lstBookID.Size = new System.Drawing.Size(245, 342);
            this.lstBookID.TabIndex = 0;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(339, 12);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(49, 13);
            this.lblBookID.TabIndex = 1;
            this.lblBookID.Text = "Book ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(344, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(343, 87);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 13);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "Cost:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(340, 129);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Location = new System.Drawing.Point(306, 163);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(82, 13);
            this.lblDatePublished.TabIndex = 5;
            this.lblDatePublished.Text = "Date Published:";
            // 
            // lblVendorID
            // 
            this.lblVendorID.AutoSize = true;
            this.lblVendorID.Location = new System.Drawing.Point(330, 203);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(58, 13);
            this.lblVendorID.TabIndex = 6;
            this.lblVendorID.Text = "Vendor ID:";
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Location = new System.Drawing.Point(313, 245);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(75, 13);
            this.lblVendorName.TabIndex = 7;
            this.lblVendorName.Text = "Vendor Name:";
            // 
            // lblClientOrderID
            // 
            this.lblClientOrderID.AutoSize = true;
            this.lblClientOrderID.Location = new System.Drawing.Point(309, 287);
            this.lblClientOrderID.Name = "lblClientOrderID";
            this.lblClientOrderID.Size = new System.Drawing.Size(79, 13);
            this.lblClientOrderID.TabIndex = 8;
            this.lblClientOrderID.Text = "Client Order ID:";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(398, 12);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 20);
            this.txtBookID.TabIndex = 9;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(398, 49);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 10;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(398, 87);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(398, 129);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // txtDatePublished
            // 
            this.txtDatePublished.Location = new System.Drawing.Point(398, 163);
            this.txtDatePublished.Name = "txtDatePublished";
            this.txtDatePublished.Size = new System.Drawing.Size(100, 20);
            this.txtDatePublished.TabIndex = 13;
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(398, 200);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(100, 20);
            this.txtVendorID.TabIndex = 14;
            this.txtVendorID.TextChanged += new System.EventHandler(this.txtVendorID_TextChanged);
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(398, 242);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(100, 20);
            this.txtVendorName.TabIndex = 15;
            // 
            // txtClientOrderID
            // 
            this.txtClientOrderID.Location = new System.Drawing.Point(398, 284);
            this.txtClientOrderID.Name = "txtClientOrderID";
            this.txtClientOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtClientOrderID.TabIndex = 16;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(22, 379);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 17;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(131, 379);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(242, 379);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 19;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(357, 379);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(113, 23);
            this.btnUpdateBook.TabIndex = 20;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(492, 379);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBook.TabIndex = 21;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(492, 429);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 22;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblBookInfoID
            // 
            this.lblBookInfoID.AutoSize = true;
            this.lblBookInfoID.Location = new System.Drawing.Point(412, 15);
            this.lblBookInfoID.Name = "lblBookInfoID";
            this.lblBookInfoID.Size = new System.Drawing.Size(35, 13);
            this.lblBookInfoID.TabIndex = 23;
            this.lblBookInfoID.Text = "label1";
            this.lblBookInfoID.TextChanged += new System.EventHandler(this.lblBookInfoID_TextChanged);
            // 
            // pnlAddBook
            // 
            this.pnlAddBook.Controls.Add(this.dtpAddBookPublished);
            this.pnlAddBook.Controls.Add(this.btnAddBookCancel);
            this.pnlAddBook.Controls.Add(this.btnSaveBook);
            this.pnlAddBook.Controls.Add(this.txtAddBookInfoPrice);
            this.pnlAddBook.Controls.Add(this.txtAddBookInfoCost);
            this.pnlAddBook.Controls.Add(this.cboAddBookVendorID);
            this.pnlAddBook.Controls.Add(this.cboAddBookVendorName);
            this.pnlAddBook.Controls.Add(this.cboAddBookInfoTitle);
            this.pnlAddBook.Controls.Add(this.cboAddBookInfoID);
            this.pnlAddBook.Controls.Add(this.lblAVendor);
            this.pnlAddBook.Controls.Add(this.lblADateOfPublished);
            this.pnlAddBook.Controls.Add(this.lblAprice);
            this.pnlAddBook.Controls.Add(this.lblAddCost);
            this.pnlAddBook.Controls.Add(this.lblABookInfo);
            this.pnlAddBook.Location = new System.Drawing.Point(731, 46);
            this.pnlAddBook.Name = "pnlAddBook";
            this.pnlAddBook.Size = new System.Drawing.Size(493, 359);
            this.pnlAddBook.TabIndex = 24;
            this.pnlAddBook.Visible = false;
            // 
            // dtpAddBookPublished
            // 
            this.dtpAddBookPublished.Location = new System.Drawing.Point(129, 148);
            this.dtpAddBookPublished.Name = "dtpAddBookPublished";
            this.dtpAddBookPublished.Size = new System.Drawing.Size(200, 20);
            this.dtpAddBookPublished.TabIndex = 14;
            // 
            // btnAddBookCancel
            // 
            this.btnAddBookCancel.Location = new System.Drawing.Point(290, 269);
            this.btnAddBookCancel.Name = "btnAddBookCancel";
            this.btnAddBookCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddBookCancel.TabIndex = 13;
            this.btnAddBookCancel.Text = "Cancel";
            this.btnAddBookCancel.UseVisualStyleBackColor = true;
            this.btnAddBookCancel.Click += new System.EventHandler(this.btnAddBookCancel_Click);
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.Location = new System.Drawing.Point(43, 272);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBook.TabIndex = 12;
            this.btnSaveBook.Text = "Save Book";
            this.btnSaveBook.UseVisualStyleBackColor = true;
            this.btnSaveBook.Click += new System.EventHandler(this.btnSaveBook_Click);
            // 
            // txtAddBookInfoPrice
            // 
            this.txtAddBookInfoPrice.Location = new System.Drawing.Point(129, 114);
            this.txtAddBookInfoPrice.Name = "txtAddBookInfoPrice";
            this.txtAddBookInfoPrice.Size = new System.Drawing.Size(100, 20);
            this.txtAddBookInfoPrice.TabIndex = 11;
            // 
            // txtAddBookInfoCost
            // 
            this.txtAddBookInfoCost.Location = new System.Drawing.Point(129, 76);
            this.txtAddBookInfoCost.Name = "txtAddBookInfoCost";
            this.txtAddBookInfoCost.Size = new System.Drawing.Size(100, 20);
            this.txtAddBookInfoCost.TabIndex = 10;
            // 
            // cboAddBookVendorID
            // 
            this.cboAddBookVendorID.FormattingEnabled = true;
            this.cboAddBookVendorID.Location = new System.Drawing.Point(129, 184);
            this.cboAddBookVendorID.Name = "cboAddBookVendorID";
            this.cboAddBookVendorID.Size = new System.Drawing.Size(44, 21);
            this.cboAddBookVendorID.TabIndex = 8;
            // 
            // cboAddBookVendorName
            // 
            this.cboAddBookVendorName.FormattingEnabled = true;
            this.cboAddBookVendorName.Location = new System.Drawing.Point(186, 184);
            this.cboAddBookVendorName.Name = "cboAddBookVendorName";
            this.cboAddBookVendorName.Size = new System.Drawing.Size(121, 21);
            this.cboAddBookVendorName.TabIndex = 7;
            // 
            // cboAddBookInfoTitle
            // 
            this.cboAddBookInfoTitle.FormattingEnabled = true;
            this.cboAddBookInfoTitle.Location = new System.Drawing.Point(186, 37);
            this.cboAddBookInfoTitle.Name = "cboAddBookInfoTitle";
            this.cboAddBookInfoTitle.Size = new System.Drawing.Size(121, 21);
            this.cboAddBookInfoTitle.TabIndex = 6;
            // 
            // cboAddBookInfoID
            // 
            this.cboAddBookInfoID.FormattingEnabled = true;
            this.cboAddBookInfoID.Location = new System.Drawing.Point(129, 38);
            this.cboAddBookInfoID.Name = "cboAddBookInfoID";
            this.cboAddBookInfoID.Size = new System.Drawing.Size(44, 21);
            this.cboAddBookInfoID.TabIndex = 5;
            // 
            // lblAVendor
            // 
            this.lblAVendor.AutoSize = true;
            this.lblAVendor.Location = new System.Drawing.Point(61, 187);
            this.lblAVendor.Name = "lblAVendor";
            this.lblAVendor.Size = new System.Drawing.Size(41, 13);
            this.lblAVendor.TabIndex = 4;
            this.lblAVendor.Text = "Vendor";
            // 
            // lblADateOfPublished
            // 
            this.lblADateOfPublished.AutoSize = true;
            this.lblADateOfPublished.Location = new System.Drawing.Point(32, 148);
            this.lblADateOfPublished.Name = "lblADateOfPublished";
            this.lblADateOfPublished.Size = new System.Drawing.Size(82, 13);
            this.lblADateOfPublished.TabIndex = 3;
            this.lblADateOfPublished.Text = "Date Published:";
            // 
            // lblAprice
            // 
            this.lblAprice.AutoSize = true;
            this.lblAprice.Location = new System.Drawing.Point(62, 114);
            this.lblAprice.Name = "lblAprice";
            this.lblAprice.Size = new System.Drawing.Size(34, 13);
            this.lblAprice.TabIndex = 2;
            this.lblAprice.Text = "Price:";
            // 
            // lblAddCost
            // 
            this.lblAddCost.AutoSize = true;
            this.lblAddCost.Location = new System.Drawing.Point(65, 79);
            this.lblAddCost.Name = "lblAddCost";
            this.lblAddCost.Size = new System.Drawing.Size(31, 13);
            this.lblAddCost.TabIndex = 1;
            this.lblAddCost.Text = "Cost:";
            // 
            // lblABookInfo
            // 
            this.lblABookInfo.AutoSize = true;
            this.lblABookInfo.Location = new System.Drawing.Point(40, 41);
            this.lblABookInfo.Name = "lblABookInfo";
            this.lblABookInfo.Size = new System.Drawing.Size(56, 13);
            this.lblABookInfo.TabIndex = 0;
            this.lblABookInfo.Text = "Book Info:";
            // 
            // pnlUpdateBook
            // 
            this.pnlUpdateBook.Controls.Add(this.txtUpdateBookID);
            this.pnlUpdateBook.Controls.Add(this.lblUpdateBookInfoID);
            this.pnlUpdateBook.Controls.Add(this.dtpUpdateDate);
            this.pnlUpdateBook.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateBook.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateBook.Controls.Add(this.txtUpdateVendorName);
            this.pnlUpdateBook.Controls.Add(this.txtUpdateVendorID);
            this.pnlUpdateBook.Controls.Add(this.txtUpdateBookPrice);
            this.pnlUpdateBook.Controls.Add(this.txtUpdateBookCost);
            this.pnlUpdateBook.Controls.Add(this.txtUpdateBookTitle);
            this.pnlUpdateBook.Controls.Add(this.lblUpdateVendorName);
            this.pnlUpdateBook.Controls.Add(this.lblUpdateVendorID);
            this.pnlUpdateBook.Controls.Add(this.lblUpdateDateP);
            this.pnlUpdateBook.Controls.Add(this.lblUpdateBookP);
            this.pnlUpdateBook.Controls.Add(this.lblUpdateBookC);
            this.pnlUpdateBook.Controls.Add(this.lblupdateBtitle);
            this.pnlUpdateBook.Controls.Add(this.lblUpdateBID);
            this.pnlUpdateBook.Location = new System.Drawing.Point(688, 429);
            this.pnlUpdateBook.Name = "pnlUpdateBook";
            this.pnlUpdateBook.Size = new System.Drawing.Size(477, 358);
            this.pnlUpdateBook.TabIndex = 15;
            this.pnlUpdateBook.Visible = false;
            this.pnlUpdateBook.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUpdateBook_Paint);
            // 
            // txtUpdateBookID
            // 
            this.txtUpdateBookID.Location = new System.Drawing.Point(122, 31);
            this.txtUpdateBookID.Name = "txtUpdateBookID";
            this.txtUpdateBookID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateBookID.TabIndex = 7;
            this.txtUpdateBookID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblUpdateBookInfoID
            // 
            this.lblUpdateBookInfoID.AutoSize = true;
            this.lblUpdateBookInfoID.Location = new System.Drawing.Point(146, 34);
            this.lblUpdateBookInfoID.Name = "lblUpdateBookInfoID";
            this.lblUpdateBookInfoID.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateBookInfoID.TabIndex = 17;
            this.lblUpdateBookInfoID.Text = "label1";
            this.lblUpdateBookInfoID.TextChanged += new System.EventHandler(this.lblUpdateBookInfoID_TextChanged);
            this.lblUpdateBookInfoID.Click += new System.EventHandler(this.lblUpdateBookInfoID_Click);
            // 
            // dtpUpdateDate
            // 
            this.dtpUpdateDate.Location = new System.Drawing.Point(122, 177);
            this.dtpUpdateDate.Name = "dtpUpdateDate";
            this.dtpUpdateDate.Size = new System.Drawing.Size(200, 20);
            this.dtpUpdateDate.TabIndex = 16;
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(288, 320);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCancel.TabIndex = 15;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(53, 320);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(128, 23);
            this.btnSaveChanges.TabIndex = 14;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtUpdateVendorName
            // 
            this.txtUpdateVendorName.Location = new System.Drawing.Point(122, 262);
            this.txtUpdateVendorName.Name = "txtUpdateVendorName";
            this.txtUpdateVendorName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateVendorName.TabIndex = 13;
            // 
            // txtUpdateVendorID
            // 
            this.txtUpdateVendorID.Location = new System.Drawing.Point(122, 223);
            this.txtUpdateVendorID.Name = "txtUpdateVendorID";
            this.txtUpdateVendorID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateVendorID.TabIndex = 12;
            this.txtUpdateVendorID.TextChanged += new System.EventHandler(this.txtUpdateVendorID_TextChanged);
            // 
            // txtUpdateBookPrice
            // 
            this.txtUpdateBookPrice.Location = new System.Drawing.Point(122, 145);
            this.txtUpdateBookPrice.Name = "txtUpdateBookPrice";
            this.txtUpdateBookPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateBookPrice.TabIndex = 10;
            // 
            // txtUpdateBookCost
            // 
            this.txtUpdateBookCost.Location = new System.Drawing.Point(122, 107);
            this.txtUpdateBookCost.Name = "txtUpdateBookCost";
            this.txtUpdateBookCost.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateBookCost.TabIndex = 9;
            // 
            // txtUpdateBookTitle
            // 
            this.txtUpdateBookTitle.Location = new System.Drawing.Point(122, 69);
            this.txtUpdateBookTitle.Name = "txtUpdateBookTitle";
            this.txtUpdateBookTitle.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateBookTitle.TabIndex = 8;
            // 
            // lblUpdateVendorName
            // 
            this.lblUpdateVendorName.AutoSize = true;
            this.lblUpdateVendorName.Location = new System.Drawing.Point(33, 265);
            this.lblUpdateVendorName.Name = "lblUpdateVendorName";
            this.lblUpdateVendorName.Size = new System.Drawing.Size(75, 13);
            this.lblUpdateVendorName.TabIndex = 6;
            this.lblUpdateVendorName.Text = "Vendor Name:";
            // 
            // lblUpdateVendorID
            // 
            this.lblUpdateVendorID.AutoSize = true;
            this.lblUpdateVendorID.Location = new System.Drawing.Point(50, 230);
            this.lblUpdateVendorID.Name = "lblUpdateVendorID";
            this.lblUpdateVendorID.Size = new System.Drawing.Size(58, 13);
            this.lblUpdateVendorID.TabIndex = 5;
            this.lblUpdateVendorID.Text = "Vendor ID:";
            // 
            // lblUpdateDateP
            // 
            this.lblUpdateDateP.AutoSize = true;
            this.lblUpdateDateP.Location = new System.Drawing.Point(27, 185);
            this.lblUpdateDateP.Name = "lblUpdateDateP";
            this.lblUpdateDateP.Size = new System.Drawing.Size(82, 13);
            this.lblUpdateDateP.TabIndex = 4;
            this.lblUpdateDateP.Text = "Date Published:";
            // 
            // lblUpdateBookP
            // 
            this.lblUpdateBookP.AutoSize = true;
            this.lblUpdateBookP.Location = new System.Drawing.Point(74, 148);
            this.lblUpdateBookP.Name = "lblUpdateBookP";
            this.lblUpdateBookP.Size = new System.Drawing.Size(34, 13);
            this.lblUpdateBookP.TabIndex = 3;
            this.lblUpdateBookP.Text = "Price:";
            // 
            // lblUpdateBookC
            // 
            this.lblUpdateBookC.AutoSize = true;
            this.lblUpdateBookC.Location = new System.Drawing.Point(74, 105);
            this.lblUpdateBookC.Name = "lblUpdateBookC";
            this.lblUpdateBookC.Size = new System.Drawing.Size(31, 13);
            this.lblUpdateBookC.TabIndex = 2;
            this.lblUpdateBookC.Text = "Cost:";
            // 
            // lblupdateBtitle
            // 
            this.lblupdateBtitle.AutoSize = true;
            this.lblupdateBtitle.Location = new System.Drawing.Point(74, 72);
            this.lblupdateBtitle.Name = "lblupdateBtitle";
            this.lblupdateBtitle.Size = new System.Drawing.Size(30, 13);
            this.lblupdateBtitle.TabIndex = 1;
            this.lblupdateBtitle.Text = "Title:";
            // 
            // lblUpdateBID
            // 
            this.lblUpdateBID.AutoSize = true;
            this.lblUpdateBID.Location = new System.Drawing.Point(60, 34);
            this.lblUpdateBID.Name = "lblUpdateBID";
            this.lblUpdateBID.Size = new System.Drawing.Size(49, 13);
            this.lblUpdateBID.TabIndex = 0;
            this.lblUpdateBID.Text = "Book ID:";
            // 
            // BookMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 661);
            this.Controls.Add(this.pnlUpdateBook);
            this.Controls.Add(this.pnlAddBook);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lblBookInfoID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtClientOrderID);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.txtDatePublished);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblClientOrderID);
            this.Controls.Add(this.lblVendorName);
            this.Controls.Add(this.lblVendorID);
            this.Controls.Add(this.lblDatePublished);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lstBookID);
            this.Name = "BookMaintenanceForm";
            this.Text = "BookMaintenanceForm";
            this.Load += new System.EventHandler(this.BookMaintenanceForm_Load);
            this.pnlAddBook.ResumeLayout(false);
            this.pnlAddBook.PerformLayout();
            this.pnlUpdateBook.ResumeLayout(false);
            this.pnlUpdateBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBookID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDatePublished;
        private System.Windows.Forms.Label lblVendorID;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Label lblClientOrderID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDatePublished;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.TextBox txtClientOrderID;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblBookInfoID;
        private System.Windows.Forms.Panel pnlAddBook;
        private System.Windows.Forms.Button btnAddBookCancel;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.TextBox txtAddBookInfoPrice;
        private System.Windows.Forms.TextBox txtAddBookInfoCost;
        private System.Windows.Forms.ComboBox cboAddBookVendorID;
        private System.Windows.Forms.ComboBox cboAddBookVendorName;
        private System.Windows.Forms.ComboBox cboAddBookInfoTitle;
        private System.Windows.Forms.ComboBox cboAddBookInfoID;
        private System.Windows.Forms.Label lblAVendor;
        private System.Windows.Forms.Label lblADateOfPublished;
        private System.Windows.Forms.Label lblAprice;
        private System.Windows.Forms.Label lblAddCost;
        private System.Windows.Forms.Label lblABookInfo;
        private System.Windows.Forms.DateTimePicker dtpAddBookPublished;
        private System.Windows.Forms.Panel pnlUpdateBook;
        private System.Windows.Forms.DateTimePicker dtpUpdateDate;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateVendorName;
        private System.Windows.Forms.TextBox txtUpdateVendorID;
        private System.Windows.Forms.TextBox txtUpdateBookPrice;
        private System.Windows.Forms.TextBox txtUpdateBookCost;
        private System.Windows.Forms.TextBox txtUpdateBookTitle;
        private System.Windows.Forms.TextBox txtUpdateBookID;
        private System.Windows.Forms.Label lblUpdateVendorName;
        private System.Windows.Forms.Label lblUpdateVendorID;
        private System.Windows.Forms.Label lblUpdateDateP;
        private System.Windows.Forms.Label lblUpdateBookP;
        private System.Windows.Forms.Label lblUpdateBookC;
        private System.Windows.Forms.Label lblupdateBtitle;
        private System.Windows.Forms.Label lblUpdateBID;
        private System.Windows.Forms.Label lblUpdateBookInfoID;
    }
}