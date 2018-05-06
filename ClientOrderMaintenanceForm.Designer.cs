namespace BookBrokersApp
{
    partial class ClientOrderMaintenanceForm
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
            this.lstClientOrder = new System.Windows.Forms.ListBox();
            this.lblClientOrderID = new System.Windows.Forms.Label();
            this.lblClientOrderDate = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblClientLastName = new System.Windows.Forms.Label();
            this.lblClientFirstName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtClientOrderID = new System.Windows.Forms.TextBox();
            this.txtClientOrderDate = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.txtClientFirstName = new System.Windows.Forms.TextBox();
            this.txtClientStatus = new System.Windows.Forms.TextBox();
            this.btnClientPrevious = new System.Windows.Forms.Button();
            this.btnClientNext = new System.Windows.Forms.Button();
            this.btnAddClientOrder = new System.Windows.Forms.Button();
            this.btnUpdateClientOrder = new System.Windows.Forms.Button();
            this.btnDeleteClientOrder = new System.Windows.Forms.Button();
            this.btnMarkClientorderShipped = new System.Windows.Forms.Button();
            this.btnMarkClientOrderPaid = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddClientOrder = new System.Windows.Forms.Panel();
            this.btnCancelClientOrder = new System.Windows.Forms.Button();
            this.btnSaveClientOrder = new System.Windows.Forms.Button();
            this.dtpAddClientOrder = new System.Windows.Forms.DateTimePicker();
            this.cboAddClientFirstName = new System.Windows.Forms.ComboBox();
            this.cboAddClientLastName = new System.Windows.Forms.ComboBox();
            this.cboAddClientID = new System.Windows.Forms.ComboBox();
            this.lblAddClientOrder = new System.Windows.Forms.Label();
            this.lblAddClientOrderDate = new System.Windows.Forms.Label();
            this.pnlUpdateClientOrder = new System.Windows.Forms.Panel();
            this.cboUpdateClientOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateClientOrderFirst = new System.Windows.Forms.TextBox();
            this.txtUpdateClientOrderLast = new System.Windows.Forms.TextBox();
            this.txtUpdateClientOrderClientID = new System.Windows.Forms.TextBox();
            this.txtUpdateClientOrderStatus = new System.Windows.Forms.TextBox();
            this.txtUpdateClientOrderID = new System.Windows.Forms.TextBox();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblClientFirstNameUpdate = new System.Windows.Forms.Label();
            this.lblClientLastNameUpdate = new System.Windows.Forms.Label();
            this.lblClientOrderUpdateID = new System.Windows.Forms.Label();
            this.lblClientOrderUpdateStatus = new System.Windows.Forms.Label();
            this.lblClientOrderDateUpdate = new System.Windows.Forms.Label();
            this.lblClietOrderIDUpdate = new System.Windows.Forms.Label();
            this.pnlAddClientOrder.SuspendLayout();
            this.pnlUpdateClientOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstClientOrder
            // 
            this.lstClientOrder.FormattingEnabled = true;
            this.lstClientOrder.Location = new System.Drawing.Point(12, 12);
            this.lstClientOrder.Name = "lstClientOrder";
            this.lstClientOrder.Size = new System.Drawing.Size(164, 303);
            this.lstClientOrder.TabIndex = 0;
            // 
            // lblClientOrderID
            // 
            this.lblClientOrderID.AutoSize = true;
            this.lblClientOrderID.Location = new System.Drawing.Point(211, 25);
            this.lblClientOrderID.Name = "lblClientOrderID";
            this.lblClientOrderID.Size = new System.Drawing.Size(79, 13);
            this.lblClientOrderID.TabIndex = 1;
            this.lblClientOrderID.Text = "Client Order ID:";
            // 
            // lblClientOrderDate
            // 
            this.lblClientOrderDate.AutoSize = true;
            this.lblClientOrderDate.Location = new System.Drawing.Point(199, 62);
            this.lblClientOrderDate.Name = "lblClientOrderDate";
            this.lblClientOrderDate.Size = new System.Drawing.Size(91, 13);
            this.lblClientOrderDate.TabIndex = 2;
            this.lblClientOrderDate.Text = "Client Order Date:";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(236, 101);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(50, 13);
            this.lblClientID.TabIndex = 3;
            this.lblClientID.Text = "Client ID:";
            // 
            // lblClientLastName
            // 
            this.lblClientLastName.AutoSize = true;
            this.lblClientLastName.Location = new System.Drawing.Point(200, 143);
            this.lblClientLastName.Name = "lblClientLastName";
            this.lblClientLastName.Size = new System.Drawing.Size(90, 13);
            this.lblClientLastName.TabIndex = 4;
            this.lblClientLastName.Text = "Client Last Name:";
            // 
            // lblClientFirstName
            // 
            this.lblClientFirstName.AutoSize = true;
            this.lblClientFirstName.Location = new System.Drawing.Point(201, 182);
            this.lblClientFirstName.Name = "lblClientFirstName";
            this.lblClientFirstName.Size = new System.Drawing.Size(89, 13);
            this.lblClientFirstName.TabIndex = 5;
            this.lblClientFirstName.Text = "Client First Name:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(236, 224);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // txtClientOrderID
            // 
            this.txtClientOrderID.Location = new System.Drawing.Point(296, 22);
            this.txtClientOrderID.Name = "txtClientOrderID";
            this.txtClientOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtClientOrderID.TabIndex = 7;
            // 
            // txtClientOrderDate
            // 
            this.txtClientOrderDate.Location = new System.Drawing.Point(296, 59);
            this.txtClientOrderDate.Name = "txtClientOrderDate";
            this.txtClientOrderDate.Size = new System.Drawing.Size(100, 20);
            this.txtClientOrderDate.TabIndex = 8;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(296, 98);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(100, 20);
            this.txtClientID.TabIndex = 9;
            this.txtClientID.TextChanged += new System.EventHandler(this.txtClientID_TextChanged);
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Location = new System.Drawing.Point(296, 140);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(100, 20);
            this.txtClientLastName.TabIndex = 10;
            // 
            // txtClientFirstName
            // 
            this.txtClientFirstName.Location = new System.Drawing.Point(296, 182);
            this.txtClientFirstName.Name = "txtClientFirstName";
            this.txtClientFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtClientFirstName.TabIndex = 11;
            // 
            // txtClientStatus
            // 
            this.txtClientStatus.Location = new System.Drawing.Point(296, 224);
            this.txtClientStatus.Name = "txtClientStatus";
            this.txtClientStatus.Size = new System.Drawing.Size(100, 20);
            this.txtClientStatus.TabIndex = 12;
            // 
            // btnClientPrevious
            // 
            this.btnClientPrevious.Location = new System.Drawing.Point(32, 338);
            this.btnClientPrevious.Name = "btnClientPrevious";
            this.btnClientPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnClientPrevious.TabIndex = 13;
            this.btnClientPrevious.Text = "Previous";
            this.btnClientPrevious.UseVisualStyleBackColor = true;
            this.btnClientPrevious.Click += new System.EventHandler(this.btnClientPrevious_Click);
            // 
            // btnClientNext
            // 
            this.btnClientNext.Location = new System.Drawing.Point(130, 338);
            this.btnClientNext.Name = "btnClientNext";
            this.btnClientNext.Size = new System.Drawing.Size(75, 23);
            this.btnClientNext.TabIndex = 14;
            this.btnClientNext.Text = "Next";
            this.btnClientNext.UseVisualStyleBackColor = true;
            this.btnClientNext.Click += new System.EventHandler(this.btnClientNext_Click);
            // 
            // btnAddClientOrder
            // 
            this.btnAddClientOrder.Location = new System.Drawing.Point(239, 338);
            this.btnAddClientOrder.Name = "btnAddClientOrder";
            this.btnAddClientOrder.Size = new System.Drawing.Size(141, 23);
            this.btnAddClientOrder.TabIndex = 15;
            this.btnAddClientOrder.Text = "Add Client Order";
            this.btnAddClientOrder.UseVisualStyleBackColor = true;
            this.btnAddClientOrder.Click += new System.EventHandler(this.btnAddClientOrder_Click);
            // 
            // btnUpdateClientOrder
            // 
            this.btnUpdateClientOrder.Location = new System.Drawing.Point(408, 338);
            this.btnUpdateClientOrder.Name = "btnUpdateClientOrder";
            this.btnUpdateClientOrder.Size = new System.Drawing.Size(142, 23);
            this.btnUpdateClientOrder.TabIndex = 16;
            this.btnUpdateClientOrder.Text = "Update Client Order";
            this.btnUpdateClientOrder.UseVisualStyleBackColor = true;
            this.btnUpdateClientOrder.Click += new System.EventHandler(this.btnUpdateClientOrder_Click);
            // 
            // btnDeleteClientOrder
            // 
            this.btnDeleteClientOrder.Location = new System.Drawing.Point(579, 338);
            this.btnDeleteClientOrder.Name = "btnDeleteClientOrder";
            this.btnDeleteClientOrder.Size = new System.Drawing.Size(186, 23);
            this.btnDeleteClientOrder.TabIndex = 17;
            this.btnDeleteClientOrder.Text = "Delete Client Order";
            this.btnDeleteClientOrder.UseVisualStyleBackColor = true;
            this.btnDeleteClientOrder.Click += new System.EventHandler(this.btnDeleteClientOrder_Click);
            // 
            // btnMarkClientorderShipped
            // 
            this.btnMarkClientorderShipped.Location = new System.Drawing.Point(91, 379);
            this.btnMarkClientorderShipped.Name = "btnMarkClientorderShipped";
            this.btnMarkClientorderShipped.Size = new System.Drawing.Size(185, 23);
            this.btnMarkClientorderShipped.TabIndex = 18;
            this.btnMarkClientorderShipped.Text = "Mark Client Order as Shipped";
            this.btnMarkClientorderShipped.UseVisualStyleBackColor = true;
            this.btnMarkClientorderShipped.Click += new System.EventHandler(this.btnMarkClientorderShipped_Click);
            // 
            // btnMarkClientOrderPaid
            // 
            this.btnMarkClientOrderPaid.Location = new System.Drawing.Point(358, 379);
            this.btnMarkClientOrderPaid.Name = "btnMarkClientOrderPaid";
            this.btnMarkClientOrderPaid.Size = new System.Drawing.Size(192, 23);
            this.btnMarkClientOrderPaid.TabIndex = 19;
            this.btnMarkClientOrderPaid.Text = "Mark Client Order as Paid";
            this.btnMarkClientOrderPaid.UseVisualStyleBackColor = true;
            this.btnMarkClientOrderPaid.Click += new System.EventHandler(this.btnMarkClientOrderPaid_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(638, 379);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddClientOrder
            // 
            this.pnlAddClientOrder.Controls.Add(this.btnCancelClientOrder);
            this.pnlAddClientOrder.Controls.Add(this.btnSaveClientOrder);
            this.pnlAddClientOrder.Controls.Add(this.dtpAddClientOrder);
            this.pnlAddClientOrder.Controls.Add(this.cboAddClientFirstName);
            this.pnlAddClientOrder.Controls.Add(this.cboAddClientLastName);
            this.pnlAddClientOrder.Controls.Add(this.cboAddClientID);
            this.pnlAddClientOrder.Controls.Add(this.lblAddClientOrder);
            this.pnlAddClientOrder.Controls.Add(this.lblAddClientOrderDate);
            this.pnlAddClientOrder.Location = new System.Drawing.Point(607, 39);
            this.pnlAddClientOrder.Name = "pnlAddClientOrder";
            this.pnlAddClientOrder.Size = new System.Drawing.Size(511, 206);
            this.pnlAddClientOrder.TabIndex = 21;
            this.pnlAddClientOrder.Visible = false;
            // 
            // btnCancelClientOrder
            // 
            this.btnCancelClientOrder.Location = new System.Drawing.Point(295, 133);
            this.btnCancelClientOrder.Name = "btnCancelClientOrder";
            this.btnCancelClientOrder.Size = new System.Drawing.Size(75, 23);
            this.btnCancelClientOrder.TabIndex = 8;
            this.btnCancelClientOrder.Text = "Cancel";
            this.btnCancelClientOrder.UseVisualStyleBackColor = true;
            this.btnCancelClientOrder.Click += new System.EventHandler(this.btnCancelClientOrder_Click);
            // 
            // btnSaveClientOrder
            // 
            this.btnSaveClientOrder.Location = new System.Drawing.Point(80, 133);
            this.btnSaveClientOrder.Name = "btnSaveClientOrder";
            this.btnSaveClientOrder.Size = new System.Drawing.Size(124, 23);
            this.btnSaveClientOrder.TabIndex = 7;
            this.btnSaveClientOrder.Text = "Save Client Order";
            this.btnSaveClientOrder.UseVisualStyleBackColor = true;
            this.btnSaveClientOrder.Click += new System.EventHandler(this.btnSaveClientOrder_Click);
            // 
            // dtpAddClientOrder
            // 
            this.dtpAddClientOrder.Location = new System.Drawing.Point(139, 23);
            this.dtpAddClientOrder.Name = "dtpAddClientOrder";
            this.dtpAddClientOrder.Size = new System.Drawing.Size(188, 20);
            this.dtpAddClientOrder.TabIndex = 6;
            // 
            // cboAddClientFirstName
            // 
            this.cboAddClientFirstName.FormattingEnabled = true;
            this.cboAddClientFirstName.Location = new System.Drawing.Point(347, 60);
            this.cboAddClientFirstName.Name = "cboAddClientFirstName";
            this.cboAddClientFirstName.Size = new System.Drawing.Size(121, 21);
            this.cboAddClientFirstName.TabIndex = 4;
            // 
            // cboAddClientLastName
            // 
            this.cboAddClientLastName.FormattingEnabled = true;
            this.cboAddClientLastName.Location = new System.Drawing.Point(206, 60);
            this.cboAddClientLastName.Name = "cboAddClientLastName";
            this.cboAddClientLastName.Size = new System.Drawing.Size(121, 21);
            this.cboAddClientLastName.TabIndex = 3;
            // 
            // cboAddClientID
            // 
            this.cboAddClientID.FormattingEnabled = true;
            this.cboAddClientID.Location = new System.Drawing.Point(140, 60);
            this.cboAddClientID.Name = "cboAddClientID";
            this.cboAddClientID.Size = new System.Drawing.Size(38, 21);
            this.cboAddClientID.TabIndex = 2;
            // 
            // lblAddClientOrder
            // 
            this.lblAddClientOrder.AutoSize = true;
            this.lblAddClientOrder.Location = new System.Drawing.Point(91, 63);
            this.lblAddClientOrder.Name = "lblAddClientOrder";
            this.lblAddClientOrder.Size = new System.Drawing.Size(36, 13);
            this.lblAddClientOrder.TabIndex = 1;
            this.lblAddClientOrder.Text = "Client:";
            // 
            // lblAddClientOrderDate
            // 
            this.lblAddClientOrderDate.AutoSize = true;
            this.lblAddClientOrderDate.Location = new System.Drawing.Point(42, 26);
            this.lblAddClientOrderDate.Name = "lblAddClientOrderDate";
            this.lblAddClientOrderDate.Size = new System.Drawing.Size(91, 13);
            this.lblAddClientOrderDate.TabIndex = 0;
            this.lblAddClientOrderDate.Text = "Client Order Date:";
            // 
            // pnlUpdateClientOrder
            // 
            this.pnlUpdateClientOrder.Controls.Add(this.cboUpdateClientOrderDate);
            this.pnlUpdateClientOrder.Controls.Add(this.txtUpdateClientOrderFirst);
            this.pnlUpdateClientOrder.Controls.Add(this.txtUpdateClientOrderLast);
            this.pnlUpdateClientOrder.Controls.Add(this.txtUpdateClientOrderClientID);
            this.pnlUpdateClientOrder.Controls.Add(this.txtUpdateClientOrderStatus);
            this.pnlUpdateClientOrder.Controls.Add(this.txtUpdateClientOrderID);
            this.pnlUpdateClientOrder.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateClientOrder.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateClientOrder.Controls.Add(this.lblClientFirstNameUpdate);
            this.pnlUpdateClientOrder.Controls.Add(this.lblClientLastNameUpdate);
            this.pnlUpdateClientOrder.Controls.Add(this.lblClientOrderUpdateID);
            this.pnlUpdateClientOrder.Controls.Add(this.lblClientOrderUpdateStatus);
            this.pnlUpdateClientOrder.Controls.Add(this.lblClientOrderDateUpdate);
            this.pnlUpdateClientOrder.Controls.Add(this.lblClietOrderIDUpdate);
            this.pnlUpdateClientOrder.Location = new System.Drawing.Point(211, 41);
            this.pnlUpdateClientOrder.Name = "pnlUpdateClientOrder";
            this.pnlUpdateClientOrder.Size = new System.Drawing.Size(547, 324);
            this.pnlUpdateClientOrder.TabIndex = 22;
            this.pnlUpdateClientOrder.Visible = false;
            this.pnlUpdateClientOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUpdateClientOrder_Paint);
            // 
            // cboUpdateClientOrderDate
            // 
            this.cboUpdateClientOrderDate.Location = new System.Drawing.Point(158, 61);
            this.cboUpdateClientOrderDate.Name = "cboUpdateClientOrderDate";
            this.cboUpdateClientOrderDate.Size = new System.Drawing.Size(200, 20);
            this.cboUpdateClientOrderDate.TabIndex = 13;
            // 
            // txtUpdateClientOrderFirst
            // 
            this.txtUpdateClientOrderFirst.Location = new System.Drawing.Point(158, 213);
            this.txtUpdateClientOrderFirst.Name = "txtUpdateClientOrderFirst";
            this.txtUpdateClientOrderFirst.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateClientOrderFirst.TabIndex = 12;
            // 
            // txtUpdateClientOrderLast
            // 
            this.txtUpdateClientOrderLast.Location = new System.Drawing.Point(158, 174);
            this.txtUpdateClientOrderLast.Name = "txtUpdateClientOrderLast";
            this.txtUpdateClientOrderLast.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateClientOrderLast.TabIndex = 11;
            // 
            // txtUpdateClientOrderClientID
            // 
            this.txtUpdateClientOrderClientID.Location = new System.Drawing.Point(158, 131);
            this.txtUpdateClientOrderClientID.Name = "txtUpdateClientOrderClientID";
            this.txtUpdateClientOrderClientID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateClientOrderClientID.TabIndex = 10;
            this.txtUpdateClientOrderClientID.TextChanged += new System.EventHandler(this.txtUpdateClientOrderClientID_TextChanged);
            // 
            // txtUpdateClientOrderStatus
            // 
            this.txtUpdateClientOrderStatus.Location = new System.Drawing.Point(155, 96);
            this.txtUpdateClientOrderStatus.Name = "txtUpdateClientOrderStatus";
            this.txtUpdateClientOrderStatus.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateClientOrderStatus.TabIndex = 9;
            // 
            // txtUpdateClientOrderID
            // 
            this.txtUpdateClientOrderID.Location = new System.Drawing.Point(158, 30);
            this.txtUpdateClientOrderID.Name = "txtUpdateClientOrderID";
            this.txtUpdateClientOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateClientOrderID.TabIndex = 8;
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(300, 264);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCancel.TabIndex = 7;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(74, 264);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(139, 23);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblClientFirstNameUpdate
            // 
            this.lblClientFirstNameUpdate.AutoSize = true;
            this.lblClientFirstNameUpdate.Location = new System.Drawing.Point(63, 216);
            this.lblClientFirstNameUpdate.Name = "lblClientFirstNameUpdate";
            this.lblClientFirstNameUpdate.Size = new System.Drawing.Size(89, 13);
            this.lblClientFirstNameUpdate.TabIndex = 5;
            this.lblClientFirstNameUpdate.Text = "Client First Name:";
            // 
            // lblClientLastNameUpdate
            // 
            this.lblClientLastNameUpdate.AutoSize = true;
            this.lblClientLastNameUpdate.Location = new System.Drawing.Point(62, 174);
            this.lblClientLastNameUpdate.Name = "lblClientLastNameUpdate";
            this.lblClientLastNameUpdate.Size = new System.Drawing.Size(90, 13);
            this.lblClientLastNameUpdate.TabIndex = 4;
            this.lblClientLastNameUpdate.Text = "Client Last Name:";
            // 
            // lblClientOrderUpdateID
            // 
            this.lblClientOrderUpdateID.AutoSize = true;
            this.lblClientOrderUpdateID.Location = new System.Drawing.Point(99, 134);
            this.lblClientOrderUpdateID.Name = "lblClientOrderUpdateID";
            this.lblClientOrderUpdateID.Size = new System.Drawing.Size(50, 13);
            this.lblClientOrderUpdateID.TabIndex = 3;
            this.lblClientOrderUpdateID.Text = "Client ID:";
            // 
            // lblClientOrderUpdateStatus
            // 
            this.lblClientOrderUpdateStatus.AutoSize = true;
            this.lblClientOrderUpdateStatus.Location = new System.Drawing.Point(99, 99);
            this.lblClientOrderUpdateStatus.Name = "lblClientOrderUpdateStatus";
            this.lblClientOrderUpdateStatus.Size = new System.Drawing.Size(40, 13);
            this.lblClientOrderUpdateStatus.TabIndex = 2;
            this.lblClientOrderUpdateStatus.Text = "Status:";
            // 
            // lblClientOrderDateUpdate
            // 
            this.lblClientOrderDateUpdate.AutoSize = true;
            this.lblClientOrderDateUpdate.Location = new System.Drawing.Point(59, 67);
            this.lblClientOrderDateUpdate.Name = "lblClientOrderDateUpdate";
            this.lblClientOrderDateUpdate.Size = new System.Drawing.Size(91, 13);
            this.lblClientOrderDateUpdate.TabIndex = 1;
            this.lblClientOrderDateUpdate.Text = "Client Order Date:";
            // 
            // lblClietOrderIDUpdate
            // 
            this.lblClietOrderIDUpdate.AutoSize = true;
            this.lblClietOrderIDUpdate.Location = new System.Drawing.Point(74, 31);
            this.lblClietOrderIDUpdate.Name = "lblClietOrderIDUpdate";
            this.lblClietOrderIDUpdate.Size = new System.Drawing.Size(76, 13);
            this.lblClietOrderIDUpdate.TabIndex = 0;
            this.lblClietOrderIDUpdate.Text = "Client Order ID";
            // 
            // ClientOrderMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 419);
            this.Controls.Add(this.pnlUpdateClientOrder);
            this.Controls.Add(this.pnlAddClientOrder);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnMarkClientOrderPaid);
            this.Controls.Add(this.btnMarkClientorderShipped);
            this.Controls.Add(this.btnDeleteClientOrder);
            this.Controls.Add(this.btnUpdateClientOrder);
            this.Controls.Add(this.btnAddClientOrder);
            this.Controls.Add(this.btnClientNext);
            this.Controls.Add(this.btnClientPrevious);
            this.Controls.Add(this.txtClientStatus);
            this.Controls.Add(this.txtClientFirstName);
            this.Controls.Add(this.txtClientLastName);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtClientOrderDate);
            this.Controls.Add(this.txtClientOrderID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblClientFirstName);
            this.Controls.Add(this.lblClientLastName);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblClientOrderDate);
            this.Controls.Add(this.lblClientOrderID);
            this.Controls.Add(this.lstClientOrder);
            this.Name = "ClientOrderMaintenanceForm";
            this.Text = "ClientOrderMaintenanceForm";
            this.Load += new System.EventHandler(this.ClientOrderMaintenanceForm_Load);
            this.pnlAddClientOrder.ResumeLayout(false);
            this.pnlAddClientOrder.PerformLayout();
            this.pnlUpdateClientOrder.ResumeLayout(false);
            this.pnlUpdateClientOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstClientOrder;
        private System.Windows.Forms.Label lblClientOrderID;
        private System.Windows.Forms.Label lblClientOrderDate;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblClientLastName;
        private System.Windows.Forms.Label lblClientFirstName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtClientOrderID;
        private System.Windows.Forms.TextBox txtClientOrderDate;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.TextBox txtClientFirstName;
        private System.Windows.Forms.TextBox txtClientStatus;
        private System.Windows.Forms.Button btnClientPrevious;
        private System.Windows.Forms.Button btnClientNext;
        private System.Windows.Forms.Button btnAddClientOrder;
        private System.Windows.Forms.Button btnUpdateClientOrder;
        private System.Windows.Forms.Button btnDeleteClientOrder;
        private System.Windows.Forms.Button btnMarkClientorderShipped;
        private System.Windows.Forms.Button btnMarkClientOrderPaid;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddClientOrder;
        private System.Windows.Forms.Button btnCancelClientOrder;
        private System.Windows.Forms.Button btnSaveClientOrder;
        private System.Windows.Forms.DateTimePicker dtpAddClientOrder;
        private System.Windows.Forms.ComboBox cboAddClientFirstName;
        private System.Windows.Forms.ComboBox cboAddClientLastName;
        private System.Windows.Forms.ComboBox cboAddClientID;
        private System.Windows.Forms.Label lblAddClientOrder;
        private System.Windows.Forms.Label lblAddClientOrderDate;
        private System.Windows.Forms.Panel pnlUpdateClientOrder;
        private System.Windows.Forms.DateTimePicker cboUpdateClientOrderDate;
        private System.Windows.Forms.TextBox txtUpdateClientOrderFirst;
        private System.Windows.Forms.TextBox txtUpdateClientOrderLast;
        private System.Windows.Forms.TextBox txtUpdateClientOrderClientID;
        private System.Windows.Forms.TextBox txtUpdateClientOrderStatus;
        private System.Windows.Forms.TextBox txtUpdateClientOrderID;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblClientFirstNameUpdate;
        private System.Windows.Forms.Label lblClientLastNameUpdate;
        private System.Windows.Forms.Label lblClientOrderUpdateID;
        private System.Windows.Forms.Label lblClientOrderUpdateStatus;
        private System.Windows.Forms.Label lblClientOrderDateUpdate;
        private System.Windows.Forms.Label lblClietOrderIDUpdate;
    }
}