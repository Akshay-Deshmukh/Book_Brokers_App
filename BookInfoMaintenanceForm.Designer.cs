namespace BookBrokersApp
{
    partial class BookInfoMaintenanceForm
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
            this.lstBooktitles = new System.Windows.Forms.ListBox();
            this.lblBookInfoID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.lblAuthorLastName = new System.Windows.Forms.Label();
            this.lblAuthorFirstName = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtBookInfoID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.txtAuthorLastName = new System.Windows.Forms.TextBox();
            this.txtAuthorFirstName = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddBookInfo = new System.Windows.Forms.Button();
            this.btnUpdateBookInfo = new System.Windows.Forms.Button();
            this.btnDeleteBookInfo = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddBookInfo = new System.Windows.Forms.Panel();
            this.pnlUpdateBookInfo = new System.Windows.Forms.Panel();
            this.btnUpdateBookCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtUpdateNotes = new System.Windows.Forms.TextBox();
            this.txtUpdateAuthorFirstName = new System.Windows.Forms.TextBox();
            this.txtUpdateAuthorLastName = new System.Windows.Forms.TextBox();
            this.txtUpdateAuthorID = new System.Windows.Forms.TextBox();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.txtUpdateBookInfoID = new System.Windows.Forms.TextBox();
            this.lblUpdateNote = new System.Windows.Forms.Label();
            this.lblUpdateAuthorFirst = new System.Windows.Forms.Label();
            this.lblUpdateAuthorL = new System.Windows.Forms.Label();
            this.lblUpdateBookInfoAuthorID = new System.Windows.Forms.Label();
            this.lblUpdateBookInfoTitle = new System.Windows.Forms.Label();
            this.lblUpdateBookInfoID = new System.Windows.Forms.Label();
            this.btnAddBookInfoCancel = new System.Windows.Forms.Button();
            this.btnSaveBookInfo = new System.Windows.Forms.Button();
            this.cboAddAuthorFirstName = new System.Windows.Forms.ComboBox();
            this.cboAddAuthorLastName = new System.Windows.Forms.ComboBox();
            this.cboAddBookAuthorID = new System.Windows.Forms.ComboBox();
            this.txtAddAuthorNotes = new System.Windows.Forms.TextBox();
            this.txtAddBookTitle = new System.Windows.Forms.TextBox();
            this.lblAddBookNotes = new System.Windows.Forms.Label();
            this.lblAddBookAuthor = new System.Windows.Forms.Label();
            this.lblAddBookTitle = new System.Windows.Forms.Label();
            this.pnlAddBookInfo.SuspendLayout();
            this.pnlUpdateBookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBooktitles
            // 
            this.lstBooktitles.FormattingEnabled = true;
            this.lstBooktitles.Location = new System.Drawing.Point(37, 27);
            this.lstBooktitles.Name = "lstBooktitles";
            this.lstBooktitles.Size = new System.Drawing.Size(137, 277);
            this.lstBooktitles.TabIndex = 0;
            // 
            // lblBookInfoID
            // 
            this.lblBookInfoID.AutoSize = true;
            this.lblBookInfoID.Location = new System.Drawing.Point(197, 30);
            this.lblBookInfoID.Name = "lblBookInfoID";
            this.lblBookInfoID.Size = new System.Drawing.Size(67, 13);
            this.lblBookInfoID.TabIndex = 1;
            this.lblBookInfoID.Text = "Book Info ID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(234, 71);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Location = new System.Drawing.Point(212, 110);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(52, 13);
            this.lblAuthorID.TabIndex = 3;
            this.lblAuthorID.Text = "Author ID";
            // 
            // lblAuthorLastName
            // 
            this.lblAuthorLastName.AutoSize = true;
            this.lblAuthorLastName.Location = new System.Drawing.Point(179, 159);
            this.lblAuthorLastName.Name = "lblAuthorLastName";
            this.lblAuthorLastName.Size = new System.Drawing.Size(95, 13);
            this.lblAuthorLastName.TabIndex = 4;
            this.lblAuthorLastName.Text = "Author Last Name:";
            // 
            // lblAuthorFirstName
            // 
            this.lblAuthorFirstName.AutoSize = true;
            this.lblAuthorFirstName.Location = new System.Drawing.Point(180, 199);
            this.lblAuthorFirstName.Name = "lblAuthorFirstName";
            this.lblAuthorFirstName.Size = new System.Drawing.Size(94, 13);
            this.lblAuthorFirstName.TabIndex = 5;
            this.lblAuthorFirstName.Text = "Author First Name:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(229, 242);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notes";
            // 
            // txtBookInfoID
            // 
            this.txtBookInfoID.Location = new System.Drawing.Point(282, 27);
            this.txtBookInfoID.Name = "txtBookInfoID";
            this.txtBookInfoID.Size = new System.Drawing.Size(100, 20);
            this.txtBookInfoID.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(282, 71);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(226, 20);
            this.txtTitle.TabIndex = 8;
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Location = new System.Drawing.Point(282, 110);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(57, 20);
            this.txtAuthorID.TabIndex = 9;
            this.txtAuthorID.TextChanged += new System.EventHandler(this.txtAuthorID_TextChanged);
            // 
            // txtAuthorLastName
            // 
            this.txtAuthorLastName.Location = new System.Drawing.Point(282, 152);
            this.txtAuthorLastName.Name = "txtAuthorLastName";
            this.txtAuthorLastName.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorLastName.TabIndex = 10;
            // 
            // txtAuthorFirstName
            // 
            this.txtAuthorFirstName.Location = new System.Drawing.Point(282, 196);
            this.txtAuthorFirstName.Name = "txtAuthorFirstName";
            this.txtAuthorFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorFirstName.TabIndex = 11;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(282, 242);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(470, 90);
            this.txtNotes.TabIndex = 12;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(56, 404);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(161, 404);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddBookInfo
            // 
            this.btnAddBookInfo.Location = new System.Drawing.Point(270, 404);
            this.btnAddBookInfo.Name = "btnAddBookInfo";
            this.btnAddBookInfo.Size = new System.Drawing.Size(103, 23);
            this.btnAddBookInfo.TabIndex = 15;
            this.btnAddBookInfo.Text = "Add Book Info";
            this.btnAddBookInfo.UseVisualStyleBackColor = true;
            this.btnAddBookInfo.Click += new System.EventHandler(this.btnAddBookInfo_Click);
            // 
            // btnUpdateBookInfo
            // 
            this.btnUpdateBookInfo.Location = new System.Drawing.Point(406, 404);
            this.btnUpdateBookInfo.Name = "btnUpdateBookInfo";
            this.btnUpdateBookInfo.Size = new System.Drawing.Size(131, 23);
            this.btnUpdateBookInfo.TabIndex = 16;
            this.btnUpdateBookInfo.Text = "Update Book Info";
            this.btnUpdateBookInfo.UseVisualStyleBackColor = true;
            this.btnUpdateBookInfo.Click += new System.EventHandler(this.btnUpdateBookInfo_Click);
            // 
            // btnDeleteBookInfo
            // 
            this.btnDeleteBookInfo.Location = new System.Drawing.Point(588, 404);
            this.btnDeleteBookInfo.Name = "btnDeleteBookInfo";
            this.btnDeleteBookInfo.Size = new System.Drawing.Size(134, 23);
            this.btnDeleteBookInfo.TabIndex = 17;
            this.btnDeleteBookInfo.Text = "Delete Book Info";
            this.btnDeleteBookInfo.UseVisualStyleBackColor = true;
            this.btnDeleteBookInfo.Click += new System.EventHandler(this.btnDeleteBookInfo_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(619, 455);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.button6_Click);
            // 
            // pnlAddBookInfo
            // 
            this.pnlAddBookInfo.Controls.Add(this.btnAddBookInfoCancel);
            this.pnlAddBookInfo.Controls.Add(this.btnSaveBookInfo);
            this.pnlAddBookInfo.Controls.Add(this.cboAddAuthorFirstName);
            this.pnlAddBookInfo.Controls.Add(this.cboAddAuthorLastName);
            this.pnlAddBookInfo.Controls.Add(this.cboAddBookAuthorID);
            this.pnlAddBookInfo.Controls.Add(this.txtAddAuthorNotes);
            this.pnlAddBookInfo.Controls.Add(this.txtAddBookTitle);
            this.pnlAddBookInfo.Controls.Add(this.lblAddBookNotes);
            this.pnlAddBookInfo.Controls.Add(this.lblAddBookAuthor);
            this.pnlAddBookInfo.Controls.Add(this.lblAddBookTitle);
            this.pnlAddBookInfo.Location = new System.Drawing.Point(781, 428);
            this.pnlAddBookInfo.Name = "pnlAddBookInfo";
            this.pnlAddBookInfo.Size = new System.Drawing.Size(531, 376);
            this.pnlAddBookInfo.TabIndex = 19;
            this.pnlAddBookInfo.Visible = false;
            // 
            // pnlUpdateBookInfo
            // 
            this.pnlUpdateBookInfo.Controls.Add(this.btnUpdateBookCancel);
            this.pnlUpdateBookInfo.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateNotes);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateAuthorFirstName);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateAuthorLastName);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateAuthorID);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateTitle);
            this.pnlUpdateBookInfo.Controls.Add(this.txtUpdateBookInfoID);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateNote);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateAuthorFirst);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateAuthorL);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateBookInfoAuthorID);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateBookInfoTitle);
            this.pnlUpdateBookInfo.Controls.Add(this.lblUpdateBookInfoID);
            this.pnlUpdateBookInfo.Location = new System.Drawing.Point(781, 18);
            this.pnlUpdateBookInfo.Name = "pnlUpdateBookInfo";
            this.pnlUpdateBookInfo.Size = new System.Drawing.Size(523, 370);
            this.pnlUpdateBookInfo.TabIndex = 10;
            this.pnlUpdateBookInfo.Visible = false;
            // 
            // btnUpdateBookCancel
            // 
            this.btnUpdateBookCancel.Location = new System.Drawing.Point(337, 336);
            this.btnUpdateBookCancel.Name = "btnUpdateBookCancel";
            this.btnUpdateBookCancel.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBookCancel.TabIndex = 13;
            this.btnUpdateBookCancel.Text = "Cancel";
            this.btnUpdateBookCancel.UseVisualStyleBackColor = true;
            this.btnUpdateBookCancel.Click += new System.EventHandler(this.btnUpdateBookCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(65, 336);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(131, 23);
            this.btnSaveChanges.TabIndex = 12;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtUpdateNotes
            // 
            this.txtUpdateNotes.Location = new System.Drawing.Point(123, 204);
            this.txtUpdateNotes.Multiline = true;
            this.txtUpdateNotes.Name = "txtUpdateNotes";
            this.txtUpdateNotes.Size = new System.Drawing.Size(334, 102);
            this.txtUpdateNotes.TabIndex = 11;
            // 
            // txtUpdateAuthorFirstName
            // 
            this.txtUpdateAuthorFirstName.Location = new System.Drawing.Point(123, 166);
            this.txtUpdateAuthorFirstName.Name = "txtUpdateAuthorFirstName";
            this.txtUpdateAuthorFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAuthorFirstName.TabIndex = 10;
            // 
            // txtUpdateAuthorLastName
            // 
            this.txtUpdateAuthorLastName.Location = new System.Drawing.Point(123, 131);
            this.txtUpdateAuthorLastName.Name = "txtUpdateAuthorLastName";
            this.txtUpdateAuthorLastName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAuthorLastName.TabIndex = 9;
            // 
            // txtUpdateAuthorID
            // 
            this.txtUpdateAuthorID.Location = new System.Drawing.Point(123, 95);
            this.txtUpdateAuthorID.Name = "txtUpdateAuthorID";
            this.txtUpdateAuthorID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAuthorID.TabIndex = 8;
            this.txtUpdateAuthorID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Location = new System.Drawing.Point(123, 56);
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateTitle.TabIndex = 7;
            // 
            // txtUpdateBookInfoID
            // 
            this.txtUpdateBookInfoID.Location = new System.Drawing.Point(123, 19);
            this.txtUpdateBookInfoID.Name = "txtUpdateBookInfoID";
            this.txtUpdateBookInfoID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateBookInfoID.TabIndex = 6;
            // 
            // lblUpdateNote
            // 
            this.lblUpdateNote.AutoSize = true;
            this.lblUpdateNote.Location = new System.Drawing.Point(43, 207);
            this.lblUpdateNote.Name = "lblUpdateNote";
            this.lblUpdateNote.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateNote.TabIndex = 5;
            this.lblUpdateNote.Text = "Notes";
            // 
            // lblUpdateAuthorFirst
            // 
            this.lblUpdateAuthorFirst.AutoSize = true;
            this.lblUpdateAuthorFirst.Location = new System.Drawing.Point(20, 166);
            this.lblUpdateAuthorFirst.Name = "lblUpdateAuthorFirst";
            this.lblUpdateAuthorFirst.Size = new System.Drawing.Size(94, 13);
            this.lblUpdateAuthorFirst.TabIndex = 4;
            this.lblUpdateAuthorFirst.Text = "Author First Name:";
            // 
            // lblUpdateAuthorL
            // 
            this.lblUpdateAuthorL.AutoSize = true;
            this.lblUpdateAuthorL.Location = new System.Drawing.Point(18, 134);
            this.lblUpdateAuthorL.Name = "lblUpdateAuthorL";
            this.lblUpdateAuthorL.Size = new System.Drawing.Size(95, 13);
            this.lblUpdateAuthorL.TabIndex = 3;
            this.lblUpdateAuthorL.Text = "Author Last Name:";
            // 
            // lblUpdateBookInfoAuthorID
            // 
            this.lblUpdateBookInfoAuthorID.AutoSize = true;
            this.lblUpdateBookInfoAuthorID.Location = new System.Drawing.Point(58, 101);
            this.lblUpdateBookInfoAuthorID.Name = "lblUpdateBookInfoAuthorID";
            this.lblUpdateBookInfoAuthorID.Size = new System.Drawing.Size(55, 13);
            this.lblUpdateBookInfoAuthorID.TabIndex = 2;
            this.lblUpdateBookInfoAuthorID.Text = "Author ID:";
            // 
            // lblUpdateBookInfoTitle
            // 
            this.lblUpdateBookInfoTitle.AutoSize = true;
            this.lblUpdateBookInfoTitle.Location = new System.Drawing.Point(83, 61);
            this.lblUpdateBookInfoTitle.Name = "lblUpdateBookInfoTitle";
            this.lblUpdateBookInfoTitle.Size = new System.Drawing.Size(30, 13);
            this.lblUpdateBookInfoTitle.TabIndex = 1;
            this.lblUpdateBookInfoTitle.Text = "Title:";
            // 
            // lblUpdateBookInfoID
            // 
            this.lblUpdateBookInfoID.AutoSize = true;
            this.lblUpdateBookInfoID.Location = new System.Drawing.Point(43, 22);
            this.lblUpdateBookInfoID.Name = "lblUpdateBookInfoID";
            this.lblUpdateBookInfoID.Size = new System.Drawing.Size(70, 13);
            this.lblUpdateBookInfoID.TabIndex = 0;
            this.lblUpdateBookInfoID.Text = "Book Info ID:";
            // 
            // btnAddBookInfoCancel
            // 
            this.btnAddBookInfoCancel.Location = new System.Drawing.Point(362, 339);
            this.btnAddBookInfoCancel.Name = "btnAddBookInfoCancel";
            this.btnAddBookInfoCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddBookInfoCancel.TabIndex = 9;
            this.btnAddBookInfoCancel.Text = "Cancel";
            this.btnAddBookInfoCancel.UseVisualStyleBackColor = true;
            this.btnAddBookInfoCancel.Click += new System.EventHandler(this.btnAddBookInfoCancel_Click);
            // 
            // btnSaveBookInfo
            // 
            this.btnSaveBookInfo.Location = new System.Drawing.Point(41, 339);
            this.btnSaveBookInfo.Name = "btnSaveBookInfo";
            this.btnSaveBookInfo.Size = new System.Drawing.Size(131, 23);
            this.btnSaveBookInfo.TabIndex = 8;
            this.btnSaveBookInfo.Text = "Save Book Info";
            this.btnSaveBookInfo.UseVisualStyleBackColor = true;
            this.btnSaveBookInfo.Click += new System.EventHandler(this.btnSaveBookInfo_Click);
            // 
            // cboAddAuthorFirstName
            // 
            this.cboAddAuthorFirstName.FormattingEnabled = true;
            this.cboAddAuthorFirstName.Location = new System.Drawing.Point(340, 111);
            this.cboAddAuthorFirstName.Name = "cboAddAuthorFirstName";
            this.cboAddAuthorFirstName.Size = new System.Drawing.Size(121, 21);
            this.cboAddAuthorFirstName.TabIndex = 7;
            // 
            // cboAddAuthorLastName
            // 
            this.cboAddAuthorLastName.FormattingEnabled = true;
            this.cboAddAuthorLastName.Location = new System.Drawing.Point(191, 111);
            this.cboAddAuthorLastName.Name = "cboAddAuthorLastName";
            this.cboAddAuthorLastName.Size = new System.Drawing.Size(121, 21);
            this.cboAddAuthorLastName.TabIndex = 6;
            // 
            // cboAddBookAuthorID
            // 
            this.cboAddBookAuthorID.FormattingEnabled = true;
            this.cboAddBookAuthorID.Location = new System.Drawing.Point(128, 111);
            this.cboAddBookAuthorID.Name = "cboAddBookAuthorID";
            this.cboAddBookAuthorID.Size = new System.Drawing.Size(44, 21);
            this.cboAddBookAuthorID.TabIndex = 5;
            // 
            // txtAddAuthorNotes
            // 
            this.txtAddAuthorNotes.Location = new System.Drawing.Point(128, 166);
            this.txtAddAuthorNotes.Multiline = true;
            this.txtAddAuthorNotes.Name = "txtAddAuthorNotes";
            this.txtAddAuthorNotes.Size = new System.Drawing.Size(292, 154);
            this.txtAddAuthorNotes.TabIndex = 4;
            this.txtAddAuthorNotes.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAddBookTitle
            // 
            this.txtAddBookTitle.Location = new System.Drawing.Point(128, 52);
            this.txtAddBookTitle.Name = "txtAddBookTitle";
            this.txtAddBookTitle.Size = new System.Drawing.Size(100, 20);
            this.txtAddBookTitle.TabIndex = 3;
            // 
            // lblAddBookNotes
            // 
            this.lblAddBookNotes.AutoSize = true;
            this.lblAddBookNotes.Location = new System.Drawing.Point(56, 184);
            this.lblAddBookNotes.Name = "lblAddBookNotes";
            this.lblAddBookNotes.Size = new System.Drawing.Size(38, 13);
            this.lblAddBookNotes.TabIndex = 2;
            this.lblAddBookNotes.Text = "Notes:";
            // 
            // lblAddBookAuthor
            // 
            this.lblAddBookAuthor.AutoSize = true;
            this.lblAddBookAuthor.Location = new System.Drawing.Point(50, 111);
            this.lblAddBookAuthor.Name = "lblAddBookAuthor";
            this.lblAddBookAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAddBookAuthor.TabIndex = 1;
            this.lblAddBookAuthor.Text = "Author:";
            // 
            // lblAddBookTitle
            // 
            this.lblAddBookTitle.AutoSize = true;
            this.lblAddBookTitle.Location = new System.Drawing.Point(52, 55);
            this.lblAddBookTitle.Name = "lblAddBookTitle";
            this.lblAddBookTitle.Size = new System.Drawing.Size(30, 13);
            this.lblAddBookTitle.TabIndex = 0;
            this.lblAddBookTitle.Text = "Title:";
            // 
            // BookInfoMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 510);
            this.Controls.Add(this.pnlAddBookInfo);
            this.Controls.Add(this.pnlUpdateBookInfo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteBookInfo);
            this.Controls.Add(this.btnUpdateBookInfo);
            this.Controls.Add(this.btnAddBookInfo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtAuthorFirstName);
            this.Controls.Add(this.txtAuthorLastName);
            this.Controls.Add(this.txtAuthorID);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtBookInfoID);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblAuthorFirstName);
            this.Controls.Add(this.lblAuthorLastName);
            this.Controls.Add(this.lblAuthorID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBookInfoID);
            this.Controls.Add(this.lstBooktitles);
            this.Name = "BookInfoMaintenanceForm";
            this.Text = "BookInfoMaintenanceForm";
            this.Load += new System.EventHandler(this.BookInfoMaintenanceForm_Load);
            this.pnlAddBookInfo.ResumeLayout(false);
            this.pnlAddBookInfo.PerformLayout();
            this.pnlUpdateBookInfo.ResumeLayout(false);
            this.pnlUpdateBookInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBooktitles;
        private System.Windows.Forms.Label lblBookInfoID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthorID;
        private System.Windows.Forms.Label lblAuthorLastName;
        private System.Windows.Forms.Label lblAuthorFirstName;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtBookInfoID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.TextBox txtAuthorLastName;
        private System.Windows.Forms.TextBox txtAuthorFirstName;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddBookInfo;
        private System.Windows.Forms.Button btnUpdateBookInfo;
        private System.Windows.Forms.Button btnDeleteBookInfo;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddBookInfo;
        private System.Windows.Forms.ComboBox cboAddBookAuthorID;
        private System.Windows.Forms.TextBox txtAddAuthorNotes;
        private System.Windows.Forms.TextBox txtAddBookTitle;
        private System.Windows.Forms.Label lblAddBookNotes;
        private System.Windows.Forms.Label lblAddBookAuthor;
        private System.Windows.Forms.Label lblAddBookTitle;
        private System.Windows.Forms.ComboBox cboAddAuthorFirstName;
        private System.Windows.Forms.ComboBox cboAddAuthorLastName;
        private System.Windows.Forms.Button btnAddBookInfoCancel;
        private System.Windows.Forms.Button btnSaveBookInfo;
        private System.Windows.Forms.Panel pnlUpdateBookInfo;
        private System.Windows.Forms.Button btnUpdateBookCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateNotes;
        private System.Windows.Forms.TextBox txtUpdateAuthorFirstName;
        private System.Windows.Forms.TextBox txtUpdateAuthorLastName;
        private System.Windows.Forms.TextBox txtUpdateAuthorID;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.TextBox txtUpdateBookInfoID;
        private System.Windows.Forms.Label lblUpdateNote;
        private System.Windows.Forms.Label lblUpdateAuthorFirst;
        private System.Windows.Forms.Label lblUpdateAuthorL;
        private System.Windows.Forms.Label lblUpdateBookInfoAuthorID;
        private System.Windows.Forms.Label lblUpdateBookInfoTitle;
        private System.Windows.Forms.Label lblUpdateBookInfoID;
    }
}