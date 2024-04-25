using DAL;
using ParkingLotManagement;
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
    public partial class FrmVehicleList : Form
    {
        public string SelectedCellValue { get; private set; }
        private DataTable vehicleDataTable;
        public FrmVehicleList(DataTable vehicleDataTable = null)
        {
            InitializeComponent();
            this.vehicleDataTable = vehicleDataTable;
            
        }

        private void LoadDataToVehicleList()
        {
            if (vehicleDataTable == null)
            {
                AccessHelperDAL accessHelperDAL = new AccessHelperDAL();
                dtgvVehicleList.DataSource = accessHelperDAL.GetTableData("Vehicle");
            }
            else
            {
                dtgvVehicleList.DataSource = vehicleDataTable;
            }
        }

        private void FrmVehicleList_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDataToVehicleList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"FrmVehicleList_Load:{ex.Message}");
            }
        }

        private void dtgvVehicleList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = this.dtgvVehicleList.Rows[e.RowIndex];
            SelectedCellValue = (string)selectedRow.Cells[0].Value;
            this.Close();
        }

        private void btnResetVehicleList_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDataToVehicleList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnResetVehicleList_Click:{ex.Message}");
            }
        }

        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            FrmAddVehicle frmAddCustomer = new FrmAddVehicle();
            frmAddCustomer.ShowDialog(this);
            LoadDataToVehicleList();
        }
    }
}
