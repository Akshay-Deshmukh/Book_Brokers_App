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
    public partial class BookInfoMaintenanceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmAuthor;

        public BookInfoMaintenanceForm(DataModule dm, MainForm mnu)
        {

            // Initialize Component, DataModule reference 
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddBookInfo.Top = 2;
            pnlAddBookInfo.Left = 90;
            pnlUpdateBookInfo.Top = 2;
            pnlUpdateBookInfo.Left = 100;



        }

        private void BindControls()
        {
            //list bind to data source
            lstBooktitles.DataSource = DM.dsBookBroker1;
            lstBooktitles.DisplayMember = "BookInfo.Title";
            lstBooktitles.ValueMember = "BookInfo.Title";

            // Bind control is used to bind data to text box
            txtBookInfoID.DataBindings.Add("Text", DM.dsBookBroker1, "BookInfo.BookInfoID");
            txtTitle.DataBindings.Add("Text", DM.dsBookBroker1, "BookInfo.Title");
            txtAuthorID.DataBindings.Add("Text", DM.dsBookBroker1, "BookInfo.AuthorID");
            txtNotes.DataBindings.Add("Text", DM.dsBookBroker1, "BookInfo.Notes");

            // Currency Manager
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "BookInfo"];
            cmAuthor = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "Author"];

            txtUpdateBookInfoID.DataBindings.Add("Text", DM.dsBookBroker1, "BookInfo.BookInfoID");
            txtUpdateAuthorID.DataBindings.Add("Text", DM.dsBookBroker1, "BookInfo.AuthorID");
            txtUpdateTitle.DataBindings.Add("Text", DM.dsBookBroker1, "BookInfo.Title");
            txtUpdateNotes.DataBindings.Add("Text", DM.dsBookBroker1, "BookInfo.Notes");

            txtBookInfoID.Enabled = false;
            txtTitle.Enabled = false;
            txtAuthorID.Enabled = false;
            txtAuthorLastName.Enabled = false;
            txtAuthorFirstName.Enabled = false;
            txtNotes.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BookInfoMaintenanceForm_Load(object sender, EventArgs e)
        {

        }

        private void txtAuthorID_TextChanged(object sender, EventArgs e)
        {
            // When the value changes text changes
            if (txtAuthorID.Text == "")
            {
                txtAuthorFirstName.Text = "";
                txtAuthorLastName.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(txtAuthorID.Text);
                cmAuthor.Position = DM.authorView.Find(aCountryID);
                DataRow drClient = DM.dtAuthor.Rows[cmAuthor.Position];
                txtAuthorFirstName.Text = drClient["FirstName"].ToString();
                txtAuthorLastName.Text = drClient["LastName"].ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadBookInfo()
        {
            // Loads data in checkboxes from database
            cboAddBookAuthorID.DataSource = DM.dsBookBroker1;
            cboAddBookAuthorID.DisplayMember = "Author.AuthorID";
            cboAddBookAuthorID.ValueMember = "Author.AuthorID";
            cboAddAuthorLastName.DataSource = DM.dsBookBroker1;
            cboAddAuthorLastName.DisplayMember = "Author.LastName";
            cboAddAuthorLastName.ValueMember = "Author.LastName";
            cboAddAuthorFirstName.DataSource = DM.dsBookBroker1;
            cboAddAuthorFirstName.DisplayMember = "Author.FirstName";
            cboAddAuthorFirstName.ValueMember = "Author.FirstName";




        }

        private void btnAddBookInfo_Click(object sender, EventArgs e)
        {
            pnlAddBookInfo.Show();
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateBookInfo.Enabled = false;
            btnReturn.Enabled = false;
            btnDeleteBookInfo.Enabled = false;
            lstBooktitles.Visible = false;
            txtNotes.Visible = false;
            loadBookInfo();
        }

        private void btnSaveBookInfo_Click(object sender, EventArgs e)
        {
            //Create a new role that the Variable will be added into
            DataRow newBookInforow = DM.dtBookInfo.NewRow();
            newBookInforow["Title"] = txtAddBookTitle.Text;
            newBookInforow["AuthorID"] = cboAddBookAuthorID.Text;
            newBookInforow["Notes"] = txtAddAuthorNotes.Text;
            DM.dtBookInfo.Rows.Add(newBookInforow);
            currencyManager.EndCurrentEdit();
            // Give the user the success message
            MessageBox.Show("Book Info added successfully", "Success");
            // Database is updated
            DM.UpdateBookInfo();
        }

        private void btnAddBookInfoCancel_Click(object sender, EventArgs e)
        {
            pnlAddBookInfo.Hide();
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateBookInfo.Enabled = true;
            btnReturn.Enabled = true;
            btnDeleteBookInfo.Enabled = true;
            lstBooktitles.Visible = true;
            txtNotes.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // When the value changes text changes
            if (txtUpdateAuthorID.Text == "")
            {
                txtUpdateAuthorFirstName.Text = "";
                txtUpdateAuthorLastName.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(txtAuthorID.Text);
                cmAuthor.Position = DM.authorView.Find(aCountryID);
                DataRow drClient = DM.dtAuthor.Rows[cmAuthor.Position];
                txtUpdateAuthorFirstName.Text = drClient["FirstName"].ToString();
                txtUpdateAuthorLastName.Text = drClient["LastName"].ToString();
            }
        }

        private void btnUpdateBookInfo_Click(object sender, EventArgs e)
        {
            pnlUpdateBookInfo.Show();
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddBookInfo.Enabled = false;
            btnDeleteBookInfo.Enabled = false;
            btnReturn.Enabled = false;
            lstBooktitles.Visible = false;
            txtNotes.Visible = false;
            txtUpdateBookInfoID.Enabled = false;
            txtUpdateAuthorID.Enabled = false;
            txtUpdateAuthorFirstName.Enabled = false;
            txtUpdateAuthorLastName.Enabled = false;


        }

        private void btnUpdateBookCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateBookInfo.Hide();
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddBookInfo.Enabled = true;
            btnDeleteBookInfo.Enabled = true;
            btnReturn.Enabled = true;
            lstBooktitles.Visible = true;
            txtNotes.Visible = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            
            DataRow updateBookInforow = DM.dtBookInfo.Rows[currencyManager.Position];
            if (txtUpdateTitle.Text == "")

            {
                MessageBox.Show("You Cant  Leave Feild Blank", "Error");
            }

            else
            {
                updateBookInforow["Title"] = txtUpdateTitle.Text;
                updateBookInforow["Notes"] = txtUpdateNotes.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateBookInfo();
                MessageBox.Show("Book Info Updated Successfully");
            }
        }

        private void btnDeleteBookInfo_Click(object sender, EventArgs e)
        {

            DataRow deleteBookInforow = DM.dtBookInfo.Rows[currencyManager.Position];
            DataRow[] Bookrow = DM.dtBook.Select("BookInfoID = " + txtBookInfoID.Text);
            if (Bookrow.Length != 0)
            {
                MessageBox.Show("You may only delete Info Records that have no books ", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "WARNING",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)

                {
                    deleteBookInforow.Delete();
                    DM.UpdateBookInfo();
                    MessageBox.Show("Book Info Deleted successfully");
                }
            }
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
    }
}
