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
using DTO;

namespace ParkingLotManagement
{
    public partial class FrmCustomerList : Form
    {
        public string SelectedCellValue { get; private set; }

        public FrmCustomerList()
        {
            InitializeComponent();
        }

        private void LoadDataToCustomerList()
        {
            AccessHelperDAL accessHelperDAL = new AccessHelperDAL();
            dtgvCustomerList.DataSource = accessHelperDAL.GetTableData("Customer");
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDataToCustomerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"FrmCustomerList_Load:{ex.Message}");
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frmAddCustomer = new FrmAddCustomer();
            frmAddCustomer.ShowDialog(this);
            LoadDataToCustomerList();
        }

        private void btnResetCustomerList_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDataToCustomerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnResetCustomerList_Click:{ex.Message}");
            }
        }

        private void dtgvCustomerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = this.dtgvCustomerList.Rows[e.RowIndex];
            SelectedCellValue = (string)selectedRow.Cells[0].Value;
            this.Close();
        }
    }
}
