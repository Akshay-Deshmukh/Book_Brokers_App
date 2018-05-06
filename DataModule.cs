using System;
using System.Data.OleDb;
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
    public partial class DataModule : Form
    {
        public DataTable dtVendor;
        public DataTable dtCountry;
        public DataView vendorView;
        public DataView countryView;

        public DataTable dtBook;
        public DataView bookView;

        public DataTable dtClient;
        public DataView clientView;

        public DataTable dtClientOrder;
        public DataView clientorderView;

        public DataTable dtBookInfo;
        public DataView bookinfoView;


        public DataTable dtAuthor;
        public DataView authorView;


        public DataModule()
        {
            InitializeComponent();
            dsBookBroker1.EnforceConstraints = false;
            daVendor.Fill(dsBookBroker1);
            daCountry.Fill(dsBookBroker1);
            dtCountry = dsBookBroker1.Tables["Country"];
            dtVendor = dsBookBroker1.Tables["Vendor"];
            daBook.Fill(dsBookBroker1);
            dtBook = dsBookBroker1.Tables["Book"];

            daClient.Fill(dsBookBroker1);
            dtClient = dsBookBroker1.Tables["Client"];

            daClientOrder.Fill(dsBookBroker1);
            dtClientOrder = dsBookBroker1.Tables["ClientOrder"];

            daBookInfo.Fill(dsBookBroker1);
            dtBookInfo = dsBookBroker1.Tables["BookInfo"];

            daAuthor.Fill(dsBookBroker1);
            dtAuthor = dsBookBroker1.Tables["Author"];

            


            dsBookBroker1.EnforceConstraints = true;
            vendorView = new DataView(dtVendor);
            vendorView.Sort = "VendorID";
            countryView = new DataView(dtCountry);
            countryView.Sort = "CountryID";
            bookView = new DataView(dtBook);
            bookView.Sort = "BookID";
            clientView = new DataView(dtClient);
            clientView.Sort = "ClientID";
            clientorderView = new DataView(dtClientOrder);
            clientorderView.Sort = "ClientOrderID";
            bookinfoView = new DataView(dtBookInfo);
            bookinfoView.Sort = "BookInfoID";
            authorView = new DataView(dtAuthor);
            authorView.Sort = "AuthorID";

        }

        private void DataModule_Load(object sender, EventArgs e)
        {

        }
        public void UpdateVendor()
        {
            daVendor.Update(dtVendor);
        }

        public void UpdateClient()
        {
            daClient.Update(dtClient);
        }
        public void UpdateClientOrder()
        {
            daClientOrder.Update(dtClientOrder);
        }

        public void UpdateBookInfo()
        {
            daBookInfo.Update(dtBookInfo);
        }
        public void UpdateBook()
        {
            daBook.Update(dtBook);
        }
        private void daVendor_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the access database
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBroker);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and
                //store it the VendorID Column
                newID = (int)idCMD.ExecuteScalar();
                e.Row["VendorID"] = newID;
            }
        }

        private void daClient_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the access database
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBroker);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and
                //store it the ClientID Column
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ClientID"] = newID;
            }
        }

        private void daClientOrder_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the access database
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBroker);

            if (e.StatementType == StatementType.Insert)
            {

                // Retrieve the identity value and
                //store it the ClientOrderID Column
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ClientOrderID"] = newID;
            }
        }

        private void daBookInfo_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the access database
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBroker);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and
                //store it the BookInfoID Column
                newID = (int)idCMD.ExecuteScalar();
                e.Row["BookInfoID"] = newID;
            }
        }

        private void daBook_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            
            // Include a variable and a command to retrieve
            // the identity value from the access database
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBroker);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and
                //store it the BookID Column
                newID = (int)idCMD.ExecuteScalar();
                e.Row["BookID"] = newID;
            }
        }
    }
}
