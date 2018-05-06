using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBrokersApp
{
    public partial class BookMaintenanceForm : Form
    {

        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmBookInfo;
        private CurrencyManager cmVendor;


        public BookMaintenanceForm(DataModule dm, MainForm mnu)
        {

            // Initialize Component, DataModule reference 
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddBook.Top = 5;
            pnlAddBook.Left = 20;
            pnlUpdateBook.Top = 5;
            pnlUpdateBook.Left = 25;
        }

        private void BindControls()
        {

            // Bind control is used to bind data to text box
            lblBookInfoID.DataBindings.Add("Text", DM.dsBookBroker1, "Book.BookInfoID");
            lblUpdateBookInfoID.DataBindings.Add("Text", DM.dsBookBroker1, "Book.BookInfoID");
            txtUpdateVendorID.DataBindings.Add("Text", DM.dsBookBroker1, "Book.VendorID");
            txtUpdateBookCost.DataBindings.Add("Text", DM.dsBookBroker1, "Book.Cost");
            txtUpdateBookPrice.DataBindings.Add("Text", DM.dsBookBroker1, "Book.Price");
            txtUpdateBookID.DataBindings.Add("Text", DM.dsBookBroker1, "Book.BookInfoID");
            dtpUpdateDate.DataBindings.Add("Text", DM.dsBookBroker1, "Book.DatePublished");

            //list bind to data source
            lstBookID.DataSource = DM.dsBookBroker1;
            lstBookID.DisplayMember = "Book.BookID";
            lstBookID.ValueMember = "Book.BookID";

            txtBookID.DataBindings.Add("Text", DM.dsBookBroker1, "Book.BookID");
            txtCost.DataBindings.Add("Text", DM.dsBookBroker1, "Book.Cost");
            txtPrice.DataBindings.Add("Text", DM.dsBookBroker1, "Book.Price");
            txtDatePublished.DataBindings.Add("Text", DM.dsBookBroker1, "Book.DatePublished");
            txtVendorID.DataBindings.Add("Text", DM.dsBookBroker1, "Book.VendorID");
            txtClientOrderID.DataBindings.Add("Text", DM.dsBookBroker1, "Book.ClientOrderID");


            // Currency Manager
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "Book"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "BOOKINFO"];
            cmVendor = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "VENDOR"];

            txtBookID.Enabled = false;
            txtTitle.Enabled = false;
            txtCost.Enabled = false;
            txtPrice.Enabled = false;
            txtDatePublished.Enabled = false;
            txtVendorID.Enabled = false;
            txtVendorName.Enabled = false;
            txtClientOrderID.Enabled = false;

        }

        private void BookMaintenanceForm_Load(object sender, EventArgs e)
        {

        }

        private void lblBookInfoID_TextChanged(object sender, EventArgs e)
        {
            // When the value changes text changes
            if (lblBookInfoID.Text == "")
            {
                txtTitle.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(lblBookInfoID.Text);
                cmBookInfo.Position = DM.bookinfoView.Find(aCountryID);
                DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];
                txtTitle.Text = drBookInfo["Title"].ToString();


            }
        }

        private void txtVendorID_TextChanged(object sender, EventArgs e)
        {
            // When the value changes text changes
            if (txtVendorID.Text == "")
            {
                txtVendorName.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(txtVendorID.Text);
                cmVendor.Position = DM.vendorView.Find(aCountryID);
                DataRow drVendor = DM.dtVendor.Rows[cmVendor.Position];
                txtVendorName.Text = drVendor["VendorName"].ToString();


            }
        }


        private void LoadDetails()
        {
            // Loads data in checkboxes from database
            cboAddBookInfoID.DataSource = DM.dsBookBroker1;
            cboAddBookInfoID.DisplayMember = "BookInfo.BookInfoID";
            cboAddBookInfoID.ValueMember = "BookInfo.BookInfoID";
            cboAddBookInfoTitle.DataSource = DM.dsBookBroker1;
            cboAddBookInfoTitle.DisplayMember = "BookInfo.Title";
            cboAddBookInfoTitle.ValueMember = "BookInfo.Title";
            cboAddBookVendorID.DataSource = DM.dsBookBroker1;
            cboAddBookVendorID.DisplayMember = "Vendor.VendorID";
            cboAddBookVendorID.ValueMember = "Vendor.VendorID";
            cboAddBookVendorName.DataSource = DM.dsBookBroker1;
            cboAddBookVendorName.DisplayMember = "Vendor.VendorName";
            cboAddBookVendorName.ValueMember = "Vendor.VendorName";


        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            pnlAddBook.Show();
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateBook.Enabled = false;
            btnDeleteBook.Enabled = false;
            lstBookID.Visible = false;
            LoadDetails();

        }

        private void btnAddBookCancel_Click(object sender, EventArgs e)
        {
            pnlAddBook.Hide();
            btnPrevious.Enabled = true;
            btnReturn.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateBook.Enabled = true;
            btnDeleteBook.Enabled = true;
            lstBookID.Visible = true;
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            //Create a new role that the Variable will be added into
            DataRow newBookrow = DM.dtBook.NewRow();

            // if any of the text area is empty then do not write the data and return error message
            if ((cboAddBookInfoID.Text == "") || (txtAddBookInfoCost.Text == "") || (txtAddBookInfoPrice.Text == "") ||
            (dtpAddBookPublished.Text == "") || (cboAddBookVendorID.Text == ""))
            {
                MessageBox.Show("You must type in all feilds", "Error");
            }

            else
            {

                newBookrow["BookInfoID"] = cboAddBookInfoID.Text;
                newBookrow["Cost"] = txtAddBookInfoCost.Text;
                newBookrow["Price"] = txtAddBookInfoPrice.Text;
                newBookrow["DatePublished"] = dtpAddBookPublished.Text;
                newBookrow["VendorID"] = cboAddBookVendorID.Text;

                //Add the new row to the table
                DM.dtBook.Rows.Add(newBookrow);
                currencyManager.EndCurrentEdit();

                // Give the user the success message
                MessageBox.Show("Book added successfully", "Success");

                DM.UpdateBook();



            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            DataRow updateBookrow = DM.dtBook.Rows[currencyManager.Position];
            if (txtClientOrderID != null && !string.IsNullOrWhiteSpace(txtClientOrderID.Text))
            {
                MessageBox.Show("Cannot update the book that is on order");
            }
            if (txtClientOrderID.Text == "")
            {
                pnlUpdateBook.Visible = true;
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
                btnReturn.Enabled = false;
                btnAddBook.Enabled = false;
                btnDeleteBook.Enabled = false;
                lstBookID.Visible = false;
                txtUpdateBookID.Enabled = false;
                txtUpdateBookTitle.Enabled = false;
                txtUpdateVendorID.Enabled = false;
                txtUpdateVendorName.Enabled = false;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateBookrow = DM.dtBook.Rows[currencyManager.Position];
            if ((txtUpdateBookCost.Text == "") || (txtUpdateBookPrice.Text == "") || (dtpUpdateDate.Text == ""))
            {
                MessageBox.Show("You Can't leave feild empty", "Error");
            }
            else
            {
                updateBookrow["Cost"] = txtUpdateBookCost.Text;
                updateBookrow["Price"] = txtUpdateBookPrice.Text;
                updateBookrow["DatePublished"] = dtpUpdateDate.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateBook();
                MessageBox.Show("Book Updated Successfully");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUpdateBookInfoID_Click(object sender, EventArgs e)
        {

        }

        private void lblUpdateBookInfoID_TextChanged(object sender, EventArgs e)
        {
            // When the value changes text changes
            if (lblUpdateBookInfoID.Text == "")
            {
                txtUpdateBookTitle.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(lblUpdateBookInfoID.Text);
                cmBookInfo.Position = DM.bookinfoView.Find(aCountryID);
                DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];
                txtUpdateBookTitle.Text = drBookInfo["Title"].ToString();


            }
        }

        private void txtUpdateVendorID_TextChanged(object sender, EventArgs e)
        {
            // When the value changes text changes
            if (txtUpdateVendorID.Text == "")
            {
                txtUpdateVendorName.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(txtVendorID.Text);
                cmVendor.Position = DM.vendorView.Find(aCountryID);
                DataRow drVendor = DM.dtVendor.Rows[cmVendor.Position];
                txtUpdateVendorName.Text = drVendor["VendorName"].ToString();


            }
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateBook.Visible = false;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnReturn.Enabled = true;
            btnAddBook.Enabled = true;
            btnDeleteBook.Enabled = true;
            lstBookID.Visible = true;
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            {
                // Client delete Event
                DataRow deleteClientRow = DM.dtBook.Rows[currencyManager.Position];

                // Client delete Condition is checked 
                if (txtClientOrderID != null && !string.IsNullOrWhiteSpace(txtClientOrderID.Text))
                {
                    MessageBox.Show("You may only delete book that are not on order");
                }
                if (txtClientOrderID.Text == "")
                {
                     if(MessageBox.Show("Are you sure want to delete this record?", "WARNING",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        deleteClientRow.Delete();
                        DM.UpdateBook();
                        MessageBox.Show("Book Deleted successfully");
                    }
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }

        }

        private void pnlUpdateBook_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
