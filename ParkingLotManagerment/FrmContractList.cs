using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLotManagement
{
    public partial class FrmContractList : Form
    {
        public FrmContractList()
        {
            InitializeComponent();
        }

        private void LoadDataToCustomerList()
        {
            AccessHelperDAL accessHelperDAL = new AccessHelperDAL();
            dtgvContractList.DataSource = accessHelperDAL.GetTableData("Contract");
        }

        private void FrmContractList_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDataToCustomerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"FrmContractList_Load:{ex.Message}");
            }
        }
    }
}
