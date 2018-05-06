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
    public partial class MainForm : Form
    {
        private DataModule DM;
        private VendorMaintenanceForm frmVendorMaintenance;
        private ClientMaintenanceForm frmClientMaintenance;
        private ClientOrderMaintenanceForm frmClientOrderMaintenance;
        private BookInfoMaintenanceForm frmBookInfoMaintenance;
        private BookMaintenanceForm frmBookMaintenance;
        private AddBookToClientOrderForm frmAddBookToClientOrder;
        private InvoiceForm frmInvoice;
        private VendorsForm frmVendors;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }

        private void btnVendorMaintenance_Click(object sender, EventArgs e)
        {
            if (frmVendorMaintenance ==  null)
            {
                frmVendorMaintenance = new VendorMaintenanceForm(DM, this);
            }
            frmVendorMaintenance.ShowDialog();
        }

        private void btnBookMaintenance_Click(object sender, EventArgs e)
        {
            if ( frmBookMaintenance == null)
            {
                frmBookMaintenance = new BookMaintenanceForm(DM, this);
            }
            frmBookMaintenance.ShowDialog();
        }

        private void btnClientMaintenance_Click(object sender, EventArgs e)
        {

            if (frmClientMaintenance == null)
            {
                frmClientMaintenance = new ClientMaintenanceForm(DM, this);
            }
            frmClientMaintenance.ShowDialog();
        }

        private void btnClientOrderMaintenance_Click(object sender, EventArgs e)
        {

            if (frmClientOrderMaintenance == null)
            {
                frmClientOrderMaintenance = new ClientOrderMaintenanceForm(DM, this);
            }
            frmClientOrderMaintenance.ShowDialog();
        }

        private void btnBookInfoMaintenance_Click(object sender, EventArgs e)
        {
            if (frmBookInfoMaintenance == null)
            {
                frmBookInfoMaintenance = new BookInfoMaintenanceForm(DM, this);
            }
            frmBookInfoMaintenance.ShowDialog();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (frmAddBookToClientOrder == null)
            {
                frmAddBookToClientOrder = new AddBookToClientOrderForm(DM, this);
            }
            frmAddBookToClientOrder.ShowDialog();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoice == null)
            {
                frmInvoice = new InvoiceForm(DM, this);
            }
            frmInvoice.ShowDialog();
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            if (frmVendors == null)
            {
                frmVendors = new VendorsForm(DM, this);
            }
            frmVendors.ShowDialog();
        }
    }
}
