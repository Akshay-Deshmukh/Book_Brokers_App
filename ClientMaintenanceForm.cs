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
    public partial class ClientMaintenanceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmCountry;
        private CurrencyManager cmClient;

        public ClientMaintenanceForm(DataModule dm, MainForm mnu)
        {
            // Initialize Component, DataModule reference 

            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
             pnlAddClient.Left = 220;
            pnlAddClient.Top = 5;
            pnlUpdateClient.Left = 220;
            pnlUpdateClient.Top = 5;


        }

        public void BindControls()
        {
            // Bind control is used to bind data to text box

            txtClientID.DataBindings.Add("Text",DM.dsBookBroker1, "Client.ClientID");
            txtLastName.DataBindings.Add("Text", DM.dsBookBroker1, "Client.LastName");
            txtFirstName.DataBindings.Add("Text", DM.dsBookBroker1, "Client.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DM.dsBookBroker1, "Client.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.dsBookBroker1, "Client.Suburb");
            txtCity.DataBindings.Add("Text", DM.dsBookBroker1, "Client.city");
            txtEmail.DataBindings.Add("Text", DM.dsBookBroker1, "Client.Email");
            txtCreditStatus.DataBindings.Add("Text", DM.dsBookBroker1, "Client.CreditStatus");
            lblClientCountryID.DataBindings.Add("Text", DM.dsBookBroker1, "Client.CountryID");         
            txtClientUpdateLastName.DataBindings.Add("Text", DM.dsBookBroker1, "Client.LastName");
            txtClientUpdateFirstName.DataBindings.Add("Text", DM.dsBookBroker1, "Client.FirstName");
            txtClientUpdateStreet.DataBindings.Add("Text", DM.dsBookBroker1, "Client.StreetAddress");
            txtClientUpdateSuburb.DataBindings.Add("Text", DM.dsBookBroker1, "Client.Suburb");
            txtClientUpdateCity.DataBindings.Add("Text", DM.dsBookBroker1, "Client.City");
            txtClientUpdateEmail.DataBindings.Add("Text", DM.dsBookBroker1, "Client.Email");
       
           
            
            txtClientID.Enabled = false;
            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtCity.Enabled = false;
            txtEmail.Enabled = false;
            txtCreditStatus.Enabled = false;
            txtCountryClient.Enabled = false;

            //list bind to data source
            lstClientMaintenance.DataSource = DM.dsBookBroker1;
            lstClientMaintenance.DisplayMember = "Client.ClientName";
            lstClientMaintenance.ValueMember = "Client.FirstName";

            // Currency Manager
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "Client"];
            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "COUNTRY"];
            
        }

        private void txtCreditStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private  void loadCountry()
        {
            // Loads data in checkboxes from database

            cboAddClientCountryName.DataSource = DM.dsBookBroker1;
            cboAddClientCountryName.DisplayMember = "Country.CountryName";
            cboAddClientCountryName.ValueMember = "Country.CountryName";
            cboAddClientCountryID.DataSource = DM.dsBookBroker1;
            cboAddClientCountryID.DisplayMember = "Country.CountryID";
            cboAddClientCountryID.ValueMember = "Country.CountryID";
            cboClientUpdateCountryID.DataSource = DM.dsBookBroker1;
            cboClientUpdateCountryID.DisplayMember = "Country.CountryID";
            cboClientUpdateCountryID.ValueMember = "Country.CountryID";
            cboClientUpdateCountryName.DataSource = DM.dsBookBroker1;
            cboClientUpdateCountryName.DisplayMember = "Country.CountryName";
            cboClientUpdateCountryName.ValueMember = "Country.CountryName";


        }

        private void lblClientCountryID_TextChanged(object sender, EventArgs e)
        {
            // When the value changes text changes
            if (lblClientCountryID.Text == "")
            {
                txtCountryClient.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(lblClientCountryID.Text);
                cmCountry.Position = DM.countryView.Find(aCountryID);
                DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];
                txtCountryClient.Text = drCountry["CountryName"].ToString();


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            lstClientMaintenance.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateClient.Enabled = false;
            btnDeleteClient.Enabled = false;
           

            loadCountry();
            pnlAddClient.Show();
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            //Create a new role that the Variable will be added into

            DataRow newClientRow = DM.dtClient.NewRow();

            // if any of the text area is empty then do not write the data and return error message
            if ((txtAddClientLastName.Text == "") || (txtAddClientFirstName.Text == "") || (txtAddClientStreetAddress.Text == "") ||
            (txtAddClientSuburb.Text == "") || (txtAddClientCity.Text == "") || (cboAddClientCountryID.Text == "") ||
             (cboAddClientCountryName.Text == "") || (txtAddClientEmail.Text == "") || (cboAddClientCreditStatus.Text == ""))
            {
                MessageBox.Show("You must type in all feilds", "Error");
            }

            else
            {
                
                    newClientRow["LastName"] = txtAddClientLastName.Text;
                    newClientRow["FirstName"] = txtAddClientFirstName.Text;
                    newClientRow["StreetAddress"] = txtAddClientStreetAddress.Text;
                    newClientRow["Suburb"] = txtAddClientSuburb.Text;
                    newClientRow["City"] = txtAddClientCity.Text;
                    newClientRow["CountryID"] = cboAddClientCountryID.Text;
                    newClientRow["Email"] = txtAddClientEmail.Text;
                    newClientRow["CreditStatus"] = cboAddClientCreditStatus.Text;

                //Add the new row to the table
                DM.dtClient.Rows.Add(newClientRow);
                   currencyManager.EndCurrentEdit();

                // Give the user the success message
                MessageBox.Show("Client added successfully", "Success");

                    DM.UpdateClient();

                
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddClient.Hide();
            lstClientMaintenance.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnReturn.Enabled = true;
            btnUpdateClient.Enabled = true;
            btnDeleteClient.Enabled = true;
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            lstClientMaintenance.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnReturn.Enabled = false;
            btnAddClient.Enabled = false;
            btnDeleteClient.Enabled = false;


            loadCountry();
            pnlUpdateClient.Show();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
              
            DataRow updateClientrRow = DM.dtClient.Rows[currencyManager.Position];
            if ((txtClientUpdateLastName.Text == "") || (txtClientUpdateFirstName.Text == "") ||
                (txtClientUpdateStreet.Text == "") || (txtClientUpdateSuburb.Text == "") || (txtClientUpdateCity.Text == "")
                || (txtClientUpdateEmail.Text == "") || (cboClientUpdateCredit.Text == ""))

            {
                MessageBox.Show("You must enter a value for each of the text feilds", "Error");
            }

            else
            {
                updateClientrRow["LastName"] = txtClientUpdateLastName.Text;
                updateClientrRow["FirstName"] = txtClientUpdateFirstName.Text;
                updateClientrRow["StreetAddress"] = txtClientUpdateStreet.Text;
                updateClientrRow["Suburb"] = txtClientUpdateStreet.Text;
                updateClientrRow["City"] = txtClientUpdateCity.Text;
                updateClientrRow["Email"] = txtClientUpdateEmail.Text;
                updateClientrRow["CreditStatus"] = cboClientUpdateCredit.Text;
                updateClientrRow["CountryID"] = cboClientUpdateCountryID.Text;

                currencyManager.EndCurrentEdit();

                // Database is updated
                DM.UpdateClient();
                MessageBox.Show("Client Updated Successfully");
            }
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateClient.Hide();
            lstClientMaintenance.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnReturn.Enabled = true;
            btnAddClient.Enabled = true;
            btnDeleteClient.Enabled = true;

        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            // Client delete Event
            DataRow deleteClientRow = DM.dtClient.Rows[currencyManager.Position];
            DataRow[] ClientOrderRow = DM.dtClientOrder.Select("ClientID = " + txtClientID.Text);

            // Client delete Condition is checked 
            if (ClientOrderRow.Length != 0)
            {
                MessageBox.Show("You may only delete Client who have no Client orders ", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "WARNING",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)

                {
                    deleteClientRow.Delete();
                    DM.UpdateClient();
                    MessageBox.Show("Client Deleted successfully");
                }
            }
        }

        private void ClientMaintenanceForm_Load(object sender, EventArgs e)
        {

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
    }
}
