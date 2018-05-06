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
    public partial class AddBookToClientOrderForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmBook;
        private CurrencyManager cmClientOrder;
        private CurrencyManager cmCB;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDT;
        private CurrencyManager cmClient;
        private CurrencyManager currencyManager;
        private CurrencyManager currencyManager1;

        //



        public AddBookToClientOrderForm(DataModule dm, MainForm mnu)
        {
            // Initialize Component, DataModule reference 
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;

            // Currency Manager initialized
            cmBook = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "BOOK"];
            cmClientOrder = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "CLIENTORDER"];
            cmDT = (CurrencyManager)this.BindingContext[dt];
            cmCB = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "CLIENTORDER.CLIENTORDERID_BOOK"];
            cmClient = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "Client"];

            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "Book"];
            currencyManager1 = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "Book"];
            BindControls();


        }

        private void AddBookToClientOrderForm_Load(object sender, EventArgs e)
        {


        }

        public void BindControls()
        {
            // Bind control is used to bind data to Grid data table
            dgvClientOrder.DataSource = DM.dsBookBroker1;
            dgvClientOrder.DataMember = "ClientOrder";

            dgvClientOrderBook.DataSource = DM.dsBookBroker1;
            dgvClientOrderBook.DataMember = "CLIENTORDER.CLIENTORDERID_BOOK";


            // to get null values in grid table
            DataView dataviewBookNoClient = DM.dsBookBroker1.Tables["Book"].DefaultView;
            dataviewBookNoClient.RowFilter = "ClientOrderID is null";
            dgvBook.DataSource = dataviewBookNoClient;
            dgvBook.Columns["ClientOrderID"].Visible = true;



        }

        private void dgvClientOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientOrder_Click(object sender, EventArgs e)
        {




        }

        private void dgvClientOrder_DataMemberChanged(object sender, EventArgs e)
        {
        }

        private void dgvClientOrder_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvClientOrder.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                label2.Text = row.Cells[2].Value.ToString();


                int aClientID = Convert.ToInt32(row.Cells[2].Value);
                cmClient.Position = DM.clientView.Find(aClientID);
                DataRow drClient = DM.dtClient.Rows[cmClient.Position];
                txtClientLastName.Text = drClient["LastName"].ToString();
                txtClientFirstName.Text = drClient["FirstName"].ToString();

            }

        }

        private void dgvClientOrder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void dgvBook_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void dgvClientOrderBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow rows = this.dgvClientOrderBook.Rows[e.RowIndex];

              

                int aClientID = Convert.ToInt32(rows.Cells[4].Value);
                cmBook.Position = DM.bookinfoView.Find(aClientID);
                DataRow drClient = DM.dtBookInfo.Rows[cmBook.Position];
                txtTitle.Text = drClient["Title"].ToString();

                    int aBookID1 = Convert.ToInt32(rows.Cells[0].Value);
                currencyManager1.Position = DM.bookView.Find(aBookID1);


            }
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvBook.Rows[e.RowIndex];
                int aClientID = Convert.ToInt32(row.Cells[4].Value);
                cmBook.Position = DM.bookinfoView.Find(aClientID);
                DataRow drClient = DM.dtBookInfo.Rows[cmBook.Position];
                txtTitle.Text = drClient["Title"].ToString();

                int aBookID = Convert.ToInt32(row.Cells[0].Value);
                currencyManager.Position = DM.bookView.Find(aBookID);

            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (DM.dtClientOrder.Rows[cmClientOrder.Position]["Status"].ToString() == "Current")
                {
                    DataRow UpdateBookrow = DM.dtBook.Rows[currencyManager.Position];
                    UpdateBookrow["ClientOrderID"] = dgvClientOrder["ClientOrderID", cmClientOrder.Position].Value;

                    currencyManager.EndCurrentEdit();
                    DM.UpdateBook();
                    MessageBox.Show("Book Added Successfully");
                }
                else
                {
                    MessageBox.Show("Book can only be added to current order");
                }

            }
            catch (ConstraintException)
            {
                MessageBox.Show("Test");
            }



        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtRemoveBook_Click(object sender, EventArgs e)
        {

            
                if (DM.dtClientOrder.Rows[cmClientOrder.Position]["Status"].ToString() == "Current")
                {
                    DataRow UpdateBookrow1 = DM.dtBook.Rows[currencyManager1.Position];
                    UpdateBookrow1["ClientOrderID"] = DBNull.Value;

                    currencyManager1.EndCurrentEdit();
                    DM.UpdateBook();
                    MessageBox.Show("Book deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Book can only be deleted wose current order");
                }

          
            }

        private void txtClientLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

