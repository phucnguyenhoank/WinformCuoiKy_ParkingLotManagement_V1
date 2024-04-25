using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace ParkingLotManagement
{
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer(txtCustomerID.Text, txtCustomerName.Text, txtCitizenNumber.Text, txtPhoneNumber.Text, txtCustomerAddress.Text);
                CustomerDAL customerDAL = new CustomerDAL();
                customerDAL.AddCustomer(customer);
                MessageBox.Show("Add customer successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnAddCustomer_Click:{ex.Message}");
            }
        }
    }
}
