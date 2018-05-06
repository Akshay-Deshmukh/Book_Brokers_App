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
    public partial class VendorMaintenanceForm : Form
    {

        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmVendor;
        private CurrencyManager cmCountry;

      

        public VendorMaintenanceForm(DataModule dm, MainForm mnu)
        {
           // Initialize Component, DataModule reference 

            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddVendor.Left = 220;
            pnlAddVendor.Top = 40;
            pnlUpdateVendor.Left = 220;
            pnlUpdateVendor.Top = 20;
        }

        private void btnDeleteVendor_Click(object sender, EventArgs e)
        {   
            // Book delete Event

            DataRow deleteVendorRow = DM.dtVendor.Rows[currencyManager.Position];
            DataRow[] BookRow = DM.dtBook.Select("VendorID = " + txtVendorID.Text);

            // Book delete Condition is checked 
            if (BookRow.Length != 0) 
            {
                MessageBox.Show("You may only delete Vendor that have no books", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "WARNING",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                   
               {
                   deleteVendorRow.Delete();
                  DM.UpdateVendor();
                   MessageBox.Show("Vendor Delete successfully");
              }
            }
        }

        private void lstVendors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void BindControls()
        {
            // Bind control is used to bind data to text box

            txtVendorID.DataBindings.Add("Text", DM.dsBookBroker1, "Vendor.VendorID");
            txtVendorName.DataBindings.Add("Text", DM.dsBookBroker1, "Vendor.VendorName");
            txtPostBoxNumber.DataBindings.Add("Text", DM.dsBookBroker1, "Vendor.PostBoxNumber");
            txtEmail.DataBindings.Add("Text", DM.dsBookBroker1, "Vendor.Email");
            txtUpdateVendorID.DataBindings.Add("Text", DM.dsBookBroker1, "Vendor.VendorID");
            txtUpdateVendorName.DataBindings.Add("Text", DM.dsBookBroker1, "Vendor.VendorName");
            txtUpdatePostBox.DataBindings.Add("Text", DM.dsBookBroker1, "Vendor.PostBoxNumber");
            txtUpdateEmail.DataBindings.Add("Text", DM.dsBookBroker1, "Vendor.Email");

            txtCountry.Enabled = false;
            txtVendorID.Enabled = false;
            txtVendorName.Enabled = false;
            txtPostBoxNumber.Enabled = false;
            txtCountryName.Enabled = false;
            txtEmail.Enabled = false;
            txtUpdateVendorID.Enabled = false;

            //list bind to data source 
            lstVendors.DataSource = DM.dsBookBroker1;
            lstVendors.DisplayMember = "Vendor.VendorName";
            lstVendors.ValueMember = "Vendor.VendorName";
            
            // Currency Manager 
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "VENDOR"];
            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBroker1, "COUNTRY"];
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VendorMaintenanceForm_Load(object sender, EventArgs e)
        {

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
            if (currencyManager.Position <  currencyManager.Count -1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            lstVendors.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateVendor.Enabled = false;
            btnDeleteVendor.Enabled = false;
            txtCountryName.Visible = false;
            txtCountry.Visible = false;
            
            pnlAddVendor.Show();
            // load country method is called
            LoadCountry();
            
        }

        private void btnSaveVendor_Click(object sender, EventArgs e)
        {

            //Create a new role that the Variable will be added into

           
            DataRow newVendorRow = DM.dtVendor.NewRow();
           

            // if any of the text area is empty then do not write the data and return
            if((txtAddVendorName.Text == "")  || (txtAddPostBoxNumber.Text == "") || (txtAddEmail.Text == "") || (cboAddCountryID.Text == ""))
            {
                MessageBox.Show("You must type in Valid data", "Error");
            }
            else
            {
                try
                {
                    newVendorRow["VendorName"] = txtAddVendorName.Text;
                    newVendorRow["PostBoxNumber"] = txtAddPostBoxNumber.Text;
                    newVendorRow["Email"] = txtAddEmail.Text;
                    newVendorRow["CountryID"] = cboAddCountryID.Text;

                    //Add the new row to the table
                    DM.dtVendor.Rows.Add(newVendorRow);

                    // Give the user the success message
                    MessageBox.Show("Vendor added successfully", "Success");  
                    DM.UpdateVendor();

                }
                catch(FormatException ex)
                {
                    MessageBox.Show("please enter a name", "Error");

                }
            }
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void LoadCountry()
        {
            // Loads data in checkboxes from database

            cboAddCountry.DataSource = DM.dsBookBroker1;
            cboAddCountry.DisplayMember = "Country.CountryName";
            cboAddCountry.ValueMember = "Country.CountryName";
            cboAddCountryID.DataSource = DM.dsBookBroker1;
            cboAddCountryID.DisplayMember = "Country.CountryID";
            cboAddCountryID.ValueMember = "Country.CountryID";
          

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddVendor.Hide();
            lstVendors.Enabled = true;
            lstVendors.Visible = true;
            btnDeleteVendor.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateVendor.Enabled = true;
            btnAddVendor.Enabled = true;
            txtCountryName.Visible = true;
            txtCountry.Visible = true;
            btnReturn.Enabled = true;
            lblVendorID.Visible = true;
        }

        private void cboAddCountryID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblVendorID_Click(object sender, EventArgs e)
        {

        }

        private void txtVendorID_TextChanged(object sender, EventArgs e)
        {
            // When the value changes text changes

            if (txtVendorID.Text == "")
            {
                txtCountry.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(txtVendorID.Text);
                cmCountry.Position = DM.countryView.Find(aCountryID);
                DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];
                txtCountry.Text = drCountry["CountryName"].ToString();


            }
        }

        private void lblCountryID_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void btnUpdateVendor_Click(object sender, EventArgs e)
        {
            lstVendors.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddVendor.Enabled = false;
            btnDeleteVendor.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpdateVendor.Show();
            LoadCountry();
            txtCountry.Visible = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Can update this text box
            DataRow updateVendorRow = DM.dtVendor.Rows[currencyManager.Position];
            if ((txtVendorName.Text == "") || (txtPostBoxNumber.Text == "") ||
                (txtEmail.Text == ""))
           
            {
                MessageBox.Show("You must enter a value for each of the text feilds", "Error");
            }
       
            else
            {
                // Add the text area 
                updateVendorRow["VendorName"] = txtUpdateVendorName.Text;
                updateVendorRow["PostBoxNumber"] = txtUpdatePostBox.Text;
                updateVendorRow["Email"] = txtUpdateEmail.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateVendor();

                // Give the success message
                MessageBox.Show("Vendor Updated Successfully");
            }
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            txtUpdateVendorID.Text = null;
            pnlUpdateVendor.Hide();
            lstVendors.Enabled = true;
            lstVendors.Visible = true;
            btnDeleteVendor.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateVendor.Enabled = true;
            btnAddVendor.Enabled = true;
            txtCountryName.Visible = true;
            btnReturn.Enabled = true;
            txtCountry.Visible = true;

            
        }

        private void cboUpdateCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            
        }

        private void txtCountryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCountryID_Click(object sender, EventArgs e)
        {

        }

        private void txtUpdateVendorID_TextChanged(object sender, EventArgs e)
        {
            // When the value changes text changes

            if (txtUpdateVendorID.Text == "")
            {
                txtCountryName.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(txtVendorID.Text);
                cmCountry.Position = DM.countryView.Find(aCountryID);
                DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];
                txtCountryName.Text = drCountry["CountryName"].ToString();


            }
        }
    }
}
