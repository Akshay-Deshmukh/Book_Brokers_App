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
    public partial class ClientOrderMaintenanceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmClient;


        public ClientOrderMaintenanceForm(DataModule dm, MainForm mnu)
        {
            // Initialize Component, DataModule reference 

            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddClientOrder.Top = 50;
            pnlAddClientOrder.Left = 100;
            pnlUpdateClientOrder.Top = 10;
            pnlUpdateClientOrder.Left = 40;
        }

        private void ClientOrderMaintenanceForm_Load(object sender, EventArgs e)
        {

        }

        public void BindControls()
        {
            // Bind control is used to bind data to text box 

            txtClientOrderID.DataBindings.Add("Text", DM.dsBookBroker1, "ClientOrder.ClientOrderID");
            txtClientOrderDate.DataBindings.Add("Text", DM.dsBookBroker1, "ClientOrder.OrderDate");
            txtClientID.DataBindings.Add("Text", DM.dsBookBroker1, "ClientOrder.ClientID");
            txtClientStatus.DataBindings.Add("Text", DM.dsBookBroker1, "ClientOrder.Status");

            //list bind to data source
            lstClientOrder.DataSource = DM.dsBookBroker1;
            lstClientOrder.DisplayMember = "ClientOrder.ClientOrderID";
            lstClientOrder.ValueMember = "ClientOrder.ClientOrderID";

            // Currency Manager
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "ClientOrder"];
            cmClient = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "Client"];

            txtUpdateClientOrderID.DataBindings.Add("Text", DM.dsBookBroker1, "ClientOrder.ClientOrderID");
            txtUpdateClientOrderStatus.DataBindings.Add("Text", DM.dsBookBroker1, "ClientOrder.Status");
            txtUpdateClientOrderClientID.DataBindings.Add("Text", DM.dsBookBroker1, "ClientOrder.ClientID");
            
            txtClientOrderID.Enabled = false;
            txtClientOrderDate.Enabled = false;
            txtClientID.Enabled = false;
            txtClientLastName.Enabled = false;
            txtClientFirstName.Enabled = false;
            txtClientStatus.Enabled = false;


        }



        private void load()
        {
            // Loads data in checkboxes from database

            cboAddClientFirstName.DataSource = DM.dsBookBroker1;
            cboAddClientFirstName.DisplayMember = "Client.FirstName";
            cboAddClientFirstName.ValueMember = "Client.FirstName";
            cboAddClientLastName.DataSource = DM.dsBookBroker1;
            cboAddClientLastName.DisplayMember = "Client.LastName";
            cboAddClientLastName.ValueMember = "Client.LastName";
            cboAddClientID.DataSource = DM.dsBookBroker1;
            cboAddClientID.DisplayMember = "Client.ClientID";
            cboAddClientID.ValueMember = "Client.ClientID";



        }

        private void txtClientID_TextChanged(object sender, EventArgs e)
        {
            // When the value changes text changes
            if (txtClientID.Text == "")
            {
                txtClientLastName.Text = "";
                txtClientFirstName.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(txtClientID.Text);
                cmClient.Position = DM.clientView.Find(aCountryID);
                DataRow drClient = DM.dtClient.Rows[cmClient.Position];
                txtClientLastName.Text = drClient["LastName"].ToString();
                txtClientFirstName.Text = drClient["FirstName"].ToString();
            }
        }

        private void btnAddClientOrder_Click(object sender, EventArgs e)
        {
            pnlAddClientOrder.Show();
            btnClientPrevious.Enabled = false;
            btnClientNext.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateClientOrder.Enabled = false;
            btnDeleteClientOrder.Enabled = false;
            btnMarkClientorderShipped.Enabled = false;
            btnMarkClientOrderPaid.Enabled = false;
            lstClientOrder.Visible = false;
            lblClientOrderID.Visible = false;
            txtClientOrderID.Visible = false;
            load();




        }

        private void btnSaveClientOrder_Click(object sender, EventArgs e)
        {

            //Create a new role that the Variable will be added into
            DataRow newClientOrderRow = DM.dtClientOrder.NewRow();

            // if any of the text area is empty then do not write the data and return error message
            if (dtpAddClientOrder.Text == "")
            {
                MessageBox.Show("You must enter a Order Date and Client ID", "Error");
            }

            else
            {
                newClientOrderRow["OrderDate"] = dtpAddClientOrder.Text;
                newClientOrderRow["ClientID"] = cboAddClientID.Text;
                newClientOrderRow["Status"] = "Current";

                //Add the new row to the table
                DM.dtClientOrder.Rows.Add(newClientOrderRow);
                currencyManager.EndCurrentEdit();
                DM.UpdateClientOrder();
                // Give the user the success message
                MessageBox.Show("Client Order Added Successfully");
            }
        }

        private void btnCancelClientOrder_Click(object sender, EventArgs e)
        {
            pnlAddClientOrder.Hide();
            btnClientPrevious.Enabled = true;
            btnClientNext.Enabled = true;
            btnReturn.Enabled = true;
            btnUpdateClientOrder.Enabled = true;
            btnDeleteClientOrder.Enabled = true;
            btnMarkClientorderShipped.Enabled = true;
            btnMarkClientOrderPaid.Enabled = true;
            lstClientOrder.Visible = true;
            lblClientOrderID.Visible = true;
            txtClientOrderID.Visible = true;
        }

        private void pnlUpdateClientOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdateClientOrder_Click(object sender, EventArgs e)
        {
            pnlUpdateClientOrder.Show();
            lstClientOrder.Visible = false;
            btnClientPrevious.Enabled = false;
            btnClientNext.Enabled = false;
            btnReturn.Enabled = false;
            btnAddClientOrder.Enabled = false;
            btnDeleteClientOrder.Enabled = false;
            btnMarkClientorderShipped.Enabled = false;
            btnMarkClientOrderPaid.Enabled = false;
            txtUpdateClientOrderID.Enabled = false;
            txtUpdateClientOrderStatus.Enabled = false;
            txtUpdateClientOrderClientID.Enabled = false;
            txtUpdateClientOrderFirst.Enabled = false;
            txtUpdateClientOrderLast.Enabled = false;
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateClientOrder.Hide();
            lstClientOrder.Visible = true;
            btnClientPrevious.Enabled = true;
            btnClientNext.Enabled = true;
            btnReturn.Enabled = true;
            btnAddClientOrder.Enabled = true;
            btnDeleteClientOrder.Enabled = true;
            btnMarkClientorderShipped.Enabled = true;
            btnMarkClientOrderPaid.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            if (cboUpdateClientOrderDate.Text == "")

            {
                MessageBox.Show("You must enter Date to Update", "Error");
            }

            else
            {
                updateClientOrderRow["OrderDate"] = cboUpdateClientOrderDate.Text;

                currencyManager.EndCurrentEdit();
                // Database is updated
                DM.UpdateClientOrder();
                MessageBox.Show("Client Order Updated Successfully");
            }
        }

        private void txtUpdateClientOrderClientID_TextChanged(object sender, EventArgs e)
        {
            if (txtUpdateClientOrderClientID.Text == "")
            {
                txtUpdateClientOrderLast.Text = "";
                txtUpdateClientOrderFirst.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(txtClientID.Text);
                cmClient.Position = DM.clientView.Find(aCountryID);
                DataRow drClient = DM.dtClient.Rows[cmClient.Position];
                txtUpdateClientOrderLast.Text = drClient["LastName"].ToString();
                txtUpdateClientOrderFirst.Text = drClient["FirstName"].ToString();
            }
        }

        private void btnDeleteClientOrder_Click(object sender, EventArgs e)
        {
            //  Delete Event
            DataRow deleteClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            DataRow[] BookRow = DM.dtBook.Select("ClientOrderID = " + txtClientOrderID.Text);
           
            // Book delete Condition is checked 
            if (BookRow.Length != 0)
            {
                MessageBox.Show("You may only delete a Client Order that has no books", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "WARNING",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)

                {
                    deleteClientOrderRow.Delete();
                    DM.UpdateClientOrder();
                    MessageBox.Show("Client Order Deleted successfully");
                }
            }
        }

        private void btnMarkClientorderShipped_Click(object sender, EventArgs e)
        {
            DataRow updateClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            if ((txtClientStatus.Text == "Shipped") || (txtClientStatus.Text == "Paid"))

            {
                MessageBox.Show("Only Current Clients can be marked as Shipped", "Error");
            }

            else
            {
                updateClientOrderRow["Status"] = "Shipped";

                currencyManager.EndCurrentEdit();
                DM.UpdateClientOrder();
                MessageBox.Show("Client Order Updated Successfully");
            }


        }

        private void btnMarkClientOrderPaid_Click(object sender, EventArgs e)
        {
            DataRow updateClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            if ((txtClientStatus.Text == "Current") || (txtClientStatus.Text == "Paid"))

            {
                MessageBox.Show("Only Shipped Clients can be marked as Paid", "Error");
            }

            else
            {
                updateClientOrderRow["Status"] = "Paid";
                DataRow[] BookRow = DM.dtBook.Select("ClientOrderID = " + txtClientOrderID.Text);
                updateClientOrderRow.Delete();


                currencyManager.EndCurrentEdit();
                DM.UpdateClientOrder();
                MessageBox.Show("Client Order Updated Successfully");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClientPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnClientNext_Click(object sender, EventArgs e)
        {

            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }
    }
}
